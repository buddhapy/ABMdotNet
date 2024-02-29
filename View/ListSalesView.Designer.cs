namespace ABMdotNet.View
{
    partial class ListSalesView
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
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.NombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;
            this.dataGridViewSales.AllowUserToOrderColumns = true;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProd,
            this.CodigoProd,
            this.MontoPago,
            this.NombreCliente,
            this.ApellidoCliente,
            this.EmailCliente});
            this.dataGridViewSales.Location = new System.Drawing.Point(31, 70);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.RowHeadersWidth = 51;
            this.dataGridViewSales.RowTemplate.Height = 24;
            this.dataGridViewSales.Size = new System.Drawing.Size(1141, 150);
            this.dataGridViewSales.TabIndex = 0;
            // 
            // NombreProd
            // 
            this.NombreProd.HeaderText = "NombreProd";
            this.NombreProd.MinimumWidth = 6;
            this.NombreProd.Name = "NombreProd";
            this.NombreProd.ReadOnly = true;
            this.NombreProd.Width = 125;
            // 
            // CodigoProd
            // 
            this.CodigoProd.HeaderText = "CodigoProd";
            this.CodigoProd.MinimumWidth = 6;
            this.CodigoProd.Name = "CodigoProd";
            this.CodigoProd.ReadOnly = true;
            this.CodigoProd.Width = 125;
            // 
            // MontoPago
            // 
            this.MontoPago.HeaderText = "Monto A Pagar";
            this.MontoPago.MinimumWidth = 6;
            this.MontoPago.Name = "MontoPago";
            this.MontoPago.ReadOnly = true;
            this.MontoPago.Width = 125;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.MinimumWidth = 6;
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 125;
            // 
            // ApellidoCliente
            // 
            this.ApellidoCliente.HeaderText = "Apellido Cliente";
            this.ApellidoCliente.MinimumWidth = 6;
            this.ApellidoCliente.Name = "ApellidoCliente";
            this.ApellidoCliente.ReadOnly = true;
            this.ApellidoCliente.Width = 125;
            // 
            // EmailCliente
            // 
            this.EmailCliente.HeaderText = "EmailCliente";
            this.EmailCliente.MinimumWidth = 6;
            this.EmailCliente.Name = "EmailCliente";
            this.EmailCliente.ReadOnly = true;
            this.EmailCliente.Width = 125;
            // 
            // ListSalesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 450);
            this.Controls.Add(this.dataGridViewSales);
            this.Name = "ListSalesView";
            this.Text = "ListSalesView";
            this.Load += new System.EventHandler(this.ListSalesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailCliente;
    }
}