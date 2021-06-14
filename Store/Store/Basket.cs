using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class Basket : Form
    {
        public Product product;
        public Basket(Product _product)
        {
            InitializeComponent();
            product = new Product();
            product = _product;
            tbIdProduct.Text = _product.Id.ToString();
            tbNameProduct.Text = _product.Name;
            numQuantity.Value = _product.Quantity;
            tbPrice.Text = _product.Price.ToString();
            lbTotal.Text = (_product.Price * _product.Quantity).ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (UserStoreContext db = new UserStoreContext())
            {
                db.Sales.Add(new Sale() { ProductId = Convert.ToInt32(tbIdProduct.Text), Quantity = Convert.ToInt32(numQuantity.Value), SaleTimeP = dtpDateSale.Value });
                db.SaveChanges();
            }
        }
    }
}
