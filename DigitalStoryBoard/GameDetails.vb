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
Friend Class GameDetails
    Private _gme As Game
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Public ReadOnly Property Game As Game
        Get
            Return _gme
        End Get
    End Property
    Public Sub New(gm As Game)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me._gme = gm

        cboSize.Enabled = False
        txtSubtitle.Text = gm.Subtitle
        cboSize.SelectedIndex = gm.StoryType
        txtName.Text = gm.Name
        txtCharacters.Text = gm.Characters
        txtComments.Text = gm.Comments
        txtVariables.Text = gm.Variables
        cboGenre.Text = gm.Genre
        For Each im As String In gm.GameChars.Keys
            ImageList1.Images.Add(im, gm.GameChars.Item(im))
            ListView1.Items.Add(im, im)
        Next
    End Sub
    Private Sub GameDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSize.SelectedIndex = 0
    End Sub

    Private Sub butOK_Click(sender As Object, e As EventArgs) Handles butOK.Click
        If String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(cboGenre.Text) Then
            MsgBox("Name and Genere must be filled", MsgBoxStyle.Information)
            Exit Sub
        End If
        If _gme Is Nothing Then
            _gme = New Game
        Else
            _gme.GameChars.Clear()
        End If
        With _gme
            .Name = txtName.Text
            .Subtitle = txtSubtitle.Text
            .Comments = txtComments.Text
            .Variables = txtVariables.Text
            .Characters = txtCharacters.Text
            .Genre = cboGenre.Text
            .StoryType = cboSize.SelectedIndex
            For Each im As String In ImageList1.Images.Keys
                If Not _gme Is Nothing Then
                    If _gme.GameChars.ContainsKey(im) Then
                        _gme.GameChars.Remove(im)

                    End If
                End If

            Next
            .Characters = ""
            If .StoryType = DisplayType.Large Then
                For Each im As String In ImageList1.Images.Keys
                    .GameChars.Add(im, ImageList1.Images.Item(im))

                    .Characters += im & vbCrLf

                Next
            End If
            .GameIsChanged()

        End With
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub butBrowseImages_Click(sender As Object, e As EventArgs) Handles butBrowseImages.Click
        Dim ofd As New OpenFileDialog
        With ofd
            .Filter = "Png files|*.png"
            .InitialDirectory = My.Settings.ImagesLocation
            If .ShowDialog = DialogResult.OK Then
                Dim ch As String = IO.Path.GetFileNameWithoutExtension(.FileName)

                Dim lv As New ListViewItem

                Dim im As Image = Bitmap.FromFile(.FileName)
                ImageList1.Images.Add(ch, im)
                lv.ImageKey = ch
                lv.Text = ch
                ListView1.Items.Add(lv)
                My.Settings.ImagesLocation = IO.Path.GetDirectoryName(.FileName)
                My.Settings.Save()
            End If
        End With
    End Sub

    Private Sub butDeleteImage_Click(sender As Object, e As EventArgs) Handles butDeleteImage.Click
        If ListView1.SelectedItems.Count > 0 Then
            ImageList1.Images.RemoveByKey(ListView1.SelectedItems(0).ImageKey)
            ListView1.Items.RemoveAt(ListView1.SelectedItems(0).Index)

        End If
    End Sub


End Class