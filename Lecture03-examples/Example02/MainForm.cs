using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppleStoreLibrary01;
namespace Example02
{
    public partial class MainForm : Form
    {
        public Class1[] products;
        public List<Class1> ShoppingCart;
        int Total;
        public MainForm()
            
        {
            InitializeComponent();
            products = new Class1[]
            {
                new Class1()
                {
                id=1,
                Name="iphone",
                Price=28900,
                categories=new string[] {"iphone"}
                },
                new Class1()
                {
                id = 2,
                Name = "iphone+",
                Price = 31900,
                categories = new string[] {"iphone"}
                 }

        };
            ShoppingCart = new List<Class1>();
            TotalLabel.Text = string.Format("總金額: {0}元", Total);
            Total = 0;
            Product1Lebel.Text = string.Format("產品:{0}, 價格:{1}元", products[0].Name, products[0].Price);
            Product2Lebel.Text = string.Format("產品:{0}, 價格:{1}元", products[1].Name, products[1].Price);
        }

        private void AddProduct1Button_Click(object sender, EventArgs e)
        {
            ShoppingCartRichTextBox.Text =
                ShoppingCartRichTextBox.Text + products[0].Name + "\n";
            Total += products[0].Price;
            TotalLabel.Text = string.Format("總金額: {0}元", Total);
        }

        private void AddProduct2Button_Click(object sender, EventArgs e)
        {
            ShoppingCartRichTextBox.Text =
                ShoppingCartRichTextBox.Text + products[1].Name + "\n";
            Total += products[1].Price;
            TotalLabel.Text = string.Format("總金額: {0}元", Total);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Total = 0;
            ShoppingCartRichTextBox.Text = "";
            TotalLabel.Text = "總金額: 0元";
        }
    }
}
