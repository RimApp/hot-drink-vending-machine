
namespace HotDrinkVendingMachine
{
    partial class HotDrinkVendingMachineForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drinkLabel = new System.Windows.Forms.Label();
            this.drinkComboBox = new System.Windows.Forms.ComboBox();
            this.salePriceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // drinkLabel
            // 
            this.drinkLabel.AutoSize = true;
            this.drinkLabel.Location = new System.Drawing.Point(26, 23);
            this.drinkLabel.Name = "drinkLabel";
            this.drinkLabel.Size = new System.Drawing.Size(67, 20);
            this.drinkLabel.TabIndex = 0;
            this.drinkLabel.Text = "Boisson :";
            // 
            // drinkComboBox
            // 
            this.drinkComboBox.FormattingEnabled = true;
            this.drinkComboBox.Location = new System.Drawing.Point(132, 20);
            this.drinkComboBox.Name = "drinkComboBox";
            this.drinkComboBox.Size = new System.Drawing.Size(151, 28);
            this.drinkComboBox.TabIndex = 1;
            // 
            // salePriceLabel
            // 
            this.salePriceLabel.AutoSize = true;
            this.salePriceLabel.Location = new System.Drawing.Point(26, 57);
            this.salePriceLabel.Name = "salePriceLabel";
            this.salePriceLabel.Size = new System.Drawing.Size(101, 20);
            this.salePriceLabel.TabIndex = 2;
            this.salePriceLabel.Text = "Prix de vente :";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(132, 54);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(151, 27);
            this.priceTextBox.TabIndex = 3;
            // 
            // HotDrinkVendingMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.salePriceLabel);
            this.Controls.Add(this.drinkComboBox);
            this.Controls.Add(this.drinkLabel);
            this.Name = "HotDrinkVendingMachineForm";
            this.Text = "Distributeur automatique de boisson chaude";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label drinkLabel;
        private System.Windows.Forms.ComboBox drinkComboBox;
        private System.Windows.Forms.Label salePriceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
    }
}

