Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D


<DefaultEvent("_TextChanged")>
Partial Public Class RJTextBox
    Inherits UserControl

    Private _borderColor As Color = Color.MediumSlateBlue
    Private _borderFocusColor As Color = Color.HotPink
    Private _borderSize As Integer = 2
    Private _underlinedStyle As Boolean = False
    Private _isFocused As Boolean = False
    Private _borderRadius As Integer = 0
    Private _placeholderColor As Color = Color.DarkGray
    Private _placeholderText As String = ""
    Private _isPlaceholder As Boolean = False
    Private _isPasswordChar As Boolean = False
    Public Event _TextChanged As EventHandler

    Public Sub New()
        InitializeComponent()
    End Sub

    Private components As System.ComponentModel.IContainer = Nothing
    Private textBox1 As New System.Windows.Forms.TextBox

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If

        MyBase.Dispose(disposing)
    End Sub
    Private Sub InitializeComponent()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        Me.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textBox1.Location = New System.Drawing.Point(10, 7)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(230, 15)
        Me.textBox1.TabIndex = 0
        AddHandler Me.textBox1.Click, AddressOf textBox1_Click
        AddHandler Me.textBox1.TextChanged, AddressOf textBox1_TextChanged
        AddHandler Me.textBox1.Enter, AddressOf textBox1_Enter
        AddHandler Me.textBox1.KeyPress, AddressOf textBox1_KeyPress
        AddHandler Me.textBox1.KeyDown, AddressOf textBox1_KeyDown
        AddHandler Me.textBox1.KeyUp, AddressOf textBox1_KeyUp
        AddHandler Me.textBox1.Leave, AddressOf textBox1_Leave
        AddHandler Me.textBox1.MouseEnter, AddressOf textBox1_MouseEnter
        AddHandler Me.textBox1.MouseLeave, AddressOf textBox1_MouseLeave
        AddHandler Me.textBox1.MouseClick, AddressOf textBox1_MouseClick
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.Controls.Add(Me.textBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
        Me.ForeColor = System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((64)))))), (CInt(((CByte((64)))))))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "RJTextBox"
        Me.Padding = New System.Windows.Forms.Padding(10, 7, 10, 7)
        Me.Size = New System.Drawing.Size(250, 30)
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub




    <Category("RJ Code Advance")>
    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(ByVal value As Color)
            _borderColor = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderFocusColor As Color
        Get
            Return _borderFocusColor
        End Get
        Set(ByVal value As Color)
            _borderFocusColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderSize As Integer
        Get
            Return _borderSize
        End Get
        Set(ByVal value As Integer)

            If value >= 1 Then
                _borderSize = value
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property UnderlinedStyle As Boolean
        Get
            Return _underlinedStyle
        End Get
        Set(ByVal value As Boolean)
            _underlinedStyle = value
            Me.Invalidate()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property PasswordChar As Boolean
        Get
            Return _isPasswordChar
        End Get
        Set(ByVal value As Boolean)
            _isPasswordChar = value
            If Not _isPlaceholder Then textBox1.UseSystemPasswordChar = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property Multiline As Boolean
        Get
            Return textBox1.Multiline
        End Get
        Set(ByVal value As Boolean)
            textBox1.Multiline = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property _ReadOnly As Boolean
        Get
            Return textBox1.ReadOnly
        End Get
        Set(ByVal value As Boolean)
            textBox1.ReadOnly = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property BackColor As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            MyBase.BackColor = value
            textBox1.BackColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property ForeColor As Color
        Get
            Return MyBase.ForeColor
        End Get
        Set(ByVal value As Color)
            MyBase.ForeColor = value
            textBox1.ForeColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property Font As Font
        Get
            Return MyBase.Font
        End Get
        Set(ByVal value As Font)
            MyBase.Font = value
            textBox1.Font = value
            If Me.DesignMode Then UpdateControlHeight()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Overrides Property Text As String
        Get

            If _isPlaceholder Then
                Return ""
            Else
                Return textBox1.Text
            End If
        End Get
        Set(ByVal value As String)
            textBox1.Text = value
            SetPlaceholder()
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property BorderRadius As Integer
        Get
            Return _borderRadius
        End Get
        Set(ByVal value As Integer)

            If value >= 0 Then
                _borderRadius = value
                Me.Invalidate()
            End If
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property PlaceholderColor As Color
        Get
            Return _placeholderColor
        End Get
        Set(ByVal value As Color)
            _placeholderColor = value
            If _isPlaceholder Then textBox1.ForeColor = value
        End Set
    End Property

    <Category("RJ Code Advance")>
    Public Property PlaceholderText As String
        Get
            Return _placeholderText
        End Get
        Set(ByVal value As String)
            _placeholderText = value
            textBox1.Text = ""
            SetPlaceholder()
        End Set
    End Property

    Protected Overrides Sub OnResize(ByVal e As EventArgs)
        MyBase.OnResize(e)
        If Me.DesignMode Then UpdateControlHeight()
    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        MyBase.OnLoad(e)
        UpdateControlHeight()
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim graph As Graphics = e.Graphics

        If BorderRadius > 1 Then
            Dim rectBorderSmooth = Me.ClientRectangle
            Dim rectBorder = Rectangle.Inflate(rectBorderSmooth, -BorderSize, -BorderSize)
            Dim smoothSize As Integer = If(BorderSize > 0, BorderSize, 1)

            Using pathBorderSmooth As GraphicsPath = GetFigurePath(rectBorderSmooth, BorderRadius)

                Using pathBorder As GraphicsPath = GetFigurePath(rectBorder, BorderRadius - BorderSize)

                    Using penBorderSmooth As New Pen(Me.Parent.BackColor, smoothSize)

                        Using penBorder As New Pen(BorderColor, BorderSize)
                            Me.Region = New Region(pathBorderSmooth)
                            If BorderRadius > 15 Then SetTextBoxRoundedRegion()
                            graph.SmoothingMode = SmoothingMode.AntiAlias
                            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center
                            If _isFocused Then penBorder.Color = _borderFocusColor

                            If UnderlinedStyle Then
                                graph.DrawPath(penBorderSmooth, pathBorderSmooth)
                                graph.SmoothingMode = SmoothingMode.None
                                graph.DrawLine(penBorder, 0, Me.Height - 1, Me.Width, Me.Height - 1)
                            Else
                                graph.DrawPath(penBorderSmooth, pathBorderSmooth)
                                graph.DrawPath(penBorder, pathBorder)
                                '  Dim BluePen1 As New Pen(Color.FromArgb(0, 103, 192), 3)
                                '  graph.DrawLine(BluePen1, 0, Me.Height - 1, Me.Width, Me.Height - 1)
                            End If
                        End Using
                    End Using
                End Using
            End Using

        Else

            Using penBorder As New Pen(BorderColor, BorderSize)
                Me.Region = New Region(Me.ClientRectangle)
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset
                If _isFocused Then penBorder.Color = _borderFocusColor

                If UnderlinedStyle Then
                    graph.DrawLine(penBorder, 0, Me.Height - 1, Me.Width, Me.Height - 1)
                Else
                    '  graph.DrawLine(BluePen, 0, Me.Height - 5, Me.Width, Me.Height - 5)
                    graph.DrawRectangle(penBorder, 0, 0, Me.Width - 0.5F, Me.Height - 0.5F)
                End If
            End Using


        End If
        Dim rect As New Rectangle(0, 0, MyBase.Width, MyBase.Height)
        Dim BluePen As New Pen(Color.FromArgb(0, 103, 192), 3)
        Dim p1 As New PointF(0, rect.Height)
        Dim p2 As New PointF(rect.Height, rect.Width)
        Dim g2 As Graphics = e.Graphics
        '  g2.DrawLine(BluePen, 0, rect.Height - 10, rect.Width, rect.Height - 10)
        graph.DrawLine(BluePen, 0, Me.Height - 1, Me.Width, Me.Height - 1)

    End Sub

    Private Sub SetPlaceholder()
        If String.IsNullOrWhiteSpace(textBox1.Text) AndAlso PlaceholderText <> "" Then
            _isPlaceholder = True
            textBox1.Text = PlaceholderText
            textBox1.ForeColor = PlaceholderColor
            If _isPasswordChar Then textBox1.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub RemovePlaceholder()
        If _isPlaceholder AndAlso PlaceholderText <> "" Then
            _isPlaceholder = False
            textBox1.Text = ""
            textBox1.ForeColor = Me.ForeColor
            If _isPasswordChar Then textBox1.UseSystemPasswordChar = True
        End If
    End Sub

    Private Function GetFigurePath(ByVal rect As Rectangle, ByVal radius As Integer) As GraphicsPath
        Dim path As New GraphicsPath()
        Dim curveSize As Single = radius * 2.0F
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90)
        path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90)
        path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90)
        path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90)
        path.CloseFigure()
        Return path
    End Function

    Private Sub SetTextBoxRoundedRegion()
        Dim pathTxt As GraphicsPath

        If Multiline Then
            pathTxt = GetFigurePath(textBox1.ClientRectangle, BorderRadius - BorderSize)
            textBox1.Region = New Region(pathTxt)
        Else
            pathTxt = GetFigurePath(textBox1.ClientRectangle, BorderSize * 2)
            textBox1.Region = New Region(pathTxt)
        End If

        pathTxt.Dispose()
    End Sub

    Private Sub UpdateControlHeight()
        If textBox1.Multiline = False Then
            Dim txtHeight As Integer = TextRenderer.MeasureText("Text", Me.Font).Height + 1
            textBox1.Multiline = True
            textBox1.MinimumSize = New Size(0, txtHeight)
            textBox1.Multiline = False
            Me.Height = textBox1.Height + Me.Padding.Top + Me.Padding.Bottom
        End If
    End Sub

    Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnTextChanged(e)
        RaiseEvent _TextChanged(sender, e)
        '  If _TextChanged IsNot Nothing Then _TextChanged.Invoke(sender, e)
    End Sub

    Private Sub textBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnClick(e)
    End Sub
    Private Sub textBox1_MouseClick(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnMouseClick(e)
    End Sub
    Private Sub textBox1_MouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnMouseEnter(e)
    End Sub

    Private Sub textBox1_MouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        Me.OnMouseLeave(e)
    End Sub

    Private Sub textBox1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        Me.OnKeyPress(e)
    End Sub
    Private Sub textBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
        Me.OnKeyDown(e)
    End Sub

    Private Sub textBox1_Keyup(ByVal sender As Object, ByVal e As KeyEventArgs)
        Me.OnKeyUp(e)
    End Sub

    Private Sub textBox1_Enter(ByVal sender As Object, ByVal e As EventArgs)
        _isFocused = True
        Me.Invalidate()
        RemovePlaceholder()
    End Sub

    Private Sub textBox1_Leave(ByVal sender As Object, ByVal e As EventArgs)
        _isFocused = False
        Me.Invalidate()
        SetPlaceholder()
    End Sub
End Class
