using System;
using System.Windows.Forms;

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

        private string runCommand(String command)
        {
            if (command == "help")
            {
                return "help - Fetches this dialog";
            }
            else if (command == "m")
            {
                mainForm.directTransmit();
                return mainForm.directTransmit();
            }


                return "Command Not Found, Type help For A list of commands";
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
