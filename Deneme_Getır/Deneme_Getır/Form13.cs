// Form13.cs
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Deneme_Getır
{
    public partial class Form13 : Form
    {
        private List<string> itemList = new List<string>(); // Listbox için liste

        private Form1 form1Instance;

        public Form13(Form1 form1)
        {
            InitializeComponent();
            form1Instance = form1;
        }

        
       
    }
}
