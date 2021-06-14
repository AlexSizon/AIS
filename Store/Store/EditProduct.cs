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
    public partial class EditProduct : Form
    {
        public Product product;
        public bool IsAccepted=false;
        public EditProduct(Product _product)
        {
            InitializeComponent();
            using (UserStoreContext db = new UserStoreContext())
            {
                cbCategory.Items.AddRange(db.Categories.ToArray());
            }
            product = new Product();
            product = _product;
            cbCategory.SelectedIndex = _product.CategoryId;
            tbNameProduct.Text = _product.Name;
            tbQuantity.Text = _product.Quantity.ToString();
            tbPrice.Text = _product.Price.ToString();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            product.CategoryId = cbCategory.SelectedIndex;
            product.Name = tbNameProduct.Text;
            product.Quantity = Convert.ToInt32(tbQuantity.Text);
            product.Price = Convert.ToDouble(tbPrice.Text);
            IsAccepted = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}