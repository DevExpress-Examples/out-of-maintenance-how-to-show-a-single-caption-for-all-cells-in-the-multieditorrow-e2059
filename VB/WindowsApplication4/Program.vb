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
Imports System.Windows.Forms

Namespace WindowsApplication4
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Class
End Namespace