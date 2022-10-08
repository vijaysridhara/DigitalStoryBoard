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
Friend Class StoryExporter
    Private curGame As Game
    Event ExportException(ex As Exception)
    Private myStyles As New Styles
    Public Sub New(cGame As Game)
        Me.curGame = cGame
    End Sub
    Public Function ExporttoFile(fname As String) As Boolean
        Dim fw As New IO.StreamWriter(fname)
        Try
            Dim e As Exception
            Dim IMdIR As String = IO.Path.GetDirectoryName(fname) & "\images"

            If IO.Directory.Exists(IO.Path.GetDirectoryName(fname) & "\images") = False Then
                MkDir(IO.Path.GetDirectoryName(fname) & "\images")
            End If
            IO.File.WriteAllText(IO.Path.GetDirectoryName(fname) & "\images\styles.css", My.Resources.styles)
            With myStyles
                fw.Write(.TopHead(curGame.Name))
                fw.Write(.Title(curGame.Name))
                fw.Write(.Subtitle(curGame.Subtitle))
                fw.Write(.Genre("(" & curGame.Genre & ")"))
                fw.Write(.Desc(curGame.Comments))
                fw.Write(.Section("Game characters"))
                If curGame.GameChars.Count > 0 Then
                    fw.Write("<div style=""width:100%"">")
                    For Each x As String In curGame.GameChars.Keys
                        curGame.GameChars(x).Save(IO.Path.GetDirectoryName(fname) & "\images\" & x & ".png")
                        fw.Write(.CharName(x, x & ".png"))
                    Next
                    If (curGame.GameChars.Count Mod 2) > 0 Then
                        fw.Write(.CharName("None", "none.png"))
                    End If
                    fw.Write("</div>")
                Else
                    If String.IsNullOrEmpty(curGame.Characters) = False Then

                        fw.Write(.CharName(curGame.Characters.Replace(vbCrLf, "<BR/>")))

                    Else
                        fw.Write("N/A <BR/>")
                    End If
                End If
                Dim vars As String = ""
                fw.Write(.Section("Game variables"))
                If String.IsNullOrEmpty(curGame.Variables) = False Then
                    For Each y As String In curGame.Variables.Split(vbCrLf)
                        vars &= y & "<BR/>"
                    Next
                    fw.Write(.Variables(vars))
                Else
                    fw.Write(.Variables("N/A"))
                End If
                fw.Write(.Scenes(True))
                If curGame.StoryType = DisplayType.Large Then
                    blankimage.Save(IO.Path.GetDirectoryName(fname) & "\images\blankimage.jpg")
                End If
                For Each k As String In curGame.Scenes.Keys
                    Dim s As Scene = curGame.Scenes(k)
                    fw.Write("<div>" & vbCrLf)


                    fw.Write(.SubSection("[SCENE]-" & s.SceneID & ": " & s.Name))


                    fw.Write("<div style=""margin-bottom:10px"">" & .SceneHead([Enum].GetName(GetType(Importance), s.SceneImportance), s.Page) & "</div><BR>")
                    If curGame.StoryType = DisplayType.Large Then
                        Dim imgname As String = "blankimage.jpg"
                        If Not s.SceneImage Is blankimage Then
                            imgname = s.SceneID & ".jpg"
                            s.SceneImage.Save(IO.Path.GetDirectoryName(fname) & "\images\" & imgname)
                        End If
                        fw.Write("<div style=""float:right;width:350px;height:262px;""><img src="".\images\" & imgname & """></div><BR/>")
                    End If
                    fw.Write(.SubSection("Brief"))
                    fw.Write(IIf(String.IsNullOrEmpty(s.Brief), "N/A", .Brief(s.Brief)))
                    fw.Write(.SubSection("Characters in the scene"))
                    fw.Write(.CharsInvolved(IIf(String.IsNullOrEmpty(s.Characters), "N/A", s.Characters.Replace(vbCrLf, ","))))
                    fw.Write(.SubSection("Variables used"))
                    fw.Write(.VarsInvolved(IIf(String.IsNullOrEmpty(s.Variables), "N/A", s.Variables.Replace(vbCrLf, ","))))
                    fw.Write(.SubSection("Dialogs"))
                    fw.Write(.Dialogs(IIf(String.IsNullOrEmpty(s.Dialogs), "N/A", s.Dialogs.Replace(vbCrLf, "<BR/>"))))


                    fw.Write(.SubSection("Logic"))
                    If s.Logic Is Nothing Then
                        fw.Write(.Logic("N/A"))
                    Else
                        fw.Write(.Logic(IIf(String.IsNullOrEmpty(s.Logic), "N/A", s.Logic.Replace(vbCrLf, "<BR/>"))))
                    End If

                    fw.Write(.SubSection("Ideas"))
                    If s.Ideas = Nothing Then
                        fw.Write(.Ideas("N/A"))
                    Else
                        fw.Write(.Ideas(IIf(String.IsNullOrEmpty(s.Ideas), "N/A", s.Ideas.Replace(vbCrLf, "<BR/>"))))
                    End If
                    fw.Write("</div>" & vbCrLf)
                Next
                fw.Write(.Scenes(False))
                If curGame.DeletedScenes.Count = 0 Then
                    fw.Write("None")
                End If
                For Each k As String In curGame.DeletedScenes.Keys
                    Dim s As Scene = curGame.DeletedScenes(k)
                    fw.Write(.SubSection("[SCENE]-" & s.SceneID & ": " & s.Name))
                    fw.Write(.SceneHead([Enum].GetName(GetType(Importance), s.SceneImportance), s.Page))
                    fw.Write(.SubSection("Brief"))
                    fw.Write(IIf(String.IsNullOrEmpty(s.Brief), "N/A", .Brief(s.Brief)))
                    fw.Write(.SubSection("Characters in the scene"))
                    fw.Write(.CharsInvolved(IIf(String.IsNullOrEmpty(s.Characters), "N/A", s.Characters.Replace(vbCrLf, ","))))
                    fw.Write(.SubSection("Variables used"))
                    fw.Write(.VarsInvolved(IIf(String.IsNullOrEmpty(s.Variables), "N/A", s.Variables.Replace(vbCrLf, ","))))
                    fw.Write(.SubSection("Dialogs"))
                    fw.Write(.Dialogs(IIf(String.IsNullOrEmpty(s.Dialogs), "N/A", s.Dialogs.Replace(vbCrLf, "<BR/>"))))

                    fw.Write(.SubSection("Logic"))
                    If s.Logic Is Nothing Then
                        fw.Write(.Logic("N/A"))
                    Else
                        fw.Write(.Logic(IIf(String.IsNullOrEmpty(s.Logic), "N/A", s.Logic.Replace(vbCrLf, "<BR/>"))))
                    End If

                    fw.Write(.SubSection("Ideas"))
                    If s.Ideas = Nothing Then
                        fw.Write(.Ideas("N/A"))
                    Else
                        fw.Write(.Ideas(IIf(String.IsNullOrEmpty(s.Ideas), "N/A", s.Ideas.Replace(vbCrLf, "<BR/>"))))
                    End If

                Next
                fw.Write(.BottomTail)
            End With

            Return True
        Catch ex As Exception
            RaiseEvent ExportException(ex)
            Return False
        Finally
            fw.Close()
            fw.Dispose()
        End Try
    End Function
End Class
