<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Settings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.but_Save = New DevExpress.XtraEditors.SimpleButton()
        Me.but_Close = New DevExpress.XtraEditors.SimpleButton()
        Me.tb_Hotkey = New Launcher.RJTextBox()
        Me.cb_Center = New DevExpress.XtraEditors.CheckEdit()
        Me.cb_Hide = New DevExpress.XtraEditors.CheckEdit()
        Me.cb_TopMost = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.cb_Center.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_Hide.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_TopMost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Set Hotkey to Open:"
        '
        'but_Save
        '
        Me.but_Save.AllowFocus = False
        Me.but_Save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.but_Save.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_Save.Appearance.Options.UseFont = True
        Me.but_Save.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.but_Save.Location = New System.Drawing.Point(12, 173)
        Me.but_Save.Name = "but_Save"
        Me.but_Save.Size = New System.Drawing.Size(90, 33)
        Me.but_Save.TabIndex = 2
        Me.but_Save.Text = "Save"
        '
        'but_Close
        '
        Me.but_Close.AllowFocus = False
        Me.but_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Close.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.but_Close.Appearance.Options.UseFont = True
        Me.but_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.but_Close.Location = New System.Drawing.Point(183, 173)
        Me.but_Close.Name = "but_Close"
        Me.but_Close.Size = New System.Drawing.Size(90, 33)
        Me.but_Close.TabIndex = 3
        Me.but_Close.Text = "Close"
        '
        'tb_Hotkey
        '
        Me.tb_Hotkey._ReadOnly = True
        Me.tb_Hotkey.BackColor = System.Drawing.SystemColors.Window
        Me.tb_Hotkey.BorderColor = System.Drawing.Color.Silver
        Me.tb_Hotkey.BorderFocusColor = System.Drawing.Color.Silver
        Me.tb_Hotkey.BorderRadius = 5
        Me.tb_Hotkey.BorderSize = 1
        Me.tb_Hotkey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Hotkey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tb_Hotkey.Location = New System.Drawing.Point(16, 33)
        Me.tb_Hotkey.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Hotkey.Multiline = False
        Me.tb_Hotkey.Name = "tb_Hotkey"
        Me.tb_Hotkey.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.tb_Hotkey.PasswordChar = False
        Me.tb_Hotkey.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.tb_Hotkey.PlaceholderText = ""
        Me.tb_Hotkey.Size = New System.Drawing.Size(250, 31)
        Me.tb_Hotkey.TabIndex = 1
        Me.tb_Hotkey.UnderlinedStyle = False
        '
        'cb_Center
        '
        Me.cb_Center.Location = New System.Drawing.Point(16, 71)
        Me.cb_Center.Name = "cb_Center"
        Me.cb_Center.Properties.AllowFocused = False
        Me.cb_Center.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Center.Properties.Appearance.Options.UseFont = True
        Me.cb_Center.Properties.AutoWidth = True
        Me.cb_Center.Properties.Caption = "Center Launcher"
        Me.cb_Center.Properties.FullFocusRect = True
        Me.cb_Center.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cb_Center.Size = New System.Drawing.Size(135, 25)
        Me.cb_Center.TabIndex = 5
        '
        'cb_Hide
        '
        Me.cb_Hide.Location = New System.Drawing.Point(16, 102)
        Me.cb_Hide.Name = "cb_Hide"
        Me.cb_Hide.Properties.AllowFocused = False
        Me.cb_Hide.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Hide.Properties.Appearance.Options.UseFont = True
        Me.cb_Hide.Properties.AutoWidth = True
        Me.cb_Hide.Properties.Caption = "Hide on Deactivate"
        Me.cb_Hide.Properties.FullFocusRect = True
        Me.cb_Hide.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cb_Hide.Size = New System.Drawing.Size(151, 25)
        Me.cb_Hide.TabIndex = 6
        '
        'cb_TopMost
        '
        Me.cb_TopMost.Location = New System.Drawing.Point(16, 133)
        Me.cb_TopMost.Name = "cb_TopMost"
        Me.cb_TopMost.Properties.AllowFocused = False
        Me.cb_TopMost.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_TopMost.Properties.Appearance.Options.UseFont = True
        Me.cb_TopMost.Properties.AutoWidth = True
        Me.cb_TopMost.Properties.Caption = "Keep On Top"
        Me.cb_TopMost.Properties.FullFocusRect = True
        Me.cb_TopMost.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.cb_TopMost.Size = New System.Drawing.Size(110, 25)
        Me.cb_TopMost.TabIndex = 7
        '
        'form_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 218)
        Me.Controls.Add(Me.cb_TopMost)
        Me.Controls.Add(Me.cb_Hide)
        Me.Controls.Add(Me.cb_Center)
        Me.Controls.Add(Me.but_Close)
        Me.Controls.Add(Me.but_Save)
        Me.Controls.Add(Me.tb_Hotkey)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        CType(Me.cb_Center.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_Hide.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_TopMost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_Hotkey As RJTextBox
    Friend WithEvents but_Save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents but_Close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cb_Center As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cb_Hide As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cb_TopMost As DevExpress.XtraEditors.CheckEdit
End Class
