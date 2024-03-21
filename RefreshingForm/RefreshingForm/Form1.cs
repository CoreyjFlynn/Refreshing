using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace RefreshingForm
{
    public partial class RefreshingForm : Form
    {
        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);

        private static string _processName;
        private static int _interval;
        private static bool _isRandom;
        public RefreshingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;
            int.TryParse(intervalTextBox.Text, out var intervalInSeconds);
            _interval = intervalInSeconds * 1000;
            _isRandom = RandomIntervalCheckBox.Checked;
            _processName = processTextBox.Text;
            SaveConfig();
            startButton.Enabled = false;
            restoreDefaultsButton.Enabled = false;
            RefreshTimer.Timer(_interval, _isRandom, _processName);
            Application.DoEvents();
        }

        private void RandomIntervalCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ChangeIsRandom();
        }

        private bool ValidateInputs()
        {
            if (String.IsNullOrWhiteSpace(intervalTextBox.Text) && !RandomIntervalCheckBox.Checked)
            {
                MessageBox.Show("Must have interval or be random.", "Error");
                return false;
            }

            if (!int.TryParse(intervalTextBox.Text, out int interval) && !RandomIntervalCheckBox.Checked)
            {
                MessageBox.Show("Must be a number or be random.", "Error");
                return false;
            }

            if (String.IsNullOrWhiteSpace(processTextBox.Text))
            {
                MessageBox.Show("Must have a Process Name such as chrome or iexplorer", "Error");
                return false;
            }

            return true;
        }

        private void RefreshingForm_Load(object sender, EventArgs e)
        {
            LoadConfig();
            SetFormFields();
        }

        private void SaveConfig()
        {
            ConfigManager.SaveConfig(_interval, _isRandom, _processName);
        }

        private void LoadConfig()
        {
            ConfigManager.LoadConfig(out _interval, out _isRandom, out _processName);
        }

        private void SetFormFields()
        {
            var intervalInSeconds = _interval / 1000;
            RandomIntervalCheckBox.Checked = _isRandom;
            intervalTextBox.Text = intervalInSeconds.ToString();
            processTextBox.Text = _processName;
            ChangeIsRandom();
        }

        private void ChangeIsRandom()
        {
            if (RandomIntervalCheckBox.Checked)
            {
                intervalTextBox.Enabled = false;
            }
            else
            {
                intervalTextBox.Enabled = true;
            }
        }

        private void restoreDefaultsButton_Click(object sender, EventArgs e)
        {
            _interval = 120000;
            _isRandom = false;
            _processName = "chrome";
            SaveConfig();
            SetFormFields();
        }
    }
}
