namespace FormUI
{
    partial class Dashboard
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
            this.tickerListBox = new System.Windows.Forms.ListBox();
            this.tickerLookupBox = new System.Windows.Forms.Label();
            this.tickerSearchBox = new System.Windows.Forms.TextBox();
            this.getTickerButton = new System.Windows.Forms.Button();
            this.tickerAddText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.companyNameAddText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.volumeAddText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.websiteAddText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addCompanyButton = new System.Windows.Forms.Button();
            this.optionableAddCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tickerListBox
            // 
            this.tickerListBox.FormattingEnabled = true;
            this.tickerListBox.Location = new System.Drawing.Point(12, 54);
            this.tickerListBox.Name = "tickerListBox";
            this.tickerListBox.Size = new System.Drawing.Size(120, 95);
            this.tickerListBox.TabIndex = 0;
            // 
            // tickerLookupBox
            // 
            this.tickerLookupBox.AutoSize = true;
            this.tickerLookupBox.Location = new System.Drawing.Point(12, 9);
            this.tickerLookupBox.Name = "tickerLookupBox";
            this.tickerLookupBox.Size = new System.Drawing.Size(40, 13);
            this.tickerLookupBox.TabIndex = 1;
            this.tickerLookupBox.Text = "Ticker:";
            // 
            // tickerSearchBox
            // 
            this.tickerSearchBox.Location = new System.Drawing.Point(58, 6);
            this.tickerSearchBox.Name = "tickerSearchBox";
            this.tickerSearchBox.Size = new System.Drawing.Size(74, 20);
            this.tickerSearchBox.TabIndex = 2;
            // 
            // getTickerButton
            // 
            this.getTickerButton.Location = new System.Drawing.Point(15, 25);
            this.getTickerButton.Name = "getTickerButton";
            this.getTickerButton.Size = new System.Drawing.Size(117, 23);
            this.getTickerButton.TabIndex = 3;
            this.getTickerButton.Text = "Get Ticker";
            this.getTickerButton.UseVisualStyleBackColor = true;
            this.getTickerButton.Click += new System.EventHandler(this.getTickerButton_Click);
            // 
            // tickerAddText
            // 
            this.tickerAddText.Location = new System.Drawing.Point(103, 207);
            this.tickerAddText.Name = "tickerAddText";
            this.tickerAddText.Size = new System.Drawing.Size(74, 20);
            this.tickerAddText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ticker:";
            // 
            // companyNameAddText
            // 
            this.companyNameAddText.Location = new System.Drawing.Point(103, 233);
            this.companyNameAddText.Name = "companyNameAddText";
            this.companyNameAddText.Size = new System.Drawing.Size(74, 20);
            this.companyNameAddText.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Company Name:";
            // 
            // volumeAddText
            // 
            this.volumeAddText.Location = new System.Drawing.Point(103, 259);
            this.volumeAddText.Name = "volumeAddText";
            this.volumeAddText.Size = new System.Drawing.Size(74, 20);
            this.volumeAddText.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Volume:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Optionable:";
            // 
            // websiteAddText
            // 
            this.websiteAddText.Location = new System.Drawing.Point(103, 311);
            this.websiteAddText.Name = "websiteAddText";
            this.websiteAddText.Size = new System.Drawing.Size(74, 20);
            this.websiteAddText.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Website:";
            // 
            // addCompanyButton
            // 
            this.addCompanyButton.Location = new System.Drawing.Point(58, 337);
            this.addCompanyButton.Name = "addCompanyButton";
            this.addCompanyButton.Size = new System.Drawing.Size(117, 23);
            this.addCompanyButton.TabIndex = 14;
            this.addCompanyButton.Text = "Add Company";
            this.addCompanyButton.UseVisualStyleBackColor = true;
            this.addCompanyButton.Click += new System.EventHandler(this.addCompanyButton_Click);
            // 
            // optionableAddCheckBox
            // 
            this.optionableAddCheckBox.AutoSize = true;
            this.optionableAddCheckBox.Location = new System.Drawing.Point(103, 288);
            this.optionableAddCheckBox.Name = "optionableAddCheckBox";
            this.optionableAddCheckBox.Size = new System.Drawing.Size(15, 14);
            this.optionableAddCheckBox.TabIndex = 15;
            this.optionableAddCheckBox.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 433);
            this.Controls.Add(this.optionableAddCheckBox);
            this.Controls.Add(this.addCompanyButton);
            this.Controls.Add(this.websiteAddText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.volumeAddText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.companyNameAddText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tickerAddText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.getTickerButton);
            this.Controls.Add(this.tickerSearchBox);
            this.Controls.Add(this.tickerLookupBox);
            this.Controls.Add(this.tickerListBox);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tickerListBox;
        private System.Windows.Forms.Label tickerLookupBox;
        private System.Windows.Forms.TextBox tickerSearchBox;
        private System.Windows.Forms.Button getTickerButton;
        private System.Windows.Forms.TextBox tickerAddText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox companyNameAddText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox volumeAddText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox websiteAddText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addCompanyButton;
        private System.Windows.Forms.CheckBox optionableAddCheckBox;
    }
}

