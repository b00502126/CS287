namespace Example02
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ShoppingCartRichTextBox = new System.Windows.Forms.RichTextBox();
            this.Product1Lebel = new System.Windows.Forms.Label();
            this.Product2Lebel = new System.Windows.Forms.Label();
            this.AddProduct1Button = new System.Windows.Forms.Button();
            this.AddProduct2Button = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShoppingCartRichTextBox
            // 
            this.ShoppingCartRichTextBox.Location = new System.Drawing.Point(12, 180);
            this.ShoppingCartRichTextBox.Name = "ShoppingCartRichTextBox";
            this.ShoppingCartRichTextBox.Size = new System.Drawing.Size(449, 164);
            this.ShoppingCartRichTextBox.TabIndex = 0;
            this.ShoppingCartRichTextBox.Text = "";
            // 
            // Product1Lebel
            // 
            this.Product1Lebel.AutoSize = true;
            this.Product1Lebel.Location = new System.Drawing.Point(12, 32);
            this.Product1Lebel.Name = "Product1Lebel";
            this.Product1Lebel.Size = new System.Drawing.Size(128, 20);
            this.Product1Lebel.TabIndex = 1;
            this.Product1Lebel.Text = "Product1 Name";
            // 
            // Product2Lebel
            // 
            this.Product2Lebel.AutoSize = true;
            this.Product2Lebel.Location = new System.Drawing.Point(12, 106);
            this.Product2Lebel.Name = "Product2Lebel";
            this.Product2Lebel.Size = new System.Drawing.Size(128, 20);
            this.Product2Lebel.TabIndex = 2;
            this.Product2Lebel.Text = "Product2 Name";
            // 
            // AddProduct1Button
            // 
            this.AddProduct1Button.Location = new System.Drawing.Point(310, 32);
            this.AddProduct1Button.Name = "AddProduct1Button";
            this.AddProduct1Button.Size = new System.Drawing.Size(151, 36);
            this.AddProduct1Button.TabIndex = 3;
            this.AddProduct1Button.Text = "加入購物車清單";
            this.AddProduct1Button.UseVisualStyleBackColor = true;
            this.AddProduct1Button.Click += new System.EventHandler(this.AddProduct1Button_Click);
            // 
            // AddProduct2Button
            // 
            this.AddProduct2Button.Location = new System.Drawing.Point(310, 98);
            this.AddProduct2Button.Name = "AddProduct2Button";
            this.AddProduct2Button.Size = new System.Drawing.Size(151, 36);
            this.AddProduct2Button.TabIndex = 4;
            this.AddProduct2Button.Text = "加入購物車清單";
            this.AddProduct2Button.UseVisualStyleBackColor = true;
            this.AddProduct2Button.Click += new System.EventHandler(this.AddProduct2Button_Click);
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(12, 351);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(61, 20);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "總金額:";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(310, 140);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(151, 34);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "清空購物車";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 380);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.AddProduct2Button);
            this.Controls.Add(this.AddProduct1Button);
            this.Controls.Add(this.Product2Lebel);
            this.Controls.Add(this.Product1Lebel);
            this.Controls.Add(this.ShoppingCartRichTextBox);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.Text = "歡迎光臨AppleStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ShoppingCartRichTextBox;
        private System.Windows.Forms.Label Product1Lebel;
        private System.Windows.Forms.Label Product2Lebel;
        private System.Windows.Forms.Button AddProduct1Button;
        private System.Windows.Forms.Button AddProduct2Button;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button ClearButton;
    }
}

