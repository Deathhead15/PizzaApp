using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UncleJoeysPizza
{
    public partial class Form1 : Form
    {
        string pizzaType, pizzaSize= "";
        double pizzaRate, pizzaTopping, pizzaBeverage, totalCost, totalDue = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            pizzaType = "Pepperoni";
            this.textBoxPizzaType.Text = pizzaType;
        }

        private void radioButtonHawaiian_CheckedChanged(object sender, EventArgs e)
        {
            pizzaType = "Hawaiian";
            this.textBoxPizzaType.Text = pizzaType;
        }

        private void radioButtonVegetarian_CheckedChanged(object sender, EventArgs e)
        {
            pizzaType = "Vegetarian";
            this.textBoxPizzaType.Text = pizzaType;
        }

        private void radioButtonSuperSupreme_CheckedChanged(object sender, EventArgs e)
        {
            pizzaType = "Super Supreme";
            this.textBoxPizzaType.Text = pizzaType;
        }

        private void radioButtonSmall_CheckedChanged(object sender, EventArgs e)
        {
            pizzaSize = "Small 8\" Pizza ";
            this.textBoxPizzaSize.Text = pizzaSize;
            pizzaRate = 6.99;
        }

        private void radioButtonMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            pizzaSize = "Medium 12\" Pizza ";
            this.textBoxPizzaSize.Text = pizzaSize;
            pizzaRate = 8.99;
        }

        private void radioButtonLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            pizzaSize = "Large 16\" Pizza ";
            this.textBoxPizzaSize.Text = pizzaSize;
            pizzaRate = 10.99;
        }

        private void radioButtonExtraLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            pizzaSize = "Extra Large 20\" Pizza ";
            this.textBoxPizzaSize.Text = pizzaSize;
            pizzaRate = 12.99;
        }


        double ptemp, stemp, ctemp, btemp, bbtemp, stetemp = 0;
        string ptop, stop, ctop, btop, bbtop, stetop = "";
        private void checkBoxPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ptemp == 2.00)
                {
                pizzaTopping -= ptemp;
                ptemp -= ptemp;
                ptop = "";
            }
            else
                {
                ptemp = 2.00;
                pizzaTopping += ptemp;
                ptop = "Pepperoni ";
            }

        }

        private void checkBoxSalami_CheckedChanged(object sender, EventArgs e)
        {
            if (stemp == 2.00)
            {
                pizzaTopping -= stemp;
                stemp -= stemp;
                stop = "";
            }
            else
            {
                stemp = 2.00;
                pizzaTopping += stemp;
                stop = "Salami ";
            }
        }

        private void checkBoxChicken_CheckedChanged(object sender, EventArgs e)
        {
            if (ctemp == 2.00)
            {
                pizzaTopping -= ctemp;
                ctemp -= ctemp;
                ctop = "";
            }
            else
            {
                ctemp = 2.00;
                pizzaTopping += ctemp;
                ctop = "Chicken ";
            }
        }

        private void checkBoxBeef_CheckedChanged(object sender, EventArgs e)
        {
            if (btemp == 2.00)
            {
                pizzaTopping -= btemp;
                btemp -= btemp;
                btop = "";
            }
            else
            {
                btemp = 2.00;
                pizzaTopping += btemp;
                btop = "Ground Beef ";
            }
        }

        private void checkBoxBBQ_CheckedChanged(object sender, EventArgs e)
        {
            if (bbtemp == 2.00)
            {
                pizzaTopping -= bbtemp;
                bbtemp -= bbtemp;
                bbtop = "";
            }
            else
            {
                bbtemp = 2.00;
                pizzaTopping += bbtemp;
                bbtop = "BBQ Strips ";
            }
        }

        private void checkBoxSteak_CheckedChanged(object sender, EventArgs e)
        {
            if (stetemp == 2.00)
            {
                pizzaTopping -= stetemp;
                stetemp -= stetemp;
                stetop = "";
            }
            else
            {
                stetemp = 2.00;
                pizzaTopping += stetemp;
                stetop = "Steak Strips ";
            }
        }

        double pc, mc, gc, prc, fc, fec = 0;
        string partop, moztop, goatop, protop, foutop, fettop = "";
        
        private void checkBoxParmesan_CheckedChanged(object sender, EventArgs e)
        {
            if (pc == 1.50)
            {
                pizzaTopping -= pc;
                pc -= pc;
                partop = "";
            }
            else
            {
                pc = 1.50;
                pizzaTopping += pc;
                partop = "Parmesan Cheese ";
            }
        }

        private void checkBoxMozarella_CheckedChanged(object sender, EventArgs e)
        {
            if (mc == 1.50)
            {
                pizzaTopping -= mc;
                mc -= mc;
                moztop = "";
            }
            else
            {
                mc = 1.50;
                pizzaTopping += mc;
                moztop = "Mozarella Cheese ";
            }
        }

        private void checkBoxGoat_CheckedChanged(object sender, EventArgs e)
        {
            if (gc == 1.50)
            {
                pizzaTopping -= gc;
                gc -= gc;
                goatop = "";
            }
            else
            {
                gc = 1.50;
                pizzaTopping += gc;
                goatop = "Goat Cheese ";
            }
        }


        private void checkBoxProvolone_CheckedChanged(object sender, EventArgs e)
        {
            if (prc == 1.50)
            {
                pizzaTopping -= prc;
                prc -= prc;
                protop = "";
            }
            else
            {
                prc = 1.50;
                pizzaTopping += prc;
                protop = "Provolone Cheese ";
            }
        }

        private void buttonFinalOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.textBoxFirstName.Text + " " + this.textBoxLastName.Text +
                ", Please wait for 30 minutes for you order to arrive.  Our delivery staff would call at ("
                + textBoxAreaCode.Text + ") " + textBoxPhoneNumber.Text + " to confirm.  Thank You!", "Delivery Details");

        }

        private void checkBoxFour_CheckedChanged(object sender, EventArgs e)
        {
            if (fc == 1.50)
            {
                pizzaTopping -= fc;
                fc -= fc;
                foutop = "";
            }
            else
            {
                fc = 1.50;
                pizzaTopping += fc;
                foutop = "Four Cheese ";
            }
        }

        private void checkBoxFeta_CheckedChanged(object sender, EventArgs e)
        {
            if (fec == 1.50)
            {
                pizzaTopping -= fec;
                fec -= fec;
                fettop = "";
            }
            else
            {
                fec = 1.50;
                pizzaTopping += fec;
                fettop = "Feta Cheese ";
            }
        }

        double mush, roma, pine, oliv, pepp, spin = 0;
        string mushtop, romatop, pinetop, olivtop, pepptop, spintop = "";

        private void checkBoxMushroom_CheckedChanged(object sender, EventArgs e)
        {
            if (mush == 1.00)
            {
                pizzaTopping -= mush;
                mush -= mush;
                mushtop = "";
            }
            else
            {
                mush = 1.00;
                pizzaTopping += mush;
                mushtop = "Mushroom ";
            }
        }

        private void checkBoxRoma_CheckedChanged(object sender, EventArgs e)
        {
            if (roma == 1.00)
            {
                pizzaTopping -= roma;
                roma -= roma;
                romatop = "";
            }
            else
            {
                roma = 1.00;
                pizzaTopping += roma;
                romatop = "Roma Tomatoes ";
            }
        }

        private void checkBoxPineapple_CheckedChanged(object sender, EventArgs e)
        {
            if (pine == 1.00)
            {
                pizzaTopping -= pine;
                pine -= pine;
                pinetop = "";
            }
            else
            {
                pine = 1.00;
                pizzaTopping += pine;
                pinetop = "Pineapple ";
            }
        }

        private void checkBoxOlive_CheckedChanged(object sender, EventArgs e)
        {
            if (oliv== 1.00)
            {
                pizzaTopping -= oliv;
                oliv -= oliv;
                olivtop = "";
            }
            else
            {
                oliv = 1.00;
                pizzaTopping += oliv;
                olivtop = "Olives ";
            }
        }

        private void checkBoxPepper_CheckedChanged(object sender, EventArgs e)
        {
            if (pepp == 1.00)
            {
                pizzaTopping -= pepp;
                pepp -= pepp;
                pepptop = "";
            }
            else
            {
                pepp = 1.00;
                pizzaTopping += pepp;
                pepptop = "Peppers ";
            }
        }

        private void checkBoxSpinach_CheckedChanged(object sender, EventArgs e)
        {
            if (spin == 1.00)
            {
                pizzaTopping -= spin;
                spin -= spin;
                spintop = "";
            }
            else
            {
                spin = 1.00;
                pizzaTopping += spin;
                spintop = "Spinach ";
            }
        }

        double ging, fant, root, diet, coke, spri = 0;
        string gingbev, fantbev, rootbev, cokebev, spribev, dietbev = "";

        private void checkBoxGinger_CheckedChanged(object sender, EventArgs e)
        {
            if (ging == 1.00)
            {
                pizzaBeverage -= ging;
                ging -= ging;
                gingbev= "";
            }
            else
            {
                ging = 1.00;
                pizzaBeverage += ging;
                gingbev = "Ginger Ale ";
            }
        }

        private void checkBoxFanta_CheckedChanged(object sender, EventArgs e)
        {
            if (fant== 1.00)
            {
                pizzaBeverage -= fant;
                fant -= fant;
                fantbev = "";
            }
            else
            {
                fant = 1.00;
                pizzaBeverage += ging;
                fantbev = "Fanta Orange ";
            }
        }

        private void checkBoxRoot_CheckedChanged(object sender, EventArgs e)
        {
            if (root == 1.00)
            {
                pizzaBeverage -= root;
                root -= root;
                rootbev = "";
            }
            else
            {
                root = 1.00;
                pizzaBeverage += root;
                rootbev = "Root Beer ";
            }
        }

        private void checkBoxDiet_CheckedChanged(object sender, EventArgs e)
        {
            if (diet == 1.00)
            {
                pizzaBeverage -= diet;
                diet -= diet;
                dietbev = "";
            }
            else
            {
                diet = 1.00;
                pizzaBeverage += diet;
                dietbev = "Diet Coke ";
            }
        }

        private void checkBoxSprite_CheckedChanged(object sender, EventArgs e)
        {
            if (spri == 1.00)
            {
                pizzaBeverage -= spri;
                spri -= spri;
                spribev = "";
            }
            else
            {
                spri = 1.00;
                pizzaBeverage += spri;
                spribev = "Sprite ";
            }
        }
        private void checkBoxCoke_CheckedChanged(object sender, EventArgs e)
        {
            if (coke == 1.00)
            {
                pizzaBeverage -= coke;
                coke -= coke;
                cokebev = "";
            }
            else
            {
                coke = 1.00;
                pizzaBeverage += coke;
                cokebev = "Coke ";
            }
        }

        double choc, bott, milk = 0;
        string chocbev, bottbev, milkbev = "";

        private void checkBoxChocolateMilk_CheckedChanged(object sender, EventArgs e)
        {
            if (choc == 1.00)
            {
                pizzaBeverage -= choc;
                choc -= choc;
                chocbev = "";
            }
            else
            {
                choc = 1.00;
                pizzaBeverage += choc;
                chocbev = "Chocolate Milk ";
            }

        }

        private void checkBoxBottledWater_CheckedChanged(object sender, EventArgs e)
        {
            if (bott == 1.00)
            {
                pizzaBeverage -= bott;
                bott -= bott;
                bottbev = "";
            }
            else
            {
                bott = 1.00;
                pizzaBeverage += bott;
                bottbev = "Bottled Water ";
            }
        }

        private void checkBoxMilk_CheckedChanged(object sender, EventArgs e)
        {
            if (milk == 1.00)
            {
                pizzaBeverage -= milk;
                milk -= milk;
                milkbev = "";
            }
            else
            {
                milk = 1.00;
                pizzaBeverage += milk;
                milkbev = "Milk ";
            }
        }


        private void buttonNexttoAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void buttonPlaceMain_Click(object sender, EventArgs e)
        {
            totalCost = pizzaRate + pizzaTopping + pizzaBeverage;
            totalDue = totalCost * 1.14;
            this.textBoxToppings.Text = ptop + stop + ctop + btop + bbtop + stetop +
                partop + moztop + goatop + protop + foutop + fettop +
                mushtop + romatop + pinetop + olivtop + pepptop + spintop;
            this.textBoxBeverages.Text = gingbev + fantbev + rootbev + cokebev + spribev + dietbev +
                chocbev + bottbev + milkbev;
            this.textBoxTotalCost.Text = "$" + Math.Round(totalCost, 2).ToString();
            this.textBoxAmountDue.Text = "$" + Math.Round(totalDue, 2).ToString();
            if (totalDue > 0) { this.buttonPlaceMain.Text = "Update Cart"; }
        }

    }
}
