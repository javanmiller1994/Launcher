Imports System.Text
Imports MadMilkman.Ini

Public Class AddForm

    Public Shared NewImage As String

    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        but_Export.Image = My.Resources.icons8_save_96
        but_Load.Image = My.Resources.icons8_open_view_96
    End Sub

    Private Sub but_OK_Click(sender As Object, e As EventArgs) Handles but_OK.Click

        form_Launcher.NewAppName = tb_Name.Text
        If NewImage = "" Then
            Try
                NewImage = form_Launcher.NewAppImage
            Catch ex As Exception
                NewImage = Application.StartupPath & "\Blank.png"
            End Try


        End If


        form_Launcher.NewAppImage = NewImage
        form_Launcher.NewAppLocation = tb_App.Text
        form_Launcher.NewAppArguments = tb_Arguments.Text
    End Sub


    Private Sub tb_App_MouseClick(sender As Object, e As MouseEventArgs) Handles but_ChangeLocation.Click ', tb_App.MouseClick
        Dim filechooser As New OpenFileDialog With {
            .Title = "Locate the Desired App",
            .Filter = "Applications (*.exe) |*.exe|All Files |*.*"
        }
        If filechooser.ShowDialog = DialogResult.OK Then
            tb_App.Text = filechooser.FileName
        End If


    End Sub



    Private Sub tb_Name_TextChanged(sender As Object, e As EventArgs) Handles tb_Name.TextChanged
        IconBox.Text = tb_Name.Text
    End Sub

    Private Sub but_Image_Click(sender As Object, e As EventArgs) Handles but_Image.Click
        Dim ImagePicker As New OpenFileDialog With {
            .Title = "Choose Image for App",
            .FileName = "Choose Image for App",
            .Filter = "PNG Image Files (*.png) |*.png|Other Image Files (*.jpg *.bmp) |*.jpg; *.jpeg; *.bmp|All Files |*.*"
        }
        If ImagePicker.ShowDialog = DialogResult.OK Then
            NewImage = ImagePicker.FileName
            IconBox.Image = Image.FromFile(NewImage)

        End If
    End Sub

    Private Sub but_Cancel_Click(sender As Object, e As EventArgs) Handles but_Cancel.Click
        Me.Dispose()

    End Sub

    Private Sub but_Load_Click(sender As Object, e As EventArgs) Handles but_Load.Click
        Dim Loader As New OpenFileDialog With {
            .Title = "Load Launcher File",
            .FileName = "Load Launcher File",
            .Filter = "Launcher File|*.lff"
        }
        If Loader.ShowDialog = DialogResult.OK Then
            If IO.Path.GetExtension(Loader.FileName) = ".lff" Then
                Dim ini As New IniFile
                ini.Load(Loader.FileName)

                tb_App.Text = ini.Sections("Info").Keys("Location").Value 'DragFile
                tb_Name.Text = ini.Sections("Info").Keys("Name").Value 'IO.Path.GetFileNameWithoutExtension(DragFile)
                tb_Arguments.Text = ini.Sections("Info").Keys("Arguments").Value
                NewImage = ini.Sections("Info").Keys("IconLocation").Value ' IconFile
                IconBox.Image = Image.FromFile(NewImage) ' IconFile)


            End If





        End If

    End Sub

    Private Sub but_Export_Click(sender As Object, e As EventArgs) Handles but_Export.Click
        Dim ini As New IniFile(New IniOptions() With {.Encoding = Encoding.Unicode})
        Dim Saver As New SaveFileDialog


        ini.Sections.Add("Info")
        ini.Sections("Info").Keys.Add("Location")
        ini.Sections("Info").Keys.Add("Name")
        ini.Sections("Info").Keys.Add("Arguments")
        ini.Sections("Info").Keys.Add("IconLocation")



        Dim AppLocation As String = tb_App.Text
        Dim AppName As String = tb_Name.Text
        Dim AppArguments As String = tb_Arguments.Text
        Dim AppIcon As String = NewImage



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

    Private Sub but_ChangeLocation_MouseEnter(sender As Object, e As EventArgs) Handles but_ChangeLocation.MouseEnter
        sender.backcolor = Color.FromArgb(210, 210, 210)
    End Sub
    Private Sub but_ChangeLocation_MouseLeave(sender As Object, e As EventArgs) Handles but_ChangeLocation.MouseLeave
        sender.backcolor = Color.Transparent
    End Sub

    Private Sub buttons_MouseEnter(sender As Object, e As EventArgs) Handles but_Export.MouseEnter, but_Load.MouseEnter
        sender.backcolor = Color.FromArgb(255, 255, 255)
    End Sub
    Private Sub buttons_MouseLeave(sender As Object, e As EventArgs) Handles but_Export.MouseLeave, but_Load.MouseLeave
        sender.backcolor = Color.Transparent
    End Sub
    Public Sub buttons_MouseDown(sender As Object, e As MouseEventArgs) Handles but_Load.MouseDown, but_Export.MouseDown
        sender.ImageHeight = 23
    End Sub
    Public Sub buttons_mouseup(sender As Object, e As MouseEventArgs) Handles but_Load.MouseUp, but_Export.MouseUp
        sender.ImageHeight = 27

    End Sub

    Private Sub AddForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        form_Launcher.KeepActivated = False
    End Sub


End Class