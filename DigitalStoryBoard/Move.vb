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
Friend Class Move
    Dim scn As Scene
    Public Sub New(scn As Scene)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.scn = scn

    End Sub
    Private Sub Move_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To MAX_PAGES
            Dim pno As String = i
            While pno.Length < MAX_PAGES_LENGTH
                pno = "0" & pno
            End While
            cboPage.Items.Add("Page-" & pno)
        Next
        cboPage.Text = scn.Page
    End Sub

    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click
        If scn.Page <> cboPage.Text Then
            scn.Page = cboPage.Text

        End If
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub butCancel_Click(sender As Object, e As EventArgs) Handles butCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class