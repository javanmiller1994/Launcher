Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Collections
Imports System.Runtime.InteropServices
Imports MadMilkman.Ini
Imports System.Text

Public Class form_Launcher


#Region " Declarations"

    Public Shared NewAppName As String
    Public Shared NewAppImage As String
    Public Shared NewAppLocation As String
    Public Shared NewAppArguments As String

    Public Shared NewAppNumber As Integer
    Public Shared IsDragDrop As Boolean = False

    Public Shared AppOpen As Boolean = False

    Public Shared ErrorMessage As String


#End Region

#Region " Load / Close / App Handles"

    Public Shared Sub CenterForm(ByVal frm As Form, Optional ByVal parent As Form = Nothing)
        '' Note: call this from frm's Load event!
        Dim r As Rectangle
        If parent IsNot Nothing Then
            r = parent.RectangleToScreen(parent.ClientRectangle)
        Else
            r = Screen.FromPoint(frm.Location).PrimaryScreen.WorkingArea
        End If

        Dim x As Integer
        Dim y As Integer
        Select Case My.Settings.CenterForm
            Case True
                x = r.Left + (r.Width - frm.Width) \ 2
                y = r.Top + (r.Height - frm.Height) \ 2
            Case False
                x = r.Left + (r.Width - frm.Width) \ 2
                y = r.Bottom - (frm.Height) - 5
        End Select

        frm.Location = New Point(x, y)



        '   MsgBox(r.Top & " " & r.Height & " " & frm.Height & " " & (r.Height - frm.Height) \ 2)
    End Sub
    Private Sub form_Launcher_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        CenterForm(Me, Nothing)
    End Sub

    Private Sub form_Launcher_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        '  RegisterHotKey(Me.Handle, 0, Nothing, Keys.Escape)

        CenterForm(Me, Nothing)
        For i As Integer = 1 To My.Settings.AppNumber
            Dim but As New LabledPicturebox

            Select Case i
                Case 1
                    Try
                        but.Image = Image.FromFile(My.Settings.but1Image)
                        but.Text = My.Settings.but1App & Environment.NewLine
                        but.AppName = My.Settings.but1App
                        but.AppLocation = My.Settings.but1AppLocation
                        but.AppArguments = My.Settings.but1Arguments
                        but.AppImage = My.Settings.but1Image
                        but.Startup = My.Settings.app1startup
                    Catch
                    End Try

                Case 2
                    but.Image = Image.FromFile(My.Settings.but2Image)
                    but.Text = My.Settings.but2App & Environment.NewLine
                    but.AppName = My.Settings.but2App
                    but.AppLocation = My.Settings.but2AppLocation
                    but.AppArguments = My.Settings.but2Arguments
                    but.AppImage = My.Settings.but2Image
                    but.Startup = My.Settings.app2startup

                Case 3
                    but.Image = Image.FromFile(My.Settings.but3Image)
                    but.Text = My.Settings.but3App & Environment.NewLine
                    but.AppName = My.Settings.but3App
                    but.AppLocation = My.Settings.but3AppLocation
                    but.AppArguments = My.Settings.But3Arguments
                    but.AppImage = My.Settings.but3Image
                    but.Startup = My.Settings.app3startup

                Case 4
                    but.Image = Image.FromFile(My.Settings.but4Image)
                    but.Text = My.Settings.but4App & Environment.NewLine
                    but.AppName = My.Settings.but4App
                    but.AppLocation = My.Settings.but4AppLocation
                    but.AppArguments = My.Settings.but4Arguments
                    but.AppImage = My.Settings.but4Image
                    but.Startup = My.Settings.app4startup

                Case 5
                    but.Image = Image.FromFile(My.Settings.but5Image)
                    but.Text = My.Settings.but5App & Environment.NewLine
                    but.AppName = My.Settings.but5App
                    but.AppLocation = My.Settings.but5AppLocation
                    but.AppArguments = My.Settings.but5Arguments
                    but.AppImage = My.Settings.but5Image
                    but.Startup = My.Settings.app5startup

                Case 6
                    but.Image = Image.FromFile(My.Settings.but6Image)
                    but.Text = My.Settings.but6App & Environment.NewLine
                    but.AppName = My.Settings.but6App
                    but.AppLocation = My.Settings.but6AppLocation
                    but.AppArguments = My.Settings.but6Arguments
                    but.AppImage = My.Settings.but6Image
                    but.Startup = My.Settings.app6startup

                Case 7
                    but.Image = Image.FromFile(My.Settings.but7Image)
                    but.Text = My.Settings.but7App & Environment.NewLine
                    but.AppName = My.Settings.but7App
                    but.AppLocation = My.Settings.but7AppLocation
                    but.AppArguments = My.Settings.but7Arguments
                    but.AppImage = My.Settings.but7Image
                    but.Startup = My.Settings.app7startup

                Case 8
                    but.Image = Image.FromFile(My.Settings.but8Image)
                    but.Text = My.Settings.but8App & Environment.NewLine
                    but.AppName = My.Settings.but8App
                    but.AppLocation = My.Settings.but8AppLocation
                    but.AppArguments = My.Settings.but8Arguments
                    but.AppImage = My.Settings.but8Image
                    but.Startup = My.Settings.app8startup

                Case 9
                    but.Image = Image.FromFile(My.Settings.but9Image)
                    but.Text = My.Settings.but9App & Environment.NewLine
                    but.AppName = My.Settings.but9App
                    but.AppLocation = My.Settings.but9AppLocation
                    but.AppArguments = My.Settings.but9Arguments
                    but.AppImage = My.Settings.but9Image
                    but.Startup = My.Settings.app9startup

                Case 10
                    but.Image = Image.FromFile(My.Settings.but10Image)
                    but.Text = My.Settings.but10App & Environment.NewLine
                    but.AppName = My.Settings.but10App
                    but.AppLocation = My.Settings.but10AppLocation
                    but.AppArguments = My.Settings.but10Arguments
                    but.AppImage = My.Settings.but10Image
                    but.Startup = My.Settings.app10startup

                Case 11
                    but.Image = Image.FromFile(My.Settings.but11Image)
                    but.Text = My.Settings.but11App & Environment.NewLine
                    but.AppName = My.Settings.but11App
                    but.AppLocation = My.Settings.but11AppLocation
                    but.AppArguments = My.Settings.but11Arguments
                    but.AppImage = My.Settings.but11Image
                    but.Startup = My.Settings.app11startup

                Case 12
                    but.Image = Image.FromFile(My.Settings.but12Image)
                    but.Text = My.Settings.but12App & Environment.NewLine
                    but.AppName = My.Settings.but12App
                    but.AppLocation = My.Settings.but12AppLocation
                    but.AppArguments = My.Settings.but12Arguments
                    but.AppImage = My.Settings.but12Image
                    but.Startup = My.Settings.app12startup

                Case 13
                    but.Image = Image.FromFile(My.Settings.but13Image)
                    but.Text = My.Settings.but13App & Environment.NewLine
                    but.AppName = My.Settings.but13App
                    but.AppLocation = My.Settings.but13AppLocation
                    but.AppArguments = My.Settings.but13Arguments
                    but.AppImage = My.Settings.but13Image
                    but.Startup = My.Settings.app13startup

                Case 14
                    but.Image = Image.FromFile(My.Settings.but14Image)
                    but.Text = My.Settings.but14App & Environment.NewLine
                    but.AppName = My.Settings.but14App
                    but.AppLocation = My.Settings.but14AppLocation
                    but.AppArguments = My.Settings.but14Arguments
                    but.AppImage = My.Settings.but14Image
                    but.Startup = My.Settings.app14startup

                Case 15
                    but.Image = Image.FromFile(My.Settings.but15Image)
                    but.Text = My.Settings.but15App & Environment.NewLine
                    but.AppName = My.Settings.but15App
                    but.AppLocation = My.Settings.but15AppLocation
                    but.AppArguments = My.Settings.but15Arguments
                    but.AppImage = My.Settings.but15Image
                    but.Startup = My.Settings.app15startup

                Case 16
                    but.Image = Image.FromFile(My.Settings.but16Image)
                    but.Text = My.Settings.but16App & Environment.NewLine
                    but.AppName = My.Settings.but16App
                    but.AppLocation = My.Settings.but16AppLocation
                    but.AppArguments = My.Settings.but16Arguments
                    but.AppImage = My.Settings.but16Image
                    but.Startup = My.Settings.app16startup

                Case 17
                    but.Image = Image.FromFile(My.Settings.but17Image)
                    but.Text = My.Settings.but17App & Environment.NewLine
                    but.AppName = My.Settings.but17App
                    but.AppLocation = My.Settings.but17AppLocation
                    but.AppArguments = My.Settings.but17Arguments
                    but.AppImage = My.Settings.but17Image
                    but.Startup = My.Settings.app17startup

                Case 18
                    but.Image = Image.FromFile(My.Settings.but18Image)
                    but.Text = My.Settings.but18App & Environment.NewLine
                    but.AppName = My.Settings.but18App
                    but.AppLocation = My.Settings.but18AppLocation
                    but.AppArguments = My.Settings.but18Arguments
                    but.AppImage = My.Settings.but18Image
                    but.Startup = My.Settings.app18startup

            End Select

            but.Name = "but_App" & i
            LauncherPanel.Controls.Add(but)
        Next




        Setup_Events()

        RegisterHotKey(Me.Handle, 1, My.Settings.ctrl Or My.Settings.shift Or My.Settings.alt, DirectCast([Enum].Parse(GetType(Keys), My.Settings.key), Keys))
        AppOpen = True
    End Sub

    Private Sub but_Exit_Click(sender As Object, e As EventArgs) Handles but_Exit.Click
        My.Settings.AppNumber = LauncherPanel.Controls.Count
        SaveButtons()
        My.Settings.Save()
        Application.ExitThread()
    End Sub

    Private Sub form_Launcher_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If AppOpen Then
            SaveButtons()
        End If


        Try
            '  UnregisterHotKey(Me.Handle, 1)
        Catch ex As Exception
            ErrorMessage = ex.ToString
        End Try
        My.Settings.AppNumber = LauncherPanel.Controls.Count
        My.Settings.Save()
        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
        HideMe.start
    End Sub

