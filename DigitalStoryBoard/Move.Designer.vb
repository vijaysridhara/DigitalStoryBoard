<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Move
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
        Me.cboPage = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.butOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboPage
        '
        Me.cboPage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPage.FormattingEnabled = True
        Me.cboPage.Location = New System.Drawing.Point(63, 12)
        Me.cboPage.Name = "cboPage"
        Me.cboPage.Size = New System.Drawing.Size(116, 21)
        Me.cboPage.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 15)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Page"
        '
        'butCancel
        '
        Me.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancel.Location = New System.Drawing.Point(146, 51)
        Me.butCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(75, 31)
        Me.butCancel.TabIndex = 9
        Me.butCancel.Text = "&Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(63, 51)
        Me.butOK.Margin = New System.Windows.Forms.Padding(4)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(75, 31)
        Me.butOK.TabIndex = 8
        Me.butOK.Text = "O&K"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'Move
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 96)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.cboPage)
        Me.Controls.Add(Me.Label11)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Move"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Move"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboPage As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents butCancel As Button
    Friend WithEvents butOK As Button
End Class
