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
using System.Windows.Forms;

namespace WindowsApplication4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}