using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormShop
{
    public partial class Form2 : Form
    {
        public static Form1 gotoshop = new Form1();

        public Form2()
        {

            InitializeComponent();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            PcComponent comp = (PcComponent)CartList.SelectedItem;
            CartList.Items.Remove(CartList.SelectedItem);
            Form1.Cart.Remove(comp);
            lblCartPrice.Text = Form1.Cart.Sum(x => x.Price).ToString("C");

        }
        
        private void GoToShop_Click(object sender, EventArgs e)
        {
            gotoshop.TotalPrice.Text = Form1.Cart.Sum(x => x.Price).ToString("C");

            Hide();
            gotoshop.Refresh();
            gotoshop.Show();

        }

        private void btnExitCart_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
