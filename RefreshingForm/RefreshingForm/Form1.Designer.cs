
namespace RefreshingForm
{
    partial class RefreshingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startButton = new System.Windows.Forms.Button();
            this.processTextBox = new System.Windows.Forms.TextBox();
            this.intervalTextBox = new System.Windows.Forms.TextBox();
            this.processLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RandomIntervalCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.restoreDefaultsButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(713, 415);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // processTextBox
            // 
            this.processTextBox.Location = new System.Drawing.Point(354, 104);
            this.processTextBox.Name = "processTextBox";
            this.processTextBox.Size = new System.Drawing.Size(100, 23);
            this.processTextBox.TabIndex = 1;
            this.processTextBox.Text = "chrome";
            // 
            // intervalTextBox
            // 
            this.intervalTextBox.Location = new System.Drawing.Point(306, 22);
            this.intervalTextBox.Name = "intervalTextBox";
            this.intervalTextBox.Size = new System.Drawing.Size(100, 23);
            this.intervalTextBox.TabIndex = 2;
            this.intervalTextBox.Text = "120";
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Location = new System.Drawing.Point(75, 107);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(82, 15);
            this.processLabel.TabIndex = 3;
            this.processLabel.Text = "Process Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RandomIntervalCheckBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.intervalTextBox);
            this.groupBox1.Location = new System.Drawing.Point(48, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 151);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // RandomIntervalCheckBox
            // 
            this.RandomIntervalCheckBox.AutoSize = true;
            this.RandomIntervalCheckBox.Location = new System.Drawing.Point(27, 83);
            this.RandomIntervalCheckBox.Name = "RandomIntervalCheckBox";
            this.RandomIntervalCheckBox.Size = new System.Drawing.Size(113, 19);
            this.RandomIntervalCheckBox.TabIndex = 4;
            this.RandomIntervalCheckBox.Text = "Random Interval";
            this.RandomIntervalCheckBox.UseVisualStyleBackColor = true;
            this.RandomIntervalCheckBox.CheckedChanged += new System.EventHandler(this.RandomIntervalCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Interval (in seconds)";
            // 
            // restoreDefaultsButton
            // 
            this.restoreDefaultsButton.Location = new System.Drawing.Point(12, 415);
            this.restoreDefaultsButton.Name = "restoreDefaultsButton";
            this.restoreDefaultsButton.Size = new System.Drawing.Size(120, 23);
            this.restoreDefaultsButton.TabIndex = 5;
            this.restoreDefaultsButton.Text = "Restore Defaults";
            this.restoreDefaultsButton.UseVisualStyleBackColor = true;
            this.restoreDefaultsButton.Click += new System.EventHandler(this.restoreDefaultsButton_Click);
            // 
            // RefreshingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restoreDefaultsButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.processLabel);
            this.Controls.Add(this.processTextBox);
            this.Controls.Add(this.startButton);
            this.Name = "RefreshingForm";
            this.Text = "Refreshing";
            this.Load += new System.EventHandler(this.RefreshingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox processTextBox;
        private System.Windows.Forms.TextBox intervalTextBox;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox RandomIntervalCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button restoreDefaultsButton;
    }
}

