<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddForm))
        Me.Label_Name = New System.Windows.Forms.Label()
        Me.Label_App = New System.Windows.Forms.Label()
        Me.Label_Argument = New System.Windows.Forms.Label()
        Me.but_OK = New DevExpress.XtraEditors.SimpleButton()
        Me.but_Cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.but_Image = New DevExpress.XtraEditors.SimpleButton()
        Me.but_LoadFile = New DevExpress.XtraEditors.SimpleButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.but_ChangeLocation = New System.Windows.Forms.PictureBox()
        Me.but_Load = New Launcher.LabledPicturebox()
        Me.but_Export = New Launcher.LabledPicturebox()
        Me.tb_Arguments = New Launcher.RJTextBox()
        Me.tb_App = New Launcher.RJTextBox()
        Me.tb_Name = New Launcher.RJTextBox()
        Me.IconBox = New Launcher.LabledPicturebox()
        CType(Me.but_ChangeLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_Name
        '
        Me.Label_Name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Name.Location = New System.Drawing.Point(5, 15)
        Me.Label_Name.Name = "Label_Name"
        Me.Label_Name.Size = New System.Drawing.Size(115, 21)
        Me.Label_Name.TabIndex = 0
        Me.Label_Name.Text = "Name:"
        Me.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_App
        '
        Me.Label_App.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_App.Location = New System.Drawing.Point(5, 54)
        Me.Label_App.Name = "Label_App"
        Me.Label_App.Size = New System.Drawing.Size(115, 21)
        Me.Label_App.TabIndex = 0
        Me.Label_App.Text = "Location:"
        Me.Label_App.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_Argument
        '
        Me.Label_Argument.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Argument.Location = New System.Drawing.Point(5, 93)
        Me.Label_Argument.Name = "Label_Argument"
        Me.Label_Argument.Size = New System.Drawing.Size(115, 21)
        Me.Label_Argument.TabIndex = 0
        Me.Label_Argument.Text = "Arguments:"
        Me.Label_Argument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'but_OK
        '
        Me.but_OK.AllowFocus = False
        Me.but_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.but_OK.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.but_OK.Appearance.Options.UseFont = True
        Me.but_OK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.but_OK.Location = New System.Drawing.Point(12, 195)
        Me.but_OK.Name = "but_OK"
        Me.but_OK.Size = New System.Drawing.Size(134, 38)
        Me.but_OK.TabIndex = 2
        Me.but_OK.Text = "Add"
        '
        'but_Cancel
        '
        Me.but_Cancel.AllowFocus = False
        Me.but_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Cancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.but_Cancel.Appearance.Options.UseFont = True
        Me.but_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.but_Cancel.Location = New System.Drawing.Point(348, 195)
        Me.but_Cancel.Name = "but_Cancel"
        Me.but_Cancel.Size = New System.Drawing.Size(134, 38)
        Me.but_Cancel.TabIndex = 2
        Me.but_Cancel.Text = "Cancel"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(390, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Preview"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'but_Image
        '
        Me.but_Image.AllowFocus = False
        Me.but_Image.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Image.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.but_Image.Appearance.Options.UseFont = True
        Me.but_Image.Location = New System.Drawing.Point(12, 149)
        Me.but_Image.Name = "but_Image"
        Me.but_Image.Size = New System.Drawing.Size(134, 38)
        Me.but_Image.TabIndex = 5
        Me.but_Image.Text = "Choose Image"
        '
        'but_LoadFile
        '
        Me.but_LoadFile.AllowFocus = False
        Me.but_LoadFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.but_LoadFile.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.but_LoadFile.Appearance.Options.UseFont = True
        Me.but_LoadFile.Location = New System.Drawing.Point(152, 149)
        Me.but_LoadFile.Name = "but_LoadFile"
        Me.but_LoadFile.Size = New System.Drawing.Size(134, 38)
        Me.but_LoadFile.TabIndex = 8
        Me.but_LoadFile.Text = "Load From File"
        Me.but_LoadFile.Visible = False
        '
        'but_ChangeLocation
        '
        Me.but_ChangeLocation.BackColor = System.Drawing.Color.Transparent
        Me.but_ChangeLocation.BackgroundImage = Global.Launcher.My.Resources.Resources.Open_folder
        Me.but_ChangeLocation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_ChangeLocation.Location = New System.Drawing.Point(342, 50)
        Me.but_ChangeLocation.Name = "but_ChangeLocation"
        Me.but_ChangeLocation.Size = New System.Drawing.Size(28, 28)
        Me.but_ChangeLocation.TabIndex = 11
        Me.but_ChangeLocation.TabStop = False
        '
        'but_Load
        '
        Me.but_Load.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Load.AppArguments = Nothing
        Me.but_Load.AppImage = Nothing
        Me.but_Load.AppLocation = Nothing
        Me.but_Load.AppName = Nothing
        Me.but_Load.BackColor = System.Drawing.Color.Transparent
        Me.but_Load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.but_Load.Image = Global.Launcher.My.Resources.Resources.icons8_open_view_96
        Me.but_Load.ImageHeight = 27
        Me.but_Load.Location = New System.Drawing.Point(418, 139)
        Me.but_Load.Name = "but_Load"
        Me.but_Load.Opacity = 0!
        Me.but_Load.Size = New System.Drawing.Size(64, 50)
        Me.but_Load.Startup = False
        Me.but_Load.TabIndex = 10
        Me.but_Load.Text = "Load File"
        Me.but_Load.TextExpand = False
        Me.but_Load.TextVisible = True
        Me.ToolTip1.SetToolTip(Me.but_Load, "Load Launcher File")
        '
        'but_Export
        '
        Me.but_Export.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Export.AppArguments = Nothing
        Me.but_Export.AppImage = Nothing
        Me.but_Export.AppLocation = Nothing
        Me.but_Export.AppName = Nothing
        Me.but_Export.BackColor = System.Drawing.Color.Transparent
        Me.but_Export.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.but_Export.Image = Global.Launcher.My.Resources.Resources.icons8_save_96
        Me.but_Export.ImageHeight = 27
        Me.but_Export.Location = New System.Drawing.Point(348, 139)
        Me.but_Export.Name = "but_Export"
        Me.but_Export.Opacity = 0!
        Me.but_Export.Size = New System.Drawing.Size(64, 50)
        Me.but_Export.Startup = False
        Me.but_Export.TabIndex = 9
        Me.but_Export.Text = "Export"
        Me.but_Export.TextExpand = False
        Me.but_Export.TextVisible = True
        Me.ToolTip1.SetToolTip(Me.but_Export, "Save current settings to Launcher File")
        '
        'tb_Arguments
        '
        Me.tb_Arguments._ReadOnly = False
        Me.tb_Arguments.BackColor = System.Drawing.SystemColors.Window
        Me.tb_Arguments.BorderColor = System.Drawing.Color.Silver
        Me.tb_Arguments.BorderFocusColor = System.Drawing.Color.Silver
        Me.tb_Arguments.BorderRadius = 5
        Me.tb_Arguments.BorderSize = 1
        Me.tb_Arguments.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Arguments.ForeColor = System.Drawing.Color.Black
        Me.tb_Arguments.Location = New System.Drawing.Point(123, 87)
        Me.tb_Arguments.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Arguments.Multiline = False
        Me.tb_Arguments.Name = "tb_Arguments"
        Me.tb_Arguments.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.tb_Arguments.PasswordChar = False
        Me.tb_Arguments.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.tb_Arguments.PlaceholderText = ""
        Me.tb_Arguments.Size = New System.Drawing.Size(250, 32)
        Me.tb_Arguments.TabIndex = 7
        Me.tb_Arguments.UnderlinedStyle = False
        '
        'tb_App
        '
        Me.tb_App._ReadOnly = False
        Me.tb_App.BackColor = System.Drawing.SystemColors.Window
        Me.tb_App.BorderColor = System.Drawing.Color.Silver
        Me.tb_App.BorderFocusColor = System.Drawing.Color.Silver
        Me.tb_App.BorderRadius = 5
        Me.tb_App.BorderSize = 1
        Me.tb_App.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_App.ForeColor = System.Drawing.Color.Black
        Me.tb_App.Location = New System.Drawing.Point(123, 48)
        Me.tb_App.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_App.Multiline = False
        Me.tb_App.Name = "tb_App"
        Me.tb_App.Padding = New System.Windows.Forms.Padding(10, 7, 35, 7)
        Me.tb_App.PasswordChar = False
        Me.tb_App.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.tb_App.PlaceholderText = ""
        Me.tb_App.Size = New System.Drawing.Size(250, 32)
        Me.tb_App.TabIndex = 7
        Me.tb_App.UnderlinedStyle = False
        '
        'tb_Name
        '
        Me.tb_Name._ReadOnly = False
        Me.tb_Name.BackColor = System.Drawing.SystemColors.Window
        Me.tb_Name.BorderColor = System.Drawing.Color.Silver
        Me.tb_Name.BorderFocusColor = System.Drawing.Color.Silver
        Me.tb_Name.BorderRadius = 5
        Me.tb_Name.BorderSize = 1
        Me.tb_Name.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Name.ForeColor = System.Drawing.Color.Black
        Me.tb_Name.Location = New System.Drawing.Point(123, 9)
        Me.tb_Name.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Name.Multiline = False
        Me.tb_Name.Name = "tb_Name"
        Me.tb_Name.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.tb_Name.PasswordChar = False
        Me.tb_Name.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.tb_Name.PlaceholderText = ""
        Me.tb_Name.Size = New System.Drawing.Size(250, 32)
        Me.tb_Name.TabIndex = 6
        Me.tb_Name.UnderlinedStyle = False
        '
        'IconBox
        '
        Me.IconBox.AppArguments = Nothing
        Me.IconBox.AppImage = Nothing
        Me.IconBox.AppLocation = Nothing
        Me.IconBox.AppName = Nothing
        Me.IconBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.IconBox.Image = Global.Launcher.My.Resources.Resources.Blank
        Me.IconBox.ImageHeight = 43
        Me.IconBox.Location = New System.Drawing.Point(390, 36)
        Me.IconBox.Name = "IconBox"
        Me.IconBox.Opacity = 0!
        Me.IconBox.Size = New System.Drawing.Size(92, 78)
        Me.IconBox.Startup = False
        Me.IconBox.TabIndex = 3
        Me.IconBox.Text = "Item Name" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.IconBox.TextExpand = True
        Me.IconBox.TextVisible = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 248)
        Me.Controls.Add(Me.but_ChangeLocation)
        Me.Controls.Add(Me.but_Load)
        Me.Controls.Add(Me.but_Export)
        Me.Controls.Add(Me.but_LoadFile)
        Me.Controls.Add(Me.tb_Arguments)
        Me.Controls.Add(Me.tb_App)
        Me.Controls.Add(Me.tb_Name)
        Me.Controls.Add(Me.but_Image)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IconBox)
        Me.Controls.Add(Me.but_Cancel)
        Me.Controls.Add(Me.but_OK)
        Me.Controls.Add(Me.Label_Argument)
        Me.Controls.Add(Me.Label_Name)
        Me.Controls.Add(Me.Label_App)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Button"
        CType(Me.but_ChangeLocation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label_Name As Label
    Friend WithEvents Label_App As Label
    Friend WithEvents Label_Argument As Label
    Friend WithEvents but_OK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents but_Cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IconBox As LabledPicturebox
    Friend WithEvents Label1 As Label
    Friend WithEvents but_Image As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents tb_Name As RJTextBox
    Friend WithEvents tb_App As RJTextBox
    Friend WithEvents tb_Arguments As RJTextBox
    Friend WithEvents but_LoadFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents but_Export As LabledPicturebox
    Friend WithEvents but_Load As LabledPicturebox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents but_ChangeLocation As PictureBox
End Class
