<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Launcher
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Launcher))
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LauncherPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.but_Exit = New System.Windows.Forms.PictureBox()
        Me.panel_BottomBar = New System.Windows.Forms.Panel()
        Me.but_Settings = New System.Windows.Forms.PictureBox()
        Me.but_Add = New System.Windows.Forms.PictureBox()
        Me.tb_Launcher = New Launcher.RJTextBox()
        Me.Menu_RightClick = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.MenuBut_Edit = New DevExpress.XtraBars.BarButtonItem()
        Me.MenuBut_Duplicate = New DevExpress.XtraBars.BarButtonItem()
        Me.MenuBut_OpenLocation = New DevExpress.XtraBars.BarButtonItem()
        Me.cb_Startup = New DevExpress.XtraBars.BarCheckItem()
        Me.MenuBut_Save = New DevExpress.XtraBars.BarButtonItem()
        Me.MenuBut_Delete = New DevExpress.XtraBars.BarButtonItem()
        Me.MenuBut_MoveLeft = New DevExpress.XtraBars.BarButtonItem()
        Me.MenuBut_MoveRight = New DevExpress.XtraBars.BarButtonItem()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RepositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.timer_StartPowerToys = New System.Windows.Forms.Timer(Me.components)
        Me.HideMe = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_BottomBar.SuspendLayout()
        CType(Me.but_Settings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_Add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_RightClick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Launcher.My.Resources.Resources.icons8_launch_96
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 30)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Launch"
        '
        'LauncherPanel
        '
        Me.LauncherPanel.AutoScroll = True
        Me.LauncherPanel.AutoScrollMinSize = New System.Drawing.Size(0, 253)
        Me.LauncherPanel.ColumnCount = 6
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.LauncherPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.LauncherPanel.Location = New System.Drawing.Point(12, 93)
        Me.LauncherPanel.MaximumSize = New System.Drawing.Size(592, 253)
        Me.LauncherPanel.MinimumSize = New System.Drawing.Size(592, 0)
        Me.LauncherPanel.Name = "LauncherPanel"
        Me.LauncherPanel.Padding = New System.Windows.Forms.Padding(0, 0, 17, 0)
        Me.LauncherPanel.RowCount = 3
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.LauncherPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.LauncherPanel.Size = New System.Drawing.Size(592, 253)
        Me.LauncherPanel.TabIndex = 12
        '
        'but_Exit
        '
        Me.but_Exit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Exit.BackColor = System.Drawing.Color.Transparent
        Me.but_Exit.BackgroundImage = CType(resources.GetObject("but_Exit.BackgroundImage"), System.Drawing.Image)
        Me.but_Exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Exit.Location = New System.Drawing.Point(529, 20)
        Me.but_Exit.Name = "but_Exit"
        Me.but_Exit.Size = New System.Drawing.Size(40, 40)
        Me.but_Exit.TabIndex = 15
        Me.but_Exit.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Exit, "Exit Launcher")
        '
        'panel_BottomBar
        '
        Me.panel_BottomBar.BackColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(231, Byte), Integer))
        Me.panel_BottomBar.Controls.Add(Me.but_Settings)
        Me.panel_BottomBar.Controls.Add(Me.but_Add)
        Me.panel_BottomBar.Controls.Add(Me.but_Exit)
        Me.panel_BottomBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel_BottomBar.Location = New System.Drawing.Point(0, 352)
        Me.panel_BottomBar.Name = "panel_BottomBar"
        Me.panel_BottomBar.Size = New System.Drawing.Size(616, 72)
        Me.panel_BottomBar.TabIndex = 16
        '
        'but_Settings
        '
        Me.but_Settings.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Settings.BackColor = System.Drawing.Color.Transparent
        Me.but_Settings.BackgroundImage = Global.Launcher.My.Resources.Resources.Settings_small
        Me.but_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Settings.Location = New System.Drawing.Point(40, 20)
        Me.but_Settings.Name = "but_Settings"
        Me.but_Settings.Size = New System.Drawing.Size(40, 40)
        Me.but_Settings.TabIndex = 16
        Me.but_Settings.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Settings, "Change Settings")
        '
        'but_Add
        '
        Me.but_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.but_Add.BackColor = System.Drawing.Color.Transparent
        Me.but_Add.BackgroundImage = Global.Launcher.My.Resources.Resources.Plus
        Me.but_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Add.Location = New System.Drawing.Point(483, 20)
        Me.but_Add.Name = "but_Add"
        Me.but_Add.Size = New System.Drawing.Size(40, 40)
        Me.but_Add.TabIndex = 16
        Me.but_Add.TabStop = False
        Me.ToolTip1.SetToolTip(Me.but_Add, "Add Item to Launcher")
        '
        'tb_Launcher
        '
        Me.tb_Launcher._ReadOnly = False
        Me.tb_Launcher.BackColor = System.Drawing.SystemColors.Window
        Me.tb_Launcher.BorderColor = System.Drawing.Color.Silver
        Me.tb_Launcher.BorderFocusColor = System.Drawing.Color.Silver
        Me.tb_Launcher.BorderRadius = 5
        Me.tb_Launcher.BorderSize = 1
        Me.tb_Launcher.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_Launcher.ForeColor = System.Drawing.Color.Black
        Me.tb_Launcher.Location = New System.Drawing.Point(43, 12)
        Me.tb_Launcher.Margin = New System.Windows.Forms.Padding(4)
        Me.tb_Launcher.Multiline = False
        Me.tb_Launcher.Name = "tb_Launcher"
        Me.tb_Launcher.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.tb_Launcher.PasswordChar = False
        Me.tb_Launcher.PlaceholderColor = System.Drawing.Color.DarkGray
        Me.tb_Launcher.PlaceholderText = ""
        Me.tb_Launcher.Size = New System.Drawing.Size(561, 32)
        Me.tb_Launcher.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.tb_Launcher, "Search with Launcher")
        Me.tb_Launcher.UnderlinedStyle = False
        '
        'Menu_RightClick
        '
        Me.Menu_RightClick.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.MenuBut_Edit), New DevExpress.XtraBars.LinkPersistInfo(Me.MenuBut_Duplicate), New DevExpress.XtraBars.LinkPersistInfo(Me.MenuBut_OpenLocation, True), New DevExpress.XtraBars.LinkPersistInfo(Me.cb_Startup), New DevExpress.XtraBars.LinkPersistInfo(Me.MenuBut_Save, True), New DevExpress.XtraBars.LinkPersistInfo(Me.MenuBut_Delete), New DevExpress.XtraBars.LinkPersistInfo(Me.MenuBut_MoveLeft), New DevExpress.XtraBars.LinkPersistInfo(Me.MenuBut_MoveRight)})
        Me.Menu_RightClick.Manager = Me.BarManager1
        Me.Menu_RightClick.Name = "Menu_RightClick"
        '
        'MenuBut_Edit
        '
        Me.MenuBut_Edit.Caption = "Edit"
        Me.MenuBut_Edit.Id = 2
        Me.MenuBut_Edit.Name = "MenuBut_Edit"
        '
        'MenuBut_Duplicate
        '
        Me.MenuBut_Duplicate.Caption = "Duplicate"
        Me.MenuBut_Duplicate.Id = 15
        Me.MenuBut_Duplicate.Name = "MenuBut_Duplicate"
        '
        'MenuBut_OpenLocation
        '
        Me.MenuBut_OpenLocation.Caption = "Open File Location"
        Me.MenuBut_OpenLocation.Id = 14
        Me.MenuBut_OpenLocation.Name = "MenuBut_OpenLocation"
        '
        'cb_Startup
        '
        Me.cb_Startup.Caption = "Run at Startup"
        Me.cb_Startup.Id = 1
        Me.cb_Startup.Name = "cb_Startup"
        '
        'MenuBut_Save
        '
        Me.MenuBut_Save.Caption = "Export"
        Me.MenuBut_Save.Id = 3
        Me.MenuBut_Save.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MenuBut_Save.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Green
        Me.MenuBut_Save.ItemAppearance.Normal.Options.UseFont = True
        Me.MenuBut_Save.ItemAppearance.Normal.Options.UseForeColor = True
        Me.MenuBut_Save.Name = "MenuBut_Save"
        ToolTipTitleItem1.Text = "Save Button to File"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        Me.MenuBut_Save.SuperTip = SuperToolTip1
        '
        'MenuBut_Delete
        '
        Me.MenuBut_Delete.Caption = "Delete"
        Me.MenuBut_Delete.Id = 0
        Me.MenuBut_Delete.ItemAppearance.Hovered.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MenuBut_Delete.ItemAppearance.Hovered.Options.UseFont = True
        Me.MenuBut_Delete.ItemAppearance.Normal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.MenuBut_Delete.ItemAppearance.Normal.ForeColor = System.Drawing.Color.Maroon
        Me.MenuBut_Delete.ItemAppearance.Normal.Options.UseFont = True
        Me.MenuBut_Delete.ItemAppearance.Normal.Options.UseForeColor = True
        Me.MenuBut_Delete.Name = "MenuBut_Delete"
        '
        'MenuBut_MoveLeft
        '
        Me.MenuBut_MoveLeft.Caption = "←"
        Me.MenuBut_MoveLeft.Id = 10
        Me.MenuBut_MoveLeft.Name = "MenuBut_MoveLeft"
        Me.MenuBut_MoveLeft.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'MenuBut_MoveRight
        '
        Me.MenuBut_MoveRight.Caption = "→"
        Me.MenuBut_MoveRight.Id = 11
        Me.MenuBut_MoveRight.Name = "MenuBut_MoveRight"
        Me.MenuBut_MoveRight.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.MenuBut_Delete, Me.cb_Startup, Me.MenuBut_Edit, Me.MenuBut_Save, Me.MenuBut_MoveLeft, Me.MenuBut_MoveRight, Me.MenuBut_OpenLocation, Me.MenuBut_Duplicate})
        Me.BarManager1.MaxItemId = 16
        Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemSpinEdit1})
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(616, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 424)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(616, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 424)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(616, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 424)
        '
        'RepositoryItemSpinEdit1
        '
        Me.RepositoryItemSpinEdit1.AutoHeight = False
        Me.RepositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemSpinEdit1.Name = "RepositoryItemSpinEdit1"
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.White
        Me.ToolTip1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'timer_StartPowerToys
        '
        Me.timer_StartPowerToys.Interval = 3500
        '
        'HideMe
        '
        Me.HideMe.Interval = 750
        '
        'form_Launcher
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 463)
        Me.Controls.Add(Me.LauncherPanel)
        Me.Controls.Add(Me.panel_BottomBar)
        Me.Controls.Add(Me.tb_Launcher)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(632, 463)
        Me.MinimumSize = New System.Drawing.Size(632, 463)
        Me.Name = "form_Launcher"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Launcher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_BottomBar.ResumeLayout(False)
        CType(Me.but_Settings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_Add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_RightClick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LauncherPanel As TableLayoutPanel
    Friend WithEvents tb_Launcher As RJTextBox
    Friend WithEvents but_Exit As PictureBox
    Friend WithEvents panel_BottomBar As Panel
    Friend WithEvents but_Add As PictureBox
    Friend WithEvents Menu_RightClick As DevExpress.XtraBars.PopupMenu
    Friend WithEvents MenuBut_Delete As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents cb_Startup As DevExpress.XtraBars.BarCheckItem
    Friend WithEvents MenuBut_Edit As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents but_Settings As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents timer_StartPowerToys As Timer
    Friend WithEvents MenuBut_Save As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuBut_MoveLeft As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuBut_MoveRight As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RepositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents HideMe As Timer
    Friend WithEvents MenuBut_OpenLocation As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents MenuBut_Duplicate As DevExpress.XtraBars.BarButtonItem
End Class
