<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SceneDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtBrief = New System.Windows.Forms.TextBox()
        Me.txtLogic = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDialogs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCharacters = New System.Windows.Forms.TextBox()
        Me.butOK = New System.Windows.Forms.Button()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIDeas = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboImportance = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboPage = New System.Windows.Forms.ComboBox()
        Me.txtVariables = New System.Windows.Forms.TextBox()
        Me.txtLinkScenes = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(157, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 42)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Brief"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(460, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Logic"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(42, 5)
        Me.txtID.Name = "txtID"
        Me.txtID.ReadOnly = True
        Me.txtID.Size = New System.Drawing.Size(100, 22)
        Me.txtID.TabIndex = 23
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(209, 5)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(230, 22)
        Me.txtName.TabIndex = 1
        '
        'txtBrief
        '
        Me.txtBrief.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtBrief.Location = New System.Drawing.Point(0, 0)
        Me.txtBrief.MaxLength = 500
        Me.txtBrief.Multiline = True
        Me.txtBrief.Name = "txtBrief"
        Me.txtBrief.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBrief.Size = New System.Drawing.Size(379, 202)
        Me.txtBrief.TabIndex = 7
        '
        'txtLogic
        '
        Me.txtLogic.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtLogic.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogic.Location = New System.Drawing.Point(463, 36)
        Me.txtLogic.MaxLength = 2048
        Me.txtLogic.Multiline = True
        Me.txtLogic.Name = "txtLogic"
        Me.txtLogic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLogic.Size = New System.Drawing.Size(418, 226)
        Me.txtLogic.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(528, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Variables"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(725, 42)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Next scenes"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Dialogs"
        '
        'txtDialogs
        '
        Me.txtDialogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDialogs.Location = New System.Drawing.Point(0, 36)
        Me.txtDialogs.MaxLength = 2048
        Me.txtDialogs.Multiline = True
        Me.txtDialogs.Name = "txtDialogs"
        Me.txtDialogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDialogs.Size = New System.Drawing.Size(460, 226)
        Me.txtDialogs.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 42)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Characters"
        '
        'txtCharacters
        '
        Me.txtCharacters.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtCharacters.Location = New System.Drawing.Point(379, 0)
        Me.txtCharacters.MaxLength = 3200
        Me.txtCharacters.Multiline = True
        Me.txtCharacters.Name = "txtCharacters"
        Me.txtCharacters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCharacters.Size = New System.Drawing.Size(152, 202)
        Me.txtCharacters.TabIndex = 9
        '
        'butOK
        '
        Me.butOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butOK.Location = New System.Drawing.Point(631, 8)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(116, 34)
        Me.butOK.TabIndex = 20
        Me.butOK.Text = "O&K"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'butCancel
        '
        Me.butCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancel.Location = New System.Drawing.Point(753, 8)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(116, 34)
        Me.butCancel.TabIndex = 21
        Me.butCancel.Text = "&Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label9.Location = New System.Drawing.Point(0, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 16)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Other ideas"
        '
        'txtIDeas
        '
        Me.txtIDeas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtIDeas.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDeas.Location = New System.Drawing.Point(0, 16)
        Me.txtIDeas.MaxLength = 2048
        Me.txtIDeas.Multiline = True
        Me.txtIDeas.Name = "txtIDeas"
        Me.txtIDeas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIDeas.Size = New System.Drawing.Size(881, 103)
        Me.txtIDeas.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(446, 8)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Importance"
        '
        'cboImportance
        '
        Me.cboImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboImportance.FormattingEnabled = True
        Me.cboImportance.Items.AddRange(New Object() {"None", "Mild", "Moderate", "Important", "VeryMuch", "Final", "Invalid", "Backup"})
        Me.cboImportance.Location = New System.Drawing.Point(532, 5)
        Me.cboImportance.Name = "cboImportance"
        Me.cboImportance.Size = New System.Drawing.Size(158, 24)
        Me.cboImportance.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(697, 8)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 16)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Page"
        '
        'cboPage
        '
        Me.cboPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPage.FormattingEnabled = True
        Me.cboPage.Location = New System.Drawing.Point(751, 5)
        Me.cboPage.Name = "cboPage"
        Me.cboPage.Size = New System.Drawing.Size(116, 24)
        Me.cboPage.TabIndex = 5
        '
        'txtVariables
        '
        Me.txtVariables.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtVariables.Location = New System.Drawing.Point(531, 0)
        Me.txtVariables.MaxLength = 3200
        Me.txtVariables.Multiline = True
        Me.txtVariables.Name = "txtVariables"
        Me.txtVariables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVariables.Size = New System.Drawing.Size(197, 202)
        Me.txtVariables.TabIndex = 11
        '
        'txtLinkScenes
        '
        Me.txtLinkScenes.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtLinkScenes.Location = New System.Drawing.Point(728, 0)
        Me.txtLinkScenes.MaxLength = 3200
        Me.txtLinkScenes.Multiline = True
        Me.txtLinkScenes.Name = "txtLinkScenes"
        Me.txtLinkScenes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLinkScenes.Size = New System.Drawing.Size(153, 202)
        Me.txtLinkScenes.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboPage)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboImportance)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtID)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(881, 61)
        Me.Panel1.TabIndex = 24
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 61)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDialogs)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitter2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtLogic)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(881, 590)
        Me.SplitContainer1.SplitterDistance = 202
        Me.SplitContainer1.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtBrief)
        Me.Panel2.Controls.Add(Me.txtCharacters)
        Me.Panel2.Controls.Add(Me.txtVariables)
        Me.Panel2.Controls.Add(Me.txtLinkScenes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(881, 202)
        Me.Panel2.TabIndex = 0
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter2.Location = New System.Drawing.Point(460, 36)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 226)
        Me.Splitter2.TabIndex = 19
        Me.Splitter2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(881, 36)
        Me.Panel5.TabIndex = 18
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter1.Location = New System.Drawing.Point(0, 262)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(881, 3)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtIDeas)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 265)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(881, 119)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.butOK)
        Me.Panel4.Controls.Add(Me.butCancel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 651)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(881, 45)
        Me.Panel4.TabIndex = 26
        '
        'SceneDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butCancel
        Me.ClientSize = New System.Drawing.Size(881, 696)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "SceneDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SceneDetails"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtBrief As TextBox
    Friend WithEvents txtLogic As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDialogs As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtCharacters As TextBox
    Friend WithEvents butOK As Button
    Friend WithEvents butCancel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIDeas As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboImportance As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboPage As ComboBox
    Friend WithEvents txtVariables As TextBox
    Friend WithEvents txtLinkScenes As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Splitter2 As Splitter
End Class
