Partial Public Class Form1
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.but_PlexDrive = New System.Windows.Forms.PictureBox()
        Me.but_Scripts = New System.Windows.Forms.PictureBox()
        Me.but_VirtualMonitor = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_PlexDrive, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_Scripts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.but_VirtualMonitor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(93, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Launch:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Launcher.My.Resources.Resources.Startup
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 75)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'but_PlexDrive
        '
        Me.but_PlexDrive.BackColor = System.Drawing.Color.Transparent
        Me.but_PlexDrive.BackgroundImage = Global.Launcher.My.Resources.Resources.Plex
        Me.but_PlexDrive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_PlexDrive.Location = New System.Drawing.Point(47, 93)
        Me.but_PlexDrive.Name = "but_PlexDrive"
        Me.but_PlexDrive.Size = New System.Drawing.Size(40, 40)
        Me.but_PlexDrive.TabIndex = 4
        Me.but_PlexDrive.TabStop = False
        '
        'but_Scripts
        '
        Me.but_Scripts.BackColor = System.Drawing.Color.Transparent
        Me.but_Scripts.BackgroundImage = Global.Launcher.My.Resources.Resources.Startup
        Me.but_Scripts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_Scripts.Location = New System.Drawing.Point(97, 93)
        Me.but_Scripts.Name = "but_Scripts"
        Me.but_Scripts.Size = New System.Drawing.Size(40, 40)
        Me.but_Scripts.TabIndex = 5
        Me.but_Scripts.TabStop = False
        '
        'but_VirtualMonitor
        '
        Me.but_VirtualMonitor.BackColor = System.Drawing.Color.Transparent
        Me.but_VirtualMonitor.BackgroundImage = Global.Launcher.My.Resources.Resources.Monitor
        Me.but_VirtualMonitor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.but_VirtualMonitor.Location = New System.Drawing.Point(143, 93)
        Me.but_VirtualMonitor.Name = "but_VirtualMonitor"
        Me.but_VirtualMonitor.Size = New System.Drawing.Size(40, 40)
        Me.but_VirtualMonitor.TabIndex = 6
        Me.but_VirtualMonitor.TabStop = False
        '
        'Form1
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 278)
        Me.Controls.Add(Me.but_VirtualMonitor)
        Me.Controls.Add(Me.but_Scripts)
        Me.Controls.Add(Me.but_PlexDrive)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Launcher"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_PlexDrive, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_Scripts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.but_VirtualMonitor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents but_PlexDrive As PictureBox
    Friend WithEvents but_Scripts As PictureBox
    Friend WithEvents but_VirtualMonitor As PictureBox

#End Region

End Class
