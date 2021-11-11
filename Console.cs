using System;
using System.Windows.Forms;
using MiFare.Classic;

namespace MifareReader
{
    public partial class Console : Form
    {
        private MifareToolForm mainForm;

        public Console(MifareToolForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public void WriteLine(String text)
        {
            lblConsole.AppendText(text);
            lblConsole.AppendText(Environment.NewLine);
        }

        private void cmdRun_Click(object sender, EventArgs e)
        {
            String command = txtCommand.Text;
            this.WriteLine("> " + command);
            txtCommand.Clear();
            this.WriteLine( this.runCommand(command) );
        }

        private string runCommand(String rawcommand)
        {
            String[] command = rawcommand.Split(' ');

            switch (command[0])
            {
                case "help":
                    return "help - Fetches this dialog";
                case "rawadpu":
                    return rawadpu(command);
                default:
                    return "Command Not Found, Type help For A list of commands";
            }                
        }

        private string rawadpu(String[] command)
        {
            byte cla = Extensions.StringToByteArray(command[1])[0];
            byte ins = Extensions.StringToByteArray(command[2])[0];
            byte p1 = Extensions.StringToByteArray(command[3])[0];
            byte p2 = Extensions.StringToByteArray(command[4])[0];
            byte[] data = { };
            if (command.Length > 5)
            {
                data = Extensions.StringToByteArray(command[5]);
            }
            
            return mainForm.directTransmit(cla, ins, p1, p2, data);
        }

        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdRun_Click(sender, e);
            }
            return;
        }

        private void ConsoleFormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
    }
}
