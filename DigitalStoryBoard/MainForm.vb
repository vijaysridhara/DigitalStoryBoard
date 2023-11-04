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

Friend Class MainForm
    Private currentGame As Game
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With SceneBackBrushes
            .Add(New SolidBrush(Color.White))
            .Add(New SolidBrush(Color.LightCyan))
            .Add(New SolidBrush(Color.Cyan))
            .Add(New SolidBrush(Color.Yellow))
            .Add(New SolidBrush(Color.Orange))
            .Add(New SolidBrush(Color.Red))
            .Add(New SolidBrush(Color.DarkSlateGray))
            .Add(New SolidBrush(Color.Brown))
        End With
        Dim g As Graphics = Graphics.FromImage(blankimage)
        g.Clear(Color.DarkSlateGray)
        g.DrawRectangle(Pens.Black, New Rectangle(0, 0, blankimage.Width - 1, blankimage.Height - 1))

        'borderPen.DashStyle = Drawing2D.DashStyle.Solid
        'selBorderpen.DashStyle = Drawing2D.DashStyle.Solid
        'selBorder2Pen.DashStyle = Drawing2D.DashStyle.Dash
        'currentGame = New Game
        'Dim scn As New Scene("0001", "First Scene", New Point(10, 10))
        'currentGame.Scenes.Add("0001", scn)
        'Dim scn1 As New Scene("0002", "Second Scene", New Point(120, 10))
        'scn1.SceneImportance = Importance.Mild
        'currentGame.Scenes.Add("0002", scn1)
        'Dim scn2 As New Scene("0003", "Third Scene", New Point(230, 10))
        'scn2.SceneImportance = Importance.Moderate
        'currentGame.Scenes.Add("0003", scn2)
        'Dim scn3 As New Scene("0004", "Fourth Scene", New Point(10, 80))
        'scn3.SceneImportance = Importance.Important
        'currentGame.Scenes.Add("0004", scn3)
        'Dim scn4 As New Scene("0005", "Fifth Scene", New Point(120, 80))
        'scn4.SceneImportance = Importance.VeryMuch
        'currentGame.Scenes.Add("0005", scn4)
        'Dim scn5 As New Scene("006", "Sixth Scene", New Point(10, 150))
        'scn5.SceneImportance = Importance.Final
        'currentGame.Scenes.Add("0006", scn5)
        For i As Integer = 1 To MAX_PAGES
            Dim pno As String = i
            While pno.Length < MAX_PAGES_LENGTH
                pno = "0" & pno
            End While
            lstPages.Items.Add("Page-" & pno)
        Next
        lstPages.SelectedIndex = 0
        Me.Location = New Point((Screen.PrimaryScreen.WorkingArea.Width / 2 - Me.Width / 2) + 100, Screen.PrimaryScreen.Bounds.Height / 2 - Me.Height / 2)
    End Sub

    Private Sub pnlCanvasContainer_Paint(sender As Object, e As PaintEventArgs) Handles pnlCanvasContainer.Paint

    End Sub
    Private Sub EnableDisable(enable As Boolean)
        butNewScene.Enabled = enable
        butNewSceneAdj.Enabled = enable

        butEditDetails.Enabled = enable
        If Not enable Then butDeleteScene.Enabled = enable
        butExport.Enabled = enable
        lstPages.Enabled = enable
        txtCharacters.Enabled = enable
        txtVariables.Enabled = enable
        lstPages.SelectedIndex = 0
        txtPAgename.Enabled = enable
        butRecover.Enabled = enable
        chkShowoutline.Enabled = enable
        If enable = False Then lblPAgeDetails.Text = ""
        If enable = False Then lblGameName.Text = ""
        If enable = False Then txtCharacters.Clear()
        If enable = False Then txtVariables.Clear()
    End Sub
    'Private Sub pnlCanvasContainer_Resize(sender As Object, e As EventArgs) Handles pnlCanvasContainer.Resize

    '    Canvas1.Size = New Size(pnlCanvasContainer.Width - 50, pnlCanvasContainer.Height - 50)
    '    Canvas1.Location = New Point(pnlCanvasContainer.Width / 2 - Canvas1.Width / 2, pnlCanvasContainer.Height / 2 - Canvas1.Height / 2)
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butNewGame.Click
        If Not currentGame Is Nothing Then
            If currentGame.IsDirty Then
                Dim res As DialogResult
                res = MsgBox("The game seems to have modified, do you want to save", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question)
                If res = DialogResult.Cancel Then Exit Sub
                If res = DialogResult.Yes Then
                    butSaveGame_Click(Nothing, Nothing)
                    If currentGame.IsDirty Then Exit Sub
                End If

            End If
            currentGame.ClearScenes()
            RemoveHandler currentGame.GameChanged, AddressOf GameChanged
            RemoveHandler currentGame.ASceneSelected, AddressOf SceneSelected
            RemoveHandler currentGame.ASceneChanged, AddressOf SceneChanged
            If Not d Is Nothing Then
                RemoveHandler d.FormClosed, AddressOf so_FormClosed
                d.Close()
                chkShowoutline.Checked = False
            End If
            currentGame = Nothing
            EnableDisable(False)
            Canvas1.ClearGame()
        End If
        'currentGame = New Game()
        'currentGame.Name = "New Game"
        'currentGame.Genre = "Adult"
        'currentGame.Characters = "Lisa" & vbCrLf & "Mona" & vbCrLf & "Kyra" & vbCrLf & "Tom"
        'lblGameName.Text = currentGame.Name
        'Canvas1.LoadGame(currentGame)
        'EnableDisable(True)
        'AddHandler currentGame.GameChanged, AddressOf GameChanged
        'AddHandler currentGame.ASceneSelected, AddressOf SceneSelected
        'AddHandler currentGame.ASceneChanged, AddressOf SceneChanged

        'txtCharacters.Text = currentGame.Characters
        'txtVariables.Text = currentGame.Variables
        'lstPages.SelectedIndex = 0
        'Exit Sub
        Dim gd As New GameDetails
        If gd.ShowDialog = DialogResult.OK Then
            currentGame = gd.Game
            Canvas1.LoadGame(currentGame)
            AddHandler currentGame.GameChanged, AddressOf GameChanged
            AddHandler currentGame.ASceneSelected, AddressOf SceneSelected
            AddHandler currentGame.ASceneChanged, AddressOf SceneChanged
            EnableDisable(True)
            txtCharacters.Text = currentGame.Characters
            txtVariables.Text = currentGame.Variables
            butSaveGame.Enabled = True
            butSaveGame.BackColor = Color.Orange
            lblGameName.Text = currentGame.Name
            ' lblPAgeDetails.Text = lstPages.SelectedItem & ", Scenes: " & currentGame.GetScenecountinPAge(lstPages.SelectedItem)
            lstPages_SelectedIndexChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub butNewScene_Click(sender As Object, e As EventArgs) Handles butNewScene.Click
        If Not currentGame Is Nothing Then
            currentGame.AddScene(lstPages.SelectedItem)
            lblPAgeDetails.Text = lstPages.SelectedItem & vbCrLf & "Scenes  : " & currentGame.GetScenecountinPAge(lstPages.SelectedItem) & vbCrLf & "Deleted : " & currentGame.GetDelSceneCountinginPAge(lstPages.SelectedItem)
            Canvas1.Invalidate()
            
        End If
    End Sub

    Private Sub lstPages_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPages.SelectedIndexChanged
        Canvas1.CurrentPAge = lstPages.SelectedItem
        If currentGame Is Nothing Then Exit Sub
        txtPAgename.Text = currentGame.PageName(lstPages.SelectedItem)
        lblPAgeDetails.Text = lstPages.SelectedItem & vbCrLf & "Scenes  : " & currentGame.GetScenecountinPAge(lstPages.SelectedItem) & vbCrLf & "Deleted : " & currentGame.GetDelSceneCountinginPAge(lstPages.SelectedItem)
    End Sub

    Private Sub butSaveGame_Click(sender As Object, e As EventArgs) Handles butSaveGame.Click
        Try
            If currentGame Is Nothing Then Exit Sub
            If String.IsNullOrEmpty(currentGame.FileName) Or IO.File.Exists(currentGame.FileName) = False Then
                Dim sfd As New SaveFileDialog
                With sfd
                    .Filter = "Digital Story Board files(*.dsbf)|*.dsbf"
                    .InitialDirectory = My.Settings.SaveLocation
                    If .ShowDialog = DialogResult.OK Then
                        If currentGame.SaveXML(.FileName) Then
                            butSaveGame.Enabled = False
                            butSaveGame.BackColor = SystemColors.Control
                            My.Settings.SaveLocation = IO.Path.GetDirectoryName(.FileName)
                            My.Settings.Save()
                        End If
                    End If
                End With
            Else
                If currentGame.SaveXML(currentGame.FileName) Then
                    butSaveGame.Enabled = False
                    butSaveGame.BackColor = SystemColors.Control
                End If

            End If
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butOpenGame_Click(sender As Object, e As EventArgs) Handles butOpenGame.Click
        Try

            If Not currentGame Is Nothing Then
                If currentGame.IsDirty Then
                    Dim res As DialogResult
                    res = MsgBox("The game seems to have modified, do you want to save", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question)
                    If res = DialogResult.Cancel Then Exit Sub
                    If res = DialogResult.Yes Then
                        butSaveGame_Click(Nothing, Nothing)
                        If currentGame.IsDirty Then Exit Sub
                    End If

                End If
                currentGame.ClearScenes()
                RemoveHandler currentGame.GameChanged, AddressOf GameChanged
                RemoveHandler currentGame.ASceneSelected, AddressOf SceneSelected
                RemoveHandler currentGame.ASceneChanged, AddressOf SceneChanged
                If Not d Is Nothing Then
                    RemoveHandler d.FormClosed, AddressOf so_FormClosed
                    d.Close()
                    chkShowoutline.Checked = False
                End If
                currentGame = Nothing

                EnableDisable(False)
                Canvas1.ClearGame()
                butSaveGame.Enabled = False
                butSaveAs.Enabled = False
                butSaveGame.BackColor = SystemColors.ControlDarkDark

            End If
            Dim ofd As New OpenFileDialog
            With ofd
                .Filter = "Digital Story Board files(*.dsbf)|*.dsbf"
                If .ShowDialog = DialogResult.OK Then
                    If currentGame Is Nothing Then
                        currentGame = New Game
                    End If
                    If currentGame.LoadGame(.FileName) Then

                        AddHandler currentGame.GameChanged, AddressOf GameChanged
                        AddHandler currentGame.ASceneSelected, AddressOf SceneSelected
                        AddHandler currentGame.ASceneChanged, AddressOf SceneChanged
                        Canvas1.SceneSize = currentGame.StoryType
                        Canvas1.LoadGame(currentGame)

                        lblGameName.Text = currentGame.Name
                        txtCharacters.Text = currentGame.Characters
                        txtVariables.Text = currentGame.Variables
                        ' lblPAgeDetails.Text = lstPages.SelectedItem & ", Scenes: " & currentGame.GetScenecountinPAge(lstPages.SelectedItem)
                        EnableDisable(True)
                        lstPages_SelectedIndexChanged(Nothing, Nothing)
                        butSaveAs.Enabled = True
                        butSaveGame.Enabled = False

                    End If
                End If
            End With
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub
    Public Sub GameChanged()
        butSaveGame.Enabled = True
        butSaveGame.BackColor = Color.Orange
        currentGame.IsDirty = True
        Canvas1.Invalidate()
    End Sub
    Public Sub SceneChanged(scn As Scene)

    End Sub
    Public Sub SceneSelected(scn As Scene)
        If butDeleteScene.Enabled = False Then
            butDeleteScene.Enabled = True
        End If
    End Sub

    Private Sub txtCharacters_TextChanged(sender As Object, e As EventArgs) Handles txtCharacters.TextChanged
        If currentGame Is Nothing Then Exit Sub
        currentGame.Characters = txtCharacters.Text
    End Sub

    Private Sub txtVariables_TextChanged(sender As Object, e As EventArgs) Handles txtVariables.TextChanged
        If currentGame Is Nothing Then Exit Sub
        currentGame.Variables = txtVariables.Text
    End Sub

    Private Sub butEditDetails_Click(sender As Object, e As EventArgs) Handles butEditDetails.Click
        If currentGame Is Nothing Then Exit Sub
        Dim gd As New GameDetails(currentGame)
        If gd.ShowDialog = DialogResult.OK Then
            txtVariables.Text = currentGame.Variables
            txtCharacters.Text = currentGame.Characters
            lblGameName.Text = currentGame.Name
        End If
    End Sub
    Private se As StoryExporter
    Private Sub butExport_Click(sender As Object, e As EventArgs) Handles butExport.Click
        Try
            Dim sfd As New SaveFileDialog
            sfd.Filter = "HTML Files (*.html)|*.html"
            If sfd.ShowDialog = DialogResult.OK Then

                se = New StoryExporter(currentGame)
                AddHandler se.ExportException, AddressOf se_ExportException
                If se.ExporttoFile(sfd.FileName) Then
                    MsgBox("Successfully saved", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            DE(ex)
        Finally
            If Not se Is Nothing Then RemoveHandler se.ExportException, AddressOf se_ExportException

        End Try
    End Sub
    'Private Function PopulateDocument(doc As org.pdfclown.documents.Document) As Boolean
    '    Try
    '        Dim pg As documents.Page = New Page(doc)
    '        pg.Size = PageFormat.GetSize(PageFormat.SizeEnum.A4)
    '        doc.Pages.Add(pg)
    '        Dim pgSize As SizeF = pg.Size
    '        Dim pComposer As New PrimitiveComposer(pg)
    '        Dim bComposer As New BlockComposer(pComposer)
    '        bComposer.Hyphenation = True
    '        bComposer.Begin(New RectangleF(PAGE_Margin, PAGE_Margin, pgSize.Width - PAGE_Margin * 2, pgSize.Height - PAGE_Margin * 2), XAlignmentEnum.Center, YAlignmentEnum.Middle)
    '        Dim titleFont As New StandardType1Font(doc, StandardType1Font.FamilyEnum.Times, True, False)
    '        bComposer.ShowBreak()
    '        pComposer.SetFont(titleFont, 22)
    '        pComposer.ShowText(currentGame.Name)
    '        bComposer.ShowBreak()
    '        bComposer.ShowBreak()
    '        Dim SubTitleFont As New StandardType1Font(doc, StandardType1Font.FamilyEnum.Helvetica, False, False)
    '        pComposer.SetFont(SubTitleFont, 14)
    '        pComposer.ShowText(currentGame.Comments)
    '        bComposer.ShowBreak()
    '        bComposer.ShowBreak()
    '        Dim genreFont As New StandardType1Font(doc, StandardType1Font.FamilyEnum.Helvetica, False, False)
    '        pComposer.SetFont(genreFont, 16)
    '        pComposer.ShowText("(" & currentGame.Genre & ")")
    '        bComposer.ShowBreak()
    '        pComposer.Flush()

    '        For Each c As String In currentGame.Characters.Split(vbCrLf)

    '        Next
    '        Return True
    '    Catch ex As Exception
    '        DE(ex)
    '        Return False
    '    End Try

    'End Function
    Private Sub pnlCanvasContainer_Resize(sender As Object, e As EventArgs) Handles pnlCanvasContainer.Resize
        If pnlCanvasContainer.Width > Canvas1.Width Then
            Canvas1.Left = pnlCanvasContainer.Width / 2 - Canvas1.Width / 2
        Else
            Canvas1.Left = 0
        End If
        If pnlCanvasContainer.Height > Canvas1.Height Then
            Canvas1.Top = pnlCanvasContainer.Height / 2 - Canvas1.Height / 2
        Else
            Canvas1.Top = 0
        End If
    End Sub

    Private Sub butAbout_Click(sender As Object, e As EventArgs) Handles butAbout.Click
        Dim ab As New AboutDSB
        ab.ShowDialog()
    End Sub

    Private Sub butNewSceneAdj_Click(sender As Object, e As EventArgs) Handles butNewSceneAdj.Click
        Dim sa As New SceneAdj(currentGame, lstPages.SelectedItem)
        sa.ShowDialog()
        lblPAgeDetails.Text = lstPages.SelectedItem & vbCrLf & "Scenes  : " & currentGame.GetScenecountinPAge(lstPages.SelectedItem) & vbCrLf & "Deleted : " & currentGame.GetDelSceneCountinginPAge(lstPages.SelectedItem)

    End Sub

    Private Sub butDeleteScene_Click(sender As Object, e As EventArgs) Handles butDeleteScene.Click
        If Canvas1.SelectedScene Is Nothing Then Exit Sub
        If MsgBox("Do you really want to delete the scene? " & Canvas1.SelectedScene.SceneID, MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        currentGame.DeleteRecoverScene(Canvas1.SelectedScene.SceneID, True)
        currentGame.GameIsChanged()

        lblPAgeDetails.Text = lstPages.SelectedItem & vbCrLf & "Scenes  : " & currentGame.GetScenecountinPAge(lstPages.SelectedItem) & vbCrLf & "Deleted : " & currentGame.GetDelSceneCountinginPAge(lstPages.SelectedItem)
    End Sub

    Private Sub Canvas1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Canvas1_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub txtPAgename_TextChanged(sender As Object, e As EventArgs) Handles txtPAgename.TextChanged
        If currentGame Is Nothing Then Exit Sub
        currentGame.PageName(lstPages.SelectedItem) = txtPAgename.Text.Trim
    End Sub

    Private Sub Canvas1_NewSceneClicked(loc As Point) Handles Canvas1.NewSceneClicked
        If Not currentGame Is Nothing Then
            currentGame.AddScene(lstPages.SelectedItem, loc)
            lblPAgeDetails.Text = lstPages.SelectedItem & vbCrLf & "Scenes  : " & currentGame.GetScenecountinPAge(lstPages.SelectedItem) & vbCrLf & "Deleted : " & currentGame.GetDelSceneCountinginPAge(lstPages.SelectedItem)
            Canvas1.Invalidate()
        End If
    End Sub


    Private Sub Canvas1_DeleteSceneClicked(scn As Scene) Handles Canvas1.DeleteSceneClicked
        butDeleteScene_Click(Nothing, Nothing)
    End Sub

    Private Sub Canvas1_MoveSceneClicked(scn As Scene) Handles Canvas1.MoveSceneClicked
        Dim csrPos As Point = Cursor.Position
        Dim mv As New Move(scn)
        mv.Location = csrPos
        mv.ShowDialog()
    End Sub

    Private Sub butCopy_Click(sender As Object, e As EventArgs) Handles butSaveAs.Click
        Dim sfd As New SaveFileDialog
        With sfd
            .Filter = "Digital Story Board files(*.dsbf)|*.dsbf"
            If .ShowDialog = DialogResult.OK Then
                If currentGame.SaveCopy(.FileName) Then
                    MsgBox("Meta data copied", MsgBoxStyle.Information)
                End If
            End If
        End With
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If currentGame Is Nothing Then Exit Sub
        If butSaveGame.Enabled = True Then
            Dim res As DialogResult = MsgBox("The game is modified, do you want to save?", MsgBoxStyle.Question Or MsgBoxStyle.YesNoCancel)
            If res = MsgBoxResult.Yes Then
                butSaveGame_Click(Nothing, Nothing)
                If butSaveGame.Enabled Then e.Cancel = True
            ElseIf res = DialogResult.Cancel Then
                e.Cancel = True
            Else
                'Do nothing for a no
            End If
        End If
    End Sub

    Private Sub butSaveAs_Click(sender As Object, e As EventArgs) Handles butSaveAs.Click
        Try
            Dim sfd As New SaveFileDialog
            With sfd
                .Title = "Save the file as..."
                .Filter = "Digital Story Board files(*.dsbf)|*.dsbf"
                If String.IsNullOrEmpty(currentGame.FileName) = False And IO.File.Exists(currentGame.FileName) Then
                    .FileName = IO.Path.GetFileName(currentGame.FileName)
                End If
                If .ShowDialog = DialogResult.OK Then
                    If currentGame.SaveXML(.FileName) Then
                        butSaveGame.Enabled = False
                        butSaveGame.BackColor = SystemColors.Control
                    End If
                End If
            End With
        Catch ex As Exception
            DE(ex)
        End Try
    End Sub

    Private Sub butRecover_Click(sender As Object, e As EventArgs) Handles butRecover.Click
        If currentGame Is Nothing Then Exit Sub
        If currentGame.DeletedScenes.Count = 0 Then
            MsgBox("There are no deleted scenese to recover", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim rc As New RecoverScene(currentGame)
        If rc.ShowDialog(Me) = DialogResult.OK Then
            Canvas1.Invalidate()
        End If


    End Sub

    Private Sub se_ExportException(ex As Exception)
        DE(ex)
    End Sub

    Private WithEvents d As StoryOutline
    Private Sub chkShowoutline_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowoutline.CheckedChanged
        If chkShowoutline.Checked Then
            For Each f As Form In Application.OpenForms
                If TypeOf f Is StoryOutline Then
                    f.Activate()
                    Exit Sub
                End If
            Next
            d = New StoryOutline(currentGame, New Point(Me.Left - 300, Me.Top), Me.Height)
            AddHandler d.FormClosed, AddressOf so_FormClosed
            d.Show(Me)
        Else
            For Each f As Form In Application.OpenForms
                If TypeOf f Is StoryOutline Then
                    f.Close()
                    Exit Sub
                End If
            Next
        End If
    End Sub
    Private Sub so_FormClosed(sender As Object, e As FormClosedEventArgs)
        RemoveHandler CType(sender, Form).FormClosed, AddressOf so_FormClosed
        chkShowoutline.Checked = False

    End Sub

    Private Sub Canvas1_Resize(sender As Object, e As EventArgs) Handles Canvas1.Resize
        pnlCanvasContainer_Resize(Nothing, Nothing)
    End Sub

    Private Sub butSupport_Click(sender As Object, e As EventArgs) Handles butSupport.Click
        Dim pinfo As New ProcessStartInfo("https://www.facebook.com/groups/vssoftware")
        pinfo.UseShellExecute = True
        Process.Start(pinfo)
    End Sub
End Class
