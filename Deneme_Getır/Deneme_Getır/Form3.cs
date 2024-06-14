using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Deneme_Getır
{
    public partial class Form3 : Form
    {

            // Sebze adet ve fiyatları
            private int kalemmakarnaQuantity = 0;
            private decimal kalemmakarnaPrice = 15.0m;
            private int pilavlikbulgurQuantity = 0;
            private decimal pilavlikbulgurPrice = 33.0m;
            private int mercimekQuantity = 0;
            private decimal mercimekPrice = 45.0m;
            private int mantimakarnaQuantity = 0;
            private decimal mantimakarnaPrice = 15.0m;
            private int hediklikbulgurQuantity = 0;
            private decimal hediklikbulgurPrice = 33.0m;
            private int barbunyaQuantity = 0;
            private decimal barbunyaPrice = 50.0m;
            private int baldopirincQuantity = 0;
            private decimal baldopirincPrice = 65.0m;
            private int pilavlikpirincQuantity = 0;
            private decimal pilavlikpirincPrice = 72.0m;
            private int burgumakarnaQuantity = 0;
            private decimal burgumakarnaPrice = 15.0m;
           
      
        private Form1 mainForm;

        public Form3(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            // Her baklıyat için label'ları güncelle
            label19.Text = kalemmakarnaQuantity.ToString();
            label10.Text = "Fiyat: " + kalemmakarnaPrice.ToString("C");
            label20.Text = pilavlikbulgurQuantity.ToString();
            label11.Text = "Fiyat: " + pilavlikbulgurPrice.ToString("C");
            label21.Text = mercimekQuantity.ToString();
            label12.Text = "Fiyat: " + mercimekPrice.ToString("C");
            label22.Text = mantimakarnaQuantity.ToString();
            label13.Text = "Fiyat: " + mantimakarnaPrice.ToString("C");
            label23.Text = hediklikbulgurQuantity.ToString();
            label14.Text = "Fiyat: " + hediklikbulgurPrice.ToString("C");
            label24.Text = barbunyaQuantity.ToString();
            label15.Text = "Fiyat: " + barbunyaPrice.ToString("C");
            label25.Text = baldopirincQuantity.ToString();
            label16.Text = "Fiyat: " + baldopirincPrice.ToString("C");
            label26.Text = pilavlikpirincQuantity.ToString();
            label17.Text = "Fiyat: " + pilavlikpirincPrice.ToString("C");
            label27.Text = burgumakarnaQuantity.ToString();
            label18.Text = "Fiyat: " + burgumakarnaPrice.ToString("C");
           
        }


        private void button1_Click(object sender, System.EventArgs e)
        {
            kalemmakarnaQuantity++;
            UpdateLabels();
            UpdateListBox("Kalemmakarna", kalemmakarnaQuantity, kalemmakarnaPrice);
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (kalemmakarnaQuantity > 0)
            {
                kalemmakarnaQuantity--;
                if (kalemmakarnaQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Kalemmakarna");
                }
                else
                {
                    UpdateListBox("Kalemmakarna", kalemmakarnaQuantity, kalemmakarnaPrice);
                }
                UpdateLabels();
            }
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            pilavlikbulgurQuantity++;
            UpdateLabels();
            UpdateListBox("Pilavlikbulgur", pilavlikbulgurQuantity, pilavlikbulgurPrice);
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (pilavlikbulgurQuantity > 0)
            {
                pilavlikbulgurQuantity--;
                if (pilavlikbulgurQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Pilavlikbulgur");
                }
                else
                {
                    UpdateListBox("Pilavlikbulgur", pilavlikbulgurQuantity, pilavlikbulgurPrice);
                }
                UpdateLabels();
            }
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            mercimekQuantity++;
            UpdateLabels();
            UpdateListBox("Mercimek", mercimekQuantity, mercimekPrice);
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            if (mercimekQuantity > 0)
            {
                mercimekQuantity--;
                if (mercimekQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Mercimek");
                }
                else
                {
                    UpdateListBox("Mercimek", mercimekQuantity, mercimekPrice);
                }
                UpdateLabels();
            }
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            mantimakarnaQuantity++;
            UpdateLabels();
            UpdateListBox("Mantimakarna", mantimakarnaQuantity, mantimakarnaPrice);
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            if (mantimakarnaQuantity > 0)
            {
                mantimakarnaQuantity--;
                if (mantimakarnaQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Mantimakarna");
                }
                else
                {
                    UpdateListBox("Mantimakarnas", mantimakarnaQuantity, mantimakarnaPrice);
                }
                UpdateLabels();
            }
        }

        private void button10_Click(object sender, System.EventArgs e)
        {
            hediklikbulgurQuantity++;
            UpdateLabels();
            UpdateListBox("Hediklikbulgur", hediklikbulgurQuantity, hediklikbulgurPrice);
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            if (hediklikbulgurQuantity > 0)
            {
                hediklikbulgurQuantity--;
                if (hediklikbulgurQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Hediklikbulgur");
                }
                else
                {
                    UpdateListBox("Hediklikbulgur", hediklikbulgurQuantity, hediklikbulgurPrice);
                }
                UpdateLabels();
            }
        }

        private void button12_Click(object sender, System.EventArgs e)
        {
            barbunyaQuantity++;
            UpdateLabels();
            UpdateListBox("Barbunya", barbunyaQuantity, barbunyaPrice);
        }

        private void button11_Click(object sender, System.EventArgs e)
        {
            if (barbunyaQuantity > 0)
            {
                barbunyaQuantity--;
                if (barbunyaQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Barbunya");
                }
                else
                {
                    UpdateListBox("Barbunya", barbunyaQuantity, barbunyaPrice);
                }
                UpdateLabels();
            }

        }

        private void button14_Click(object sender, System.EventArgs e)
        {
            baldopirincQuantity++;
            UpdateLabels();
            UpdateListBox("Baldopirinc", baldopirincQuantity, baldopirincPrice);
        }

        private void button13_Click(object sender, System.EventArgs e)
        {
            if (baldopirincQuantity > 0)
            {
                baldopirincQuantity--;
                if (baldopirincQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Baldopirinc");
                }
                else
                {
                    UpdateListBox("Baldopirinc", baldopirincQuantity, baldopirincPrice);
                }
                UpdateLabels();
            }
        }

        private void button16_Click(object sender, System.EventArgs e)
        {
            pilavlikpirincQuantity++;
            UpdateLabels();
            UpdateListBox("Pilavlikpirinc", pilavlikpirincQuantity, pilavlikpirincPrice);
        }

        private void button15_Click(object sender, System.EventArgs e)
        {
            if (pilavlikpirincQuantity > 0)
            {
                pilavlikpirincQuantity--;
                if (pilavlikpirincQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Pilavlikpirinc");
                }
                else
                {
                    UpdateListBox("Pilavlikpirinc", pilavlikpirincQuantity, pilavlikpirincPrice);
                }
                UpdateLabels();
            }
        }

        private void button18_Click(object sender, System.EventArgs e)
        {
            burgumakarnaQuantity++;
            UpdateLabels();
            UpdateListBox("Burgumakarna", burgumakarnaQuantity, burgumakarnaPrice);
        }

        private void button17_Click(object sender, System.EventArgs e)
        {
            if (burgumakarnaQuantity > 0)
            {
                burgumakarnaQuantity--;
                if (burgumakarnaQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Burgumakarna");
                }
                else
                {
                    UpdateListBox("Burgumakarna", burgumakarnaQuantity, burgumakarnaPrice);
                }
                UpdateLabels();
            }
        }


        private void UpdateListBox(string category, int quantity, decimal price)
        {
            decimal totalPrice = quantity * price;
            string item = $"{category} - Adet: {quantity}, Toplam Fiyat: {totalPrice.ToString("C")}";
            mainForm.AddToListBox(category, item); // Ana forma ekle

        }
        private void RemoveFromListBox(string category)
        {
            mainForm.RemoveFromListBox(category); // Ana formdan sil

        }
    }
}
