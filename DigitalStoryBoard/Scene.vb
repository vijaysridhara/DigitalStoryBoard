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
Friend Class Scene
    Private _sceneID As String
    Private _name As String = "" 'for quick reference of scene
    Private _characters As String = ""
    Private _brief As String
    Private _logic As String
    Private _dialogs As String = ""
    Private _linkscenes As String = ""
    Private _selected As Boolean
    Private _variablesAffected As String = ""
    Private _ideas As String
    Private _sceneImportance As Importance
    Private _page As String = "Page-001"
    Private _loc As Point
    Private _size As New Size(100, 60)
    Event SceneChanged(sender As Scene)
    Event SceneSelected(sender As Scene)
    Private titleBrush As New SolidBrush(Color.Green)
    Private borderPen As New Pen(Color.Goldenrod, 2)
    Private selBorderpen As New Pen(Color.Cyan, 1)
    Private selBorder2Pen As New Pen(Color.Cyan, 2)
    Private _sceneSize As DisplayType
    Private curGame As Game
    Private _iscomplete As Boolean
    Private _sceneImage As Image

    Public Property SceneImage As Image
        Get
            If _sceneImage Is Nothing Then
                Return blankimage
            End If
            Return _sceneImage
        End Get
        Set(value As Image)
            _sceneImage = value

        End Set
    End Property

    Public Property IsComplete As Boolean
        Get
            Return _iscomplete
        End Get
        Set(value As Boolean)
            If _iscomplete = value Then Exit Property
            _iscomplete = value
            RaiseEvent SceneChanged(Me)
        End Set
    End Property
    Public Property SceneSize As DisplayType
        Get
            Return _sceneSize
        End Get
        Set(value As DisplayType)
            _sceneSize = value
            If value = DisplayType.Medium Then
                Me.Size = New Size(SceneWidthMedium, SceneHeightMedium)
            ElseIf value = DisplayType.Small Then
                Me.Size = New Size(SceneWidthSmall, SceneHeightSmall)
            Else
                Me.Size = New Size(SceneWidthLarge, SceneHeightLarge)
            End If
        End Set
    End Property
    Public Function GetXML() As String
        Dim imStr As String = ""
        If Not _sceneImage Is Nothing Then
            Dim st As New IO.MemoryStream()
            _sceneImage.Save(st, Imaging.ImageFormat.Png)
            imStr = Convert.ToBase64String(st.ToArray)

        End If
        Dim finalString = "<scene id=""" & SceneID & """ name=""" & Name & """ page=""" & Page & """ iscomplete=""" & IIf(IsComplete, "Y", "N") & """ >" & vbCrLf &
            "<location>" & Location.X & "," & Location.Y & "</location>" & vbCrLf &
            "<brief> " & Brief & "</brief> " & vbCrLf &
            "<importance>" & SceneImportance & "</importance>" & vbCrLf &
            "<dialogs>" & Dialogs & "</dialogs>" & vbCrLf &
            "<logic>" & Logic & "</logic>" & vbCrLf &
              "<characters>" & Characters & "</characters>" & vbCrLf &
              "<variables>" & Variables & "</variables>" & vbCrLf &
              "<scenes>" & _linkscenes & "</scenes>" & vbCrLf &
              "<ideas>" & Ideas & "</ideas>" & vbCrLf &
              "<image>" & imStr & "</image>" & vbCrLf &
              "</scene>" & vbCrLf
        Return finalString
    End Function
    Public Property Size As Size
        Get
            Return _size
        End Get
        Set(value As Size)
            If _size <> value Then
                _size = value
                RaiseEvent SceneChanged(Me)
            End If
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
    Public Property Page As String
        Get
            Return _page
        End Get
        Set(value As String)
            If _page <> value Then
                _page = value
                RaiseEvent SceneChanged(Me)
            End If
        End Set
    End Property
    Public Property Location As Point
        Get
            Return _loc
        End Get
        Set(value As Point)
            If _loc <> value Then
                _loc = value
                RaiseEvent SceneChanged(Me)
            End If
        End Set
    End Property

    Public Sub New(id As String, name As String, loc As Point, par As Game)
        Me.SceneID = id
        Me.Name = name
        Me.Location = loc
        curGame = par
        borderPen.DashStyle = Drawing2D.DashStyle.Solid
        selBorderpen.DashStyle = Drawing2D.DashStyle.Solid
        selBorder2Pen.DashStyle = Drawing2D.DashStyle.Dash

    End Sub
    Public Property SceneImportance As Importance
        Get
            Return _sceneImportance
        End Get
        Set(value As Importance)
            If _sceneImportance <> value Then
                _sceneImportance = value
                RaiseEvent SceneChanged(Me)
            End If
        End Set
    End Property
    Public Property Ideas As String
        Get
            Return _ideas
        End Get
        Set(value As String)
            If _ideas <> value Then
                _ideas = value
                RaiseEvent SceneChanged(Me)
            End If

        End Set
    End Property
    Public Property Variables As String
        Get
            Return _variablesAffected
        End Get
        Set(value As String)
            If _variablesAffected <> value Then
                _variablesAffected = value
                RaiseEvent SceneChanged(Me)

            End If



        End Set
    End Property
    Public Property SceneID As String
        Get
            Return _sceneID
        End Get
        Set(value As String)

            _sceneID = value

        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            If _name <> value Then
                _name = value
                RaiseEvent SceneChanged(Me)

            End If

        End Set
    End Property

    Public Property Characters As String
        Get
            Return _characters
        End Get
        Set(value As String)
            If _characters <> value Then
                _characters = value
                RaiseEvent SceneChanged(Me)
            End If
        End Set
    End Property



    Public Property Brief As String
        Get
            Return _brief
        End Get
        Set(value As String)
            If _brief <> value Then
                _brief = value
                RaiseEvent SceneChanged(Me)
            End If
        End Set
    End Property

    Public Property Logic As String
        Get
            Return _logic
        End Get
        Set(value As String)
            If _logic <> value Then
                _logic = value
                RaiseEvent SceneChanged(Me)
            End If
        End Set
    End Property

    Public Property Dialogs As String
        Get
            Return _dialogs
        End Get
        Set(value As String)
            If _dialogs <> value Then
                _dialogs = value
                RaiseEvent SceneChanged(Me)
            End If
        End Set
    End Property

    Public Property Linkscenes As String
        Get
            Return _linkscenes
        End Get
        Set(value As String)
            If _linkscenes <> value Then
                _linkscenes = value
                RaiseEvent SceneChanged(Me)
            End If
        End Set
    End Property

    Public Property Selected As Boolean
        Get
            Return _selected
        End Get
        Set(value As Boolean)
            If value And _selected = False Then
                _selected = value
                RaiseEvent SceneSelected(Me)
            Else
                _selected = value
            End If

        End Set
    End Property

    Public Sub Paint(g As Graphics, Optional preview As Boolean = False)
        Dim loc As Point
        If preview Then
            loc = New Point(10, 10)
        Else
            loc = Me.Location
        End If

        g.FillRectangle(SceneBackBrushes(Me.SceneImportance), New Rectangle(loc, Me.Size))
        g.FillRectangle(titleBrush, New Rectangle(loc, New Size(SceneW, 20)))
        g.DrawString("ID:" & Me.SceneID, titleFont, New SolidBrush(Color.Black), loc + New Point(5, 5))
        If IsComplete Then g.DrawImage(My.Resources.Check_1_icon, New Point(loc + New Point(Me.Size.Width - 20, 2)))
        g.DrawRectangle(borderPen, New Rectangle(loc, Me.Size))
        g.DrawRectangle(borderPen, New Rectangle(loc, New Size(SceneW, 20)))
        If Me.Selected And Not preview Then
            g.DrawRectangle(selBorderpen, New Rectangle(loc, Me.Size))
            g.DrawRectangle(selBorder2Pen, New Rectangle(loc - New Point(3, 3), Me.Size + New Size(6, 6)))
        Else

            borderPen.DashStyle = Drawing2D.DashStyle.Solid
            Dim rct As New Rectangle(loc, New Size(SceneW, 20))
            'g.DrawRectangle(New Pen(Brushes.Cyan, 2), rct)
        End If
        Dim lth As Integer = Me.Name.Length
        If SceneSize = DisplayType.Medium Then
            If lth > 22 Then
                g.DrawString(Me.Name.Substring(0, 22), titleFont, New SolidBrush(Color.Black), loc + New Point(2, 25))
            Else
                g.DrawString(Me.Name, titleFont, New SolidBrush(Color.Black), loc + New Point(2, 25))
            End If

        ElseIf SceneSize = DisplayType.Small Then
            If lth > 15 Then
                g.DrawString(Me.Name.Substring(0, 15), textFont2, New SolidBrush(Color.Black), loc + New Point(2, 25))
            Else
                g.DrawString(Me.Name, textFont2, New SolidBrush(Color.Black), loc + New Point(2, 25))
            End If
        Else
            If lth > 50 Then
                g.DrawString(Me.Name.Substring(0, 55), titleFont, New SolidBrush(Color.Black), loc + New Point(2, 25))
            Else
                g.DrawString(Me.Name, titleFont, New SolidBrush(Color.Black), loc + New Point(2, 25))
            End If

        End If
        Dim cLoc As Point = loc + New Point(2, 40)
        Dim vLoc As Point = loc + New Point(35, 40)
        Dim sLoc As Point = loc + New Point(67, 40)
        If SceneSize = DisplayType.Small Or SceneSize = DisplayType.Medium Then

        Else
            cLoc = loc + New Point(2, 40)
            vLoc = loc + New Point(50, 40)
            sLoc = loc + New Point(90, 40)
            Dim iLoc As Point = loc + New Point(150, 40)
            g.DrawString("Use 16x12 image(350,262)px", textFont2, New SolidBrush(Color.Black), iLoc)
        End If
        g.DrawImage(My.Resources.charicon.ToBitmap, New Rectangle(cLoc, New Size(14, 14)))
        g.DrawString(IIf(String.IsNullOrEmpty(Me.Characters), 0, Me.Characters.Split(vbCrLf).Count), textFont2, New SolidBrush(Color.Black), cLoc + New Point(14, 1))
        g.DrawImage(My.Resources.varicon.ToBitmap, New Rectangle(vLoc, New Size(14, 14)))
        g.DrawString(IIf(String.IsNullOrEmpty(Me.Variables), 0, Me.Variables.Split(vbCrLf).Count), textFont2, New SolidBrush(Color.Black), vLoc + New Point(14, 1))
        g.DrawImage(My.Resources.sceneicon.ToBitmap, New Rectangle(sLoc, New Size(14, 14)))
        g.DrawString(IIf(String.IsNullOrEmpty(Me.Linkscenes), 0, Me.Linkscenes.Split(vbCrLf).Count), textFont2, New SolidBrush(Color.Black), sLoc + New Point(14, 1))

        If SceneSize = DisplayType.Medium Then
            If String.IsNullOrEmpty(Me.Characters) Then Exit Sub
            Dim beginX As Integer = loc.X + 5
            Dim beginY As Integer = loc.Y + 60
            Dim width As Integer = 35
            Dim height As Integer = 105
            Dim nextCnt As Integer = 0
            Dim chrs() As String = Me.Characters.Trim.Split(vbCrLf)
            For j As Integer = 0 To chrs.Length - 1
                If chrs(j).Trim = "" Then Continue For
                If curGame.GameChars.ContainsKey(chrs(j).Trim) Then
                    Dim im As Image = curGame.GameChars(chrs(j).Trim)

                    g.DrawImage(im, beginX + nextCnt * width, beginY, 35, 105)
                    Debug.Print("Next X " & beginX + nextCnt * width)
                    nextCnt += 1

                    If nextCnt = 4 Then Exit For 'Onlyu can show 4 characters
                End If
            Next
        ElseIf SceneSize = DisplayType.Large Then


            Dim beginX As Integer = loc.X + 5
            Dim beginY As Integer = loc.Y + 75
            Dim width As Integer = 350
            Dim height As Integer = 262

            g.DrawImage(SceneImage, beginX, beginY)

        End If
    End Sub
End Class
