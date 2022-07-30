Imports WindowsInput
Imports WindowsInput.Native

Module startup
    Dim keyb As New InputSimulator


    Sub Main()

        Dim pCount As Integer = 0
        Dim CSID As Integer = Process.GetCurrentProcess.SessionId
        For Each Process As Process In Process.GetProcesses
            If Process.SessionId = CSID And Process.ProcessName = "Launcher" Then

                pCount += 1
            End If
        Next
        If pCount > 1 Then

            Dim key As String = ""
            If My.Settings.ctrl <> 0 Then
                key += "^"
            End If
            If My.Settings.alt <> 0 Then
                key += "%"
            End If
            If My.Settings.shift <> 0 Then
                key += "+"
            End If
            Dim key2 As String = key & My.Settings.key
            SendKeys.SendWait(key2)
            '   SendKeys.Send(My.Settings.key)
            End
        End If

        Dim ctx As New AppContext()
        Application.Run(ctx)


    End Sub



End Module


Public Class AppContext
    Inherits ApplicationContext

#Region " Declarations"

    Private notifyIcon As NotifyIcon
    Private appActive As Boolean

    Dim TrayMenu As New ContextMenu
    Dim but_Show As New MenuItem
    Dim but_Exit As New MenuItem

#End Region

#Region " New / Load"

    Public Sub New()
        AddHandler Application.ApplicationExit, AddressOf OnApplicationExit

        SetupTrayIcon()

        RunAtStartup()

        form_Launcher.WindowState = FormWindowState.Minimized
        form_Launcher.Show()
        form_Launcher.Hide()
        ' RunStartupScripts()

        ' SetupPlexDrive()


    End Sub
    Public Sub SetupTrayIcon()
        notifyIcon = New NotifyIcon With {
            .Icon = My.Resources.icons8_launch_961,
            .Text = "Launcher"
        }

        AddHandler notifyIcon.MouseClick, AddressOf OnIconMouseClick

        but_Show.Text = "Open Launcher"
        but_Exit.Text = "Exit"
        but_Show.Name = "but_Show"
        but_Exit.Name = "but_Exit"

        AddHandler but_Exit.Click, AddressOf MenuButtons
        AddHandler but_Show.Click, AddressOf MenuButtons

        TrayMenu.MenuItems.AddRange({but_Show, but_Exit})


        appActive = True
        notifyIcon.Visible = True

        notifyIcon.ContextMenu = TrayMenu

        '   AddHandler notifyIcon.DoubleClick, AddressOf Tray_DoubleClick

    End Sub
    Public Shared Sub RunStartupScripts()
        Dim p As New ProcessStartInfo With {
            .FileName = "C:\Windows\nircmd.exe",
            .Arguments = "exec hide C:\Users\Public\Documents\Start Scripts.bat"
        }

        Process.Start(p)
    End Sub

    Public Shared Sub SetupPlexDrive()
        Dim p As New ProcessStartInfo With {
            .FileName = "C:\Windows\nircmd.exe",
            .Arguments = "exec hide C:\Users\javan\Documents\AutoHotKey\netlogon - instant.bat"
        }

        Process.Start(p)

    End Sub

    Public Sub RunAtStartup()
        If My.Settings.app1startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but1AppLocation,
                .Arguments = My.Settings.but1Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app2startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but2AppLocation,
                .Arguments = My.Settings.but2Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app3startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but3AppLocation,
                .Arguments = My.Settings.But3Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app4startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but4AppLocation,
                .Arguments = My.Settings.but4Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app5startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but5AppLocation,
                .Arguments = My.Settings.but5Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app6startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but6AppLocation,
                .Arguments = My.Settings.but6Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app7startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but7AppLocation,
                .Arguments = My.Settings.but7Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app8startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but8AppLocation,
                .Arguments = My.Settings.but9Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app9startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but9AppLocation,
                .Arguments = My.Settings.but9Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app10startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but10AppLocation,
                .Arguments = My.Settings.but10Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app11startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but11AppLocation,
                .Arguments = My.Settings.but11Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app12startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but12AppLocation,
                .Arguments = My.Settings.but12Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app13startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but13AppLocation,
                .Arguments = My.Settings.but13Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app14startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but14AppLocation,
                .Arguments = My.Settings.but14Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app15startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but15AppLocation,
                .Arguments = My.Settings.but15Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app16startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but16AppLocation,
                .Arguments = My.Settings.but16Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app17startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but17AppLocation,
                .Arguments = My.Settings.but17Arguments
            }
            Process.Start(p)
        End If
        If My.Settings.app18startup Then
            Dim p As New ProcessStartInfo With {
                .FileName = My.Settings.but18AppLocation,
                .Arguments = My.Settings.but18Arguments
            }
            Process.Start(p)
        End If


    End Sub

