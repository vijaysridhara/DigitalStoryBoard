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
Friend Class SceneDetails
    Dim _selScene As Scene
    Dim gm As Game
    Public Sub New(gm As Game)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.gm = gm
    End Sub
    Public Sub New(scn As Scene)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _selScene = scn
    End Sub
    Private Sub chkScenes_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SceneDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To MAX_PAGES
            Dim pno As String = i
            While pno.Length < MAX_PAGES_LENGTH
                pno = "0" & pno
            End While
            cboPage.Items.Add("Page-" & pno)
        Next
        cboPage.SelectedIndex = 0
        If _selScene Is Nothing Then Exit Sub
        With _selScene
            txtName.Text = .Name
            txtID.Text = .SceneID
            txtIDeas.Text = .Ideas
            txtDialogs.Text = .Dialogs
            txtBrief.Text = .Brief
            txtLogic.Text = .Logic
            txtVariables.Text = .Variables
            txtLinkScenes.Text = .Linkscenes
            cboPage.Text = .Page
            cboImportance.SelectedIndex = .SceneImportance
            txtCharacters.Text = .Characters
        End With
    End Sub

    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click
        If _selScene Is Nothing Then
            _selScene = gm.AddScene(cboPage.Text)

        End If
        With _selScene
            .Name = txtName.Text
            .Ideas = txtIDeas.Text
            .Dialogs = txtDialogs.Text
            .Brief = txtBrief.Text
            .Logic = txtLogic.Text
            .Variables = txtVariables.Text
            .SceneImportance = cboImportance.SelectedIndex
            .Linkscenes = txtLinkScenes.Text
            .Characters = txtCharacters.Text
            .Page = cboPage.Text
        End With
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        Me.Close()
    End Sub
End Class