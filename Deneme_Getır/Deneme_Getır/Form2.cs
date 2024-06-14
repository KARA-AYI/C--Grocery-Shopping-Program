using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace Deneme_Getır
{
    public partial class Form2 : Form
    {
        // listBox1 tanımlaması
        private ListBox listBox1 = new ListBox();
        // Sebze adet ve fiyatları
        private int patatesQuantity = 0;
        private decimal patatesPrice = 10.0m;
        private int soganQuantity = 0;
        private decimal soganPrice = 12.0m;
        private int eksiotQuantity = 0;
        private decimal eksiotPrice = 5.0m;
        private int avokadoQuantity = 0;
        private decimal avokadoPrice = 50.0m;
        private int armutQuantity = 0;
        private decimal armutPrice = 25.0m;
        private int patlicanQuantity = 0;
        private decimal patlicanPrice = 15.0m;
        private int domatesQuantity = 0;
        private decimal domatesPrice = 18.0m;
        private int marulQuantity = 0;
        private decimal marulPrice = 10.0m;
        private int portakalQuantity = 0;
        private decimal portakalPrice = 25.0m;
        private int narQuantity = 0;
        private decimal narPrice = 30.0m;

        private Form1 mainForm;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            mainForm = form1;
            UpdateLabels();

        }



        private void UpdateLabels()
        {
            // Her sebze için label'ları güncelle
            label21.Text = patatesQuantity.ToString();
            label11.Text = "Fiyat: " + patatesPrice.ToString("C");
            label22.Text = soganQuantity.ToString();
            label12.Text = "Fiyat: " + soganPrice.ToString("C");
            label23.Text = eksiotQuantity.ToString();
            label13.Text = "Fiyat: " + eksiotPrice.ToString("C");
            label24.Text = avokadoQuantity.ToString();
            label14.Text = "Fiyat: " + avokadoPrice.ToString("C");
            label25.Text = armutQuantity.ToString();
            label15.Text = "Fiyat: " + armutPrice.ToString("C");
            label26.Text = patlicanQuantity.ToString();
            label16.Text = "Fiyat: " + patlicanPrice.ToString("C");
            label27.Text = domatesQuantity.ToString();
            label17.Text = "Fiyat: " + domatesPrice.ToString("C");
            label28.Text = marulQuantity.ToString();
            label18.Text = "Fiyat: " + marulPrice.ToString("C");
            label29.Text = portakalQuantity.ToString();
            label19.Text = "Fiyat: " + portakalPrice.ToString("C");
            label30.Text = narQuantity.ToString();
            label20.Text = "Fiyat: " + narPrice.ToString("C");
        }


        private decimal CalculateTotalPriceFromListBox()
        {
            // List box'taki ürünlerin fiyatını topla
            decimal totalPrice = 0;
            foreach (var item in listBox1.Items)
            {
                // Ürün fiyatlarını topla (item'de ürün ve fiyatı veya miktarı gibi bilgiler olmalı)
                // Örneğin: totalPrice += item.Price * item.Quantity;
            }
            return totalPrice;
        }




        private void button1_Click(object sender, EventArgs e)
        {
            patatesQuantity++;
            UpdateLabels();
            UpdateListBox("Patates", patatesQuantity, patatesPrice);
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (patatesQuantity > 0)
            {
                patatesQuantity--;
                if (patatesQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Patates");
                }
                else
                {
                    UpdateListBox("Patates", patatesQuantity, patatesPrice);
                }
                UpdateLabels();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            soganQuantity++;
            UpdateLabels();
            UpdateListBox("Soğan", soganQuantity, soganPrice);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (soganQuantity > 0)
            {
                soganQuantity--;
                if (soganQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Soğan");
                }
                else
                {
                    UpdateListBox("Soğan", soganQuantity, soganPrice);
                }
                UpdateLabels();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            eksiotQuantity++;
            UpdateLabels();
            UpdateListBox("Ekşi Ot", eksiotQuantity, eksiotPrice);

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (eksiotQuantity > 0)
            {
                eksiotQuantity--;
                if (eksiotQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Ekşi Ot");
                }
                else
                {
                    UpdateListBox("Ekşi Ot", eksiotQuantity, eksiotPrice);
                }
                UpdateLabels();
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {

            avokadoQuantity++;
            UpdateLabels();
            UpdateListBox("Avokado", avokadoQuantity, avokadoPrice);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            if (avokadoQuantity > 0)
            {
                avokadoQuantity--;
                if (avokadoQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Avokado");
                }
                else
                {
                    UpdateListBox("Avokado", avokadoQuantity, avokadoPrice);
                }
                UpdateLabels();
            }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            armutQuantity++;
            UpdateLabels();
            UpdateListBox("Armut", armutQuantity, armutPrice);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (armutQuantity > 0)
            {
                armutQuantity--;
                if (armutQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Armut");
                }
                else
                {
                    UpdateListBox("Armut", armutQuantity, armutPrice);
                }
                UpdateLabels();
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            patlicanQuantity++;
            UpdateLabels();
            UpdateListBox("Patlican", patlicanQuantity, patlicanPrice);
        }

        private void button12_Click_1(object sender, EventArgs e)
        {

            if (patlicanQuantity > 0)
            {
                patlicanQuantity--;
                if (patlicanQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Patlıcan");
                }
                else
                {
                    UpdateListBox("Patlıcan", patlicanQuantity, patlicanPrice);
                }
                UpdateLabels();
            }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            domatesQuantity++;
            UpdateLabels();
            UpdateListBox("Domates", domatesQuantity, domatesPrice);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            if (domatesQuantity > 0)
            {
                domatesQuantity--;
                if (domatesQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Domates");
                }
                else
                {
                    UpdateListBox("Domates", domatesQuantity, domatesPrice);
                }
                UpdateLabels();
            }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            marulQuantity++;
            UpdateLabels();
            UpdateListBox("Marul", marulQuantity, marulPrice);
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (marulQuantity > 0)
            {
                marulQuantity--;
                if (marulQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Marul");
                }
                else
                {
                    UpdateListBox("Marul", marulQuantity, marulPrice);
                }
                UpdateLabels();
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            portakalQuantity++;
            UpdateLabels();
            UpdateListBox("Portakal", portakalQuantity, portakalPrice);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            if (portakalQuantity > 0)
            {
                portakalQuantity--;
                if (portakalQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Portakal");
                }
                else
                {
                    UpdateListBox("Portakal", portakalQuantity, portakalPrice);
                }
                UpdateLabels();
            }
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            narQuantity++;
            UpdateLabels();
            UpdateListBox("Nar", narQuantity, narPrice);
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            if (narQuantity > 0)
            {
                narQuantity--;
                if (narQuantity == 0)
                {
                    mainForm.RemoveFromListBox("Nar");
                }
                else
                {
                    UpdateListBox("Nar", narQuantity, narPrice);
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

