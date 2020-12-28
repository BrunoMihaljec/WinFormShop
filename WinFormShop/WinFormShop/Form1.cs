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
    public partial class Form1 : Form
    {

        public List<PcComponent> ComponentList = new List<PcComponent>();
        public List<PcComponent> Cart = new List<PcComponent>();
       
        public static  Form2 gotocart = new Form2();


        public Form1()
        {
            
            InitializeComponent();
            AddProducts();
            /*List<string> ddlSortlist = new List<string> konto sam preko ovog da odaberem nesto iz ddlSortList i da mi po tome sortira listbox
            {
                "CPU",
                "Memory",
                "Motherboard",
                "Storage",
                "Video Card"
            };            
            sortddl.DataSource = ddlSortlist;*/
            ShoppingList.DataSource = ComponentList;         

        }
        public void AddProducts()
        {
            ComponentList.Add(new PcComponent("CPU", "AMD Ryzen 8 5800x", "AMD", 449.00));
            ComponentList.Add(new PcComponent("CPU", "Intel Core i7.10700k", "Intel", 412.64));
            ComponentList.Add(new PcComponent("CPU", "Intel Core i0-9900K", "Intel", 349.99));
            ComponentList.Add(new PcComponent("Memory", "G.Skill Trident", "G.skill", 174.99));
            ComponentList.Add(new PcComponent("Memory", "Team T-Force XTREEM ARGB", "Team", 154.60));
            ComponentList.Add(new PcComponent("Memory", "Corsair Vengeance LPX", "Corsair", 143.99));
            ComponentList.Add(new PcComponent("Motherboard", "Gigabyte X570 Aourus", "Gigabyte", 177.00));
            ComponentList.Add(new PcComponent("Motherboard", "Asus ROG MAXIMUS X11", "Asus", 513.66));
            ComponentList.Add(new PcComponent("Motherboard", "Gigabyte Z390 AORUS", "Gigabyte", 179.99));
            ComponentList.Add(new PcComponent("Storage", "Crucial MX500 1 TB", "Crucial", 170.59));
            ComponentList.Add(new PcComponent("Storage", "Samsung 970 Evo 1 TB", "Samsung", 129.99));
            ComponentList.Add(new PcComponent("Storage", "Western Digital SN750 1 TB", "Western Digital", 129.99));
            ComponentList.Add(new PcComponent("Video Card", "EVGA GeForce RTX 3080", "EVGA", 1000.00));
            ComponentList.Add(new PcComponent("Video Card", "PNY GeForce RTX 3090", "PNY", 1705.99));
            ComponentList.Add(new PcComponent("Video Card", "MSI GeForce RTX 3070", "MSI", 979.00));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void ShoppingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Buybtn_Click(object sender, EventArgs e) 
        {
            gotocart.CartList.Items.Add(ShoppingList.Text);
            Cart.Add((PcComponent)ShoppingList.SelectedValue);          
            TotalPrice.Text = Cart.Sum(x => x.Price).ToString("C");
            // Ne update mi cijenu kad se vratim u shop ali ostane mi u cartu proizvodi
        }

        private void GoToCart_Click(object sender, EventArgs e)
        {
            Hide();
            gotocart.Show();            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
           
        }
    }
}
