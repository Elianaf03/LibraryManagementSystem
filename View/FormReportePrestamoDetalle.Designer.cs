
namespace View
{
    partial class FormReportePrestamoDetalle
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.spReporteTicketPrestamo2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsResportePrestamoDetalle = new View.dsResportePrestamoDetalle();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReporteTicketPrestamo2TableAdapter = new View.dsResportePrestamoDetalleTableAdapters.spReporteTicketPrestamo2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteTicketPrestamo2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResportePrestamoDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // spReporteTicketPrestamo2BindingSource
            // 
            this.spReporteTicketPrestamo2BindingSource.DataMember = "spReporteTicketPrestamo2";
            this.spReporteTicketPrestamo2BindingSource.DataSource = this.dsResportePrestamoDetalle;
            // 
            // dsResportePrestamoDetalle
            // 
            this.dsResportePrestamoDetalle.DataSetName = "dsResportePrestamoDetalle";
            this.dsResportePrestamoDetalle.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReporteTicketPrestamo2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "View.Reportes.rptResportePrestamoDetalle.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(747, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReporteTicketPrestamo2TableAdapter
            // 
            this.spReporteTicketPrestamo2TableAdapter.ClearBeforeFill = true;
            // 
            // FormReportePrestamoDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportePrestamoDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportePrestamoDetalle";
            this.Load += new System.EventHandler(this.FormReportePrestamoDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReporteTicketPrestamo2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsResportePrestamoDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReporteTicketPrestamo2BindingSource;
        private dsResportePrestamoDetalle dsResportePrestamoDetalle;
        private dsResportePrestamoDetalleTableAdapters.spReporteTicketPrestamo2TableAdapter spReporteTicketPrestamo2TableAdapter;
    }
}