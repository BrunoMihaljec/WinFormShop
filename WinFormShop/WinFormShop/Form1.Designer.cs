
namespace WinFormShop
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
            this.ShoppingList = new System.Windows.Forms.ListBox();
            this.Shop = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.Buybtn = new System.Windows.Forms.Button();
            this.GoToCart = new System.Windows.Forms.Button();
            this.sortddl = new System.Windows.Forms.ComboBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShoppingList
            // 
            this.ShoppingList.FormattingEnabled = true;
            this.ShoppingList.Location = new System.Drawing.Point(12, 57);
            this.ShoppingList.Name = "ShoppingList";
            this.ShoppingList.Size = new System.Drawing.Size(358, 264);
            this.ShoppingList.TabIndex = 0;
            this.ShoppingList.SelectedIndexChanged += new System.EventHandler(this.ShoppingList_SelectedIndexChanged);
            // 
            // Shop
            // 
            this.Shop.AutoSize = true;
            this.Shop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shop.Location = new System.Drawing.Point(12, 29);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(59, 25);
            this.Shop.TabIndex = 2;
            this.Shop.Text = "Shop";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalPrice.Location = new System.Drawing.Point(519, 275);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(82, 25);
            this.TotalPrice.TabIndex = 4;
            this.TotalPrice.Text = "0000 kn";
            // 
            // Buybtn
            // 
            this.Buybtn.Location = new System.Drawing.Point(128, 327);
            this.Buybtn.Name = "Buybtn";
            this.Buybtn.Size = new System.Drawing.Size(118, 53);
            this.Buybtn.TabIndex = 5;
            this.Buybtn.Text = "Buy";
            this.Buybtn.UseVisualStyleBackColor = true;
            this.Buybtn.Click += new System.EventHandler(this.Buybtn_Click);
            // 
            // GoToCart
            // 
            this.GoToCart.Location = new System.Drawing.Point(670, 385);
            this.GoToCart.Name = "GoToCart";
            this.GoToCart.Size = new System.Drawing.Size(118, 53);
            this.GoToCart.TabIndex = 6;
            this.GoToCart.Text = "Cart";
            this.GoToCart.UseVisualStyleBackColor = true;
            this.GoToCart.Click += new System.EventHandler(this.GoToCart_Click);
            // 
            // sortddl
            // 
            this.sortddl.FormattingEnabled = true;
            this.sortddl.Items.AddRange(new object[] {
            "All",
            "CPU",
            "Memory",
            "Motherboard",
            "Storage",
            "Video Card"});
            this.sortddl.Location = new System.Drawing.Point(428, 73);
            this.sortddl.Name = "sortddl";
            this.sortddl.Size = new System.Drawing.Size(121, 21);
            this.sortddl.TabIndex = 7;
            this.sortddl.Text = "All";
            this.sortddl.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(583, 131);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(121, 53);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cart price:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(407, 385);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(118, 53);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 148);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(425, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filter:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(47, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.sortddl);
            this.Controls.Add(this.GoToCart);
            this.Controls.Add(this.Buybtn);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.Shop);
            this.Controls.Add(this.ShoppingList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox ShoppingList;
        private System.Windows.Forms.Label Shop;
        public System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Button Buybtn;
        private System.Windows.Forms.Button GoToCart;
        private System.Windows.Forms.ComboBox sortddl;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}

