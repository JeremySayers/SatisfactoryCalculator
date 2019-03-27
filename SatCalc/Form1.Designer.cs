namespace SatCalc
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ItemDropdownBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsPerMinuteTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultOutputListView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.MinerLevelComboBox = new System.Windows.Forms.ComboBox();
            this.OrePurityLabel = new System.Windows.Forms.Label();
            this.OrePurityComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ItemDropdownBox
            // 
            this.ItemDropdownBox.FormattingEnabled = true;
            this.ItemDropdownBox.Location = new System.Drawing.Point(12, 25);
            this.ItemDropdownBox.Name = "ItemDropdownBox";
            this.ItemDropdownBox.Size = new System.Drawing.Size(246, 21);
            this.ItemDropdownBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item";
            // 
            // ItemsPerMinuteTextBox
            // 
            this.ItemsPerMinuteTextBox.Location = new System.Drawing.Point(276, 25);
            this.ItemsPerMinuteTextBox.Name = "ItemsPerMinuteTextBox";
            this.ItemsPerMinuteTextBox.Size = new System.Drawing.Size(149, 20);
            this.ItemsPerMinuteTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(276, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items / Minute";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(431, 23);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 4;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Needed Items / Machines";
            // 
            // ResultOutputListView
            // 
            this.ResultOutputListView.Location = new System.Drawing.Point(15, 110);
            this.ResultOutputListView.Name = "ResultOutputListView";
            this.ResultOutputListView.Size = new System.Drawing.Size(491, 215);
            this.ResultOutputListView.TabIndex = 7;
            this.ResultOutputListView.UseCompatibleStateImageBehavior = false;
            this.ResultOutputListView.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Miner Level";
            // 
            // MinerLevelComboBox
            // 
            this.MinerLevelComboBox.FormattingEnabled = true;
            this.MinerLevelComboBox.Location = new System.Drawing.Point(12, 69);
            this.MinerLevelComboBox.Name = "MinerLevelComboBox";
            this.MinerLevelComboBox.Size = new System.Drawing.Size(246, 21);
            this.MinerLevelComboBox.TabIndex = 8;
            // 
            // OrePurityLabel
            // 
            this.OrePurityLabel.AutoSize = true;
            this.OrePurityLabel.Location = new System.Drawing.Point(276, 53);
            this.OrePurityLabel.Name = "OrePurityLabel";
            this.OrePurityLabel.Size = new System.Drawing.Size(53, 13);
            this.OrePurityLabel.TabIndex = 11;
            this.OrePurityLabel.Text = "Ore Purity";
            // 
            // OrePurityComboBox
            // 
            this.OrePurityComboBox.FormattingEnabled = true;
            this.OrePurityComboBox.Location = new System.Drawing.Point(276, 69);
            this.OrePurityComboBox.Name = "OrePurityComboBox";
            this.OrePurityComboBox.Size = new System.Drawing.Size(230, 21);
            this.OrePurityComboBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.OrePurityLabel);
            this.Controls.Add(this.OrePurityComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MinerLevelComboBox);
            this.Controls.Add(this.ResultOutputListView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GoButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemsPerMinuteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemDropdownBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ItemDropdownBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemsPerMinuteTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ResultOutputListView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox MinerLevelComboBox;
        private System.Windows.Forms.Label OrePurityLabel;
        private System.Windows.Forms.ComboBox OrePurityComboBox;
    }
}

