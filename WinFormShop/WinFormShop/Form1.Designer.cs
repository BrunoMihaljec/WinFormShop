
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
            this.CartList = new System.Windows.Forms.ListBox();
            this.Shop = new System.Windows.Forms.Label();
            this.MyCart = new System.Windows.Forms.Label();
            this.TotalPrice = new System.Windows.Forms.Label();
            this.Buybtn = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
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
            // CartList
            // 
            this.CartList.FormattingEnabled = true;
            this.CartList.Location = new System.Drawing.Point(430, 57);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(358, 264);
            this.CartList.TabIndex = 1;
            // 
            // Shop
            // 
            this.Shop.AutoSize = true;
            this.Shop.Location = new System.Drawing.Point(12, 41);
            this.Shop.Name = "Shop";
            this.Shop.Size = new System.Drawing.Size(32, 13);
            this.Shop.TabIndex = 2;
            this.Shop.Text = "Shop";
            // 
            // MyCart
            // 
            this.MyCart.AutoSize = true;
            this.MyCart.Location = new System.Drawing.Point(427, 41);
            this.MyCart.Name = "MyCart";
            this.MyCart.Size = new System.Drawing.Size(43, 13);
            this.MyCart.TabIndex = 3;
            this.MyCart.Text = "My Cart";
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSize = true;
            this.TotalPrice.Location = new System.Drawing.Point(753, 308);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(35, 13);
            this.TotalPrice.TabIndex = 4;
            this.TotalPrice.Text = "label3";
            // 
            // Buybtn
            // 
            this.Buybtn.Location = new System.Drawing.Point(146, 327);
            this.Buybtn.Name = "Buybtn";
            this.Buybtn.Size = new System.Drawing.Size(75, 23);
            this.Buybtn.TabIndex = 5;
            this.Buybtn.Text = "Buy";
            this.Buybtn.UseVisualStyleBackColor = true;
            this.Buybtn.Click += new System.EventHandler(this.Buybtn_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(571, 327);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.Buybtn);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.MyCart);
            this.Controls.Add(this.Shop);
            this.Controls.Add(this.CartList);
            this.Controls.Add(this.ShoppingList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ShoppingList;
        private System.Windows.Forms.ListBox CartList;
        private System.Windows.Forms.Label Shop;
        private System.Windows.Forms.Label MyCart;
        private System.Windows.Forms.Label TotalPrice;
        private System.Windows.Forms.Button Buybtn;
        private System.Windows.Forms.Button btnRemove;
    }
}

