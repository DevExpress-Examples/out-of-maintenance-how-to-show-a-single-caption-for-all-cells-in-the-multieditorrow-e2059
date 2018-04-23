// Developer Express Code Central Example:
// How to show a single caption for all cells in the MultiEditorRow
// 
// This example demonstrates how to visually merge headers in MultiEditorRow and
// draw a single caption for all data cells
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2059

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;

namespace WindowsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void vGridControl1_CustomDrawSeparator(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawSeparatorEventArgs e)
        {
            VGridControl grid = sender as VGridControl;
            if (!e.IsHeaderSeparator)
            {
                Color vertLineColor = grid.ViewInfo.PaintAppearance.VertLine.BackColor;
                Pen pen = new Pen(vertLineColor, 2);
                SolidBrush brush = new SolidBrush(Color.White);
                e.Graphics.FillRectangle(brush, e.Bounds);
                e.Graphics.DrawLine(pen, e.Bounds.Right, e.Bounds.Y, e.Bounds.Right, e.Bounds.Bottom);
            }
            e.Handled = true;
            
            
        }

        private void vGridControl1_CustomDrawRowHeaderCell(object sender, DevExpress.XtraVerticalGrid.Events.CustomDrawRowHeaderCellEventArgs e)
        {
            if (!checkEdit1.Checked) 
                return;
            if (e.Row is MultiEditorRow)
            {
                VGridControl grid = sender as VGridControl;
                if (e.CellIndex == 0)
                {
                    Brush backBrush;
                    Brush brush;
                    Font textFont;
                    if (e.Focused) {
                        backBrush = e.Cache.GetSolidBrush(grid.ViewInfo.PaintAppearance.FocusedRow.BackColor);
                        brush = e.Cache.GetSolidBrush(grid.ViewInfo.PaintAppearance.FocusedRow.ForeColor);
                        textFont = grid.ViewInfo.PaintAppearance.FocusedRow.Font;
                    }
                    else {
                        backBrush = e.Cache.GetSolidBrush(grid.ViewInfo.PaintAppearance.RowHeaderPanel.BackColor);
                        brush = e.Cache.GetSolidBrush(grid.ViewInfo.PaintAppearance.RowHeaderPanel.ForeColor);
                        textFont = grid.ViewInfo.PaintAppearance.RowHeaderPanel.Font;
                    }
                     
                    e.Graphics.FillRectangle(backBrush, e.Row.HeaderInfo.HeaderRect);
                    Rectangle r = new Rectangle(e.CaptionRect.X, e.CaptionRect.Y, e.Row.HeaderInfo.HeaderCellsRect.Width, e.CaptionRect.Height);
                    e.Appearance.DrawString(e.Cache, e.Caption, r);
                }
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            vGridControl1.Invalidate();
        }
    }
}