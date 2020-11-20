
namespace DiscordRPC_CustomWinForms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DiscordRpcClientTextBox = new System.Windows.Forms.TextBox();
            this.Details = new System.Windows.Forms.Label();
            this.DetailsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StateTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LargeImageKeyTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TimeStampsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SmallImageTextTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LargeImageTextTextBox = new System.Windows.Forms.TextBox();
            this.SmallImageKeyTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SizePartyTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MaxPartyTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SetButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(12, 455);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Enabled = false;
            this.StopButton.Location = new System.Drawing.Point(501, 455);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 0;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "DiscordRpcClient";
            // 
            // DiscordRpcClientTextBox
            // 
            this.DiscordRpcClientTextBox.Location = new System.Drawing.Point(12, 52);
            this.DiscordRpcClientTextBox.Name = "DiscordRpcClientTextBox";
            this.DiscordRpcClientTextBox.Size = new System.Drawing.Size(263, 23);
            this.DiscordRpcClientTextBox.TabIndex = 2;
            // 
            // Details
            // 
            this.Details.AutoSize = true;
            this.Details.Location = new System.Drawing.Point(313, 34);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(42, 15);
            this.Details.TabIndex = 1;
            this.Details.Text = "Details";
            // 
            // DetailsTextBox
            // 
            this.DetailsTextBox.Location = new System.Drawing.Point(313, 52);
            this.DetailsTextBox.Name = "DetailsTextBox";
            this.DetailsTextBox.Size = new System.Drawing.Size(263, 23);
            this.DetailsTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "State";
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(12, 103);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(263, 23);
            this.StateTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "LargeImageKey";
            // 
            // LargeImageKeyTextBox
            // 
            this.LargeImageKeyTextBox.Location = new System.Drawing.Point(6, 37);
            this.LargeImageKeyTextBox.Name = "LargeImageKeyTextBox";
            this.LargeImageKeyTextBox.Size = new System.Drawing.Size(212, 23);
            this.LargeImageKeyTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Timestamps(in seconds)";
            // 
            // TimeStampsTextBox
            // 
            this.TimeStampsTextBox.Location = new System.Drawing.Point(313, 103);
            this.TimeStampsTextBox.Name = "TimeStampsTextBox";
            this.TimeStampsTextBox.Size = new System.Drawing.Size(263, 23);
            this.TimeStampsTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SmallImageTextTextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LargeImageTextTextBox);
            this.groupBox1.Controls.Add(this.SmallImageKeyTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LargeImageKeyTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 128);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assets";
            // 
            // SmallImageTextTextBox
            // 
            this.SmallImageTextTextBox.Location = new System.Drawing.Point(346, 86);
            this.SmallImageTextTextBox.Name = "SmallImageTextTextBox";
            this.SmallImageTextTextBox.Size = new System.Drawing.Size(212, 23);
            this.SmallImageTextTextBox.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(346, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "SmallImageText";
            // 
            // LargeImageTextTextBox
            // 
            this.LargeImageTextTextBox.Location = new System.Drawing.Point(6, 86);
            this.LargeImageTextTextBox.Name = "LargeImageTextTextBox";
            this.LargeImageTextTextBox.Size = new System.Drawing.Size(212, 23);
            this.LargeImageTextTextBox.TabIndex = 2;
            // 
            // SmallImageKeyTextBox
            // 
            this.SmallImageKeyTextBox.Location = new System.Drawing.Point(346, 37);
            this.SmallImageKeyTextBox.Name = "SmallImageKeyTextBox";
            this.SmallImageKeyTextBox.Size = new System.Drawing.Size(212, 23);
            this.SmallImageKeyTextBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "LargeImageText";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "SmallImageKey";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SizePartyTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.MaxPartyTextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(12, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Party";
            // 
            // SizePartyTextBox
            // 
            this.SizePartyTextBox.Location = new System.Drawing.Point(346, 37);
            this.SizePartyTextBox.Name = "SizePartyTextBox";
            this.SizePartyTextBox.Size = new System.Drawing.Size(212, 23);
            this.SizePartyTextBox.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(346, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 1;
            this.label11.Text = "Size";
            // 
            // MaxPartyTextBox
            // 
            this.MaxPartyTextBox.Location = new System.Drawing.Point(6, 37);
            this.MaxPartyTextBox.Name = "MaxPartyTextBox";
            this.MaxPartyTextBox.Size = new System.Drawing.Size(212, 23);
            this.MaxPartyTextBox.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Max";
            // 
            // SetButton
            // 
            this.SetButton.Enabled = false;
            this.SetButton.Location = new System.Drawing.Point(254, 366);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 23);
            this.SetButton.TabIndex = 0;
            this.SetButton.Text = "Set";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 490);
            this.Controls.Add(this.StateTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TimeStampsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DetailsTextBox);
            this.Controls.Add(this.Details);
            this.Controls.Add(this.DiscordRpcClientTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "RPC Customer For KI-18";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DiscordRpcClientTextBox;
        private System.Windows.Forms.Label Details;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StateTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LargeImageKeyTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TimeStampsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox LargeImageTextTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox SmallImageTextTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox SmallImageKeyTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SizePartyTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox MaxPartyTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.TextBox DetailsTextBox;
    }
}

