namespace Store
{
    partial class Basket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.dtpDateSale = new System.Windows.Forms.DateTimePicker();
            this.tbNameProduct = new System.Windows.Forms.TextBox();
            this.tbIdProduct = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(101, 158);
            this.numQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(175, 20);
            this.numQuantity.TabIndex = 27;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(101, 210);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(175, 20);
            this.tbPrice.TabIndex = 26;
            // 
            // dtpDateSale
            // 
            this.dtpDateSale.Location = new System.Drawing.Point(101, 106);
            this.dtpDateSale.Name = "dtpDateSale";
            this.dtpDateSale.Size = new System.Drawing.Size(175, 20);
            this.dtpDateSale.TabIndex = 25;
            // 
            // tbNameProduct
            // 
            this.tbNameProduct.Location = new System.Drawing.Point(101, 58);
            this.tbNameProduct.Name = "tbNameProduct";
            this.tbNameProduct.Size = new System.Drawing.Size(175, 20);
            this.tbNameProduct.TabIndex = 24;
            // 
            // tbIdProduct
            // 
            this.tbIdProduct.Location = new System.Drawing.Point(101, 8);
            this.tbIdProduct.Name = "tbIdProduct";
            this.tbIdProduct.Size = new System.Drawing.Size(175, 20);
            this.tbIdProduct.TabIndex = 23;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(98, 268);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Total:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sale Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Product name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product id";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(161, 298);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 20);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(27, 298);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(101, 20);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Check out";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // Basket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 335);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.dtpDateSale);
            this.Controls.Add(this.tbNameProduct);
            this.Controls.Add(this.tbIdProduct);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCheck);
            this.Name = "Basket";
            this.Text = "Basket";
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.DateTimePicker dtpDateSale;
        private System.Windows.Forms.TextBox tbNameProduct;
        private System.Windows.Forms.TextBox tbIdProduct;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheck;
    }
}