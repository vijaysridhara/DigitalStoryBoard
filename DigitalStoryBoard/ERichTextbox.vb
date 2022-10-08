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
Public Class ERichTextbox
    Inherits RichTextBox
    Friend WithEvents ctxM As New ContextMenuStrip()
    Private WithEvents ctxCopy As New ToolStripMenuItem("&Copy")
    Private WithEvents ctxCut As New ToolStripMenuItem("Cu&t")
    Private WithEvents ctxPaste As New ToolStripMenuItem("&Paste")
    Private WithEvents ctxSelAll As New ToolStripMenuItem("Select &all")
    Private WithEvents ctxSep1 As New ToolStripSeparator()
    Private WithEvents ctxBold As New ToolStripMenuItem("&Bold")
    Private WithEvents ctxItalic As New ToolStripMenuItem("&Italic")
    Private WithEvents ctxStrikethrough As New ToolStripMenuItem("&Strikethrough")
    Private WithEvents ctxFont As New ToolStripMenuItem("&Font")
    Private WithEvents ctxHighlight As New ToolStripMenuItem("&Highlight")
    Private WithEvents ctxForecolor As New ToolStripMenuItem("Forec&olor")
    Private WithEvents ctxSep2 As New ToolStripSeparator()
    Private WithEvents ctxIndentRight As New ToolStripMenuItem("&Indent right")
    Private WithEvents ctxIndentLeft As New ToolStripMenuItem("&Indent left")

    Private Sub ctxM_Opening(sender As Object, e As EventArgs) Handles ctxM.Opening
        If Me.ReadOnly Then
            ctxM.Close()
        End If
    End Sub
    Public Sub New()
        MyBase.New
        ctxM.Items.AddRange({ctxCopy, ctxCut, ctxPaste, ctxSelAll, ctxSep1, ctxBold, ctxItalic, ctxStrikethrough, ctxFont, ctxHighlight, ctxForecolor, ctxSep2, ctxIndentRight, ctxIndentLeft})
        AddHandler ctxCopy.Click, AddressOf mnuClicked
        AddHandler ctxCut.Click, AddressOf mnuClicked
        AddHandler ctxPaste.Click, AddressOf mnuClicked
        AddHandler ctxSelAll.Click, AddressOf mnuClicked
        AddHandler ctxBold.Click, AddressOf mnuClicked
        AddHandler ctxItalic.Click, AddressOf mnuClicked
        AddHandler ctxStrikethrough.Click, AddressOf mnuClicked
        AddHandler ctxFont.Click, AddressOf mnuClicked
        AddHandler ctxHighlight.Click, AddressOf mnuClicked
        AddHandler ctxForecolor.Click, AddressOf mnuClicked
        AddHandler ctxIndentRight.Click, AddressOf mnuClicked
        AddHandler ctxIndentLeft.Click, AddressOf mnuClicked
        Me.ContextMenuStrip = ctxM
    End Sub
    Public Sub mnuClicked(sender As Object, e As EventArgs)
        If Me.ReadOnly Then Exit Sub
        Dim ix As Integer = ctxM.Items.IndexOf(CType(sender, ToolStripMenuItem))
        Debug.Print(ix)
        Select Case ix
            Case 0
                Me.Copy()
            Case 1
                Me.Cut()
            Case 2
                Me.Paste()
            Case 3
                Me.SelectAll()
            Case 5
                SelectionFont = New Font(SelectionFont.Name, SelectionFont.Size, SelectionFont.Style Xor FontStyle.Bold)
            Case 6
                SelectionFont = New Font(SelectionFont.Name, SelectionFont.Size, SelectionFont.Style Xor FontStyle.Italic)
            Case 7
                SelectionFont = New Font(SelectionFont.Name, SelectionFont.Size, SelectionFont.Style Xor FontStyle.Strikeout)
            Case 8
                Dim fnt As New FontDialog
                fnt.Font = SelectionFont
                If fnt.ShowDialog = DialogResult.OK Then
                    SelectionFont = fnt.Font
                End If
            Case 9
                Dim cp As New VijaySridhara.Controls.ColorWheel
                cp.Location = ctxM.Location
                cp.Color = SelectionBackColor
                If cp.ShowDialog = DialogResult.OK Then
                    SelectionBackColor = cp.Color
                End If
            Case 10
                Dim cp As New VijaySridhara.Controls.ColorWheel
                cp.Location = ctxM.Location
                cp.Color = SelectionColor
                If cp.ShowDialog = DialogResult.OK Then
                    SelectionColor = cp.Color
                End If
            Case 12
                SelectionIndent = SelectionIndent + 20
            Case 13
                If SelectionIndent < 20 Then
                    SelectionIndent = 0
                Else
                    SelectionIndent -= 20
                End If
        End Select
    End Sub
End Class
