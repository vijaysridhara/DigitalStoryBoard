'***********************************************************************
'Copyright 2022 Vijay Sridhara

'Licensed under the Apache License, Version 2.0 (the "License");
'you may not use this file except in compliance with the License.
'You may obtain a copy of the License at

'   http://www.apache.org/licenses/LICENSE-2.0

'Unless required by applicable law or agreed to in writing, software
'distributed under the License is distributed on an "AS IS" BASIS,
'WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
'See the License for the specific language governing permissions and
'limitations under the License.
'***********************************************************************
Imports System.ComponentModel

Friend Class Canvas
    Inherits Control
    Private _currentGame As Game
    Private cursorPos As Point
    Private _selectedScene As Scene
    Private _selSceneLoc As Point
    Private _showGrid As Boolean
    Private bandPen As New Pen(Color.DarkRed, 10)
    Private _currentPage As String
    Friend WithEvents ctxCanvas As ContextMenuStrip
    Private components As System.ComponentModel.IContainer
    Friend WithEvents tlstpNewScene As ToolStripMenuItem
    Friend WithEvents tlstpEditScene As ToolStripMenuItem
    Friend WithEvents tlstpMoveScene As ToolStripMenuItem
    Friend WithEvents tlstpDeleteScene As ToolStripMenuItem
    Friend WithEvents tlstpMark As ToolStripMenuItem
    Friend WithEvents tlstpMarkIncomplete As ToolStripMenuItem
    Friend WithEvents tlstpMarkComplete As ToolStripMenuItem
    Friend WithEvents tlstpImage As ToolStripMenuItem
    Friend WithEvents tlstpClearImage As ToolStripMenuItem
    Friend WithEvents tlstpAddImage As ToolStripMenuItem
    Private _sceneSize As DisplayType
    Event NewSceneClicked()
    Event DeleteSceneClicked(scn As Scene)
    Event MoveSceneClicked(scn As Scene)

    Public ReadOnly Property SelectedScene As Scene
        Get
            Return _selectedScene
        End Get
    End Property

    Public Property SceneSize As DisplayType
        Get
            Return _sceneSize
        End Get
        Set(value As DisplayType)
            _sceneSize = value
            Me.Size = New Size(1120, 710) ' A default size, that fits both sizes
            CalculateGrid()

        End Set
    End Property
    Private ReadOnly Property SceneW As Integer
        Get
            If SceneSize = DisplayType.Medium Then
                Return SceneWidthMedium
            ElseIf SceneSize = DisplayType.Small Then
                Return SceneWidthSmall
            Else
                Return SceneWidthLarge
            End If
        End Get
    End Property
    Private ReadOnly Property SceneH As Integer
        Get
            If SceneSize = DisplayType.Medium Then
                Return SceneHeightMedium
            ElseIf SceneSize = DisplayType.Small Then
                Return SceneHeightSmall
            Else
                Return SceneHeightLarge
            End If
        End Get
    End Property
    Public Property CurrentPAge As String
        Get
            Return _currentPage
        End Get
        Set(value As String)
            _currentPage = value
            Me.Invalidate()
        End Set
    End Property
    Public Property ShowGrid As Boolean
        Get
            Return _showGrid
        End Get
        Set(value As Boolean)
            _showGrid = value
        End Set
    End Property
    Public Sub New()
        InitializeComponent()
        MyBase.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        MyBase.SetStyle(ControlStyles.ResizeRedraw, True)

    End Sub
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ctxCanvas = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tlstpNewScene = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpEditScene = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpMoveScene = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpDeleteScene = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpMark = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpMarkComplete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpMarkIncomplete = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpClearImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.tlstpAddImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctxCanvas.SuspendLayout()
        Me.SuspendLayout()
        '
        'ctxCanvas
        '
        Me.ctxCanvas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstpNewScene, Me.tlstpEditScene, Me.tlstpMoveScene, Me.tlstpDeleteScene, Me.tlstpMark, Me.tlstpImage})
        Me.ctxCanvas.Name = "ctxCanvas"
        Me.ctxCanvas.Size = New System.Drawing.Size(141, 136)
        '
        'tlstpNewScene
        '
        Me.tlstpNewScene.Name = "tlstpNewScene"
        Me.tlstpNewScene.Size = New System.Drawing.Size(140, 22)
        Me.tlstpNewScene.Text = "&New"
        '
        'tlstpEditScene
        '
        Me.tlstpEditScene.Name = "tlstpEditScene"
        Me.tlstpEditScene.Size = New System.Drawing.Size(140, 22)
        Me.tlstpEditScene.Text = "&Edit scene"
        '
        'tlstpMoveScene
        '
        Me.tlstpMoveScene.Name = "tlstpMoveScene"
        Me.tlstpMoveScene.Size = New System.Drawing.Size(140, 22)
        Me.tlstpMoveScene.Text = "&Move scene"
        '
        'tlstpDeleteScene
        '
        Me.tlstpDeleteScene.Name = "tlstpDeleteScene"
        Me.tlstpDeleteScene.Size = New System.Drawing.Size(140, 22)
        Me.tlstpDeleteScene.Text = "&Delete scene"
        '
        'tlstpMark
        '
        Me.tlstpMark.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstpMarkComplete, Me.tlstpMarkIncomplete})
        Me.tlstpMark.Name = "tlstpMark"
        Me.tlstpMark.Size = New System.Drawing.Size(140, 22)
        Me.tlstpMark.Text = "&Mark"
        '
        'tlstpMarkComplete
        '
        Me.tlstpMarkComplete.Name = "tlstpMarkComplete"
        Me.tlstpMarkComplete.Size = New System.Drawing.Size(164, 22)
        Me.tlstpMarkComplete.Text = "Mark &Complete"
        '
        'tlstpMarkIncomplete
        '
        Me.tlstpMarkIncomplete.Name = "tlstpMarkIncomplete"
        Me.tlstpMarkIncomplete.Size = New System.Drawing.Size(164, 22)
        Me.tlstpMarkIncomplete.Text = "Mark &Incomplete"
        '
        'tlstpImage
        '
        Me.tlstpImage.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tlstpClearImage, Me.tlstpAddImage})
        Me.tlstpImage.Enabled = False
        Me.tlstpImage.Name = "tlstpImage"
        Me.tlstpImage.Size = New System.Drawing.Size(140, 22)
        Me.tlstpImage.Text = "Image"
        '
        'tlstpClearImage
        '
        Me.tlstpClearImage.Name = "tlstpClearImage"
        Me.tlstpClearImage.Size = New System.Drawing.Size(137, 22)
        Me.tlstpClearImage.Text = "Clear image"
        '
        'tlstpAddImage
        '
        Me.tlstpAddImage.Name = "tlstpAddImage"
        Me.tlstpAddImage.Size = New System.Drawing.Size(137, 22)
        Me.tlstpAddImage.Text = "Add image"
        '
        'Canvas
        '
        Me.BackColor = System.Drawing.Color.Black
        Me.ContextMenuStrip = Me.ctxCanvas
        Me.Size = New System.Drawing.Size(400, 300)
        Me.ctxCanvas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public Sub LoadGame(gm As Game)
        ClearGame()
        Me._currentGame = gm
        SceneSize = gm.StoryType
        CalculateGrid()

    End Sub
    Public Sub ClearGame()
        _currentGame = Nothing
        _selectedScene = Nothing
        _selSceneLoc = Nothing
        CalculateGrid()
    End Sub

    Dim bw As Integer = 10
    Dim nextxLoc As Integer = 0
    'Dim sceneW As Integer = 100
    'Dim sceneH As Integer = 60

    Private Sub Canvas_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

        For i As Integer = 0 To noOfBandsV
            nextxLoc = i * (bw + SceneW) + 5
            e.Graphics.DrawLine(bandPen, New Point(nextxLoc, 0), New Point(nextxLoc, Me.Height))
        Next
        For i As Integer = 0 To noOfBandsH
            nextxLoc = i * (bw + SceneH) + 5
            e.Graphics.DrawLine(bandPen, New Point(0, nextxLoc), New Point(Me.Width, nextxLoc))
            ' e.Graphics.DrawString(nextxLoc, titleFont, Brushes.Black, New Point(10, nextxLoc)) # for debugging
        Next
        e.Graphics.FillRectangle(Brushes.Blue, New RectangleF(Me.Width - SceneW - bw, bw, SceneW, SceneH))
        If Not _currentGame Is Nothing Then
            For Each sc As Scene In _currentGame.Scenes.Values
                If sc.Page = CurrentPAge Then sc.Paint(e.Graphics)
            Next
        End If


        '  e.Graphics.DrawImage(My.Resources.target_icon, cursorPos.X - 8, cursorPos.Y - 8)

    End Sub

    Dim dx, dy As Integer
    Private Sub Canvas_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Right Then
            cursorPos = e.Location
            Me.Invalidate()
        Else
            Dim scn As Scene = GetSceneAtLocation(e.Location)
            dx = e.X
            dy = e.Y
            If Not scn Is Nothing Then _selSceneLoc = scn.Location
            _selectedScene = scn
            If _currentGame Is Nothing Then Exit Sub
            For Each scn1 As Scene In _currentGame.Scenes.Values
                If Not scn Is scn1 Then
                    scn1.Selected = False
                End If
            Next
            Me.Invalidate()
        End If
    End Sub
    Private Function GetSceneAtLocation(loc As Point) As Scene
        If _currentGame Is Nothing Then Return Nothing
        For Each scn As Scene In _currentGame.Scenes.Values
            If scn.Page <> CurrentPAge Then Continue For
            Dim rect As New Rectangle(scn.Location, scn.Size)
            If rect.Contains(loc) Then
                scn.Selected = True
                Return scn
            End If
        Next

        Return Nothing
    End Function
    Private noOfBandsH, noOfBandsV As Integer
    Private Sub CalculateGrid()
        If SceneSize = DisplayType.Medium Then
            Dim cnt As Integer = 1
            Dim totWidth, totHeight As Integer
            totWidth = (cnt + 1) * bw + cnt * SceneWidthMedium
            While totWidth <= Me.Width
                cnt += 1
                totWidth = (cnt + 1) * bw + cnt * SceneWidthMedium
            End While
            cnt -= 1
            Me.Width = (cnt + 1) * bw + cnt * SceneWidthMedium
            noOfBandsV = cnt
            cnt = 1
            totHeight = (cnt + 1) * bw + cnt * SceneHeightMedium
            While totHeight <= Me.Height
                cnt += 1
                totHeight = (cnt + 1) * bw + cnt * SceneHeightMedium
            End While
            cnt -= 1
            noOfBandsH = cnt
            Me.Height = (cnt + 1) * bw + cnt * SceneHeightMedium
        ElseIf SceneSize = DisplayType.Small Then
            Dim cnt As Integer = 1
            Dim totWidth, totHeight As Integer
            totWidth = (cnt + 1) * bw + cnt * SceneWidthSmall
            While totWidth <= Me.Width
                cnt += 1
                totWidth = (cnt + 1) * bw + cnt * SceneWidthSmall
            End While
            cnt -= 1
            Me.Width = (cnt + 1) * bw + cnt * SceneWidthSmall
            noOfBandsV = cnt
            cnt = 1
            totHeight = (cnt + 1) * bw + cnt * SceneHeightSmall
            While totHeight <= Me.Height
                cnt += 1
                totHeight = (cnt + 1) * bw + cnt * SceneHeightSmall
            End While
            cnt -= 1
            noOfBandsH = cnt
            Me.Height = (cnt + 1) * bw + cnt * SceneHeightSmall
        Else
            Dim cnt As Integer = 1
            Dim totWidth, totHeight As Integer
            totWidth = (cnt + 1) * bw + cnt * SceneWidthLarge
            While totWidth <= Me.Width
                cnt += 1
                totWidth = (cnt + 1) * bw + cnt * SceneWidthLarge
            End While
            cnt -= 1
            Me.Width = (cnt + 1) * bw + cnt * SceneWidthLarge
            noOfBandsV = cnt
            cnt = 1
            totHeight = (cnt + 1) * bw + cnt * SceneHeightLarge
            While totHeight <= Me.Height
                cnt += 1
                totHeight = (cnt + 1) * bw + cnt * SceneHeightLarge
            End While
            cnt -= 1
            noOfBandsH = cnt
            Me.Height = (cnt + 1) * bw + cnt * SceneHeightLarge
        End If
        Me.Invalidate()
    End Sub
    Private Sub Canvas_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        cursorPos = New Point(Me.Width / 2, Me.Height / 2)


        'CalculateGrid()
    End Sub
    Dim ddx, ddy As Integer

    Private ReadOnly Property MidWidthTolerance As Integer
        Get
            If SceneSize = DisplayType.Large Then
                Return 90
            Else
                Return 75
            End If
        End Get

    End Property
    Private ReadOnly Property MidHeightTolerance As Integer
        Get
            If SceneSize = DisplayType.Medium Then
                Return 120
            ElseIf SceneSize = DisplayType.Small Then
                Return 40
            ElseIf SceneSize = DisplayType.Large Then
                Return 250
            End If
        End Get

    End Property
    Private Sub Canvas_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If e.Button = MouseButtons.Left Then
            If _selectedScene Is Nothing Then Exit Sub
            Dim delLoc As Point = New Point((dx - e.X), (dy - e.Y))
            ddx = delLoc.X
            ddy = delLoc.Y
            If delLoc.X > MidWidthTolerance Then
                delLoc.X = SceneW + bw
                If _selSceneLoc.X - delLoc.X <= 0 Then Exit Sub
                _selectedScene.Location = New Point(_selSceneLoc.X - delLoc.X, _selSceneLoc.Y)
                _selSceneLoc = _selectedScene.Location
                dx = e.X : dy = e.Y

            ElseIf delLoc.X < -MidWidthTolerance Then
                delLoc.X = -(SceneW + bw)
                If _selSceneLoc.X - delLoc.X >= Me.Width Then Exit Sub
                _selectedScene.Location = New Point(_selSceneLoc.X - delLoc.X, _selSceneLoc.Y)
                _selSceneLoc = _selectedScene.Location

                dx = e.X
                dy = e.Y

            End If
            If delLoc.Y > MidHeightTolerance Then
                delLoc.Y = SceneH + bw
                If _selSceneLoc.Y - delLoc.Y <= 0 Then Exit Sub
                _selectedScene.Location = New Point(_selSceneLoc.X, _selSceneLoc.Y - delLoc.Y)
                _selSceneLoc = _selectedScene.Location

                dx = e.X : dy = e.Y

            ElseIf delLoc.Y < -MidHeightTolerance Then
                delLoc.Y = -(SceneH + bw)
                If _selSceneLoc.Y - delLoc.Y >= Me.Height Then Exit Sub
                _selectedScene.Location = New Point(_selSceneLoc.X, _selSceneLoc.Y - delLoc.Y)
                _selSceneLoc = _selectedScene.Location

                dx = e.X : dy = e.Y

            End If

            Me.Invalidate()
        End If
    End Sub

    Private Sub Canvas_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        If _selectedScene Is Nothing Then Exit Sub
        Dim ssn As New SceneDetails(_selectedScene)
        If ssn.ShowDialog = DialogResult.OK Then
            Me.Invalidate()
        End If
    End Sub

    Private Sub ctxCanvas_Opening(sender As Object, e As CancelEventArgs) Handles ctxCanvas.Opening
        If _currentGame Is Nothing Then
            ctxCanvas.Enabled = False
        Else
            ctxCanvas.Enabled = True
            tlstpNewScene.Enabled = True
            If SelectedScene Is Nothing Then
                tlstpEditScene.Enabled = False
                tlstpDeleteScene.Enabled = False
                tlstpMoveScene.Enabled = False
                tlstpMark.Enabled = False
                tlstpImage.Enabled = False
            Else
                tlstpEditScene.Enabled = True
                tlstpDeleteScene.Enabled = True
                tlstpMoveScene.Enabled = True
                tlstpMark.Enabled = True
                If SceneSize = DisplayType.Large Then
                    tlstpImage.Enabled = True
                    If SelectedScene.SceneImage Is blankimage Then
                        tlstpClearImage.Enabled = False
                    Else
                        tlstpClearImage.Enabled = True
                    End If
                Else
                    tlstpImage.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub tlstpDeleteScene_Click(sender As Object, e As EventArgs) Handles tlstpDeleteScene.Click
        RaiseEvent DeleteSceneClicked(SelectedScene)
    End Sub

    Private Sub tlstpEditScene_Click(sender As Object, e As EventArgs) Handles tlstpEditScene.Click

        Canvas_DoubleClick(Nothing, Nothing)
    End Sub

    Private Sub tlstpMoveScene_Click(sender As Object, e As EventArgs) Handles tlstpMoveScene.Click
        RaiseEvent MoveSceneClicked(SelectedScene)
    End Sub

    Private Sub tlstpNewScene_Click(sender As Object, e As EventArgs) Handles tlstpNewScene.Click
        RaiseEvent NewSceneClicked()
    End Sub

    Private Sub tlstpMarkComplete_Click(sender As Object, e As EventArgs) Handles tlstpMarkComplete.Click
        SelectedScene.IsComplete = True
    End Sub

    Private Sub tlstpMarkIncomplete_Click(sender As Object, e As EventArgs) Handles tlstpMarkIncomplete.Click
        SelectedScene.IsComplete = False
    End Sub

    Private Sub tlstpAddImage_Click(sender As Object, e As EventArgs) Handles tlstpAddImage.Click
        Dim fbd As New OpenFileDialog
        fbd.Filter = "JPG Files(*.jpg)|*.jpg"
        If fbd.ShowDialog = DialogResult.OK Then
            Dim fname As String = fbd.FileName
            Dim im As Image = New Bitmap(blankimage.Width, blankimage.Height)
            Dim g As Graphics = Graphics.FromImage(im)
            g.Clear(Color.Teal)
            Dim readImage As Image = Bitmap.FromFile(fname)
            Dim asrat As Single = readImage.Width / readImage.Height
            Dim newHt, newWd As Integer
            If asrat > 1 Then
                newWd = im.Width
                newHt = newWd / asrat
            Else
                newHt = im.Height
                newWd = asrat * newHt
            End If
            g.DrawImage(readImage, New Rectangle(0 + im.Width / 2 - newWd / 2, im.Height / 2 - newHt / 2, newWd, newHt))
            readImage.Dispose()
            SelectedScene.SceneImage = im
            Me.Invalidate()
        End If

    End Sub

    Private Sub tlstpClearImage_Click(sender As Object, e As EventArgs) Handles tlstpClearImage.Click
        If MsgBox("Do you want to remove the image from this scene?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No Then Exit Sub
        SelectedScene.SceneImage = Nothing
        Me.Invalidate()
    End Sub
End Class
