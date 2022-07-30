Imports System.ComponentModel
Imports System.Drawing.Imaging

Public Class LabledPicturebox
    Inherits Panel

    Dim _Image As Image
    Dim _Text As String

    Dim _picturebox As New PictureBox
    Dim _label As New Label
    Dim _ImageHeight As Integer
    Dim _Opacity As Single
    Dim _TextVisible As Boolean = True
    Dim _TextExpand As Boolean = True

    Public Sub New()
        MyBase.New
        _ImageHeight = 43
        Me.Controls.Add(_label)
        Me.Controls.Add(_picturebox)
        _picturebox.Dock = DockStyle.Top
        _label.Dock = DockStyle.Bottom
        _picturebox.Height = ImageHeight
        _label.AutoSize = False
        _label.Height = 25

        _picturebox.BackgroundImage = _Image
        _label.TextAlign = ContentAlignment.MiddleCenter
        '  _label.Text = _Text & Environment.NewLine


    End Sub


    Public Property Image As Image
        Get
            Return _Image
        End Get
        Set(ByVal value As Image)
            _Image = value
            _picturebox.BackgroundImageLayout = ImageLayout.Zoom
            _picturebox.BackgroundImage = _Image
        End Set

    End Property
    Public Property ImageHeight As Integer
        Get
            Return _ImageHeight
        End Get
        Set(ByVal value As Integer)
            _ImageHeight = value
            _picturebox.Height = _ImageHeight
        End Set

    End Property
    Public Property TextVisible As Boolean
        Get
            Return _TextVisible
        End Get
        Set(ByVal value As Boolean)
            _TextVisible = value
            _label.Visible = _TextVisible
        End Set

    End Property

    Public Property AppName As String
    Public Property AppLocation As String
    Public Property AppArguments As String
    Public Property AppImage As String
    Public Property Startup As Boolean = False

    <Browsable(True)>
    Public Overrides Property Text() As String
        Get
            Return _Text
        End Get
        Set(ByVal Value As String)
            If _TextExpand Then
                _Text = Value & Environment.NewLine
            Else
                _Text = Value.Trim.Replace(Environment.NewLine, "").Replace(ChrW(13), "") _
                    .Replace(ChrW(10), "")
            End If
            _label.Text = _Text
        End Set
    End Property
    Public Property TextExpand As Boolean
        Get
            Return _TextExpand
        End Get
        Set(ByVal value As Boolean)
            _TextExpand = value
            If _TextExpand Then
                _Text &= Environment.NewLine
            Else
                _Text = _Text.Trim.Replace(Environment.NewLine, "").Replace(Global.Microsoft.VisualBasic.ChrW(13), "") _
                    .Replace(Global.Microsoft.VisualBasic.ChrW(10), "")
            End If
            _label.Text = _Text
        End Set

    End Property
    Public Property Opacity As Single
        Get
            Return _Opacity
        End Get
        Set(ByVal value As Single)
            _Opacity = value
            _picturebox.BackgroundImage = ChangeOpacity(_Image, _Opacity)
        End Set

    End Property

    <Browsable(False)>
    Public Overrides Property BackgroundImage As Image

    <Browsable(False)>
    Public Overrides Property BackgroundImageLayout As ImageLayout

    Protected Overrides Sub OnControlAdded(ByVal e As System.Windows.Forms.ControlEventArgs)
        AddHandler e.Control.MouseEnter, AddressOf domouseenter
        AddHandler e.Control.MouseLeave, AddressOf domouseleave
        AddHandler e.Control.Click, AddressOf doclick
        AddHandler e.Control.MouseClick, AddressOf domouseclick
        AddHandler e.Control.MouseDoubleClick, AddressOf doMouseDoubleClick
        AddHandler e.Control.MouseDown, AddressOf domousedown
        AddHandler e.Control.MouseUp, AddressOf domouseup
        AddHandler e.Control.MouseMove, AddressOf domousemove

    End Sub
    Private Sub domouseenter(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnMouseEnter(e)
    End Sub
    Private Sub doclick(ByVal sender As Object, ByVal e As EventArgs)

        Me.OnClick(e)

    End Sub
    Private Sub domouseclick(ByVal sender As Object, ByVal e As MouseEventArgs)

        Me.OnMouseClick(e)

    End Sub
    Private Sub doMouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)

        Me.OnMouseClick(e)

    End Sub
    Private Sub domouseleave(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnMouseLeave(e)
    End Sub

    Private Sub domousedown(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnMouseDown(e)
    End Sub
    Private Sub domouseup(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnMouseUp(e)
    End Sub
    Private Sub domousemove(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnMouseMove(e)
    End Sub
    Protected Overrides Sub OnControlRemoved(ByVal e As System.Windows.Forms.ControlEventArgs)
        RemoveHandler e.Control.MouseEnter, AddressOf domouseenter
        RemoveHandler e.Control.MouseLeave, AddressOf domouseleave
        RemoveHandler e.Control.Click, AddressOf doclick
        RemoveHandler e.Control.MouseClick, AddressOf domouseclick
        RemoveHandler e.Control.MouseDoubleClick, AddressOf doMouseDoubleClick
        RemoveHandler e.Control.MouseDown, AddressOf domousedown
        RemoveHandler e.Control.MouseUp, AddressOf domouseup
        RemoveHandler e.Control.MouseMove, AddressOf domousemove
    End Sub

    Public Shared Function ChangeOpacity(ByVal img As Image, ByVal opacityvalue As Single) As Bitmap
        Dim bmp As New Bitmap(img.Width, img.Height)
        Dim graphics__1 As Graphics = Graphics.FromImage(bmp)
        Dim colormatrix As New ColorMatrix With {
            .Matrix33 = opacityvalue
        }
        Dim imgAttribute As New ImageAttributes
        imgAttribute.SetColorMatrix(colormatrix, ColorMatrixFlag.[Default], ColorAdjustType.Bitmap)
        graphics__1.DrawImage(img, New Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, img.Width, img.Height,
         GraphicsUnit.Pixel, imgAttribute)
        graphics__1.Dispose()
        Return bmp
    End Function

End Class
