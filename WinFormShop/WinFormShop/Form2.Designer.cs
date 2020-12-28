
namespace WinFormShop
{
    partial class Form2
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.MyCart = new System.Windows.Forms.Label();
            this.CartList = new System.Windows.Forms.ListBox();
            this.GoToShop = new System.Windows.Forms.Button();
            this.btnExitCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(120, 328);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(118, 53);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // MyCart
            // 
            this.MyCart.AutoSize = true;
            this.MyCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCart.Location = new System.Drawing.Point(7, 30);
            this.MyCart.Name = "MyCart";
            this.MyCart.Size = new System.Drawing.Size(81, 25);
            this.MyCart.TabIndex = 8;
            this.MyCart.Text = "My Cart";
            // 
            // CartList
            // 
            this.CartList.FormattingEnabled = true;
            this.CartList.Location = new System.Drawing.Point(12, 58);
            this.CartList.Name = "CartList";
            this.CartList.Size = new System.Drawing.Size(358, 264);
            this.CartList.TabIndex = 7;
            // 
            // GoToShop
            // 
            this.GoToShop.Location = new System.Drawing.Point(633, 372);
            this.GoToShop.Name = "GoToShop";
            this.GoToShop.Size = new System.Drawing.Size(155, 66);
            this.GoToShop.TabIndex = 10;
            this.GoToShop.Text = "Shop";
            this.GoToShop.UseVisualStyleBackColor = true;
            this.GoToShop.Click += new System.EventHandler(this.GoToShop_Click);
            // 
            // btnExitCart
            // 
            this.btnExitCart.Location = new System.Drawing.Point(429, 372);
            this.btnExitCart.Name = "btnExitCart";
            this.btnExitCart.Size = new System.Drawing.Size(155, 66);
            this.btnExitCart.TabIndex = 11;
            this.btnExitCart.Text = "Exit";
            this.btnExitCart.UseVisualStyleBackColor = true;
            this.btnExitCart.Click += new System.EventHandler(this.btnExitCart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExitCart);
            this.Controls.Add(this.GoToShop);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.MyCart);
            this.Controls.Add(this.CartList);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label MyCart;
        public System.Windows.Forms.ListBox CartList;
        private System.Windows.Forms.Button GoToShop;
        private System.Windows.Forms.Button btnExitCart;
    }
}