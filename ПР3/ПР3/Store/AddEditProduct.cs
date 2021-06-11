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
    public partial class AddEditProduct : Form
    {
        public AddEditProduct()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDBDataSet);

        }

        private void AddEditProduct_Load(object sender, EventArgs e)
        {
            this.categoriesTableAdapter.Fill(this.storeDBDataSet.Categories);
            cbCategory.Text = category;
            tbNameProduct.Text = nameProduct;
            tbQuantity.Text = quantity;
            tbPrice.Text = price;
            if (operation == "Add")
                { 
               btnAddProduct.Text = "Добавить" ;
                }
            else if (operation == "Edit ")
{
                this.Text = "Изменение товара" ;
                btnAddProduct.Text = "Изменить" ;
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            int idCategory;
            if (!Int32.TryParse(cbCategory.Text, out idCategory))
            {
                idCategory = Convert.ToInt32(cbCategory.SelectedValue);
            }
            else
            {
                MessageBox.Show(" Недопустимая категория продукта! ");
                return;

            }
            string nameProduct;
            if (tbNameProduct.Text != "" && tbNameProduct.Text != null)
{
                nameProduct = tbNameProduct.Text;
            } else
            {
                MessageBox.Show(" Заполните название продукта! ");
                return;
            }
            int quantity;
            if (Int32.TryParse(tbQuantity.Text, out quantity))
            {
                quantity = Convert.ToInt32(tbQuantity.Text);
            }
            else
            {
                MessageBox.Show(" Некоректное количество продукта! ");
                return;
            }
            int price;
            if (Int32.TryParse(tbPrice.Text, out price))
            {
                price = Convert.ToInt32(tbPrice.Text);
            }
            else
            {
                MessageBox.Show(" Некоректная цена продукта! ");
                return;
            }
            try
            {
                if (operation == " Add ")
                {
                    productsTableAdapter.Insert(0,idCategory, nameProduct, quantity, price);
                }
                else if (operation == "Edit")
                {
                    productsTableAdapter.Edit(idCategory, nameProduct, quantity, price,
                    Convert.ToInt32(idProduct));
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        string idProduct, nameProduct, category, quantity, price, operation;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public AddEditProduct(string operation)
        {
            InitializeComponent();
            this.operation = operation;
        }

        public AddEditProduct(string idProduct, string nameProduct, string category, string
        quantity, string price, string operation)
        {
            InitializeComponent();
            this.nameProduct = nameProduct;
            this.category = category;
            this.quantity = quantity;
            this.price = price;
            this.operation = operation;
        }




    }
}
