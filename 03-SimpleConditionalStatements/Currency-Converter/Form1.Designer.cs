namespace Currency_Converter
{
    partial class FormConverter
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
            this.labelResult1 = new System.Windows.Forms.Label();
            this.comboBoxCurrency1 = new System.Windows.Forms.ComboBox();
            this.numericUpDownAmount1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResult1
            // 
            this.labelResult1.BackColor = System.Drawing.Color.PaleGreen;
            this.labelResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult1.Location = new System.Drawing.Point(12, 58);
            this.labelResult1.Name = "labelResult1";
            this.labelResult1.Size = new System.Drawing.Size(283, 37);
            this.labelResult1.TabIndex = 0;
            this.labelResult1.Text = "label2";
            this.labelResult1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxCurrency1
            // 
            this.comboBoxCurrency1.FormattingEnabled = true;
            this.comboBoxCurrency1.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP"});
            this.comboBoxCurrency1.Location = new System.Drawing.Point(223, 11);
            this.comboBoxCurrency1.Name = "comboBoxCurrency1";
            this.comboBoxCurrency1.Size = new System.Drawing.Size(72, 28);
            this.comboBoxCurrency1.TabIndex = 1;
            // 
            // numericUpDownAmount1
            // 
            this.numericUpDownAmount1.DecimalPlaces = 2;
            this.numericUpDownAmount1.Location = new System.Drawing.Point(16, 12);
            this.numericUpDownAmount1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownAmount1.Name = "numericUpDownAmount1";
            this.numericUpDownAmount1.Size = new System.Drawing.Size(151, 26);
            this.numericUpDownAmount1.TabIndex = 2;
            this.numericUpDownAmount1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "BGN";
            // 
            // FormConverter
            // 
            this.ClientSize = new System.Drawing.Size(311, 110);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownAmount1);
            this.Controls.Add(this.comboBoxCurrency1);
            this.Controls.Add(this.labelResult1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConverter";
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCurrency;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelResult1;
        private System.Windows.Forms.ComboBox comboBoxCurrency1;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount1;
        private System.Windows.Forms.Label label2;
    }
}

