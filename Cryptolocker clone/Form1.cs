using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cryptolocker_clone
{
    public partial class Form1 : Form
    {
        private readonly Timer tic = new Timer();
        public int hour = 72;
        public int min = 00;
        public int sec = 00;

        Label label9;

        private void MainText()
        {
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "Your important files ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = "encryption ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "produced on this computer: photos, videos, documents, etc.";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "          is a complete list of encrypted files, and you can personally verify this.";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "Encryption was produced using a ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = "unique ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "public key";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "                   generated for this";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "computer. To decrypt files you need to obtain the ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = "private key.\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "The ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = "single copy ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "of the private key, which will allow you to decrypt the files, located\n";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "on a secret server on the Internet; the server will ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = "destroy ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "the key after a time\n";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "specified in this window. After that, ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = "nobody and never will be able ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "to restore files...\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = "To obtain ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "the private key for this computer, which will automatically decrypt files, you\n";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "need to pay ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = "300 USD ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "/ ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectedText = "300 EUR ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "/ ";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "similar amount in another currency.\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f);
            richTextBox1.SelectedText = "Click «Next» to select the method of payment.\n";
            richTextBox1.SelectedText = "\n";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(215, 0, 0);
            richTextBox1.SelectedText = "Any attempt to remove or damage this software will lead to the immediate\n";
            richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
            richTextBox1.SelectionColor = Color.FromArgb(215, 0, 0);
            richTextBox1.SelectedText = "destruction of the private key by server.";
        }

        public Form1()
        {
            InitializeComponent();
            MainText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
            tic.Interval = 1000;
            tic.Start();
            tic.Tick += Tic_Tick;

            DateTime dt = DateTime.Now;
            label4.Text = dt.ToString();
            label4.Text = DateTime.Now.AddDays(3).ToString("MM/dd/yyyy");

            label6.Text = DateTime.Now.ToString("HH/mm");

            label9 = new Label();
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Tahoma", 18.75f, FontStyle.Bold);
            label9.Text = "Your personal files are encrypted!";
            label9.AutoSize = true;
            label9.Location = new Point(325, 19);
            this.Controls.Add(label9);


            label7.Visible = false;
            label8.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            textBox1.Visible = false;
        }

        private void Tic_Tick(object sender, EventArgs e)
        {
            sec -= 1;
            if (sec < 0)
            {
                sec = 59;
                min -= 1;
            }
            if (min < 0)
            {
                hour -= 1;
                min = 59;
            }
            label1.Text = string.Format("{0:00}:{1:00}:{2:00}", hour, min, sec);
            if (hour == 0 && min == 0 && sec == 0)
            {
                tic.Stop();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString() == "MoneyPak (USA only)")
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                richTextBox1.Text = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "MoneyPak is an easy and convenient way to send money to where you need it. The\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "MoneyPak works as a ‘cash top-up card’.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "Where can I purchase a MoneyPak?\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "MoneyPak can be purchased at thousands of stores nationwide, including major retailers such as Walmart, Walgreens, CVS/pharmacy, Rite Aid, Kmart and Kroger. Click         to find a store near you.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "How do I buy a MoneyPak at the store?";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "Pick up a MoneyPak from the Prepaid Product Section or Green Dot display and take it to the register. ";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "The cashier will collect your cash and load it onto the MoneyPak.";
                linkLabel3.Visible = false;
                linkLabel4.Visible = false;
                linkLabel5.Visible = true;
                linkLabel6.Visible = true;
                linkLabel7.Visible = true;
                button1.Visible = false;
                button1.Enabled = true;
                button3.Visible = true;

                label8.Visible = true;
                label8.Text = "Enter the card number and press «Pay»:";
                comboBox2.Visible = true;
                comboBox2.SelectedIndex = 0;
                textBox1.Visible = true;
            }

            if (comboBox1.Text.ToString() == "paysafecard")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                richTextBox1.Text = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "Paysafecard is an electronic payment method for predominantly online shopping and is\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "based on a pre-pay system. Paying with paysafecard does not require sharing sensitive ";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "bank account or credit card details. Using paysafecard is comparable to paying with cash ";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "in a shop and it is currently available in over 30 countries.\n\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "Paysafecard works by purchasing a PIN code printed on a card, and entering this code";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "at webshops.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "Paysafecard is available from many supermarkets, petrol stations, tobacconists and \n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "newsagents.";
                linkLabel3.Visible = false;
                linkLabel4.Visible = false;
                linkLabel5.Visible = false;
                linkLabel6.Visible = false;
                linkLabel7.Visible = false;
                button1.Visible = false;
                button1.Enabled = true;
                button3.Visible = true;

                label8.Visible = true;
                label8.Text = "Enter the PIN-code of the card, select card currency, and press «Pay»:";
                comboBox2.Visible = true;
                comboBox2.SelectedIndex = 0;
                textBox1.Visible = true;
            }

            if (comboBox1.Text.ToString() == "Ukash")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                richTextBox1.Text = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "Ukash is electronic cash and e-commerce brand. Based on a prepaid system, Ukash\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "allows users to purchase and then spend money online.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "Money can be purchased from one of the reported 420,000 participating retail locations worldwide, or by using the company’s website. ";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "This electronic money can then be used to pay online, or loaded on to a prepaid card ";
                richTextBox1.SelectedText = "or eWallet.";
                linkLabel3.Visible = false;
                linkLabel4.Visible = false;
                linkLabel5.Visible = false;
                linkLabel6.Visible = false;
                linkLabel7.Visible = false;
                button1.Visible = false;
                button1.Enabled = true;
                button3.Visible = true;

                label8.Visible = true;
                label8.Text = "Enter the code of the card, select card currency, and press «Pay»:";
                comboBox2.Visible = true;
                comboBox2.SelectedIndex = 0;
                textBox1.Visible = true;
            }

            if (comboBox1.Text.ToString() == "cashU")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                richTextBox1.Text = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "cashU is a prepaid online and mobile payment method available in the Middle East and\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "North Africa, a region with a large and young population with very limited access to\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "credit cards. Because of this, cashU has become one of the most popular alternative\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "payment option for young Arabic online gamers and e-commerce buyers.";
                linkLabel3.Visible = false;
                linkLabel4.Visible = false;
                linkLabel5.Visible = false;
                linkLabel6.Visible = false;
                linkLabel7.Visible = false;
                button1.Visible = false;
                button1.Enabled = true;
                button3.Visible = true;

                label8.Visible = true;
                label8.Text = "Enter the coupon code and click «Pay»:";
                comboBox2.Visible = true;
                comboBox2.SelectedIndex = 0;
                textBox1.Visible = true;
            }

            if (comboBox1.Text.ToString() == "Bitcoin")
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                richTextBox1.Text = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "Bitcoin is a cryptocurrency where the creation and transfer of bitcoins is based on an\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "open-source cryptographic protocol that is independent of any central authority.\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "Bitcoins can be transferred through a computer or smartphone without an intermediate financial institution.\n";
                richTextBox1.SelectedText = "\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "You have to send below specified amount to Bitcoin address\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f, FontStyle.Bold);
                richTextBox1.SelectedText = "$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = " and specify the transaction ID, which\n";
                richTextBox1.SelectionFont = new Font("Tahoma", 10f);
                richTextBox1.SelectedText = "will be verified and confirmed.";
                linkLabel3.Visible = true;
                linkLabel4.Visible = true;
                linkLabel5.Visible = false;
                linkLabel6.Visible = false;
                linkLabel7.Visible = false;
                button1.Visible = false;
                button1.Enabled = true;
                button3.Visible = true;

                label8.Visible = true;
                label8.Text = "Enter the transaction ID and press «Pay»:";
                comboBox2.Visible = true;
                comboBox2.SelectedIndex = 1;
                textBox1.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Visible)
            {
                richTextBox1.Clear();
                comboBox1.Visible = true;
                label7.Visible = true;
                button2.Visible = true;
                linkLabel1.Visible = false;
                linkLabel2.Visible = false;
                comboBox1.SelectedItem = null;
                label9.Text = "Payment for private key";
                label9.Location = new Point(405, 19);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            MainText();

            comboBox1.Visible = false;
            comboBox1.SelectedItem = null;
            comboBox2.Visible = false;

            linkLabel1.Visible = true;
            linkLabel2.Visible = true;
            linkLabel3.Visible = false;
            linkLabel4.Visible = false;
            linkLabel5.Visible = false;
            linkLabel6.Visible = false;
            linkLabel7.Visible = false;

            button1.Visible = true;
            button1.Enabled = true;
            button2.Visible = false;
            button3.Visible= false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;

            label7.Visible = false;
            label8.Visible = false;
            textBox1.Visible = false;

            label9.Text = "Your personal files are encrypted!";
            label9.Location = new Point(325, 19);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No file has been encrypted! This is fake cryptolocker!", "FAKE CRYPTOLOCKER");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/RSA_(cryptosystem)");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://bitcoin.org/en/");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://bitcoin.org/en/getting-started");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.moneypak.com/");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://secure.attheregister.com/locations");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://secure.attheregister.com/locations");
        }
    }
}
