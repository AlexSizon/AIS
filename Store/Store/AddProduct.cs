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
    public partial class AddProduct : Form
    {
        public Product Product;
        public bool IsAccepted=false;
        public AddProduct()
        {
            InitializeComponent();
            Product = new Product();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product.CategoryId = cbCategory.SelectedIndex+1;
            Product.Name = tbNameProduct.Text;
            Product.Quantity = Convert.ToInt32(tbQuantity.Text);
            Product.Price = Convert.ToDouble(tbPrice.Text);
            IsAccepted= true;
            this.Close();
        }
        private void AddEditProduct_Load(object sender, EventArgs e)
        {
            using (UserStoreContext db = new UserStoreContext())
            {
                cbCategory.Items.AddRange(db.Categories.ToArray());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
