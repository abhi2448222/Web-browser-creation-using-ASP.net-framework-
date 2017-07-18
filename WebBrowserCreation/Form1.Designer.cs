namespace WebBrowserCreation
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Gobutton = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.encrypttextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.decrypttextBox = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrorText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.stockSymInp = new System.Windows.Forms.TextBox();
            this.getStockButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.stockQuoteOut = new System.Windows.Forms.TextBox();
            this.ErrorQuote = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1040, 20);
            this.textBox1.TabIndex = 0;
            // 
            // Gobutton
            // 
            this.Gobutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Gobutton.Location = new System.Drawing.Point(1083, 10);
            this.Gobutton.Name = "Gobutton";
            this.Gobutton.Size = new System.Drawing.Size(83, 23);
            this.Gobutton.TabIndex = 1;
            this.Gobutton.Text = "Go";
            this.Gobutton.UseVisualStyleBackColor = true;
            this.Gobutton.Click += new System.EventHandler(this.Go_Click);
            // 
            // Refresh
            // 
            this.Refresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Refresh.Location = new System.Drawing.Point(1194, 10);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(73, 23);
            this.Refresh.TabIndex = 2;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 125);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1281, 532);
            this.webBrowser1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Text to Encrypt";
            // 
            // encrypttextBox
            // 
            this.encrypttextBox.Location = new System.Drawing.Point(148, 47);
            this.encrypttextBox.Name = "encrypttextBox";
            this.encrypttextBox.Size = new System.Drawing.Size(100, 20);
            this.encrypttextBox.TabIndex = 5;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(272, 47);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 23);
            this.encryptButton.TabIndex = 6;
            this.encryptButton.Text = "Encrypt";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Text to Decrypt";
            // 
            // decrypttextBox
            // 
            this.decrypttextBox.Location = new System.Drawing.Point(148, 78);
            this.decrypttextBox.Name = "decrypttextBox";
            this.decrypttextBox.Size = new System.Drawing.Size(100, 20);
            this.decrypttextBox.TabIndex = 10;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(272, 78);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 23);
            this.decryptButton.TabIndex = 11;
            this.decryptButton.Text = "Decrypt";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(427, 62);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(157, 20);
            this.output.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Output";
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorText.ForeColor = System.Drawing.Color.Red;
            this.ErrorText.Location = new System.Drawing.Point(12, 106);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(0, 16);
            this.ErrorText.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(637, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Enter Stock Symbol";
            // 
            // stockSymInp
            // 
            this.stockSymInp.Location = new System.Drawing.Point(781, 47);
            this.stockSymInp.Name = "stockSymInp";
            this.stockSymInp.Size = new System.Drawing.Size(100, 20);
            this.stockSymInp.TabIndex = 17;
            // 
            // getStockButton
            // 
            this.getStockButton.Location = new System.Drawing.Point(919, 60);
            this.getStockButton.Name = "getStockButton";
            this.getStockButton.Size = new System.Drawing.Size(107, 23);
            this.getStockButton.TabIndex = 18;
            this.getStockButton.Text = "Get Stock Quote";
            this.getStockButton.UseVisualStyleBackColor = true;
            this.getStockButton.Click += new System.EventHandler(this.getStockButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(637, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Stock Quote";
            // 
            // stockQuoteOut
            // 
            this.stockQuoteOut.Location = new System.Drawing.Point(781, 77);
            this.stockQuoteOut.Name = "stockQuoteOut";
            this.stockQuoteOut.ReadOnly = true;
            this.stockQuoteOut.Size = new System.Drawing.Size(100, 20);
            this.stockQuoteOut.TabIndex = 20;
            // 
            // ErrorQuote
            // 
            this.ErrorQuote.AutoSize = true;
            this.ErrorQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorQuote.Location = new System.Drawing.Point(637, 106);
            this.ErrorQuote.Name = "ErrorQuote";
            this.ErrorQuote.Size = new System.Drawing.Size(0, 16);
            this.ErrorQuote.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 687);
            this.Controls.Add(this.ErrorQuote);
            this.Controls.Add(this.stockQuoteOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.getStockButton);
            this.Controls.Add(this.stockSymInp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.output);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.decrypttextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.encrypttextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Gobutton);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Web Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Gobutton;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encrypttextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox decrypttextBox;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox stockSymInp;
        private System.Windows.Forms.Button getStockButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stockQuoteOut;
        private System.Windows.Forms.Label ErrorQuote;
    }
}

