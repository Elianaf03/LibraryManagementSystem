
namespace View
{
    partial class FormReporteUsuarios
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
            this.sp_ReporteUsuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_ReporteUsuarios = new View.ds_ReporteUsuarios();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ReporteUsuariosTableAdapter = new View.ds_ReporteUsuariosTableAdapters.sp_ReporteUsuariosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ReporteUsuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ReporteUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ReporteUsuariosBindingSource
            // 
            this.sp_ReporteUsuariosBindingSource.DataMember = "sp_ReporteUsuarios";
            this.sp_ReporteUsuariosBindingSource.DataSource = this.ds_ReporteUsuarios;
            // 
            // ds_ReporteUsuarios
            // 
            this.ds_ReporteUsuarios.DataSetName = "ds_ReporteUsuarios";
            this.ds_ReporteUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.sp_ReporteUsuariosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "View.Reportes.RptReporteUsuarios.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // sp_ReporteUsuariosTableAdapter
            // 
            this.sp_ReporteUsuariosTableAdapter.ClearBeforeFill = true;
            // 
            // FormReporteUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporteUsuarios";
            this.Load += new System.EventHandler(this.FormReporteUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ReporteUsuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_ReporteUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource sp_ReporteUsuariosBindingSource;
        private ds_ReporteUsuarios ds_ReporteUsuarios;
        private ds_ReporteUsuariosTableAdapters.sp_ReporteUsuariosTableAdapter sp_ReporteUsuariosTableAdapter;
    }
}