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
Imports System.Xml

Friend Class Game
    Private _scenes As New Dictionary(Of String, Scene)
    Private _characters As String = ""
    Private _variables As String
    Private _lastSceneID As Integer = 0
    Private _comments As String
    Private _name As String
    Private _subtitle As String
    Private _genre As String
    Private _isDirty As Boolean
    Private _filename As String
    Private _storytype As DisplayType
    Private _gmChars As New Dictionary(Of String, Image)
    Private _pageNames As New Dictionary(Of String, String)
    Private _deletedScenes As New Dictionary(Of String, Scene)
    Private _outline As String = ""
    Public Property StoryOutline As String
        Get
            Return _outline
        End Get
        Set(value As String)
            _outline = value
            RaiseEvent GameChanged()
        End Set
    End Property
    Public ReadOnly Property DeletedScenes As Dictionary(Of String, Scene)
        Get
            Return _deletedScenes
        End Get
    End Property


    Public Property PageName(pno As String) As String
        Get
            If _pageNames.ContainsKey(pno) Then
                Return _pageNames(pno)
            Else
                Return pno
            End If
        End Get
        Set(value As String)
            If pno = value Then Exit Property
            If _pageNames.ContainsKey(pno) Then
                If _pageNames(pno) = value Then Exit Property
                _pageNames(pno) = value
                RaiseEvent GameChanged()
            Else
                _pageNames.Add(pno, value)
                RaiseEvent GameChanged()
            End If

        End Set
    End Property
    Public ReadOnly Property GameChars As Dictionary(Of String, Image)
        Get
            Return _gmChars
        End Get
    End Property
    Public Sub GameIsChanged()
        RaiseEvent GameChanged()
    End Sub
    Public Property StoryType As DisplayType
        Get
            Return _storytype
        End Get
        Set(value As DisplayType)
            _storytype = value
        End Set
    End Property
    Public Property FileName As String
        Get
            Return _filename
        End Get
        Set(value As String)
            _filename = value
        End Set
    End Property
    Public Property IsDirty As Boolean
        Get
            Return _isDirty
        End Get
        Set(value As Boolean)
            _isDirty = value
        End Set
    End Property
    Event GameChanged()
    Event ASceneChanged(scn As Scene)
    Event ASceneSelected(scn As Scene)
    Private _init As Boolean

    Public Sub ClearScenes()
        For Each scn As Scene In Scenes.Values
            RemoveHandler scn.SceneChanged, AddressOf SceneChanged
            RemoveHandler scn.SceneSelected, AddressOf SceneSelected
        Next
    End Sub
    Public Function LoadGame(file As String) As Boolean
        Try
            Dim xmlDoc As New Xml.XmlDocument()
            xmlDoc.Load(file)
            Dim xmlroot As XmlNode = xmlDoc.FirstChild
            If Not xmlroot Is Nothing Then
                Dim nmAtt As XmlAttribute = xmlroot.Attributes.GetNamedItem("name")
                Dim subTitle As XmlAttribute = xmlroot.Attributes.GetNamedItem("subtitle")
                Dim lsAtt As XmlAttribute = xmlroot.Attributes.GetNamedItem("lastsceneid")
                Dim genAtt As XmlAttribute = xmlroot.Attributes.GetNamedItem("genre")
                Dim sizeAtt As XmlAttribute = xmlroot.Attributes.GetNamedItem("size")
                _name = nmAtt.Value
                If subTitle Is Nothing Then
                    _subtitle = ""
                Else
                    _subtitle = subTitle.Value
                End If

                _lastSceneID = lsAtt.Value
                _genre = genAtt.Value
                _storytype = sizeAtt.Value
                Dim cmNode As XmlNode = xmlroot.FirstChild
                Comments = cmNode.InnerText
                Dim chNode As XmlNode = cmNode.NextSibling
                Characters = chNode.InnerText
                Dim vNode As XmlNode = chNode.NextSibling
                Variables = vNode.InnerText
                Dim cImNode As XmlNode = vNode.NextSibling
                Dim cImChildren As XmlNodeList = cImNode.ChildNodes
                For Each cN As XmlNode In cImChildren
                    Dim cname As String = cN.Attributes("name").Value
                    Dim imStr As String = cN.InnerText
                    Dim st As New IO.MemoryStream(Convert.FromBase64String(imStr))
                    Dim im As Image = Image.FromStream(st)
                    '''Should we close the strem is a question
                    GameChars.Add(cname, im)
                Next
                Dim scnNodes As XmlNode = cImNode.NextSibling
                Dim scNNodeList As XmlNodeList = scnNodes.ChildNodes
                For Each scnNode As XmlNode In scNNodeList

                    Dim scnidAtt As XmlAttribute = scnNode.Attributes.GetNamedItem("id")
                    Dim nameAtt As XmlAttribute = scnNode.Attributes.GetNamedItem("name")
                    Dim pageAtt As XmlAttribute = scnNode.Attributes.GetNamedItem("page")
                    Dim isCompAtt As XmlAttribute = scnNode.Attributes.GetNamedItem("iscomplete")
                    Dim scnChildren As XmlNodeList = scnNode.ChildNodes
                    Dim scn As New Scene(scnidAtt.Value, nameAtt.Value, New Point(0, 0), Me)
                    scn.Page = pageAtt.Value
                    If Not isCompAtt Is Nothing Then scn.IsComplete = IIf(isCompAtt.Value = "Y", True, False)
                    For Each scnC As XmlNode In scnChildren
                        Select Case scnC.Name
                            Case "location"
                                Dim loc() As String = scnC.InnerText.Trim.Split(",")
                                scn.Location = New Point(CInt(loc(0)), CInt(loc(1)))
                            Case "brief"
                                scn.Brief = scnC.InnerText
                            Case "importance"
                                scn.SceneImportance = scnC.InnerText.Trim
                            Case "dialogs"
                                scn.Dialogs = scnC.InnerText.Trim
                            Case "logic"
                                scn.Logic = scnC.InnerText.Trim
                            Case "characters"
                                scn.Characters = scnC.InnerText.Trim
                            Case "variables"
                                scn.Variables = scnC.InnerText.Trim
                            Case "scenes"
                                scn.Linkscenes = scnC.InnerText.Trim
                            Case "ideas"
                                scn.Ideas = scnC.InnerText.Trim
                            Case "image"
                                Dim imStr As String = scnC.InnerText.Trim
                                If String.IsNullOrEmpty(imStr) = False Then
                                    Dim st As New IO.MemoryStream(Convert.FromBase64String(imStr))
                                    Dim im As Image = Image.FromStream(st)
                                    scn.SceneImage = im
                                End If
                        End Select
                    Next
                    AddScene(scn)

                Next
                Dim pnamesNode As XmlNode = scnNodes.NextSibling
                Dim pNodeList As XmlNodeList = pnamesNode.ChildNodes
                For Each pNode As XmlNode In pNodeList
                    Dim pID As XmlAttribute = pNode.Attributes("id")
                    Me._pageNames.Add(pID.Value, pNode.InnerText)
                Next
                '''IF deleted scenes exists
                Dim delScnNodes As XmlNode = pnamesNode.NextSibling
                If Not delScnNodes Is Nothing Then
                    Dim delScNNodeList As XmlNodeList = delScnNodes.ChildNodes
                    For Each scnNode As XmlNode In delScNNodeList

                        Dim scnidAtt As XmlAttribute = scnNode.Attributes.GetNamedItem("id")
                        Dim nameAtt As XmlAttribute = scnNode.Attributes.GetNamedItem("name")
                        Dim pageAtt As XmlAttribute = scnNode.Attributes.GetNamedItem("page")
                        Dim isCompAtt As XmlAttribute = scnNode.Attributes.GetNamedItem("iscomplete")
                        Dim scnChildren As XmlNodeList = scnNode.ChildNodes
                        Dim scn As New Scene(scnidAtt.Value, nameAtt.Value, New Point(0, 0), Me)
                        scn.Page = pageAtt.Value
                        If Not isCompAtt Is Nothing Then scn.IsComplete = IIf(isCompAtt.Value = "Y", True, False)
                        For Each scnC As XmlNode In scnChildren
                            Select Case scnC.Name
                                Case "location"
                                    Dim loc() As String = scnC.InnerText.Trim.Split(",")
                                    scn.Location = New Point(CInt(loc(0)), CInt(loc(1)))
                                Case "brief"
                                    scn.Brief = scnC.InnerText
                                Case "importance"
                                    scn.SceneImportance = scnC.InnerText.Trim
                                Case "dialogs"
                                    scn.Dialogs = scnC.InnerText.Trim
                                Case "logic"
                                    scn.Logic = scnC.InnerText.Trim
                                Case "characters"
                                    scn.Characters = scnC.InnerText.Trim
                                Case "variables"
                                    scn.Variables = scnC.InnerText.Trim
                                Case "scenes"
                                    scn.Linkscenes = scnC.InnerText.Trim
                                Case "ideas"
                                    scn.Ideas = scnC.InnerText.Trim
                                Case "image"
                                    Dim imStr As String = scnC.InnerText.Trim
                                    If String.IsNullOrEmpty(imStr) = False Then
                                        Dim st As New IO.MemoryStream(Convert.FromBase64String(imStr))
                                        Dim im As Image = Image.FromStream(st)
                                        scn.SceneImage = im
                                    End If
                            End Select
                        Next
                        AddDeletedScene(scn)
                    Next
                End If
                '''IF outline exists
                Dim outlineNode As XmlNode = delScnNodes.NextSibling
                If Not outlineNode Is Nothing Then
                    _outline = outlineNode.InnerText.Trim
                End If
            End If
            _filename = file
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function
    Public Function SaveXML(file As String) As Boolean
        Try
            _filename = file
            Dim finalString = "<game name=""" & Name & """ lastsceneid=""" & LastSceneID & """ genre=""" & _genre & """ size=""" & StoryType & """ subtitle=""" & Subtitle & """>" & vbCrLf &
            "<comments> " & Comments & "</comments> " & vbCrLf &
              "<characters>" & Characters & "</characters>" & vbCrLf &
              "<variables>" & Variables & "</variables>" & vbCrLf &
                            "<cimages>" & vbCrLf
            For Each c As String In GameChars.Keys
                Dim im As Image = GameChars(c)
                Dim st As New IO.MemoryStream()
                im.Save(st, Imaging.ImageFormat.Png)
                finalString += "<cimage name=""" & c & """>" & Convert.ToBase64String(st.ToArray) & "</cimage>" & vbCrLf
                '''Shoul we close the stream is a question
            Next
            finalString += "</cimages>" & vbCrLf
            finalString += "<scenes>" & vbCrLf

            For Each scn As Scene In _scenes.Values
                finalString += scn.GetXML
            Next
            finalString += "</scenes>" & vbCrLf &
                "<pagenames>" & vbCrLf

            For Each p As String In _pageNames.Keys
                finalString &= "<page id=""" & p & """>" & _pageNames(p) & "</page>" & vbCrLf
            Next
            finalString += "</pagenames>" & vbCrLf
            finalString += "<dscenes>" & vbCrLf
            For Each scn As Scene In _deletedScenes.Values
                finalString += scn.GetXML
            Next
            finalString += "</dscenes>" & vbCrLf
            finalString += "<outline>" & _outline & vbCrLf & "</outline>" & vbCrLf & "</game>"
            Dim sw As New IO.StreamWriter(file)
            sw.Write(finalString)
            sw.Close()
            sw.Dispose()
            _isDirty = False
            Return True
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Return False
        End Try
    End Function
    Public Function SaveCopy(fname As String) As Boolean
        Try

            Dim finalString = "<game name=""" & Name & """ lastsceneid=""" & 0 & """ genre=""" & _genre & """ size=""" & StoryType & """>" & vbCrLf &
            "<comments> " & Comments & "</comments> " & vbCrLf &
              "<characters>" & Characters & "</characters>" & vbCrLf &
              "<variables>" & Variables & "</variables>" & vbCrLf &
                            "<cimages>" & vbCrLf
            For Each c As String In GameChars.Keys
                Dim im As Image = GameChars(c)
                Dim st As New IO.MemoryStream()
                im.Save(st, Imaging.ImageFormat.Png)
                finalString += "<cimage name=""" & c & """>" & Convert.ToBase64String(st.ToArray) & "</cimage>" & vbCrLf
                '''Shoul we close the stream is a question
            Next
            finalString += "</cimages>" & vbCrLf
            finalString += "<scenes>" & vbCrLf
            finalString += "</scenes>" & vbCrLf &
               "<pagenames>" & vbCrLf
            finalString += "</pagenames>" & vbCrLf
            finalString += "<dscenes>" & vbCrLf & "</dscenes>" & vbCrLf
            finalString += "<outline>" & _outline & "</outline>" & "</game>"

            Dim sw As New IO.StreamWriter(fname)
            sw.Write(finalString)
            sw.Close()
            sw.Dispose()
            Return True
        Catch ex As Exception
            DE(ex)
            Return False
        End Try


    End Function
    Public Property Genre As String
        Get
            Return _genre
        End Get
        Set(value As String)
            If _genre <> value Then
                _genre = value
                RaiseEvent GameChanged()
            End If
        End Set
    End Property
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            If _name <> value Then
                _name = value
                RaiseEvent GameChanged()
            End If
        End Set
    End Property
    Public Function DeleteRecoverScene(scnID As String, delete As Boolean) As Boolean
        Try
            If delete Then
                _deletedScenes.Add(scnID, _scenes(scnID))
                _scenes.Remove(scnID)
                RemoveHandler _deletedScenes(scnID).SceneChanged, AddressOf SceneChanged
                RemoveHandler _deletedScenes(scnID).SceneSelected, AddressOf SceneSelected
            Else
                _scenes.Add(scnID, _deletedScenes(scnID))
                _deletedScenes.Remove(scnID)
                AddHandler _scenes(scnID).SceneChanged, AddressOf SceneChanged
                AddHandler _scenes(scnID).SceneSelected, AddressOf SceneSelected
            End If
            _isDirty = True
            RaiseEvent GameChanged()
        Catch ex As Exception
            DE(ex)
            Return False
        End Try
    End Function
    Public Function AddScene(scn As Scene) As Boolean
        Try
            scn.SceneSize = Me.StoryType
            _scenes.Add(scn.SceneID, scn)
            If StoryType = DisplayType.Medium Then
                scn.Size = New Size(SceneWidthMedium, SceneHeightMedium)
            ElseIf StoryType = DisplayType.Small Then
                scn.Size = New Size(SceneWidthSmall, SceneHeightSmall)
            Else

                scn.Size = New Size(SceneWidthLarge, SceneHeightLarge)
            End If
            AddHandler scn.SceneChanged, AddressOf SceneChanged
            AddHandler scn.SceneSelected, AddressOf SceneSelected
            _isDirty = True
            Return True
        Catch ex As Exception
            DE(ex)
            Return False
        End Try
    End Function

    Public Function AddDeletedScene(scn As Scene) As Boolean
        Try
            scn.SceneSize = Me.StoryType
            _deletedScenes.Add(scn.SceneID, scn)
            If StoryType = DisplayType.Large Then
                scn.Size = New Size(SceneWidthLarge, SceneHeightLarge)
            Else
                scn.Size = New Size(SceneWidthSmall, SceneHeightSmall)
            End If
            Return True
        Catch ex As Exception
            DE(ex)
            Return False
        End Try
    End Function
    Public Function GetScenecountinPAge(p As String) As Integer
        Dim cnt As Integer = 0
        For Each sc As Scene In Me.Scenes.Values
            If sc.Page = p Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function
    Public Function GetDelSceneCountinginPAge(p As String) As Integer
        Dim cnt As Integer = 0
        For Each sc As Scene In Me.DeletedScenes.Values
            If sc.Page = p Then
                cnt += 1
            End If
        Next
        Return cnt
    End Function
    Public Function AddScene(pNo As String, Optional id As String = "") As Scene
        Dim SCN As Scene
        If String.IsNullOrEmpty(id) Then
            id = GetNextSceneID()
        End If
        If StoryType = DisplayType.Medium Then

            SCN = New Scene(id, "", New Point(6 * 10 + 5 * SceneWidthMedium, 10), Me)
            SCN.SceneSize = Me.StoryType
            SCN.Size = New Size(SceneWidthMedium, SceneHeightMedium)
        ElseIf StoryType = DisplayType.Small Then
            SCN = New Scene(id, "", New Point(10 * 10 + 9 * SceneWidthSmall, 10), Me)
            SCN.SceneSize = Me.StoryType
            SCN.Size = New Size(SceneWidthSmall, SceneHeightSmall)
        Else
            SCN = New Scene(id, "", New Point(3 * 10 + 2 * SceneWidthLarge, 10), Me)
            SCN.SceneSize = Me.StoryType
            SCN.Size = New Size(SceneWidthLarge, SceneHeightLarge)
        End If

        SCN.Page = pNo
        _scenes.Add(SCN.SceneID, SCN)

        _isDirty = True
        AddHandler SCN.SceneChanged, AddressOf SceneChanged
        AddHandler SCN.SceneSelected, AddressOf SceneSelected
        RaiseEvent GameChanged()
        Return SCN
    End Function
    Public Property Comments As String
        Get
            Return _comments
        End Get
        Set(value As String)
            If _comments <> value Then
                _comments = value
                RaiseEvent GameChanged()
            End If
        End Set
    End Property
    Public Property LastSceneID As Integer
        Get
            Return _lastSceneID
        End Get
        Set(value As Integer)

            _lastSceneID = value
        End Set
    End Property
    Public ReadOnly Property Scenes As Dictionary(Of String, Scene)
        Get
            Return _scenes
        End Get

    End Property

    Public Property Characters As String
        Get
            Return _characters
        End Get
        Set(value As String)
            If _characters <> value Then
                _characters = value
                RaiseEvent GameChanged()
            End If
        End Set
    End Property

    Public Property Variables As String
        Get
            Return _variables
        End Get
        Set(value As String)
            If _variables <> value Then
                _variables = value
                RaiseEvent GameChanged()
            End If
        End Set
    End Property

    Public Property Subtitle As String
        Get
            Return _subtitle
        End Get
        Set(value As String)
            _subtitle = value
        End Set
    End Property

    Private Function GetNextSceneID() As String
        _lastSceneID += 25
        Dim final As String = ""
        final = _lastSceneID
        While final.Length < 8
            final = "0" & final
        End While
        Return final
    End Function
    Private Sub SceneSelected(scn As Scene)
        RaiseEvent ASceneSelected(scn)
    End Sub
    Private Sub SceneChanged(scn As Scene)
        _isDirty = True
        RaiseEvent GameChanged()
        RaiseEvent ASceneChanged(scn)
    End Sub
End Class
