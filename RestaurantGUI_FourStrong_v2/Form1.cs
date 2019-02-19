using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantGUI_FourStrong_v2
{
    public partial class Form1 : Form
    {
        const double Price_Chicken = 12.95;
        const double Price_Beef = 16.95;
        const double Price_Pork = 14.95;

        const double Price_Soda = 3.95;
        const double Price_Tea = 1.95;
        const double Price_Milk = 2.95;

        const double Price_Cake = 5.95;
        const double Price_Cookie = 2.95;
        const double Price_IceCream = 3.95;

        const double Tax_Rate = 8.9;
        const double Tip_Rate = 10;

        double iTax, iTip, iSubTotal, iTotal, iChange, iCash;

        public Form1()
        {
            InitializeComponent();
        }

        private void FoodDescriptions_TextChanged(object sender, EventArgs e)
        {

        }

        private void Entrees_Click(object sender, EventArgs e)
        {
            
        }

        private void PaymentForm_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (PaymentForm.Text == "Cash")
            {
                CashGiven.Enabled = true;
                CashGiven.Text = " ";
                CashGiven.Focus();

                Change.Enabled = true;
                Change.Text = " ";
                Change.Focus();

            }
            else
            {
                CashGiven.Enabled = false;
                CashGiven.Text = "0";
                Change.Enabled = false;
                Change.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] itemCost = new double[9];
            itemCost[0] = Convert.ToDouble(ChickenQty.Text) * Price_Chicken;
            itemCost[1] = Convert.ToDouble(BeefQty.Text) * Price_Beef;
            itemCost[2] = Convert.ToDouble(PorkQty.Text) * Price_Pork;
            itemCost[3] = Convert.ToDouble(SodaQty.Text) * Price_Soda;
            itemCost[4] = Convert.ToDouble(TeaQty.Text) * Price_Tea;
            itemCost[5] = Convert.ToDouble(MilkQty.Text) * Price_Milk;
            itemCost[6] = Convert.ToDouble(CakeQty.Text) * Price_Cake;
            itemCost[7] = Convert.ToDouble(CookieQty.Text) * Price_Cookie;
            itemCost[8] = Convert.ToDouble(IceCreamQty.Text) * Price_IceCream;

           if (PaymentForm.Text == "Cash")
            {
                iSubTotal = itemCost[0] + itemCost[1] + itemCost[2] + itemCost[3] + itemCost[4] +
                    itemCost[5] + itemCost[6] + itemCost[7] + itemCost[8];

                BeforeTaxAndTip.Text = Convert.ToString(iSubTotal);
                BeforeTaxAndTip.Text = String.Format("{0:C}", iSubTotal);

                iTax = iSubTotal * Tax_Rate/100;
                TaxCharged.Text = Convert.ToString(iTax);
                TaxCharged.Text = String.Format("{0:C}", iTax);

                iTip = iSubTotal * Tip_Rate/100;
                TipCharged.Text = Convert.ToString(iTip);
                TipCharged.Text = String.Format("{0:C}", iTip);

                iTotal = iSubTotal + iTax + iTip;
                GrandTotal.Text = Convert.ToString(iTotal);
                GrandTotal.Text = String.Format("{0:C}", iTotal);

                iCash = Convert.ToDouble(CashGiven.Text);
                iChange = iCash - iTotal;
                Change.Text = Convert.ToString(iChange);
                Change.Text = String.Format("{0:C}", iChange);
            }
            else
            {
                iSubTotal = itemCost[0] + itemCost[1] + itemCost[2] + itemCost[3] + itemCost[4] +
                        itemCost[5] + itemCost[6] + itemCost[7] + itemCost[8];

                BeforeTaxAndTip.Text = Convert.ToString(iSubTotal);
                BeforeTaxAndTip.Text = String.Format("{0:C}", iSubTotal);

                iTax = (iSubTotal * Tax_Rate) / 100;
                TaxCharged.Text = Convert.ToString(iTax);
                TaxCharged.Text = String.Format("{0:C}", iTax);

                iTip = (iSubTotal * Tip_Rate) / 100;
                TipCharged.Text = Convert.ToString(iTip);
                TipCharged.Text = String.Format("{0:C}", iTip);

                iTotal = iSubTotal + iTax + iTip;
                GrandTotal.Text = Convert.ToString(iTotal);
                GrandTotal.Text = String.Format("{0:C}", iTotal);
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm that you want to Exit the System", "Restaurant and Culinary Delights",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //==================================ResetTextBoxes()=====================================
        private void ResetTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);

            };
            func(Controls);
        }
        //===============================EnableTextBoxes()=======================================
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);

            };
            func(Controls);
        }
        //===============================ResetCheckBoxes()=================================
        private void ResetCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);

            };
            func(Controls);
        }
        private void ResetComboBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else
                        func(control.Controls);

            };
            func(Controls);
        }
        private void ResetMaskedTextBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is MaskedTextBox)
                        (control as MaskedTextBox).Text = " ";
                    else
                        func(control.Controls);

            };
            func(Controls);
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            ResetTextBoxes();
            ResetCheckBoxes();
            ResetComboBoxes();
            ResetMaskedTextBox();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(Chicken.Checked == true)
            {
                ChickenQty.Enabled = true;
                ChickenQty.Text = " ";
                ChickenQty.Focus();
            }
            else
            {
                ChickenQty.Enabled = false;
                ChickenQty.Text = "0";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();
        }

        private void ChickenQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void Beef_CheckedChanged(object sender, EventArgs e)
        {
            if (Beef.Checked == true)
            {
                BeefQty.Enabled = true;
                BeefQty.Text = " ";
                BeefQty.Focus();
            }
            else
            {
                BeefQty.Enabled = false;
                BeefQty.Text = "0";
            }
        }

        private void Pork_CheckedChanged(object sender, EventArgs e)
        {
            if (Pork.Checked == true)
            {
                PorkQty.Enabled = true;
                PorkQty.Text = " ";
                PorkQty.Focus();
            }
            else
            {
                PorkQty.Enabled = false;
                PorkQty.Text = "0";
            }
        }

        private void Soda_CheckedChanged(object sender, EventArgs e)
        {
            if (Soda.Checked == true)
            {
                SodaQty.Enabled = true;
                SodaQty.Text = " ";
                SodaQty.Focus();
            }
            else
            {
                SodaQty.Enabled = false;
                SodaQty.Text = "0";
            }
        }

        private void Tea_CheckedChanged(object sender, EventArgs e)
        {
            if (Tea.Checked == true)
            {
                TeaQty.Enabled = true;
                TeaQty.Text = " ";
                TeaQty.Focus();
            }
            else
            {
                TeaQty.Enabled = false;
                TeaQty.Text = "0";
            }
        }

        private void Milk_CheckedChanged(object sender, EventArgs e)
        {
            if (Milk.Checked == true)
            {
                MilkQty.Enabled = true;
                MilkQty.Text = " ";
                MilkQty.Focus();
            }
            else
            {
                MilkQty.Enabled = false;
                MilkQty.Text = "0";
            }
        }

        private void Cake_CheckedChanged(object sender, EventArgs e)
        {
            if (Cake.Checked == true)
            {
                CakeQty.Enabled = true;
                CakeQty.Text = " ";
                CakeQty.Focus();
            }
            else
            {
                CakeQty.Enabled = false;
                CakeQty.Text = "0";
            }
        }

        private void Cookie_CheckedChanged(object sender, EventArgs e)
        {
            if (Cookie.Checked == true)
            {
                CookieQty.Enabled = true;
                CookieQty.Text = " ";
                CookieQty.Focus();
            }
            else
            {
                CookieQty.Enabled = false;
                CookieQty.Text = "0";
            }
        }

        private void CakeQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PaymentMethod_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BeforeTaxAndTip_TextChanged(object sender, EventArgs e)
        {

        }

        private void Change_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void IceCream_CheckedChanged(object sender, EventArgs e)
        {
            if (IceCream.Checked == true)
            {
                IceCreamQty.Enabled = true;
                IceCreamQty.Text = " ";
                IceCreamQty.Focus();
            }
            else
            {
                IceCreamQty.Enabled = false;
                IceCreamQty.Text = "0";
            }
        }

        private void IceCreamQty_TextChanged(object sender, EventArgs e)
        {

        }

        private void BeefQty_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
