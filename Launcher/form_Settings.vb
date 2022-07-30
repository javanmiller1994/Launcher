Public Class form_Settings
    Private Sub form_Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cb_Hide.Checked = My.Settings.HideMe
        cb_Center.Checked = My.Settings.CenterForm
        cb_TopMost.Checked = My.Settings.TopMost

        form_Launcher.IsSettingsOpen = True
        Dim depressedKeys As New List(Of String)


        If My.Settings.ctrl <> 0 Then
            depressedKeys.Add("Ctrl")
            ctrl = HotKeyRegistryClass.Modifiers.MOD_CTRL
        End If

        If My.Settings.shift <> 0 Then
            depressedKeys.Add("Shift")
            shift = HotKeyRegistryClass.Modifiers.MOD_SHIFT
        End If

        If My.Settings.alt <> 0 Then
            depressedKeys.Add("Alt")
            alt = HotKeyRegistryClass.Modifiers.MOD_ALT
        End If


        key = My.Settings.key
        depressedKeys.Add(key)

        Me.tb_Hotkey.Text = String.Join(" + ", depressedKeys)
    End Sub

    Public Shared ctrl As Integer = My.Settings.ctrl
    Public Shared shift As Integer = My.Settings.shift
    Public Shared alt As Integer = My.Settings.alt
    Public Shared key As String
    Private Sub tb_Hotkey_KeyDown(sender As Object, e As KeyEventArgs) Handles tb_Hotkey.KeyDown
        Dim depressedKeys As New List(Of String)
        ctrl = 0
        shift = 0
        alt = 0

        If e.Control Then
            depressedKeys.Add("Ctrl")
            ctrl = HotKeyRegistryClass.Modifiers.MOD_CTRL
        End If

        If e.Shift Then
            depressedKeys.Add("Shift")
            shift = HotKeyRegistryClass.Modifiers.MOD_SHIFT
        End If

        If e.Alt Then
            depressedKeys.Add("Alt")
            alt = HotKeyRegistryClass.Modifiers.MOD_ALT
        End If

        If e.KeyCode >= Keys.A AndAlso e.KeyCode <= Keys.Z Or e.KeyCode = Keys.LWin Or e.KeyCode = Keys.RWin Then
            depressedKeys.Add(e.KeyCode.ToString())
            key = e.KeyCode.ToString()
        End If

        Me.tb_Hotkey.Text = String.Join(" + ", depressedKeys)


    End Sub

    Private Sub form_Settings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        form_Launcher.IsSettingsOpen = False
        form_Launcher.KeepActivated = False
    End Sub

    Private Sub but_Close_Click(sender As Object, e As EventArgs) Handles but_Close.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

    Private Sub cb_Center_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Center.CheckedChanged


    End Sub

    Private Sub cb_Hide_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Hide.CheckedChanged

    End Sub

    Private Sub but_Save_Click(sender As Object, e As EventArgs) Handles but_Save.Click
        My.Settings.HideMe = cb_Hide.Checked
        My.Settings.CenterForm = cb_Center.Checked
        My.Settings.TopMost = cb_TopMost.Checked

        My.Settings.Save()
    End Sub
End Class