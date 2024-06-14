using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deneme_Getır
{
    public partial class Form1 : Form
    {

      


        private Form currentForm = null; // Mevcut formu takip etmek için bir değişken

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Form içinde form açılabilir yapıyoruz
            this.DoubleBuffered = true;
            CategoryQuantities = new Dictionary<string, string>();
        }

        // Sebzelerin miktarını tutacak sözlük
        private Dictionary<string, string> categoryQuantities = new Dictionary<string, string>();
        public Dictionary<string, string> CategoryQuantities
        {
            get { return categoryQuantities; }
            set { categoryQuantities = value; }
        }

        public void AddToListBox(string category, string item)
        {
            // categoryQuantities sözlüğüne ekle
            if (!categoryQuantities.ContainsKey(category))
            {
                categoryQuantities.Add(category, item);
            }
            else
            {
                categoryQuantities[category] = item;
            }

            // ListBox'ta aynı sebzeden önceki girişi kontrol et
            bool found = false;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string listItem = listBox1.Items[i].ToString();
                if (listItem.StartsWith($"{category} - Adet:"))
                {
                    // Varolan öğeyi güncelle
                    listBox1.Items[i] = item;
                    found = true;
                    break;
                }
            }

            // Eğer listede yoksa yeni öğe olarak ekle
            if (!found)
            {
                listBox1.Items.Add(item);
            }


        }

        public void RemoveFromListBox(string category)
        {
            // ListBox ve categoryQuantities'den ilgili öğeyi kaldır
            List<string> itemsToRemove = new List<string>();
            foreach (var item in listBox1.Items)
            {
                string itemString = item.ToString();
                if (itemString.StartsWith($"{category} - Adet:"))
                {
                    itemsToRemove.Add(itemString);
                }
            }

            foreach (var itemToRemove in itemsToRemove)
            {
                listBox1.Items.Remove(itemToRemove);
            }

            categoryQuantities.Remove(category); // categoryQuantities'ten kaldır

            UpdateTotalPrice(CalculateTotalPrice()); // Toplam fiyatı güncellemek için CalculateTotalPrice metodunu çağırıyoruz
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (var kvp in categoryQuantities)
            {
                listBox1.Items.Add(kvp.Value);
            }
        }

        public void UpdateTotalPrice(decimal totalPrice)
        {
            label3.Text = $"Toplam Fiyat: {totalPrice:C}";
        }

        private void UpdateTotalPriceLabel()
        {
            decimal totalPrice = CalculateTotalPrice();
            label3.Text = $"Toplam Fiyat: {totalPrice:C}";
        }

        public decimal CalculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (var kvp in categoryQuantities)
            {
                string itemString = kvp.Value;

                // "Toplam Fiyat: " etiketini arayın
                int startIndex = itemString.IndexOf("Toplam Fiyat: ");
                if (startIndex >= 0)
                {
                    startIndex += "Toplam Fiyat: ".Length;

                    // " ₺" işaretini arayın
                    int endIndex = itemString.LastIndexOf(" ₺");
                    if (endIndex >= 0 && endIndex > startIndex)
                    {
                        // Fiyatın string temsilini alın
                        string priceString = itemString.Substring(startIndex, endIndex - startIndex).Trim();

                        // Fiyatı decimal formata dönüştürmeye çalışın
                        if (decimal.TryParse(priceString, out decimal price))
                        {
                            totalPrice += price;
                        }
                    }
                }
            }

            return totalPrice;
        }







        private void button1_Click(object sender, EventArgs e)
        {
            // Form2'yi oluşturun ve özelliklerini ayarlayın
            Form2 form2 = new Form2(this);
            form2.TopLevel = false; // Ana form olarak değil, bir alt form olarak belirtiyoruz
            form2.FormBorderStyle = FormBorderStyle.None; // Kenarlık olmadan göster

            // Form2'yi panel içinde göstermek için
            panel1.Controls.Clear(); // Panelde önceki içeriği temizle
            panel1.Controls.Add(form2); // Form2'yi panele ekle

            form2.Dock = DockStyle.Fill; // Panel içinde tam boyutlandır

            // Form2'yi göster
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Form2'yi oluşturun ve özelliklerini ayarlayın
            Form3 form3 = new Form3(this);
            form3.TopLevel = false; // Ana form olarak değil, bir alt form olarak belirtiyoruz
            form3.FormBorderStyle = FormBorderStyle.None; // Kenarlık olmadan göster

            // Form2'yi panel içinde göstermek için
            panel1.Controls.Clear(); // Panelde önceki içeriği temizle
            panel1.Controls.Add(form3); // Form2'yi panele ekle

            form3.Dock = DockStyle.Fill; // Panel içinde tam boyutlandır

            // Form2'yi göster
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanel(new Form4());
            Form4 form4 = new Form4(); // Açılacak form  
            form4.MdiParent = this; // Bu formu parent olarak veriyoruz.

            // Form4'ün Parent'ını bu formun içindeki bir container kontrol olarak belirleyin
            form4.TopLevel = false;
            panel1.Controls.Add(form4); // panelContainer, Form1 üzerinde oluşturduğunuz bir Panel

            // Form4'ü gösterin
            form4.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanel(new Form5());
            Form5 form5 = new Form5(); // Açılacak form  
            form5.MdiParent = this; // Bu formu parent olarak veriyoruz.

            // Form5'in Parent'ını bu formun içindeki bir container kontrol olarak belirleyin
            form5.TopLevel = false;
            panel1.Controls.Add(form5); // panelContainer, Form1 üzerinde oluşturduğunuz bir Panel

            // Form5'i gösterin
            form5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanel(new Form6());
            Form6 form6 = new Form6(); // Açılacak form  
            form6.MdiParent = this; // Bu formu parent olarak veriyoruz.

            // Form6'nın Parent'ını bu formun içindeki bir container kontrol olarak belirleyin
            form6.TopLevel = false;
            panel1.Controls.Add(form6); // panelContainer, Form1 üzerinde oluşturduğunuz bir Panel

            // Form6'yı gösterin
            form6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanel(new Form7());
            Form7 form7 = new Form7(); // Açılacak form  
            form7.MdiParent = this; // Bu formu parent olarak veriyoruz.

            // Form7'nin Parent'ını bu formun içindeki bir container kontrol olarak belirleyin
            form7.TopLevel = false;
            panel1.Controls.Add(form7); // panelContainer, Form1 üzerinde oluşturduğunuz bir Panel

            // Form7'yi gösterin
            form7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanel(new Form8());
            Form8 form8 = new Form8(); // Açılacak form  
            form8.MdiParent = this; // Bu formu parent olarak veriyoruz.

            // Form8'in Parent'ını bu formun içindeki bir container kontrol olarak belirleyin
            form8.TopLevel = false;
            panel1.Controls.Add(form8); // panelContainer, Form1 üzerinde oluşturduğunuz bir Panel

            // Form8'i gösterin
            form8.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanel(new Form9());
            Form9 form9 = new Form9(); // Açılacak form  
            form9.MdiParent = this; // Bu formu parent olarak veriyoruz.

            // Form9'un Parent'ını bu formun içindeki bir container kontrol olarak belirleyin
            form9.TopLevel = false;
            panel1.Controls.Add(form9); // panelContainer, Form1 üzerinde oluşturduğunuz bir Panel

            // Form9'u gösterin
            form9.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanel(new Form10());
            Form10 form10 = new Form10(); // Açılacak form  
            form10.MdiParent = this; // Bu formu parent olarak veriyoruz.

            // Form10'un Parent'ını bu formun içindeki bir container kontrol olarak belirleyin
            form10.TopLevel = false;
            panel1.Controls.Add(form10); // panelContainer, Form1 üzerinde oluşturduğunuz bir Panel

            // Form10'u gösterin
            form10.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenNewFormInPanel(new Form11());
            Form11 form11 = new Form11(); // Açılacak form  
            form11.MdiParent = this; // Bu formu parent olarak veriyoruz.

            // Form11'in Parent'ını bu formun içindeki bir container kontrol olarak belirleyin
            form11.TopLevel = false;
            panel1.Controls.Add(form11); // panelContainer, Form1 üzerinde oluşturduğunuz bir Panel

            form11.Show();
        }

        private void OpenNewFormInPanel(Form newForm)
        {
            if (currentForm != null)
            {
                currentForm.Close(); // Mevcut formu kapat
            }

            currentForm = newForm; // Yeni açılacak formu currentForm olarak ayarla
            currentForm.TopLevel = false; // Formun panel içinde açılmasını sağla
            currentForm.FormBorderStyle = FormBorderStyle.None; // Formun kenarlıklarını kaldır
            currentForm.Dock = DockStyle.Fill; // Formun paneli doldurmasını sağla
            panel1.Controls.Add(currentForm); // Formu panele ekle
            panel1.Tag = currentForm; // Panelin Tag özelliğine formu ata
            currentForm.BringToFront(); // Formu öne getir
            currentForm.Show(); // Formu göster
        }

        private void button11_Click(object sender, EventArgs e)
        {  // Form13'ü oluşturun ve özelliklerini ayarlayın
            Form13 form13 = new Form13(this);

            // categoryQuantities sözlüğünden sadece değerleri alarak bir liste oluştur
            List<string> valuesList = categoryQuantities.Values.ToList();

            

            // Form 13'ü modal olarak gösterin (kullanıcı diğer işlemleri yapana kadar bu form üzerinde işlem yapabilir)
            form13.ShowDialog();

            // Form 13 kapatıldığında buraya dönecek, gerekiyorsa diğer işlemler yapılabilir }
        }
    }
}
