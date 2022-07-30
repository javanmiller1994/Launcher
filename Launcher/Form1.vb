Imports System.ComponentModel
Imports System.Text


Partial Public Class Form1
    Public Sub New()
        InitializeComponent()
    End Sub




    Private Sub but_PlexDrive_Click(sender As Object, e As EventArgs) Handles but_PlexDrive.Click
        AppContext.SetupPlexDrive()
    End Sub

    Private Sub but_Scripts_Click(sender As Object, e As EventArgs) Handles but_Scripts.Click
        AppContext.RunStartupScripts()
    End Sub

    Private Sub but_VirtualMonitor_Click(sender As Object, e As EventArgs) Handles but_VirtualMonitor.Click
        Dim p As New ProcessStartInfo
        p.FileName = "C:\Windows\nircmd.exe"
        p.Arguments = "exec hide C:\Users\javan\Downloads\Programs\Desktop Environment\Virtual Monitor\usbmmidd.bat"

        Process.Start(p)
    End Sub


End Class