#End Region
#Region " Save Buttons"

    Public Sub SaveButtons()

        For i As Integer = 1 To LauncherPanel.Controls.Count
            Dim but As LabledPicturebox = LauncherPanel.Controls(i - 1)
            Select Case i
                Case 1
                    My.Settings.but1App = but.AppName
                    My.Settings.but1AppLocation = but.AppLocation
                    My.Settings.but1Arguments = but.AppArguments
                    My.Settings.but1Image = but.AppImage
                    My.Settings.app1startup = but.Startup

                Case 2
                    My.Settings.but2App = but.AppName
                    My.Settings.but2AppLocation = but.AppLocation
                    My.Settings.but2Arguments = but.AppArguments
                    My.Settings.but2Image = but.AppImage
                    My.Settings.app2startup = but.Startup

                Case 3
                    My.Settings.but3App = but.AppName
                    My.Settings.but3AppLocation = but.AppLocation
                    My.Settings.But3Arguments = but.AppArguments
                    My.Settings.but3Image = but.AppImage
                    My.Settings.app3startup = but.Startup

                Case 4
                    My.Settings.but4App = but.AppName
                    My.Settings.but4AppLocation = but.AppLocation
                    My.Settings.but4Arguments = but.AppArguments
                    My.Settings.but4Image = but.AppImage
                    My.Settings.app4startup = but.Startup

                Case 5
                    My.Settings.but5App = but.AppName
                    My.Settings.but5AppLocation = but.AppLocation
                    My.Settings.but5Arguments = but.AppArguments
                    My.Settings.but5Image = but.AppImage
                    My.Settings.app5startup = but.Startup

                Case 6
                    My.Settings.but6App = but.AppName
                    My.Settings.but6AppLocation = but.AppLocation
                    My.Settings.but6Arguments = but.AppArguments
                    My.Settings.but6Image = but.AppImage
                    My.Settings.app6startup = but.Startup

                Case 7
                    My.Settings.but7App = but.AppName
                    My.Settings.but7AppLocation = but.AppLocation
                    My.Settings.but7Arguments = but.AppArguments
                    My.Settings.but7Image = but.AppImage
                    My.Settings.app7startup = but.Startup

                Case 8
                    My.Settings.but8App = but.AppName
                    My.Settings.but8AppLocation = but.AppLocation
                    My.Settings.but8Arguments = but.AppArguments
                    My.Settings.but8Image = but.AppImage
                    My.Settings.app8startup = but.Startup

                Case 9
                    My.Settings.but9App = but.AppName
                    My.Settings.but9AppLocation = but.AppLocation
                    My.Settings.but9Arguments = but.AppArguments
                    My.Settings.but9Image = but.AppImage
                    My.Settings.app9startup = but.Startup

                Case 10
                    My.Settings.but10App = but.AppName
                    My.Settings.but10AppLocation = but.AppLocation
                    My.Settings.but10Arguments = but.AppArguments
                    My.Settings.but10Image = but.AppImage
                    My.Settings.app10startup = but.Startup

                Case 11
                    My.Settings.but11App = but.AppName
                    My.Settings.but11AppLocation = but.AppLocation
                    My.Settings.but11Arguments = but.AppArguments
                    My.Settings.but11Image = but.AppImage
                    My.Settings.app11startup = but.Startup

                Case 12
                    My.Settings.but12App = but.AppName
                    My.Settings.but12AppLocation = but.AppLocation
                    My.Settings.but12Arguments = but.AppArguments
                    My.Settings.but12Image = but.AppImage
                    My.Settings.app12startup = but.Startup

                Case 13
                    My.Settings.but13App = but.AppName
                    My.Settings.but13AppLocation = but.AppLocation
                    My.Settings.but13Arguments = but.AppArguments
                    My.Settings.but13Image = but.AppImage
                    My.Settings.app13startup = but.Startup

                Case 14
                    My.Settings.but14App = but.AppName
                    My.Settings.but14AppLocation = but.AppLocation
                    My.Settings.but14Arguments = but.AppArguments
                    My.Settings.but14Image = but.AppImage
                    My.Settings.app14startup = but.Startup

                Case 15
                    My.Settings.but15App = but.AppName
                    My.Settings.but15AppLocation = but.AppLocation
                    My.Settings.but15Arguments = but.AppArguments
                    My.Settings.but15Image = but.AppImage
                    My.Settings.app15startup = but.Startup

                Case 16
                    My.Settings.but16App = but.AppName
                    My.Settings.but16AppLocation = but.AppLocation
                    My.Settings.but16Arguments = but.AppArguments
                    My.Settings.but16Image = but.AppImage
                    My.Settings.app16startup = but.Startup

                Case 17
                    My.Settings.but17App = but.AppName
                    My.Settings.but17AppLocation = but.AppLocation
                    My.Settings.but17Arguments = but.AppArguments
                    My.Settings.but17Image = but.AppImage
                    My.Settings.app17startup = but.Startup

                Case 18
                    My.Settings.but18App = but.AppName
                    My.Settings.but18AppLocation = but.AppLocation
                    My.Settings.but18Arguments = but.AppArguments
                    My.Settings.but18Image = but.AppImage
                    My.Settings.app18startup = but.Startup

            End Select
        Next

    End Sub


