﻿'***********************************************************************
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
Friend Class SceneAdj
    Dim curGame As Game
    Dim curPage As String
    Public Sub New(gm As Game, pg As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.curGame = gm
        Me.curPage = pg
    End Sub
    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click
        If String.IsNullOrEmpty(txtID.Text) Then
            Exit Sub
        Else
            If curGame.Scenes.ContainsKey(GetFullSceneID) Then
                MsgBox("This ID already exists, try different", MsgBoxStyle.Information)
                Exit Sub
            End If
            curGame.AddScene(curPage, GetFullSceneID)
        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub
    Private Function GetFullSceneID() As String
        Dim final As String = txtID.Text

        While final.Length < 6
            final = "0" & final
        End While
        Return final
    End Function
    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SceneAdj_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class