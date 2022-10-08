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
Imports RichTextBoxEx
Friend Class StoryOutline
    Dim curGame As Game
    Dim emptyBackColor As Color
    Dim chs As New List(Of String)
    Public Sub New(g As Game, l As Point, ht As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        curGame = g

        ERichTextbox1.ScrollBars = RichTextBoxScrollBars.Both

        ERichTextbox1.Font = New Font("Arial", 11, FontStyle.Regular)

        ERichTextbox1.Rtf = curGame.StoryOutline
        Me.Location = l
        Me.Height = ht
        Me.Width = 300
        ERichTextbox1.Modified = False
        emptyBackColor = ERichTextbox1.BackColor
        chs.AddRange(curGame.Characters.Split(vbCrLf).ToArray)
        If chs.Count <= 1 Then
            lblChars.Text = "Add some characters for shortcuts to story board"
        Else
            lblChars.Text = "CTRL+" & vbCrLf
            Dim x As Integer = 1
            For Each c As String In chs
                If x = 10 Then Exit For
                lblChars.Text += "[" & x & "-" & c.Trim & "] "
                x += 1
            Next
            lblChars.Text += "["" - Reset style]"
        End If


    End Sub

    Private Sub chkEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chkEdit.CheckedChanged

        ERichTextbox1.ReadOnly = Not chkEdit.Checked
        tmrSaver.Enabled = chkEdit.Checked
        If chkEdit.Checked Then
            chkEdit.BackColor = Color.Red
            ERichTextbox1.Focus()
            ERichTextbox1.SelectionStart = ERichTextbox1.TextLength
        Else
            chkEdit.BackColor = SystemColors.Control
        End If
    End Sub







    Private Sub VjRichtxt1_KeyUp(sender As Object, e As KeyEventArgs) Handles ERichTextbox1.KeyUp
        If e.Control Then

            Dim IX As Integer = -1
            Select Case e.KeyCode
                Case Keys.NumPad0, Keys.D0
                    IX = 0
                Case Keys.D1, Keys.NumPad1
                    IX = 1
                Case Keys.D2, Keys.NumPad2
                    IX = 2
                Case Keys.D3, Keys.NumPad4
                    IX = 3
                Case Keys.D4, Keys.NumPad4
                    IX = 4
                Case Keys.D5, Keys.NumPad5
                    IX = 5
                Case Keys.D6, Keys.NumPad6
                    IX = 6
                Case Keys.D7, Keys.NumPad7
                    IX = 7
                Case Keys.D8, Keys.NumPad8
                    IX = 8
                Case Keys.D9, Keys.NumPad9
                    IX = 9
                Case Keys.OemQuotes
                    ERichTextbox1.SelectionFont = New Font("Arial", 11)
                    ERichTextbox1.SelectionBackColor = emptyBackColor
                    ERichTextbox1.SelectedText = " "
                    Exit Sub
            End Select
            If IX = -1 Then Exit Sub
            If IX = 0 Then
                Dim L As Long = ERichTextbox1.SelectionStart
                ERichTextbox1.SelectedText = "[SCENE]"

                ERichTextbox1.SelectionStart = L
                ERichTextbox1.SelectionLength = "[SCENE]".Length
                ERichTextbox1.SelectionBackColor = Color.Yellow
                ERichTextbox1.SelectionFont = New Font(ERichTextbox1.SelectionFont.Name, ERichTextbox1.SelectionFont.Size, ERichTextbox1.SelectionFont.Style Or FontStyle.Bold)
                ERichTextbox1.SelectionStart = L + "[SCENE]".Length
                ERichTextbox1.SelectionLength = 0
                ERichTextbox1.SelectionFont = New Font("Arial", 11)
                ERichTextbox1.SelectionBackColor = emptyBackColor
                ERichTextbox1.SelectedText = vbCrLf
                ERichTextbox1.SelectionLength = 0
            ElseIf IX > 0 Then

                If chs.Count < IX Then Exit Sub
                Dim CHNAME As String = chs(IX - 1)
                Dim L As Long = ERichTextbox1.SelectionStart
                '                Dim repContent As String = "{\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Comic Sans MS;}{\f1\fnil\fcharset0 Arial;}}
                '{\colortbl ;\red0\green0\blue0;\red128\green255\blue128;}
                '{\*\generator Riched20 10.0.19041}\viewkind4\uc1 
                ''\pard\cf1\highlight2\f0\fs20\lang16393 #CHAR#\cf0\highlight0\f1\lang1033\par
                '}"

                ERichTextbox1.SelectedText = CHNAME.Trim

                ERichTextbox1.SelectionStart = L
                ERichTextbox1.SelectionLength = CHNAME.Trim.Length
                ERichTextbox1.SelectionBackColor = Color.LightGreen
                ERichTextbox1.SelectionStart = L + CHNAME.Trim.Length
                ERichTextbox1.SelectionLength = 0
                ERichTextbox1.SelectionFont = New Font("Arial", 11)
                ERichTextbox1.SelectionBackColor = emptyBackColor
                ERichTextbox1.SelectedText = " "

                '                VjRichtxt1.RichArea.SelectionStart = L + CHNAME.Length

            End If

        End If
    End Sub

    Private Sub tmrSaver_Tick(sender As Object, e As EventArgs) Handles tmrSaver.Tick
        If chkEdit.Checked Then
            If ERichTextbox1.Modified Then
                curGame.StoryOutline = ERichTextbox1.Rtf
                ERichTextbox1.Modified = False
            End If
        End If
    End Sub
End Class