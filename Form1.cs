using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VRT_Interface
{
    public partial class Form1 : Form
    {
        private readonly List<Product> products;
        public Form1(List<Product> prods)
        {
            InitializeComponent();
            products = prods;
        }

        private void btnShowProd_Click(object sender, EventArgs e)
        {
        }
    }
}
