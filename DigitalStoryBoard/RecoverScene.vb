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
Friend Class RecoverScene
    Private gm As Game
    Private curScene As String = ""
    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub RecoverScene_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each key As String In gm.DeletedScenes.Keys
            cboSceneID.Items.Add(key)
        Next
        If cboSceneID.Items.Count > 0 Then
            cboSceneID.SelectedIndex = 0
            cboSceneID_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub
    Public Sub New(gm As Game)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.gm = gm

    End Sub

    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click
        Dim tx As String = cboSceneID.SelectedItem
        If String.IsNullOrEmpty(tx) Then Exit Sub
        gm.DeleteRecoverScene(tx, False)
        Me.DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub cboSceneID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSceneID.SelectedIndexChanged
        curScene = cboSceneID.SelectedItem
        If Not String.IsNullOrEmpty(curScene) Then
            txtPAge.Text = gm.DeletedScenes(curScene).Page
            Panel1.Invalidate()
        Else
            txtPAge.Clear()
            Panel1.Invalidate()
        End If

    End Sub

    Private Sub RecoverScene_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Not String.IsNullOrEmpty(curScene) Then

            Dim g As Graphics = Panel1.CreateGraphics
            Me.gm.DeletedScenes(curScene).Paint(g, True)
            Exit Sub
        End If
    End Sub
End Class