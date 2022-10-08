<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameDetails
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.butCancel = New System.Windows.Forms.Button()
        Me.butOK = New System.Windows.Forms.Button()
        Me.txtCharacters = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtVariables = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.butBrowseImages = New System.Windows.Forms.Button()
        Me.butDeleteImage = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSubtitle = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Description"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(109, 7)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(313, 22)
        Me.txtName.TabIndex = 1
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(109, 93)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(313, 116)
        Me.txtComments.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Genre"
        '
        'cboGenre
        '
        Me.cboGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Items.AddRange(New Object() {"Children", "Sports", "Music", "Adult", "Drama", "Fiction"})
        Me.cboGenre.Location = New System.Drawing.Point(109, 63)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(175, 24)
        Me.cboGenre.TabIndex = 5
        '
        'butCancel
        '
        Me.butCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.butCancel.Location = New System.Drawing.Point(691, 466)
        Me.butCancel.Name = "butCancel"
        Me.butCancel.Size = New System.Drawing.Size(116, 34)
        Me.butCancel.TabIndex = 19
        Me.butCancel.Text = "&Cancel"
        Me.butCancel.UseVisualStyleBackColor = True
        '
        'butOK
        '
        Me.butOK.Location = New System.Drawing.Point(569, 466)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(116, 34)
        Me.butOK.TabIndex = 18
        Me.butOK.Text = "O&K"
        Me.butOK.UseVisualStyleBackColor = True
        '
        'txtCharacters
        '
        Me.txtCharacters.Location = New System.Drawing.Point(442, 29)
        Me.txtCharacters.Multiline = True
        Me.txtCharacters.Name = "txtCharacters"
        Me.txtCharacters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCharacters.Size = New System.Drawing.Size(181, 196)
        Me.txtCharacters.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(442, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Characters"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(629, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 22)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Variables"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVariables
        '
        Me.txtVariables.Location = New System.Drawing.Point(629, 29)
        Me.txtVariables.Multiline = True
        Me.txtVariables.Name = "txtVariables"
        Me.txtVariables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVariables.Size = New System.Drawing.Size(181, 196)
        Me.txtVariables.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Scene size"
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"Medium", "Small", "Large"})
        Me.cboSize.Location = New System.Drawing.Point(109, 215)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(175, 24)
        Me.cboSize.TabIndex = 9
        '
        'ListView1
        '
        Me.ListView1.HideSelection = False
        Me.ListView1.LargeImageList = Me.ImageList1
        Me.ListView1.Location = New System.Drawing.Point(109, 245)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(698, 209)
        Me.ListView1.TabIndex = 11
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(35, 105)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 32)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Thumbnails" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Pref 35x110)"
        '
        'butBrowseImages
        '
        Me.butBrowseImages.Location = New System.Drawing.Point(109, 460)
        Me.butBrowseImages.Name = "butBrowseImages"
        Me.butBrowseImages.Size = New System.Drawing.Size(75, 23)
        Me.butBrowseImages.TabIndex = 12
        Me.butBrowseImages.Text = "..."
        Me.butBrowseImages.UseVisualStyleBackColor = True
        '
        'butDeleteImage
        '
        Me.butDeleteImage.BackColor = System.Drawing.Color.Red
        Me.butDeleteImage.Location = New System.Drawing.Point(190, 460)
        Me.butDeleteImage.Name = "butDeleteImage"
        Me.butDeleteImage.Size = New System.Drawing.Size(49, 23)
        Me.butDeleteImage.TabIndex = 13
        Me.butDeleteImage.Text = "X"
        Me.butDeleteImage.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 38)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Subtitle"
        '
        'txtSubtitle
        '
        Me.txtSubtitle.Location = New System.Drawing.Point(109, 35)
        Me.txtSubtitle.Name = "txtSubtitle"
        Me.txtSubtitle.Size = New System.Drawing.Size(313, 22)
        Me.txtSubtitle.TabIndex = 3
        '
        'GameDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.butCancel
        Me.ClientSize = New System.Drawing.Size(819, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.butDeleteImage)
        Me.Controls.Add(Me.butBrowseImages)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.txtVariables)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCharacters)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.butCancel)
        Me.Controls.Add(Me.butOK)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.cboGenre)
        Me.Controls.Add(Me.txtComments)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSubtitle)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GameDetails"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboGenre As ComboBox
    Friend WithEvents butCancel As Button
    Friend WithEvents butOK As Button
    Friend WithEvents txtCharacters As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtVariables As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboSize As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Label7 As Label
    Friend WithEvents butBrowseImages As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents butDeleteImage As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSubtitle As TextBox
End Class
