' Developer Express Code Central Example:
' How to show a single caption for all cells in the MultiEditorRow
' 
' This example demonstrates how to visually merge headers in MultiEditorRow and
' draw a single caption for all data cells
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2059

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraVerticalGrid
Imports DevExpress.XtraVerticalGrid.Rows

Namespace WindowsApplication4
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub vGridControl1_CustomDrawSeparator(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawSeparatorEventArgs) Handles vGridControl1.CustomDrawSeparator
            Dim grid As VGridControl = TryCast(sender, VGridControl)
            If Not e.IsHeaderSeparator Then
                Dim vertLineColor As Color = grid.ViewInfo.PaintAppearance.VertLine.BackColor
                Dim pen As New Pen(vertLineColor, 2)
                Dim brush As New SolidBrush(Color.White)
                e.Graphics.FillRectangle(brush, e.Bounds)
                e.Graphics.DrawLine(pen, e.Bounds.Right, e.Bounds.Y, e.Bounds.Right, e.Bounds.Bottom)
            End If
            e.Handled = True


        End Sub

        Private Sub vGridControl1_CustomDrawRowHeaderCell(ByVal sender As Object, ByVal e As DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs) Handles vGridControl1.CustomDrawRowHeaderCell
            If Not checkEdit1.Checked Then
                Return
            End If
            If TypeOf e.Row Is MultiEditorRow Then
                Dim grid As VGridControl = TryCast(sender, VGridControl)
                If e.CellIndex = 0 Then
                    Dim backBrush As Brush
                    Dim brush As Brush
                    Dim textFont As Font
                    If e.Focused Then
                        backBrush = e.Cache.GetSolidBrush(grid.ViewInfo.PaintAppearance.FocusedRow.BackColor)
                        brush = e.Cache.GetSolidBrush(grid.ViewInfo.PaintAppearance.FocusedRow.ForeColor)
                        textFont = grid.ViewInfo.PaintAppearance.FocusedRow.Font
                    Else
                        backBrush = e.Cache.GetSolidBrush(grid.ViewInfo.PaintAppearance.RowHeaderPanel.BackColor)
                        brush = e.Cache.GetSolidBrush(grid.ViewInfo.PaintAppearance.RowHeaderPanel.ForeColor)
                        textFont = grid.ViewInfo.PaintAppearance.RowHeaderPanel.Font
                    End If

                    Dim backRectangle As Rectangle = e.Bounds
                    backRectangle.Width = grid.Width
                    e.Graphics.FillRectangle(backBrush, backRectangle)
                    Dim r As New Rectangle(e.CaptionRect.X, e.CaptionRect.Y, e.Row.HeaderInfo.HeaderCellsRect.Width, e.CaptionRect.Height)
                    e.Appearance.DrawString(e.Cache, e.Caption, r)
                End If
                e.Handled = True
            End If
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        End Sub

        Private Sub checkEdit1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkEdit1.CheckedChanged
            vGridControl1.Invalidate()
        End Sub
    End Class
End Namespace