#End Region
#Region " Hide"

    Dim ShiftDown As Boolean = False
    Private Sub form_Launcher_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown, LauncherPanel.KeyDown
        If e.Modifiers = Keys.Shift Then
            ShiftDown = True
        End If
    End Sub


    Private Sub form_Launcher_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp, LauncherPanel.KeyUp

        ShiftDown = False

        If e.KeyCode = Keys.Escape Then
            Me.WindowState = FormWindowState.Minimized
            HideMe.Start()
        End If
    End Sub

    Private Sub RoundedCornerTextbox1_KeyUp(sender As Object, e As KeyEventArgs) Handles tb_Launcher.KeyUp
        If e.KeyCode = Keys.Escape Then
            Me.WindowState = FormWindowState.Minimized
            HideMe.start
        End If
    End Sub

    Private Sub form_Launcher_ResizeEnd(sender As Object, e As EventArgs) Handles Me.Resize

        If Me.WindowState = FormWindowState.Minimized Then
            Hideme.start
        End If
    End Sub

#End Region
#Region " Activate / Deactivate"

    Public Shared KeepActivated As Boolean = False
    Public Shared WasActivated As Boolean = False
    Private Sub form_Launcher_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        If KeepActivated = False Then
            Me.TopMost = True

            If AppOpen = True Then
                SaveButtons()
            End If
            If My.Settings.HideMe Then
                Me.WindowState = FormWindowState.Minimized
            End If
            Me.TopMost = My.Settings.TopMost


            ' WasActivated = False
        End If


    End Sub
    Private Sub HideMe_Tick(sender As Object, e As EventArgs) Handles HideMe.Tick
        Me.Hide()
        HideMe.Stop()
    End Sub

    Private Sub form_Launcher_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, LauncherPanel.MouseClick
        KeepActivated = False
    End Sub


    Private Sub form_Launcher_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Select Case My.Settings.TopMost
            Case True
                Me.TopMost = True
            Case False
                Me.TopMost = False

        End Select

        WasActivated = True
    End Sub

