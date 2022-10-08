<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StoryOutline
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.chkEdit = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblChars = New System.Windows.Forms.Label()
        Me.tmrSaver = New System.Windows.Forms.Timer(Me.components)
        Me.ERichTextbox1 = New VijaySridhara.Applications.ERichTextbox()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkEdit
        '
        Me.chkEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkEdit.BackColor = System.Drawing.SystemColors.Control
        Me.chkEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkEdit.Location = New System.Drawing.Point(238, 4)
        Me.chkEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.chkEdit.Name = "chkEdit"
        Me.chkEdit.Size = New System.Drawing.Size(43, 28)
        Me.chkEdit.TabIndex = 22
        Me.chkEdit.Text = "&Edit"
        Me.chkEdit.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.chkEdit)
        Me.Panel2.Controls.Add(Me.lblChars)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 651)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 124)
        Me.Panel2.TabIndex = 23
        '
        'lblChars
        '
        Me.lblChars.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblChars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblChars.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblChars.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChars.Location = New System.Drawing.Point(0, 0)
        Me.lblChars.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChars.Name = "lblChars"
        Me.lblChars.Size = New System.Drawing.Size(285, 124)
        Me.lblChars.TabIndex = 23
        Me.lblChars.Text = "Add some characters for shortcuts to story board"
        Me.lblChars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tmrSaver
        '
        Me.tmrSaver.Interval = 1000
        '
        'ERichTextbox1
        '
        Me.ERichTextbox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ERichTextbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ERichTextbox1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ERichTextbox1.Location = New System.Drawing.Point(0, 0)
        Me.ERichTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ERichTextbox1.Name = "ERichTextbox1"
        Me.ERichTextbox1.ReadOnly = True
        Me.ERichTextbox1.Size = New System.Drawing.Size(285, 651)
        Me.ERichTextbox1.TabIndex = 0
        Me.ERichTextbox1.Text = ""
        '
        'StoryOutline
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 775)
        Me.Controls.Add(Me.ERichTextbox1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StoryOutline"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents chkEdit As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ERichTextbox1 As ERichTextbox
    Friend WithEvents tmrSaver As Timer
    Friend WithEvents lblChars As Label
End Class
