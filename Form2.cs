using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        float CalculateToppingsPrice()
        { float toppings = 0;
        if(chkExtraCheese.Checked)
            {
                toppings+= Convert.ToSingle(chkExtraCheese.Tag);
            }
            if (chkMushrooms.Checked)
            {
                toppings +=Convert. ToSingle( chkMushrooms.Tag);
            }
            if (chkOlives.Checked)
                {
                    toppings += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkPeppers.Checked)
            {
                toppings += Convert.ToSingle(chkPeppers.Tag);
            }
            if(chkTomatoes.Checked)
            {
                toppings += Convert.ToSingle(chkTomatoes.Tag);
            }
            if(chkOnion.Checked)
            {
                toppings += Convert.ToSingle(chkOnion.Tag);
            }
            return toppings;
        }
        float CalculateCrustPrice()
        {
           
           if (btnThinkCrust.Checked)
            {
                return Convert.ToSingle(btnThinkCrust.Tag);   }
            
                return Convert.ToSingle(btnThinCrust.Tag);
            
           
        }
        float CalculateSizePrice()
        {
            if (btnSmall.Checked)
            {
                return Convert.ToSingle(btnSmall.Tag);
            }
            else if (btnMedium.Checked)
            {
                return Convert.ToSingle( btnMedium.Tag);
            }
         
                return Convert.ToSingle( btnLarge.Tag);
        }
        float CalculateTotalPrice()
        {
            float total = 0;
            total += CalculateSizePrice();
            total += CalculateCrustPrice();
            total += CalculateToppingsPrice();
            return total;
        }
        void UpdatePrice()
        {
            lblPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        private void btnSmall_CheckedChanged(object sender, EventArgs e)
        {
            
            UpdateSize();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereToEat.Text = "Take Out";    
        }
        void UpdateToppings()
            A simple **C# Windows Forms** application that allows users to order pizza with customizable toppings.  
            The project was created as AcceptRejectRule practice for learning **WinForms, GroupBox, Label word-wrapping, and UI state management**.

            ---

            ## ✨ Features
            - Select pizza toppings (Cheese, Mushrooms, Onions, FORMATETC.).
        - Automatic word-wrap for toppings list inside GroupBox.
            - GroupBox disabling with labels shown as grayed text.
        {
            UpdatePrice();
            string toppings = "";
            if (chkExtraCheese.Checked)
            {
                toppings += "Extra Cheese, ";
            }
            if (chkMushrooms.Checked)
            {
                toppings += "Mushrooms, ";
            }
            if (chkOlives.Checked)
            {
                toppings += "Olives, ";
            }
            if (chkPeppers.Checked)
            {
                toppings += "Peppers, ";
            }
            if (chkTomatoes.Checked)
            {
                toppings += "Tomatoes, ";
            }
            if (chkOnion.Checked)
            {
                toppings += "Onion, ";
            }
            if (toppings.Length > 2)
            {
                toppings = toppings.Substring(0, toppings.Length - 2);
            }
            if(toppings=="")
            {
                toppings = "No Toppings";
            }
            lblToppings.Text = toppings;
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void btnSmall_CheckedChanged_1(object sender, EventArgs e)
        {
            
            UpdateSize();

        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to place this order?", "Confirm Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Your order has been placed!", "Order Placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                grpSize.Enabled = false;
                grpToppings.Enabled = false;
                btnOrderPizza.Enabled = false;
                grpCrust.Enabled = false;
                grpWhereToEat.Enabled = false;

            }
            else
            {
                MessageBox.Show("Your order has been cancelled.", "Order Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void ResetForm()
        {             grpSize.Enabled = true;
            grpToppings.Enabled = true;
            btnOrderPizza.Enabled = true;
            grpCrust.Enabled = true;
            grpWhereToEat.Enabled = true;
            btnSmall.Checked = true;
            btnThinCrust.Checked = true;
            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkPeppers.Checked = false;
            chkTomatoes.Checked = false;
            chkOnion.Checked = false;
            btnEatIn.Checked = true;
            lblWhereToEat.Text = "Eat In";
            lblCrustType.Text = "Thin Crust";
            lblSize.Text = "Small";
            lblToppings.Text = "No Toppings";
            UpdatePrice();
        }
        void UpdateOrderSummary()
        { UpdateSize();
            btnEatIn.Checked = true;
            btnThinCrust.Checked = true;
            UpdateCrust();
            UpdateToppings();
            lblWhereToEat.Text = btnEatIn.Checked ? "Eat In" : "Take Out";
            UpdatePrice();
        }
        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        void UpdateCrust()
        {   UpdatePrice();
            if (btnThinkCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }
            else
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }
        }
        void UpdateSize()
        {
            UpdatePrice();
            if (btnSmall.Checked)
            {
                lblSize.Text = "Small";
                    return;
            }
            else if (btnMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }
            else if (btnLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }
        }

        private void btnLarge_CheckedChanged(object sender, EventArgs e)
        {
         
            UpdateSize();

        }

        private void btnThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void btnThinkCrust_CheckedChanged(object sender, EventArgs e)
        {UpdateCrust();

        }

        private void btnEatIn_CheckedChanged(object sender, EventArgs e)
        {
           lblWhereToEat.Text = "Eat In";

        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
    }

}


