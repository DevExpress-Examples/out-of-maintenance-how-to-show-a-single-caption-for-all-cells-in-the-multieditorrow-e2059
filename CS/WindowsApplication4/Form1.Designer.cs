// Developer Express Code Central Example:
// How to show a single caption for all cells in the MultiEditorRow
// 
// This example demonstrates how to visually merge headers in MultiEditorRow and
// draw a single caption for all data cells
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2059

namespace WindowsApplication4
{
    partial class Form1
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
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.category = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow4 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.row = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.multiEditorRow1 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRow();
            this.multiEditorRowProperties1 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.multiEditorRowProperties2 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.multiEditorRowProperties3 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.multiEditorRowProperties4 = new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties();
            this.categoryRow1 = new DevExpress.XtraVerticalGrid.Rows.CategoryRow();
            this.editorRow5 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow6 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow1 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow2 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.editorRow3 = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // vGridControl1
            // 
            this.vGridControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView;
            this.vGridControl1.Location = new System.Drawing.Point(0, 0);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.RecordWidth = 162;
            this.vGridControl1.RowHeaderWidth = 38;
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.category,
            this.categoryRow1});
            this.vGridControl1.Size = new System.Drawing.Size(616, 200);
            this.vGridControl1.TabIndex = 0;
            this.vGridControl1.CustomDrawSeparator += new DevExpress.XtraVerticalGrid.Events.CustomDrawSeparatorEventHandler(this.vGridControl1_CustomDrawSeparator);
            this.vGridControl1.CustomDrawRowHeaderCell += new DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventHandler(this.vGridControl1_CustomDrawRowHeaderCell);
            // 
            // category
            // 
            this.category.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow4,
            this.multiEditorRow1});
            this.category.Name = "category";
            // 
            // editorRow4
            // 
            this.editorRow4.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.row});
            this.editorRow4.Name = "editorRow4";
            this.editorRow4.Properties.Caption = "1";
            // 
            // row
            // 
            this.row.Name = "row";
            // 
            // multiEditorRow1
            // 
            this.multiEditorRow1.Name = "multiEditorRow1";
            this.multiEditorRow1.PropertiesCollection.AddRange(new DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties[] {
            this.multiEditorRowProperties1,
            this.multiEditorRowProperties2,
            this.multiEditorRowProperties3,
            this.multiEditorRowProperties4});
            this.multiEditorRow1.SeparatorKind = DevExpress.XtraVerticalGrid.Rows.SeparatorKind.String;
            // 
            // multiEditorRowProperties1
            // 
            this.multiEditorRowProperties1.Caption = "Multi Editor Row";
            this.multiEditorRowProperties1.Value = 33;
            this.multiEditorRowProperties1.Width = 33;
            // 
            // multiEditorRowProperties2
            // 
            this.multiEditorRowProperties2.Caption = "C2";
            this.multiEditorRowProperties2.Value = 12;
            this.multiEditorRowProperties2.Width = 16;
            // 
            // multiEditorRowProperties3
            // 
            this.multiEditorRowProperties3.Caption = "C3";
            this.multiEditorRowProperties3.Value = 44;
            this.multiEditorRowProperties3.Width = 15;
            // 
            // multiEditorRowProperties4
            // 
            this.multiEditorRowProperties4.Caption = "C4";
            this.multiEditorRowProperties4.Value = 55;
            this.multiEditorRowProperties4.Width = 15;
            // 
            // categoryRow1
            // 
            this.categoryRow1.ChildRows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.editorRow5,
            this.editorRow6});
            this.categoryRow1.Name = "categoryRow1";
            // 
            // editorRow5
            // 
            this.editorRow5.Name = "editorRow5";
            this.editorRow5.Properties.Caption = "Single Editor Row";
            // 
            // editorRow6
            // 
            this.editorRow6.Name = "editorRow6";
            this.editorRow6.Properties.Caption = "3";
            // 
            // editorRow1
            // 
            this.editorRow1.Name = "editorRow1";
            this.editorRow1.Properties.Caption = "1";
            // 
            // editorRow2
            // 
            this.editorRow2.Name = "editorRow2";
            this.editorRow2.Properties.Caption = "2";
            // 
            // editorRow3
            // 
            this.editorRow3.Name = "editorRow3";
            this.editorRow3.Properties.Caption = "3";
            // 
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(12, 206);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Use Custom Draw";
            this.checkEdit1.Size = new System.Drawing.Size(157, 19);
            this.checkEdit1.TabIndex = 1;
            this.checkEdit1.CheckedChanged += new System.EventHandler(this.checkEdit1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 250);
            this.Controls.Add(this.checkEdit1);
            this.Controls.Add(this.vGridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRow multiEditorRow1;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties1;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties2;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties3;
        private DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties multiEditorRowProperties4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow1;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow2;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow3;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow4;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow5;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow editorRow6;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow category;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow row;
        private DevExpress.XtraVerticalGrid.Rows.CategoryRow categoryRow1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
    }
}