#End Region



#Region " Mouse Events"

    Dim ChildIndexbefore As Integer
    Dim newchildintex As Integer
    Dim butbefore As LabledPicturebox
    Dim IsMouseDown As Boolean = False
    Dim IsMoving As Boolean = False

    Dim ButtonRightClick As Integer
    Dim CurrentButton As LabledPicturebox
    Dim Ischecked As Boolean = False
    Dim beforeclick As Boolean = True

    Public Sub Setup_Events()
        For Each c As Control In LauncherPanel.Controls
            If c.GetType Is GetType(LabledPicturebox) Then
                Try
                    RemoveHandler c.MouseEnter, AddressOf buttons_MouseEnter
                    RemoveHandler c.MouseLeave, AddressOf buttons_MouseLeave
                    ' RemoveHandler c.Click, AddressOf buttons_MouseClick
                    RemoveHandler c.MouseClick, AddressOf but_True_MouseClick
                    RemoveHandler c.MouseMove, AddressOf buttons_MouseMove
                    RemoveHandler c.MouseDown, AddressOf buttons_MouseDown
                    RemoveHandler c.MouseUp, AddressOf buttons_mouseup
                Catch ex As Exception
                    ErrorMessage = ex.ToString

                End Try
                Try

                    AddHandler c.MouseEnter, AddressOf buttons_MouseEnter
                    AddHandler c.MouseLeave, AddressOf buttons_MouseLeave
                    ' AddHandler c.Click, AddressOf buttons_MouseClick
                    AddHandler c.Click, AddressOf but_True_MouseClick
                    AddHandler c.MouseMove, AddressOf buttons_MouseMove
                    AddHandler c.MouseDown, AddressOf buttons_MouseDown
                    AddHandler c.MouseUp, AddressOf buttons_mouseup
                Catch ex As Exception
                    ErrorMessage = ex.ToString

                End Try

            End If
        Next
        For Each c As Control In panel_BottomBar.Controls
            If c.GetType Is GetType(PictureBox) Then
                Try
                    If Not c.Name = "But_AppIcon" Then
                        AddHandler c.MouseEnter, AddressOf buttons_MouseEnter
                        AddHandler c.MouseLeave, AddressOf buttons_MouseLeave
                    End If

                Catch ex As Exception
                    ErrorMessage = ex.ToString

                End Try

            End If
        Next


    End Sub


    Private Sub buttons_MouseEnter(sender As Object, e As EventArgs)
        sender.backcolor = Color.FromArgb(247, 247, 247)
    End Sub
    Private Sub buttons_MouseLeave(sender As Object, e As EventArgs)
        sender.backcolor = Color.Transparent
    End Sub

    Dim LastOpened As String
    Private Sub buttons_MouseClick(sender As Object, e As EventArgs)
        ErrorMessage = "No info to display."
        Try
            ' If LastOpened = pr.FileName then return
            Dim pr As New ProcessStartInfo With {
                .FileName = sender.AppLocation,
                .Arguments = sender.AppArguments
            }

            Process.Start(pr)
            LastOpened = pr.FileName
        Catch ex As Exception
            ErrorMessage = ex.ToString
            KeepActivated = True
            Dim MyMessage As New MyMessageBox With {
                .Text = "Error!"
            }
            MyMessage.label_Message.Text = Environment.NewLine & "Error opening item!"
            ErrorMessage = ex.ToString
            MyMessage.ShowDialog()
            '   MsgBox("Error opening item!")
        End Try
    End Sub

    Private Sub but_True_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            If IsMoving = False Then
                '    buttons_MouseClick(sender, e)
            End If


        ElseIf e.Button = MouseButtons.Right Then
            ButtonRightClick = LauncherPanel.Controls.GetChildIndex(sender) + 1
            CurrentButton = LauncherPanel.Controls(ButtonRightClick - 1)
            Ischecked = CurrentButton.Startup

            beforeclick = True
            cb_Startup.Checked = Ischecked
            beforeclick = False
            Menu_RightClick.ShowPopup(MousePosition)
        End If
    End Sub

    Dim MouseX As Integer
    Public Sub buttons_MouseMove(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            If IsMouseDown Then
                Dim NewMouseX As Integer = LauncherPanel.PointToClient(Cursor.Position).X

                If NewMouseX > (MouseX + 5) Then
                    MoveButton()

                ElseIf NewMouseX < (MouseX - 5) Then
                    MoveButton()
                Else
                    IsMoving = False
                    butbefore.Opacity = 1
                    butbefore.TextVisible = True
                    butbefore.BackColor = Color.FromArgb(247, 247, 247)
                End If

            End If
        End If

    End Sub
    Public Sub MoveButton()
        Dim ChildIndex As Integer = LauncherPanel.Controls.IndexOf(LauncherPanel.GetChildAtPoint(LauncherPanel.PointToClient(Cursor.Position)))
        If ChildIndex <> -1 Then
            LauncherPanel.Controls.SetChildIndex(butbefore, ChildIndex)
        End If

        IsMoving = True
        butbefore.ImageHeight = 48 '46
        butbefore.Opacity = 0.5
        butbefore.TextVisible = False
        butbefore.BackColor = Color.Transparent
    End Sub

    Public Sub buttons_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            IsMouseDown = True
            MouseX = LauncherPanel.PointToClient(Cursor.Position).X

            butbefore = LauncherPanel.Controls(LauncherPanel.Controls.GetChildIndex(sender))
            ChildIndexbefore = LauncherPanel.Controls.GetChildIndex(butbefore)


            butbefore.ImageHeight = 38
        End If

    End Sub

    Public Sub buttons_mouseup(sender As Object, e As MouseEventArgs)
        IsMouseDown = False
        If e.Button = MouseButtons.Left Then
            If IsMoving = False Then
                buttons_MouseClick(sender, e)

            Else
                IsMoving = False
            End If


            Try
                butbefore.ImageHeight = 43
            Catch ex As Exception
                ErrorMessage = ex.ToString
            End Try
            Try
                butbefore.Opacity = 1
            Catch ex As Exception
                ErrorMessage = ex.ToString
            End Try
            Try
                butbefore.TextVisible = True
            Catch ex As Exception
                ErrorMessage = ex.ToString
            End Try

        End If





    End Sub

#End Region
#Region " Right Click"

    Private Sub MenuBut_Save_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MenuBut_Save.ItemClick
        KeepActivated = True
        Dim ini As New IniFile(New IniOptions() With {.Encoding = Encoding.Unicode})
        Dim Saver As New SaveFileDialog


        Dim but As LabledPicturebox = LauncherPanel.Controls(ButtonRightClick - 1)

        ini.Sections.Add("Info")
        ini.Sections("Info").Keys.Add("Location")
        ini.Sections("Info").Keys.Add("Name")
        ini.Sections("Info").Keys.Add("Arguments")
        ini.Sections("Info").Keys.Add("IconLocation")



        Dim AppLocation As String = but.AppLocation
        Dim AppName As String = but.AppName ' = but.Text.Trim
        Dim AppArguments As String = but.AppArguments
        Dim AppIcon As String = but.AppImage



        ini.Sections("Info").Keys("Location").Value = AppLocation  'DragFile
        ini.Sections("Info").Keys("Name").Value = AppName 'IO.Path.GetFileNameWithoutExtension(DragFile)
        ini.Sections("Info").Keys("Arguments").Value = AppArguments  'DragFile
        ini.Sections("Info").Keys("IconLocation").Value = AppIcon   ' IconFile


        Saver.Title = "Save Item"
        Saver.Filter = "Launcher File|*.lff"

        If Saver.ShowDialog = DialogResult.OK Then

            ini.Save(Saver.FileName)
        End If



    End Sub
    Private Sub MenuBut_Edit_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MenuBut_Edit.ItemClick
        KeepActivated = True
        NewAppImage = Nothing
        Dim but As LabledPicturebox = LauncherPanel.Controls(ButtonRightClick - 1)


        '  Try
        Dim xform As New AddForm

        xform.but_OK.Text = "Done"
        xform.Text = "Edit Button"

        xform.tb_Name.Text = but.AppName
        xform.tb_App.Text = but.AppLocation
        xform.tb_Arguments.Text = but.AppArguments
        xform.IconBox.Image = Image.FromFile(but.AppImage)
        xform.NewImage = but.AppImage

        Me.TopMost = False
        If xform.ShowDialog = DialogResult.OK Then
            If Not NewAppImage = "" Then
                but.Image = Image.FromFile(NewAppImage)
            End If

            but.Text = NewAppName & Environment.NewLine
            but.AppName = NewAppName
            but.AppLocation = NewAppLocation
            but.AppArguments = NewAppArguments
            but.AppImage = NewAppImage

            ' MsgBox(NewAppName & Environment.NewLine & NewAppLocation & Environment.NewLine & NewAppArguments & Environment.NewLine & NewAppImage)

            '  LauncherPanel.Controls.Add(but)

            My.Settings.Save()
            '   Setup_Events()
            Me.TopMost = My.Settings.TopMost
        End If


        ' LauncherPanel.Controls(ButtonRightClick - 1) = but
        '        but.Dispose()


        '  Catch ex As Exception
        ' MsgBox(ex.ToString)
        '  but.Dispose()
        '  End Try



    End Sub
    Private Sub MenuBut_Duplicate_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MenuBut_Duplicate.ItemClick
        Dim but As LabledPicturebox = LauncherPanel.Controls(ButtonRightClick - 1)
        Dim newBut As New LabledPicturebox With {
            .Image = Image.FromFile(but.AppImage),
            .Text = but.AppName & Environment.NewLine,
            .AppName = but.AppName,
            .AppLocation = but.AppLocation,
            .AppArguments = but.AppArguments,
            .AppImage = but.AppImage
        }
        LauncherPanel.Controls.Add(newBut)
        Try
            AddHandler newBut.MouseEnter, AddressOf buttons_MouseEnter
            AddHandler newBut.MouseLeave, AddressOf buttons_MouseLeave
            ' AddHandler c.Click, AddressOf buttons_MouseClick
            AddHandler newBut.Click, AddressOf but_True_MouseClick
            AddHandler newBut.MouseMove, AddressOf buttons_MouseMove
            AddHandler newBut.MouseDown, AddressOf buttons_MouseDown
            AddHandler newBut.MouseUp, AddressOf buttons_mouseup
        Catch ex As Exception

        End Try
        '  Setup_Events()
    End Sub
    Private Sub MenuBut_Delete_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MenuBut_Delete.ItemClick
        KeepActivated = True
        ErrorMessage = "No info to display."

        If ShiftDown = False Then
            Dim MyMessage As New MyMessageBox With {
                       .Text = "Delete Item?"
                   }
            MyMessage.but_Okay.DialogResult = DialogResult.Yes
            MyMessage.but_Cancel.DialogResult = DialogResult.No
            MyMessage.but_Okay.Text = "Yes"
            MyMessage.but_Cancel.Text = "No"
            MyMessage.label_Message.Text = Environment.NewLine & "Are you sure you want to delete item?" & Environment.NewLine & "This cannot be undone!"

            If MyMessage.ShowDialog = DialogResult.Yes Then
                LauncherPanel.Controls.RemoveAt(ButtonRightClick - 1)
            Else

            End If
        Else
            LauncherPanel.Controls.RemoveAt(ButtonRightClick - 1)
        End If





    End Sub

    Private Sub cb_Startup_CheckedChanged(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles cb_Startup.CheckedChanged

        If beforeclick Then Return
        CurrentButton.Startup = cb_Startup.Checked

        My.Settings.Save()
    End Sub


    Private Sub MenuBut_MoveLeft_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MenuBut_MoveLeft.ItemClick
        Dim but = LauncherPanel.Controls(ButtonRightClick - 1)
        If LauncherPanel.Controls.GetChildIndex(but) - 1 >= 0 Then
            LauncherPanel.Controls.SetChildIndex(but, LauncherPanel.Controls.GetChildIndex(but) - 1)
        End If
    End Sub

    Private Sub MenuBut_MoveRight_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MenuBut_MoveRight.ItemClick
        Dim but = LauncherPanel.Controls(ButtonRightClick - 1)
        If LauncherPanel.Controls.GetChildIndex(but) + 1 <= LauncherPanel.Controls.Count Then
            LauncherPanel.Controls.SetChildIndex(but, LauncherPanel.Controls.GetChildIndex(but) + 1)
        End If
    End Sub

    Private Sub MenuBut_OpenLocation_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles MenuBut_OpenLocation.ItemClick
        Try
            If CurrentButton.AppArguments = "" Then
                Process.Start(IO.Path.GetDirectoryName(CurrentButton.AppLocation))
            Else
                Try
                    Process.Start(IO.Path.GetDirectoryName(CurrentButton.AppArguments.Replace("exec hide ", "")))
                Catch ex As Exception
                    Process.Start(IO.Path.GetDirectoryName(CurrentButton.AppLocation))
                End Try

            End If

        Catch ex As Exception

        End Try

    End Sub


#End Region

#Region " Search Box"

    Private Sub RoundedCornerTextbox1_MouseClick(sender As Object, e As MouseEventArgs) Handles tb_Launcher.MouseClick
        ' SendKeys.Send("% ")

    End Sub
    Dim DoType As Boolean = True
    Private Sub tb_Launcher_TextChanged(sender As Object, e As EventArgs) Handles tb_Launcher.TextChanged
        KeepActivated = True
        Dim cont As Boolean = False
        If DoType Then
            For Each p As Process In Process.GetProcesses
                If p.ProcessName = "PowerToys" Then
                    cont = True
                End If
            Next
            If cont Then
                SendKeys.SendWait("% ")
                SendKeys.Send(tb_Launcher.Text)
                '  RoundedCornerTextbox1.Text = ""

                DoType = False
                tb_Launcher.Text = ""
            Else

                Try
                    Dim PowerToys As New ProcessStartInfo
                    With PowerToys
                        .UseShellExecute = True
                        .FileName = "C:\Program Files\PowerToys\PowerToys.exe"
                        .WindowStyle = ProcessWindowStyle.Minimized
                        .Verb = "runas"
                    End With
                    Process.Start(PowerToys)
                    timer_StartPowerToys.Start()

                Catch ex As Exception
                    ErrorMessage = ex.ToString

                End Try
            End If

        Else
            DoType = True
        End If


    End Sub
    Private Sub timer_StartPowerToys_Tick(sender As Object, e As EventArgs) Handles timer_StartPowerToys.Tick
        SendKeys.SendWait("% ")
        SendKeys.Send(tb_Launcher.Text)
        '  RoundedCornerTextbox1.Text = ""

        DoType = False
        tb_Launcher.Text = ""
        timer_StartPowerToys.Stop()
    End Sub

#End Region


#Region " Add Button / Drag/Drop"

    Public Sub AddButton(DragFile As String)
        ErrorMessage = "No info to display."

        KeepActivated = True
        Dim but As New LabledPicturebox
        NewAppName = ""
        NewAppImage = ""
        NewAppLocation = ""
        NewAppArguments = ""

        Try
            Me.TopMost = False
            Dim xform As New AddForm
            If IsDragDrop Then
                If DragFile <> Nothing Then

                    Dim IconFile As String = Application.StartupPath & "\test.png"
                    Dim IconFile2 As String = Application.StartupPath & "\test2.png"
                    Dim succeeded As Boolean = False

                    Dim IsINI As Boolean = False
                    Try
                        If IO.Path.GetExtension(DragFile) = ".lff" Then
                            Dim ini As New IniFile
                            ini.Load(DragFile)

                            NewAppLocation = ini.Sections("Info").Keys("Location").Value 'DragFile
                            NewAppName = ini.Sections("Info").Keys("Name").Value 'IO.Path.GetFileNameWithoutExtension(DragFile)
                            NewAppImage = ini.Sections("Info").Keys("IconLocation").Value ' IconFile
                            NewAppArguments = ini.Sections("Info").Keys("Arguments").Value

                            xform.tb_App.Text = NewAppLocation
                            xform.tb_Name.Text = NewAppName
                            xform.tb_Arguments.Text = NewAppArguments
                            xform.IconBox.Image = Image.FromFile(NewAppImage)
                            xform.NewImage = NewAppImage

                            IsINI = True
                        End If
                    Catch ex As Exception
                        ErrorMessage = ex.ToString
                        KeepActivated = True
                        Dim MyMessage As New MyMessageBox With {
                            .Text = "Error!"
                        }
                        MyMessage.label_Message.Text = Environment.NewLine & "Error loading file!"
                        ErrorMessage = ex.ToString
                        MyMessage.ShowDialog()
                    End Try

                    If IsINI = False Then
                        NewAppLocation = DragFile
                        NewAppName = IO.Path.GetFileNameWithoutExtension(DragFile)
                        Try
                            If IO.File.Exists(IconFile) Then
                                IO.File.Delete(IconFile)
                            End If
                            Icon.ExtractAssociatedIcon(DragFile).ToBitmap.Save(IconFile, Imaging.ImageFormat.Png)
                            succeeded = True
                        Catch ex As Exception
                            ErrorMessage = ex.ToString
                            If IO.File.Exists(IconFile2) Then
                                IO.File.Delete(IconFile2)
                            End If
                            Icon.ExtractAssociatedIcon(DragFile).ToBitmap.Save(IconFile2, Imaging.ImageFormat.Png)
                            succeeded = False
                        End Try

                        Try
                            If succeeded Then
                                NewAppImage = IconFile
                                xform.IconBox.Image = Image.FromFile(IconFile)
                            Else
                                NewAppImage = IconFile2
                                xform.IconBox.Image = Image.FromFile(IconFile2)
                            End If
                        Catch ex As Exception
                            ErrorMessage = ex.ToString
                            NewAppImage = IconFile2
                            xform.IconBox.Image = Image.FromFile(IconFile2)
                        End Try


                        xform.tb_App.Text = NewAppLocation
                        xform.tb_Name.Text = NewAppName

                    End If



                End If
            End If

            If xform.ShowDialog = DialogResult.OK Then
                but.Image = Image.FromFile(NewAppImage)
                but.Text = NewAppName & Environment.NewLine

                LauncherPanel.Controls.Add(but)


                but.AppName = NewAppName
                but.AppLocation = NewAppLocation
                but.AppArguments = NewAppArguments
                but.AppImage = NewAppImage

                My.Settings.Save()
                Try
                    AddHandler but.MouseEnter, AddressOf buttons_MouseEnter
                    AddHandler but.MouseLeave, AddressOf buttons_MouseLeave
                    ' AddHandler c.Click, AddressOf buttons_MouseClick
                    AddHandler but.Click, AddressOf but_True_MouseClick
                    AddHandler but.MouseMove, AddressOf buttons_MouseMove
                    AddHandler but.MouseDown, AddressOf buttons_MouseDown
                    AddHandler but.MouseUp, AddressOf buttons_mouseup
                Catch ex As Exception

                End Try
                ' Setup_Events()
            End If




        Catch ex As Exception
            ErrorMessage = ex.ToString
            KeepActivated = True
            Dim MyMessage As New MyMessageBox With {
                .Text = "Error!"
            }
            MyMessage.label_Message.Text = Environment.NewLine & "Error Adding Item!"
            If ex.ToString.Contains("Image.Fromfile(String") Then
                ErrorMessage = "Please add an image to item."
                ErrorMessage += ex.ToString
            Else
                ErrorMessage = ex.ToString
            End If

            MyMessage.ShowDialog()
            '   MsgBox("Error Adding Item!")
            but.Dispose()
        End Try



        Me.TopMost = My.Settings.TopMost

        KeepActivated = False

    End Sub
    Private Sub but_Add_Click(sender As Object, e As EventArgs) Handles but_Add.Click
        AddButton(Nothing)
    End Sub
    Private Sub form_Launcher_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Me.Activate()
        IsDragDrop = True
        Dim file As String() = e.Data.GetData(DataFormats.FileDrop)
        AddButton(file(0))
        IsDragDrop = False
    End Sub

    Private Sub form_Launcher_DragEnter(sender As Object, e As DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub


#End Region

#Region " Graphics"

    Private Sub panel_BottomBar_Paint(sender As Object, e As PaintEventArgs) Handles panel_BottomBar.Paint
        e.Graphics.DrawLine(Pens.Gray, 0, 0, panel_BottomBar.Width, 0)
    End Sub


#End Region



#Region " Hotkeys"

    Public hkr As New HotKeyRegistryClass(Me.Handle)
    Public Const MOD_ALT As Integer = &H1 'Alt key
    Public Const WM_HOTKEY As Integer = &H312

    <DllImport("User32.dll")>
    Public Shared Function RegisterHotKey(ByVal hwnd As IntPtr,
                        ByVal id As Integer, ByVal fsModifiers As Integer,
                        ByVal vk As Integer) As Integer
    End Function

    <DllImport("User32.dll")>
    Public Shared Function UnregisterHotKey(ByVal hwnd As IntPtr,
                        ByVal id As Integer) As Integer
    End Function

    Public Shared IsSettingsOpen As Boolean = False
    Private Sub but_Settings_Click(sender As Object, e As EventArgs) Handles but_Settings.Click
        Me.TopMost = False
        KeepActivated = True
        Dim xform As New form_Settings


        If xform.ShowDialog = DialogResult.OK Then
            Try
                UnregisterHotKey(Me.Handle, 1)
            Catch ex As Exception
                ErrorMessage = ex.ToString

            End Try
            Try
                RegisterHotKey(Me.Handle, 1, xform.ctrl Or xform.shift Or xform.alt, DirectCast([Enum].Parse(GetType(Keys), xform.key), Keys))
                My.Settings.ctrl = xform.ctrl
                My.Settings.alt = xform.alt
                My.Settings.shift = xform.shift
                My.Settings.key = xform.key
                My.Settings.Save()
            Catch ex As Exception
                ErrorMessage = ex.ToString

            End Try



        End If
        Me.TopMost = My.Settings.TopMost
        IsSettingsOpen = False
        KeepActivated = False
    End Sub

    Private WM_KEYUP As Integer = &H101
    Dim VK_ESCAPE As Integer = &H1B
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)

        If m.Msg = WM_HOTKEY Then

            Dim id As IntPtr = m.WParam
            Select Case (id.ToString)
                Case "0"

                Case "1"
                    If IsSettingsOpen Then

                        Return
                    End If
                    Me.Show()
                    'Me.SuspendLayout()
                    Me.WindowState = FormWindowState.Normal

                    Me.BringToFront()
                    ' Me.ResumeLayout()
                    Me.Activate()
                    CenterForm(Me, Nothing)


                Case "200"
                    'MessageBox.Show("You pressed ALT+C key combination")
            End Select

        ElseIf m.Msg = WM_KEYUP Then
            If m.WParam = Keys.Escape Then
                Me.WindowState = FormWindowState.Minimized
                HideMe.start
            End If

        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub LauncherPanel_Paint(sender As Object, e As PaintEventArgs) Handles LauncherPanel.Paint
        ' LauncherPanel.Padding = New Padding(0, 0, 15, 0)
    End Sub





#End Region

End Class


