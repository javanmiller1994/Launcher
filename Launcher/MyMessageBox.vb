Public Class MyMessageBox
    Private Sub label_Message_TextChanged(sender As Object, e As EventArgs) Handles label_Message.TextChanged
        resize()

    End Sub

    Public Shadows Sub resize()
        Dim height = TextRenderer.MeasureText(label_Message.CreateGraphics(), label_Message.Text, label_Message.Font, label_Message.Size, TextFormatFlags.WordBreak).Height

        If height > 70 Then
            label_Message.Height = height
            If label_Message.Height > 70 Then
                Me.Height = 201 + (label_Message.Height - 50)
            End If

        Else
            label_Message.Height = 70
            If label_Message.Height > 70 Then
                Me.Height = 201 + (label_Message.Height - 70)
            End If

        End If

    End Sub
    Public Function CalculateHeight(ByVal lbl As Label) As Integer
        Dim g As Graphics = lbl.CreateGraphics()
        Return Convert.ToInt32(g.MeasureString(lbl.Text, lbl.Font).Width)
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        resize()
        Timer1.Stop()
    End Sub

    Private Sub but_MoreInfo_Click(sender As Object, e As EventArgs) Handles but_MoreInfo.Click
        Dim xform As New MyMessageBox
        xform.but_MoreInfo.Visible = False
        xform.panel_buttons.Height = 40
        xform.label_Message.Font = New Font("Segoe UI", 9)
        xform.label_Message.TextAlign = ContentAlignment.TopLeft
        xform.but_Cancel.Text = "Close"
        xform.but_Okay.Dispose()
        xform.but_Cancel.Dock = DockStyle.Fill
        xform.Text = "Error Details"
        xform.label_Message.Text = form_Launcher.ErrorMessage
        xform.ShowDialog()

        '  MsgBox(form_Launcher.ErrorMessage)
    End Sub

    Private Sub MyMessageBox_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        '  form_Launcher.ErrorMessage = "No info to display."
    End Sub

    Private Sub MyMessageBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If form_Launcher.ErrorMessage = "" Then
            form_Launcher.ErrorMessage = "No info to display."
        End If
    End Sub
End Class