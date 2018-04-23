' Developer Express Code Central Example:
' How to show a single caption for all cells in the MultiEditorRow
' 
' This example demonstrates how to visually merge headers in MultiEditorRow and
' draw a single caption for all data cells
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2059


Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication4
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.vGridControl1 = New DevExpress.XtraVerticalGrid.VGridControl()
			Me.category = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow4 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.row = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.multiEditorRow1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRow()
			Me.multiEditorRowProperties1 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Me.multiEditorRowProperties2 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Me.multiEditorRowProperties3 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Me.multiEditorRowProperties4 = New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties()
			Me.categoryRow1 = New DevExpress.XtraVerticalGrid.Rows.CategoryRow()
			Me.editorRow5 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow6 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow1 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow2 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.editorRow3 = New DevExpress.XtraVerticalGrid.Rows.EditorRow()
			Me.checkEdit1 = New DevExpress.XtraEditors.CheckEdit()
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' vGridControl1
			' 
			Me.vGridControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.vGridControl1.LayoutStyle = DevExpress.XtraVerticalGrid.LayoutViewStyle.SingleRecordView
			Me.vGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.vGridControl1.Name = "vGridControl1"
			Me.vGridControl1.RecordWidth = 162
			Me.vGridControl1.RowHeaderWidth = 38
			Me.vGridControl1.Rows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.category, Me.categoryRow1})
			Me.vGridControl1.Size = New System.Drawing.Size(616, 200)
			Me.vGridControl1.TabIndex = 0
'			Me.vGridControl1.CustomDrawSeparator += New DevExpress.XtraVerticalGrid.Events.CustomDrawSeparatorEventHandler(Me.vGridControl1_CustomDrawSeparator);
'			Me.vGridControl1.CustomDrawRowHeaderCell += New DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventHandler(Me.vGridControl1_CustomDrawRowHeaderCell);
			' 
			' category
			' 
			Me.category.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow4, Me.multiEditorRow1})
			Me.category.Name = "category"
			' 
			' editorRow4
			' 
			Me.editorRow4.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.row})
			Me.editorRow4.Name = "editorRow4"
			Me.editorRow4.Properties.Caption = "1"
			' 
			' row
			' 
			Me.row.Name = "row"
			' 
			' multiEditorRow1
			' 
			Me.multiEditorRow1.Name = "multiEditorRow1"
			Me.multiEditorRow1.PropertiesCollection.AddRange(New DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties() { Me.multiEditorRowProperties1, Me.multiEditorRowProperties2, Me.multiEditorRowProperties3, Me.multiEditorRowProperties4})
			Me.multiEditorRow1.SeparatorKind = DevExpress.XtraVerticalGrid.Rows.SeparatorKind.String
			' 
			' multiEditorRowProperties1
			' 
			Me.multiEditorRowProperties1.Caption = "Multi Editor Row"
			Me.multiEditorRowProperties1.Value = 33
			Me.multiEditorRowProperties1.Width = 33
			' 
			' multiEditorRowProperties2
			' 
			Me.multiEditorRowProperties2.Caption = "C2"
			Me.multiEditorRowProperties2.Value = 12
			Me.multiEditorRowProperties2.Width = 16
			' 
			' multiEditorRowProperties3
			' 
			Me.multiEditorRowProperties3.Caption = "C3"
			Me.multiEditorRowProperties3.Value = 44
			Me.multiEditorRowProperties3.Width = 15
			' 
			' multiEditorRowProperties4
			' 
			Me.multiEditorRowProperties4.Caption = "C4"
			Me.multiEditorRowProperties4.Value = 55
			Me.multiEditorRowProperties4.Width = 15
			' 
			' categoryRow1
			' 
			Me.categoryRow1.ChildRows.AddRange(New DevExpress.XtraVerticalGrid.Rows.BaseRow() { Me.editorRow5, Me.editorRow6})
			Me.categoryRow1.Name = "categoryRow1"
			' 
			' editorRow5
			' 
			Me.editorRow5.Name = "editorRow5"
			Me.editorRow5.Properties.Caption = "Single Editor Row"
			' 
			' editorRow6
			' 
			Me.editorRow6.Name = "editorRow6"
			Me.editorRow6.Properties.Caption = "3"
			' 
			' editorRow1
			' 
			Me.editorRow1.Name = "editorRow1"
			Me.editorRow1.Properties.Caption = "1"
			' 
			' editorRow2
			' 
			Me.editorRow2.Name = "editorRow2"
			Me.editorRow2.Properties.Caption = "2"
			' 
			' editorRow3
			' 
			Me.editorRow3.Name = "editorRow3"
			Me.editorRow3.Properties.Caption = "3"
			' 
			' checkEdit1
			' 
			Me.checkEdit1.EditValue = True
			Me.checkEdit1.Location = New System.Drawing.Point(12, 206)
			Me.checkEdit1.Name = "checkEdit1"
			Me.checkEdit1.Properties.Caption = "Use Custom Draw"
			Me.checkEdit1.Size = New System.Drawing.Size(157, 19)
			Me.checkEdit1.TabIndex = 1
'			Me.checkEdit1.CheckedChanged += New System.EventHandler(Me.checkEdit1_CheckedChanged);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(616, 250)
			Me.Controls.Add(Me.checkEdit1)
			Me.Controls.Add(Me.vGridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.vGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.checkEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents vGridControl1 As DevExpress.XtraVerticalGrid.VGridControl
		Private multiEditorRow1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRow
		Private multiEditorRowProperties1 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
		Private multiEditorRowProperties2 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
		Private multiEditorRowProperties3 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
		Private multiEditorRowProperties4 As DevExpress.XtraVerticalGrid.Rows.MultiEditorRowProperties
		Private editorRow1 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow2 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow3 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow4 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow5 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private editorRow6 As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private category As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private row As DevExpress.XtraVerticalGrid.Rows.EditorRow
		Private categoryRow1 As DevExpress.XtraVerticalGrid.Rows.CategoryRow
		Private WithEvents checkEdit1 As DevExpress.XtraEditors.CheckEdit
	End Class
End Namespace
