namespace CashRegister
{
    partial class musicShop
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.numOf1Label = new System.Windows.Forms.Label();
            this.numOf2Label = new System.Windows.Forms.Label();
            this.numOf3Label = new System.Windows.Forms.Label();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input3 = new System.Windows.Forms.TextBox();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.calcTotalButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.calcChangeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.shopLabel = new System.Windows.Forms.Label();
            this.receipt = new System.Windows.Forms.Label();
            this.bar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(128, 64);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(80, 22);
            this.input1.TabIndex = 0;
            this.input1.Text = "0";
            // 
            // numOf1Label
            // 
            this.numOf1Label.AutoSize = true;
            this.numOf1Label.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOf1Label.Location = new System.Drawing.Point(11, 64);
            this.numOf1Label.Name = "numOf1Label";
            this.numOf1Label.Size = new System.Drawing.Size(85, 36);
            this.numOf1Label.TabIndex = 1;
            this.numOf1Label.Text = "Number of \r\nFazioil Piano\r\n";
            // 
            // numOf2Label
            // 
            this.numOf2Label.AutoSize = true;
            this.numOf2Label.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOf2Label.Location = new System.Drawing.Point(11, 106);
            this.numOf2Label.Name = "numOf2Label";
            this.numOf2Label.Size = new System.Drawing.Size(79, 36);
            this.numOf2Label.TabIndex = 2;
            this.numOf2Label.Text = "Number of \r\nUrtext book\r\n";
            // 
            // numOf3Label
            // 
            this.numOf3Label.AutoSize = true;
            this.numOf3Label.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOf3Label.Location = new System.Drawing.Point(11, 147);
            this.numOf3Label.Name = "numOf3Label";
            this.numOf3Label.Size = new System.Drawing.Size(102, 54);
            this.numOf3Label.TabIndex = 3;
            this.numOf3Label.Text = "Number of \r\nSteinway Piano\r\n\r\n";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(128, 106);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(80, 22);
            this.input2.TabIndex = 4;
            this.input2.Text = "0";
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(128, 147);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(80, 22);
            this.input3.TabIndex = 5;
            this.input3.Text = "0";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(128, 375);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(80, 22);
            this.tenderedInput.TabIndex = 6;
            // 
            // calcTotalButton
            // 
            this.calcTotalButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.calcTotalButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcTotalButton.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcTotalButton.Location = new System.Drawing.Point(49, 196);
            this.calcTotalButton.Name = "calcTotalButton";
            this.calcTotalButton.Size = new System.Drawing.Size(117, 26);
            this.calcTotalButton.TabIndex = 7;
            this.calcTotalButton.Text = "Calculate Totals ";
            this.calcTotalButton.UseVisualStyleBackColor = false;
            this.calcTotalButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 308);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(50, 23);
            this.totalLabel.TabIndex = 8;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(12, 274);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(41, 23);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax ";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.Location = new System.Drawing.Point(11, 242);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(79, 23);
            this.subLabel.TabIndex = 10;
            this.subLabel.Text = "Subtotal ";
            // 
            // totalOutput
            // 
            this.totalOutput.AutoSize = true;
            this.totalOutput.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.Location = new System.Drawing.Point(124, 308);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(0, 23);
            this.totalOutput.TabIndex = 11;
            // 
            // taxOutput
            // 
            this.taxOutput.AutoSize = true;
            this.taxOutput.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(124, 274);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(0, 23);
            this.taxOutput.TabIndex = 12;
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(124, 242);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(0, 23);
            this.subtotalOutput.TabIndex = 13;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(12, 373);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(85, 23);
            this.tenderedLabel.TabIndex = 14;
            this.tenderedLabel.Text = "Tendered ";
            // 
            // calcChangeButton
            // 
            this.calcChangeButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.calcChangeButton.Enabled = false;
            this.calcChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calcChangeButton.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcChangeButton.Location = new System.Drawing.Point(42, 414);
            this.calcChangeButton.Name = "calcChangeButton";
            this.calcChangeButton.Size = new System.Drawing.Size(145, 28);
            this.calcChangeButton.TabIndex = 15;
            this.calcChangeButton.UseVisualStyleBackColor = false;
            this.calcChangeButton.Click += new System.EventHandler(this.calcChangeButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.printButton.Enabled = false;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printButton.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(52, 489);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(117, 30);
            this.printButton.TabIndex = 16;
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(10, 456);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(68, 23);
            this.changeLabel.TabIndex = 17;
            this.changeLabel.Text = "Change";
            // 
            // changeOutput
            // 
            this.changeOutput.AutoSize = true;
            this.changeOutput.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(122, 456);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(0, 23);
            this.changeOutput.TabIndex = 18;
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.orderButton.Enabled = false;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.orderButton.Font = new System.Drawing.Font("Palatino Linotype", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderButton.Location = new System.Drawing.Point(356, 489);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(117, 29);
            this.orderButton.TabIndex = 19;
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // shopLabel
            // 
            this.shopLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shopLabel.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.shopLabel.Location = new System.Drawing.Point(-12, 0);
            this.shopLabel.Name = "shopLabel";
            this.shopLabel.Size = new System.Drawing.Size(561, 48);
            this.shopLabel.TabIndex = 20;
            this.shopLabel.Text = "Music Shop";
            this.shopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receipt
            // 
            this.receipt.AutoSize = true;
            this.receipt.BackColor = System.Drawing.Color.White;
            this.receipt.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt.Location = new System.Drawing.Point(239, 64);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(0, 22);
            this.receipt.TabIndex = 21;
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.Desktop;
            this.bar.Location = new System.Drawing.Point(11, 341);
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(223, 22);
            this.bar.TabIndex = 23;
            // 
            // musicShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(540, 531);
            this.Controls.Add(this.bar);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.shopLabel);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.calcChangeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.calcTotalButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.numOf3Label);
            this.Controls.Add(this.numOf2Label);
            this.Controls.Add(this.numOf1Label);
            this.Controls.Add(this.input1);
            this.Name = "musicShop";
            this.Text = "Music Shop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.Label numOf1Label;
        private System.Windows.Forms.Label numOf2Label;
        private System.Windows.Forms.Label numOf3Label;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button calcTotalButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button calcChangeButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label shopLabel;
        private System.Windows.Forms.Label receipt;
        private System.Windows.Forms.Label bar;
    }
}

