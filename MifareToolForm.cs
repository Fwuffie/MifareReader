using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiFare;
using MiFare.Classic;
using MiFare.Devices;
using MiFare.PcSc;
using System.Text.RegularExpressions;

namespace MifareReader
{
	public partial class MifareToolForm : Form
	{
		public MifareToolForm()
		{
			InitializeComponent();
			UpdateScanners();
		}

		public SmartCardReader reader;
		public CardEventArgs cardEventArg;


		private async void CardAdded(object sender, CardEventArgs args)
		{
			cardEventArg = args;
			lblCardPresence.Invoke(new Action(() => lblCardPresence.Text = "Card Present"));
			MiFareCard card = args.SmartCard.CreateMiFareCard();

			var cardIdentification = await card.GetCardInfo();
			var uid = await card.GetUid();

			lblCardInfo.Invoke(new Action(() => lblCardInfo.Text = "Card Info \n Device Class: "+ cardIdentification.PcscDeviceClass.ToString() + "\n Card Name: " + cardIdentification.PcscCardName.ToString() + "\n Card UID: " + BitConverter.ToString(uid)));

		}

		private void ValidateKey(Object sender, EventArgs e)
		{
			string key = (sender as TextBox).Text;

			key = key.ToUpper();
			Regex rgx = new Regex("[^A-F0-9]");
			key = rgx.Replace(key, "");
			(sender as TextBox).Text = key;

			if (key.Length == 12) 
			{
				cmdLoadCard.Enabled = true;
				(sender as TextBox).BackColor = Color.White;
				return; 
			}
			cmdLoadCard.Enabled = false;
			(sender as TextBox).BackColor = Color.Red;
		}

		private async void loadSector(object sender, EventArgs e)
		{
			int sector = cmbSector.SelectedIndex;

			IList<SectorKeySet> authenticationKeys = new List<SectorKeySet>();
			authenticationKeys.Add(new SectorKeySet());
			authenticationKeys.Last().KeyType = MiFare.Classic.KeyType.KeyA;
			authenticationKeys.Last().Key = Extensions.StringToByteArray(txtKeyALoad.Text);
			authenticationKeys.Last().Sector = sector;
			authenticationKeys.Add(new SectorKeySet());
			authenticationKeys.Last().KeyType = MiFare.Classic.KeyType.KeyB;
			authenticationKeys.Last().Key = Extensions.StringToByteArray(txtKeyBLoad.Text);
			authenticationKeys.Last().Sector = sector;

			MiFareCard card = cardEventArg.SmartCard.CreateMiFareCard(authenticationKeys);

			byte[] blk0 = await loadBlock(sector, 0, card);
			if (blk0 == null) { txtBlk0.Text = "Block read access restricted"; }
			else { txtBlk0.Text = Extensions.ByteArrayToString(blk0); }
				
			byte[] blk1 = await loadBlock(sector, 1, card);
			if (blk1 == null) { txtBlk1.Text = "Block read access restricted"; }
			else { txtBlk1.Text = Extensions.ByteArrayToString(blk1); }
				
			byte[] blk2 = await loadBlock(sector, 2, card);
			if (blk2 == null) { txtBlk2.Text = "Block read access restricted"; }
			else { txtBlk2.Text = Extensions.ByteArrayToString(blk2); }

			byte[] keyA = await loadBlock(sector, 3, card);
			if (keyA == null) { txtKeyA.Text = "Block read access restricted"; }
			else { txtKeyA.Text = Extensions.ByteArrayToString(keyA.Skip(10).Take(6).ToArray()); }

			byte[] keyB = await loadBlock(sector, 5, card);
			if (keyB == null) { txtKeyB.Text = "Block read access restricted"; }
			else { txtKeyB.Text = Extensions.ByteArrayToString(keyB.Take(6).ToArray()); }
		}

		private async Task<byte[]> loadBlock(int sector, int block, MiFareCard card)
		{
			try
			{
				if (block < 3)
				{
					return await card.GetData(sector, block, 16);
				}
				if (block == 3)
				{
					return await card.GetData(sector, 3, 16);
				}
				if (block == 5)
				{
					return await card.GetData(sector, 3, 16);
				}
			}
			catch
			{
				return null;
			}
			return null;
		}

		private void CardRemoved(object sender, CardEventArgs args)
		{
			cardEventArg = args;
			lblCardPresence.Invoke(new Action(() => lblCardPresence.Text = "No Card Present"));
		}


		/// <summary>
		/// Updates The Combobox to show attached scanners
		/// </summary>
		private void UpdateScanners()
		{
			string[] scanners = CardReader.GetReaderNames().ToArray<string>();
			cmbScanners.Items.Clear();
			if (scanners.Length == 0)
			{
				cmbScanners.Text = "No NFC Scanners Detected...";
				cmdConnectScanner.Enabled = false;
				return;
			}
			cmbScanners.Items.AddRange(scanners);
			cmdConnectScanner.Enabled = true;
			return;
		}

		/// <summary>
		/// Creates The Scanner Object
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="ev"></param>
		private async void cmdConnectScanner_Click(object sender, EventArgs ev)
		{
			if (cmbScanners.SelectedIndex == -1) { return; }
			try
			{
				reader = await CardReader.FindAsync(cmbScanners.Text);

				reader.CardAdded += CardAdded;
				reader.CardRemoved += CardRemoved;
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}



			lblCardPresence.Invoke(new Action(() => lblCardPresence.Text = "No Card Present"));
		}

		private void writeSector(object sender, EventArgs e)
		{

		}
	}
}
