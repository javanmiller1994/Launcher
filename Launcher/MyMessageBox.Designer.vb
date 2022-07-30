<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyMessageBox
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.but_Okay = New DevExpress.XtraEditors.SimpleButton()
        Me.label_Message = New System.Windows.Forms.Label()
        Me.panel_buttons = New System.Windows.Forms.Panel()
        Me.but_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.but_MoreInfo = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_MoreInfo = New System.Windows.Forms.Panel()
        Me.panel_buttons.SuspendLayout()
        Me.panel_MoreInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'but_Okay
        '
        Me.but_Okay.AllowFocus = False
        Me.but_Okay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.but_Okay.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.but_Okay.Appearance.Options.UseFont = True
        Me.but_Okay.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.but_Okay.Location = New System.Drawing.Point(15, 12)
        Me.but_Okay.Name = "but_Okay"
        Me.but_Okay.Size = New System.Drawing.Size(90, 40)
        Me.but_Okay.TabIndex = 0
        Me.but_Okay.Text = "Okay"
        '
        'label_Message
        '
        Me.label_Message.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label_Message.Location = New System.Drawing.Point(0, 24)
        Me.label_Message.MaximumSize = New System.Drawing.Size(220, 0)
        Me.label_Message.Name = "label_Message"
        Me.label_Message.Size = New System.Drawing.Size(220, 70)
        Me.label_Message.TabIndex = 1
        Me.label_Message.Text = "Are you sure?"
        Me.label_Message.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'panel_buttons
        '
        Me.panel_buttons.Controls.Add(Me.but_Cancel)
        Me.panel_buttons.Controls.Add(Me.but_Okay)
        Me.panel_buttons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_buttons.Location = New System.Drawing.Point(0, 97)
        Me.panel_buttons.Name = "panel_buttons"
        Me.panel_buttons.Size = New System.Drawing.Size(220, 65)
        Me.panel_buttons.TabIndex = 2
        '
        'but_Cancel
        '
        Me.but_Cancel.AllowFocus = False
        Me.but_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Cancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.but_Cancel.Appearance.Options.UseFont = True
        Me.but_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.but_Cancel.Location = New System.Drawing.Point(115, 12)
        Me.but_Cancel.Name = "but_Cancel"
        Me.but_Cancel.Size = New System.Drawing.Size(90, 40)
        Me.but_Cancel.TabIndex = 1
        Me.but_Cancel.Text = "Cancel"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'but_MoreInfo
        '
        Me.but_MoreInfo.AllowFocus = False
        Me.but_MoreInfo.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.but_MoreInfo.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.but_MoreInfo.Appearance.Options.UseFont = True
        Me.but_MoreInfo.Appearance.Options.UseForeColor = True
        Me.but_MoreInfo.Dock = System.Windows.Forms.DockStyle.Right
        Me.but_MoreInfo.Location = New System.Drawing.Point(149, 0)
        Me.but_MoreInfo.Name = "but_MoreInfo"
        Me.but_MoreInfo.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.but_MoreInfo.Size = New System.Drawing.Size(71, 21)
        Me.but_MoreInfo.TabIndex = 2
        Me.but_MoreInfo.Text = "More Info"
        '
        'panel_MoreInfo
        '
        Me.panel_MoreInfo.BackColor = System.Drawing.Color.Transparent
        Me.panel_MoreInfo.Controls.Add(Me.but_MoreInfo)
        Me.panel_MoreInfo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_MoreInfo.Location = New System.Drawing.Point(0, 0)
        Me.panel_MoreInfo.Name = "panel_MoreInfo"
        Me.panel_MoreInfo.Size = New System.Drawing.Size(220, 21)
        Me.panel_MoreInfo.TabIndex = 3
        '
        'MyMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 162)
        Me.Controls.Add(Me.panel_MoreInfo)
        Me.Controls.Add(Me.panel_buttons)
        Me.Controls.Add(Me.label_Message)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MyMessageBox"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Title"
        Me.panel_buttons.ResumeLayout(False)
        Me.panel_MoreInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents but_Okay As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents label_Message As Label
    Friend WithEvents panel_buttons As Panel
    Friend WithEvents but_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents but_MoreInfo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panel_MoreInfo As Panel
End Class
