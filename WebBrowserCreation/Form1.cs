using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowserCreation
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        Encrypt_Decrypt_ServiceReference.ServiceClient proxy = new Encrypt_Decrypt_ServiceReference.ServiceClient();
        GetStockQuote_ServiceReference1.ServiceClient proxy_for_stock = new GetStockQuote_ServiceReference1.ServiceClient();

        private void encryptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(encrypttextBox.Text))
            {
                ErrorText.Visible = false;
                string encryptOut = "";
                try
                {
                    //Calling API method to encrypt an Input

                    encryptOut = proxy.Encrypt(encrypttextBox.Text);
                }
                catch
                {
                    encryptOut = "Please enter a Valid Input";
                }

                output.Text = encryptOut;
            }
            else
            {
                //Empty String check
                ErrorText.Visible = true;
                ErrorText.Text = "Please enter the string to Encrypt/Decrypt";
            }
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(decrypttextBox.Text))
            {
                ErrorText.Visible = false;
                string decryptsOut = "";
                try
                {
                    //Calling API method to decrypt an Input

                    decryptsOut = proxy.Decrypt(decrypttextBox.Text);
                }
                catch
                {
                    decryptsOut = "Please enter a Valid Input";
                }
                output.Text = decryptsOut;
            }
            else
            {
                //Empty String check
                ErrorText.Visible = true;
                ErrorText.Text = "Please enter the string to Encrypt/Decrypt";
            }
        }

        private void getStockButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(stockSymInp.Text))
            {
                ErrorQuote.Visible = false;
                string getStockVal = "";
                try
                {
                    //Calling the API method to getStockQuote

                    getStockVal = proxy_for_stock.getStockquote(stockSymInp.Text);
                }
                catch
                {
                    getStockVal = "Please enter a Valid Input";
                }
                stockQuoteOut.Text = getStockVal;
            }
            else
            {
                ErrorQuote.Visible = true;
                ErrorQuote.Text = "Please enter Stock Symbol";
            }
        }
    }
}