#End Region




    Public Sub Tray_DoubleClick()
        form_Launcher.Show()
    End Sub
    Public Shared Sub Show_Launcher(Force As Boolean)
        If Force Then
            form_Launcher.Show()
            form_Launcher.WindowState = FormWindowState.Normal
            form_Launcher.CenterForm(form_Launcher, Nothing)
        Else
            If form_Launcher.WasActivated Then
                form_Launcher.CenterForm(form_Launcher, Nothing)
                form_Launcher.HideMe.Start()
                form_Launcher.WasActivated = False
            Else
                If form_Launcher.Visible = True Then

                    form_Launcher.CenterForm(form_Launcher, Nothing)
                    form_Launcher.HideMe.Start()
                Else
                    form_Launcher.Show()
                    form_Launcher.WindowState = FormWindowState.Normal
                    form_Launcher.CenterForm(form_Launcher, Nothing)
                End If
            End If

        End If


    End Sub

    Public Sub MenuButtons(ByVal sender As Object, ByVal e As EventArgs)
        Select Case sender.Name
            Case "but_Exit"
                Application.ExitThread()

            Case "but_Show"
                Show_Launcher(True)
        End Select


    End Sub
    Public Function IsFormOpen(ByVal frm As Form) As Boolean
        If Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub OnApplicationExit(ByVal sender As Object, ByVal e As EventArgs)
        If notifyIcon IsNot Nothing Then
            notifyIcon.Dispose()
        End If
    End Sub

    Public Sub SysTray_Click(ByVal sender As Object, ByVal e As MouseEventArgs)

    End Sub
    Private Sub OnIconMouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)

        Show_Launcher(False)

        If e.Button = MouseButtons.Right Then
            ' TrayMenu.
        End If
    End Sub


End Class






Public Class HotKeyRegistryClass

    Private Declare Function RegisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Int32, ByVal fsModifier As Int32, ByVal vk As Int32) As Int32
    Private Declare Function UnregisterHotKey Lib "user32.dll" (ByVal handle As IntPtr, ByVal id As Int32) As Int32

    Private Handle As IntPtr = IntPtr.Zero
    Private Registry As New System.Collections.Generic.List(Of Int32)

    Public Enum Messages
        [WM_HOTKEY] = &H312
        [WM_APPCOMMAND] = &H319
        [WM_KEYDOWN] = &H100
    End Enum
    Public Enum Modifiers
        [MOD_ALT] = &H1
        [MOD_CTRL] = &H2
        [MOD_SHIFT] = &H4
    End Enum


    Sub New(ByVal Handle As IntPtr)
        Me.Handle = Handle
    End Sub

    Public Function Register(ByVal Modifier As Int32, ByVal Key As System.Windows.Forms.Keys) As Int32
        Dim ret As Int32

        ret = NextAvailableIndex()
        Call RegisterHotKey(Me.Handle, ret, Modifier, Key)
        Registry.Insert(ret, ret)
        Return ret
    End Function
    Public Sub Unregister(ByVal ID As Int32)
        Call UnregisterHotKey(Me.Handle, ID)
        Registry.Remove(ID)
    End Sub

    Private Function NextAvailableIndex() As Int32
        Dim ret As Int32 = 0
        Dim n As Int32 = 0

        For i As Int32 = 0 To Registry.Count - 1
            If Registry(i) = n Then
                n += 1
            ElseIf n < Registry(i) Then
                Return n
            End If
        Next
        If n = Registry.Count Then
            Return Registry.Count
        End If
        Return ret
    End Function




End Class

