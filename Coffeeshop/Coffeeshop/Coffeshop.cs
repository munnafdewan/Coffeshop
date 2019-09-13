using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffeeshop
{
    public partial class Coffeshop : Form
    {
       
        public Coffeshop()
        {
            InitializeComponent();
        }

       

        private void button_Click(object sender, EventArgs e)
        {
            string name = customerNameBox.Text;
            string contuct = customerContuctNo.Text;
            string address = customerAddress.Text;
            string item = orderComboBox.Text;

            int quantity = Convert.ToInt32(quantityCoffee.Text);

            double price = 0;

            if(item =="Black")
            {
                price = 120 * quantity;
            }
            else if(item =="Cold")
            {
                price = 100 * quantity;
            }
            else if(item =="Hot")
            {
                price = 90 * quantity;
            }
            else if(item =="Regular")
            {
                price = 80 * quantity;
            }
            else
            {
                MessageBox.Show("Please Select an item first");
            }
           
           
            richTextBox.Text = "Customer Name : " + name + Environment.NewLine + "Contuct Number : " + contuct + Environment.NewLine + "Address : " + address + Environment.NewLine + "Order : " + item + Environment.NewLine + "Quantity: " + quantity + Environment.NewLine +"Total Price" + price + Environment.NewLine + "Thank You";

            
        }
    }
}
