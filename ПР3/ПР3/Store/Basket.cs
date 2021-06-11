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
        int quantityAll = 0;
        public Basket(string idProduct, string nameProduct, string quantityAll, string price)
        {
            InitializeComponent();
            tbIdProduct.Text = idProduct;
            tbNameProduct.Text = nameProduct;
            dtpDateSale.Value = DateTime.Today;
            tbPrice.Text = price;
            this.quantityAll = Convert.ToInt32(quantityAll);
            numQuantity.Maximum = this.quantityAll;
            lbTotal.Text = " 0 UAH " ;
        }

        private void Basket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.storeDBDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "storeDBDataSet.Sales". При необходимости она может быть перемещена или удалена.
            this.salesTableAdapter.Fill(this.storeDBDataSet.Sales);

        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (numQuantity.Value == quantityAll)
            {
                MessageBox.Show(" Достигнуто максимальное количество товара!");
            }
            lbTotal.Text = Convert.ToString(numQuantity.Value * Convert.ToInt32(tbPrice.Text)) +
            " UAH " ;
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.storeDBDataSet);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var font = new Font(" Tahoma ", 12, FontStyle.Bold);
            string printText = " Чек\nПродукт: " +tbNameProduct.Text +
             "\nКоличество: " +numQuantity.Value.ToString() + ", по цене " +tbPrice.Text + " UAH " +
              "\nСумма к оплате: " +lbTotal.Text + "\nДата покупки: " + dtpDateSale.Value.ToShortDateString();
            e.Graphics.DrawString(printText, font, Brushes.Black, 0, 0);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog(this) == DialogResult.OK)
            {
                printDocument1.Print();
                try
                {
                    salesTableAdapter.Insert(Convert.ToInt32(tbIdProduct.Text),
                    Convert.ToDateTime(dtpDateSale.Value.ToShortDateString()),
                    Convert.ToInt32(numQuantity.Value));
                    productsTableAdapter.EditQuantity(Convert.ToInt32(quantityAll -
                    numQuantity.Value),
                    Convert.ToInt32(tbIdProduct.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
