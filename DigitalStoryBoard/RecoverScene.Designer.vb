<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecoverScene
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.butOK = New System.Windows.Forms.Button()
        Me.cboSceneID = New System.Windows.Forms.ComboBox()
        Me.txtPAge = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 68)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Page"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'butCancel
        '
        Me.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancel.Location = New System.Drawing.Point(98, 164)
        Me.butCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(75, 31)
        Me.butCancel.TabIndex = 5
        Me.butCancel.Text = "&Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(15, 164)
        Me.butOK.Margin = New System.Windows.Forms.Padding(4)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(75, 31)
        Me.butOK.TabIndex = 4
        Me.butOK.Text = "O&K"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'cboSceneID
        '
        Me.cboSceneID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSceneID.FormattingEnabled = True
        Me.cboSceneID.Location = New System.Drawing.Point(57, 23)
        Me.cboSceneID.Name = "cboSceneID"
        Me.cboSceneID.Size = New System.Drawing.Size(116, 21)
        Me.cboSceneID.TabIndex = 1
        '
        'txtPAge
        '
        Me.txtPAge.Location = New System.Drawing.Point(57, 65)
        Me.txtPAge.Name = "txtPAge"
        Me.txtPAge.ReadOnly = True
        Me.txtPAge.Size = New System.Drawing.Size(116, 20)
        Me.txtPAge.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(194, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 200)
        Me.Panel1.TabIndex = 6
        '
        'RecoverScene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 208)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtPAge)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.cboSceneID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RecoverScene"
        Me.Text = "RecoverScene"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents butCancel As Button
    Friend WithEvents butOK As Button
    Friend WithEvents cboSceneID As ComboBox
    Friend WithEvents txtPAge As TextBox
    Friend WithEvents Panel1 As Panel
End Class
