using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Security;
using System.Media;
using CashRegister.Properties;

namespace CashRegister
{
    public partial class musicShop : Form
    {
        double priceA = 200000;
        double priceB = 40;
        double priceC = 150000;
        int numOfa = 0;
        int numOfb = 0;
        int numOfc = 0;
        double subtotalA = 0;
        double subtotalB = 0;
        double subtotalC = 0;
        double subtotal = 0;
        double taxRate = 0.13;
        double taxAmount = 0;
        double totalPrice = 0;
        double tenderedAmount = 0;
        double change = 0;
       

        public musicShop()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object ender, EventArgs e)
        {

            try
            {
                receipt.Text = "";

                numOfa = Convert.ToInt32(input1.Text);
                numOfb = Convert.ToInt32(input2.Text);
                numOfc = Convert.ToInt32(input3.Text);

                subtotalA = priceA * numOfa;
                subtotalB = priceB * numOfb;
                subtotalC = priceC * numOfc;
                subtotal = subtotalA + subtotalB + subtotalC;
                subtotalOutput.Text = subtotal.ToString("C");

                taxAmount = subtotal * taxRate;
                taxOutput.Text = taxAmount.ToString("C");

                totalPrice = subtotal + taxAmount;
                totalOutput.Text = totalPrice.ToString("C");
            }
            catch
            {
                receipt.Text = "Input Error \n Please Enter a Number ";
                return;
            }

            calcChangeButton.Enabled = true;
            calcChangeButton.Text = "Calculate Change";
            calcChangeButton.BackColor = Color.White;
        }

        private void calcChangeButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                receipt.Text = "";
                tenderedAmount = Convert.ToInt32(tenderedInput.Text);

                change = tenderedAmount - subtotal;
                changeOutput.Text = change.ToString("C");
            }
            catch
            {
                receipt.Text = "Input Error \n Please Enter a Number ";
                return;
            }

            printButton.Enabled = true;
            printButton.Text = "Print Receipt";
            printButton.BackColor = Color.White;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            

            SoundPlayer printerSound = new SoundPlayer(Properties.Resources.printerSound);
            printerSound.Play();

            receipt.Text =
            $"Piano Shop \n ";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += $"Order Number 0170 \n ";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += $"30/12/22 \n\n ";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += $"Fazioil Grand  x{numOfa} @ {priceA.ToString("C")} \n";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += $" Henle Urtext   x{numOfb} @ {priceB.ToString("C")} \n";
                Refresh();
            Thread.Sleep(500);
            receipt.Text += $" Steinway Grand x{numOfc} @ {priceC.ToString("C")} \n\n";
                Refresh();
            Thread.Sleep(500);
            receipt.Text += $"Subtotal       {subtotal.ToString("C")}\n";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += $"Tax            {taxAmount.ToString("C")}\n";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += $"Total          {totalPrice.ToString("C")}\n\n";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += $"Tendered       {tenderedAmount.ToString("C")}\n";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += $"Change         {change.ToString("C")}\n\n\n";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += $"Thank you, have a nice day!\n\n";
            Refresh();
            Thread.Sleep(500);
            receipt.Text += "";

            orderButton.Enabled = true;
            orderButton.Text = "New Order";
            orderButton.BackColor = Color.White;
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            input1.Text = "0";
            input2.Text = "0";
            input3.Text = "0";
            receipt.Text = "";
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";
            tenderedInput.Text = "";
            changeOutput.Text = "";

            orderButton.Enabled = false;
            orderButton.Text = "";
            orderButton.BackColor = Color.LightGray;
            printButton.Enabled = false;
            printButton.Text = "";
            printButton.BackColor = Color.LightGray;
            calcChangeButton.Enabled = false;
            calcChangeButton.Text = "";
            calcChangeButton.BackColor = Color.LightGray;

        }

       
    }
    }

