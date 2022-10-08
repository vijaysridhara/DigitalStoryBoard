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
Public Class Styles
    Private _topHead = "<html><link rel=""stylesheet"" href="".\images\styles.css""><title>#TITLE#</title><body><div class=""mainpage"">" & vbCrLf
    Private _title = "<h1>#TITLE#</h1>" & vbCrLf
    Private _subtitle = "<div class=""subtitle"">#SUBTITLE#</div>" & vbCrLf
    Private _genre = "<div class=""genre"">#GENRE#</div>" & vbCrLf
    Private _desc = "<div class=""desc"">#DESC#</div>" & vbCrLf
    Private _ascenes = "<h2>Active Scenes </h2>" & vbCrLf
    Private _dscenes = "<h2>Deleted Scenes </h2>" & vbCrLf
    Private _charName1 = "<div class=""charname"" style=""float:right"">#CHARNAME#<div class=""charimg""><img src="".\images\#CHARIMG#""/></div></div>" & vbCrLf
    Private _charName0 = "<div class=""charname"" style=""float:left"">#CHARNAME#<div class=""charimg""><img src="".\images\#CHARIMG#""/></div></div>" & vbCrLf
    Private _charName2 = "<div class=""charname2"">#CHARNAME#</div>" & vbCrLf
    Private _variables = "<div class=""variables"">#VARS#</div>" & vbCrLf
    Private _section = "<h2> #SECTION# </h2>" & vbCrLf
    Private _subscection = "<h3> #SUB# </h3>" & vbCrLf
    Private _sceneHeader = "<div class=""scenehead""><div class=""imp"">Importance: #IMP#</div><div class=""page"">Page: #PAGE#</div></div>" & vbCrLf
    Private _brief = "<div class=""brief"">#BRIEF#</div>" & vbCrLf
    Private _charsInvolved = "<div class=""chars"">#CHARS#</div>" & vbCrLf
    Private _varsInvolved = "<div class=""vars"">#VARS#</div>" & vbCrLf
    Private _nextScenes = "<div class=""nextscenes"">#NEXT#</div>" & vbCrLf
    Private _dialogs = "<div class=""dialogs"">#DIALOGS#</div>" & vbCrLf
    Private _logic = "<div class=""logic"">#LOGIC#</div>" & vbCrLf
    Private _ideas = "<div class=""ideas"">#IDEAS#</div>" & vbCrLf
    Private _bottomTail = "</div></body></html>"

    Dim alignLeftChar As Boolean = False
    Public ReadOnly Property TopHead(v As String) As String
        Get
            Return _topHead.replace("#TITLE#", v)
        End Get

    End Property

    Public ReadOnly Property Title(v As String) As String
        Get
            Return _title.replace("#TITLE#", v)
        End Get

    End Property

    Public ReadOnly Property Subtitle(v As String) As String
        Get
            Return _subtitle.replace("#SUBTITLE#", v)
        End Get

    End Property

    Public ReadOnly Property Genre(v As String) As String
        Get
            Return _genre.replace("#GENRE#", v)
        End Get

    End Property

    Public ReadOnly Property Desc(v As String) As String
        Get
            Return _desc.replace("#DESC#", v)
        End Get

    End Property

    Public ReadOnly Property Scenes(a As Boolean) As String
        Get
            If a Then Return _ascenes Else Return _dscenes
        End Get

    End Property

    Public ReadOnly Property CharName(v As String, i As String) As String
        Get
            If alignLeftChar Then
                Return _charName1.replace("#CHARNAME#", v).replace("#CHARIMG#", i)
                alignLeftChar = False

            Else
                Return _charName0.replace("#CHARNAME#", v).replace("#CHARIMG#", i)
                alignLeftChar = True
            End If

        End Get

    End Property
    Public ReadOnly Property CharName(v As String) As String
        Get
            Return _charName2.replace("#CHARNAME#", v)
        End Get

    End Property
    Public ReadOnly Property Variables(v As String) As String
        Get
            Return _variables.replace("#VARS#", v)
        End Get

    End Property


    Public ReadOnly Property Section(v As String) As String
        Get
            Return _section.replace("#SECTION#", v)
        End Get

    End Property
    Public ReadOnly Property SubSection(v As String) As String
        Get
            Return _subscection.replace("#SUB#", v)
        End Get

    End Property
    Public ReadOnly Property SceneHead(imp As String, pg As String) As String
        Get
            Return _sceneHeader.replace("#IMP#", imp).replace("#PAGE#", pg)
        End Get
    End Property
    Public ReadOnly Property Brief(v As String) As String
        Get
            Return _brief.replace("#BRIEF#", v)
        End Get

    End Property

    Public ReadOnly Property CharsInvolved(v As String) As String
        Get
            Return _charsInvolved.replace("#CHARS#", v)
        End Get

    End Property

    Public ReadOnly Property VarsInvolved(v As String) As String
        Get
            Return _varsInvolved.replace("#VARS#", v)
        End Get

    End Property

    Public ReadOnly Property NextScenes(v As String) As String
        Get
            Return _nextScenes.replace("#NEXT#", v)
        End Get

    End Property

    Public ReadOnly Property Dialogs(v As String) As String
        Get
            Return _dialogs.replace("#DIALOGS#", v)
        End Get

    End Property

    Public ReadOnly Property Logic(v As String) As String
        Get
            Return _logic.replace("#LOGIC#", v)
        End Get

    End Property

    Public ReadOnly Property Ideas(v As String) As String
        Get
            Return _ideas.replace("#IDEAS#", v)
        End Get

    End Property

    Public ReadOnly Property BottomTail As String
        Get
            Return _bottomTail
        End Get

    End Property
End Class
