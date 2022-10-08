<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.butExport = New System.Windows.Forms.Button()
        Me.butEditDetails = New System.Windows.Forms.Button()
        Me.butSaveGame = New System.Windows.Forms.Button()
        Me.butOpenGame = New System.Windows.Forms.Button()
        Me.butNewGame = New System.Windows.Forms.Button()
        Me.pnlCanvasContainer = New System.Windows.Forms.Panel()
        Me.Canvas1 = New VijaySridhara.Applications.Canvas()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.chkShowoutline = New System.Windows.Forms.CheckBox()
        Me.txtPAgename = New System.Windows.Forms.TextBox()
        Me.lblPAgeDetails = New System.Windows.Forms.Label()
        Me.butAbout = New System.Windows.Forms.Button()
        Me.lblGameName = New System.Windows.Forms.Label()
        Me.butRecover = New System.Windows.Forms.Button()
        Me.butSaveAs = New System.Windows.Forms.Button()
        Me.butNewSceneAdj = New System.Windows.Forms.Button()
        Me.butDeleteScene = New System.Windows.Forms.Button()
        Me.butNewScene = New System.Windows.Forms.Button()
        Me.pnlRight = New System.Windows.Forms.Panel()
        Me.txtVariables = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.txtCharacters = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlPages = New System.Windows.Forms.Panel()
        Me.lstPages = New System.Windows.Forms.ListBox()
        Me.pnlCanvasContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pnlRight.SuspendLayout()
        Me.pnlPages.SuspendLayout()
        Me.SuspendLayout()
        '
        'butExport
        '
        Me.butExport.Enabled = False
        Me.butExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butExport.ForeColor = System.Drawing.SystemColors.Window
        Me.butExport.Location = New System.Drawing.Point(163, 41)
        Me.butExport.Name = "butExport"
        Me.butExport.Size = New System.Drawing.Size(74, 29)
        Me.butExport.TabIndex = 5
        Me.butExport.Text = "E&xport"
        Me.butExport.UseVisualStyleBackColor = True
        '
        'butEditDetails
        '
        Me.butEditDetails.Enabled = False
        Me.butEditDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butEditDetails.ForeColor = System.Drawing.SystemColors.Window
        Me.butEditDetails.Location = New System.Drawing.Point(163, 6)
        Me.butEditDetails.Name = "butEditDetails"
        Me.butEditDetails.Size = New System.Drawing.Size(74, 29)
        Me.butEditDetails.TabIndex = 4
        Me.butEditDetails.Text = "&Edit"
        Me.butEditDetails.UseVisualStyleBackColor = True
        '
        'butSaveGame
        '
        Me.butSaveGame.Enabled = False
        Me.butSaveGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butSaveGame.ForeColor = System.Drawing.SystemColors.Window
        Me.butSaveGame.Location = New System.Drawing.Point(3, 41)
        Me.butSaveGame.Name = "butSaveGame"
        Me.butSaveGame.Size = New System.Drawing.Size(74, 29)
        Me.butSaveGame.TabIndex = 3
        Me.butSaveGame.Text = "&Save"
        Me.butSaveGame.UseVisualStyleBackColor = True
        '
        'butOpenGame
        '
        Me.butOpenGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butOpenGame.ForeColor = System.Drawing.SystemColors.Window
        Me.butOpenGame.Location = New System.Drawing.Point(83, 6)
        Me.butOpenGame.Name = "butOpenGame"
        Me.butOpenGame.Size = New System.Drawing.Size(74, 29)
        Me.butOpenGame.TabIndex = 2
        Me.butOpenGame.Text = "&Open"
        Me.butOpenGame.UseVisualStyleBackColor = True
        '
        'butNewGame
        '
        Me.butNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butNewGame.ForeColor = System.Drawing.SystemColors.Window
        Me.butNewGame.Location = New System.Drawing.Point(3, 6)
        Me.butNewGame.Name = "butNewGame"
        Me.butNewGame.Size = New System.Drawing.Size(74, 29)
        Me.butNewGame.TabIndex = 1
        Me.butNewGame.Text = "&New"
        Me.butNewGame.UseVisualStyleBackColor = True
        '
        'pnlCanvasContainer
        '
        Me.pnlCanvasContainer.AutoScroll = True
        Me.pnlCanvasContainer.BackColor = System.Drawing.SystemColors.ControlDark
        Me.pnlCanvasContainer.Controls.Add(Me.Canvas1)
        Me.pnlCanvasContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCanvasContainer.Location = New System.Drawing.Point(0, 76)
        Me.pnlCanvasContainer.Name = "pnlCanvasContainer"
        Me.pnlCanvasContainer.Size = New System.Drawing.Size(1153, 711)
        Me.pnlCanvasContainer.TabIndex = 1
        '
        'Canvas1
        '
        Me.Canvas1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Canvas1.CurrentPAge = Nothing
        Me.Canvas1.Location = New System.Drawing.Point(12, 22)
        Me.Canvas1.Name = "Canvas1"
        Me.Canvas1.SceneSize = VijaySridhara.Applications.ComFun.DisplayType.Large
        Me.Canvas1.ShowGrid = False
        Me.Canvas1.Size = New System.Drawing.Size(1120, 710)
        Me.Canvas1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.Controls.Add(Me.chkShowoutline)
        Me.Panel2.Controls.Add(Me.txtPAgename)
        Me.Panel2.Controls.Add(Me.lblPAgeDetails)
        Me.Panel2.Controls.Add(Me.butAbout)
        Me.Panel2.Controls.Add(Me.butExport)
        Me.Panel2.Controls.Add(Me.lblGameName)
        Me.Panel2.Controls.Add(Me.butRecover)
        Me.Panel2.Controls.Add(Me.butEditDetails)
        Me.Panel2.Controls.Add(Me.butSaveAs)
        Me.Panel2.Controls.Add(Me.butSaveGame)
        Me.Panel2.Controls.Add(Me.butNewGame)
        Me.Panel2.Controls.Add(Me.butOpenGame)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1455, 76)
        Me.Panel2.TabIndex = 0
        '
        'chkShowoutline
        '
        Me.chkShowoutline.AutoSize = True
        Me.chkShowoutline.Enabled = False
        Me.chkShowoutline.ForeColor = System.Drawing.Color.White
        Me.chkShowoutline.Location = New System.Drawing.Point(243, 49)
        Me.chkShowoutline.Name = "chkShowoutline"
        Me.chkShowoutline.Size = New System.Drawing.Size(101, 20)
        Me.chkShowoutline.TabIndex = 10
        Me.chkShowoutline.Text = "Sho&w outline"
        Me.chkShowoutline.UseVisualStyleBackColor = True
        '
        'txtPAgename
        '
        Me.txtPAgename.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtPAgename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPAgename.Enabled = False
        Me.txtPAgename.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPAgename.ForeColor = System.Drawing.Color.Black
        Me.txtPAgename.Location = New System.Drawing.Point(692, 48)
        Me.txtPAgename.Name = "txtPAgename"
        Me.txtPAgename.Size = New System.Drawing.Size(338, 22)
        Me.txtPAgename.TabIndex = 9
        Me.txtPAgename.Text = "Pagename"
        '
        'lblPAgeDetails
        '
        Me.lblPAgeDetails.AutoSize = True
        Me.lblPAgeDetails.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPAgeDetails.ForeColor = System.Drawing.Color.Yellow
        Me.lblPAgeDetails.Location = New System.Drawing.Point(527, 6)
        Me.lblPAgeDetails.Name = "lblPAgeDetails"
        Me.lblPAgeDetails.Size = New System.Drawing.Size(107, 45)
        Me.lblPAgeDetails.TabIndex = 8
        Me.lblPAgeDetails.Text = "Page No : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Scenes  : " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Deleted :"
        '
        'butAbout
        '
        Me.butAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butAbout.ForeColor = System.Drawing.SystemColors.Window
        Me.butAbout.Location = New System.Drawing.Point(323, 6)
        Me.butAbout.Name = "butAbout"
        Me.butAbout.Size = New System.Drawing.Size(74, 29)
        Me.butAbout.TabIndex = 6
        Me.butAbout.Text = "&About"
        Me.butAbout.UseVisualStyleBackColor = True
        '
        'lblGameName
        '
        Me.lblGameName.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblGameName.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameName.ForeColor = System.Drawing.Color.Cyan
        Me.lblGameName.Location = New System.Drawing.Point(1092, 0)
        Me.lblGameName.Name = "lblGameName"
        Me.lblGameName.Size = New System.Drawing.Size(363, 76)
        Me.lblGameName.TabIndex = 7
        Me.lblGameName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'butRecover
        '
        Me.butRecover.Enabled = False
        Me.butRecover.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butRecover.ForeColor = System.Drawing.SystemColors.Window
        Me.butRecover.Location = New System.Drawing.Point(243, 6)
        Me.butRecover.Name = "butRecover"
        Me.butRecover.Size = New System.Drawing.Size(74, 29)
        Me.butRecover.TabIndex = 4
        Me.butRecover.Text = "&Recover"
        Me.butRecover.UseVisualStyleBackColor = True
        '
        'butSaveAs
        '
        Me.butSaveAs.Enabled = False
        Me.butSaveAs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.butSaveAs.ForeColor = System.Drawing.SystemColors.Window
        Me.butSaveAs.Location = New System.Drawing.Point(83, 41)
        Me.butSaveAs.Name = "butSaveAs"
        Me.butSaveAs.Size = New System.Drawing.Size(74, 29)
        Me.butSaveAs.TabIndex = 3
        Me.butSaveAs.Text = "Save &as"
        Me.butSaveAs.UseVisualStyleBackColor = True
        '
        'butNewSceneAdj
        '
        Me.butNewSceneAdj.BackColor = System.Drawing.Color.Indigo
        Me.butNewSceneAdj.Dock = System.Windows.Forms.DockStyle.Top
        Me.butNewSceneAdj.Enabled = False
        Me.butNewSceneAdj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butNewSceneAdj.ForeColor = System.Drawing.Color.Yellow
        Me.butNewSceneAdj.Location = New System.Drawing.Point(0, 29)
        Me.butNewSceneAdj.Name = "butNewSceneAdj"
        Me.butNewSceneAdj.Size = New System.Drawing.Size(121, 29)
        Me.butNewSceneAdj.TabIndex = 9
        Me.butNewSceneAdj.Text = "Ad&justment"
        Me.butNewSceneAdj.UseVisualStyleBackColor = False
        '
        'butDeleteScene
        '
        Me.butDeleteScene.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.butDeleteScene.Dock = System.Windows.Forms.DockStyle.Top
        Me.butDeleteScene.Enabled = False
        Me.butDeleteScene.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butDeleteScene.ForeColor = System.Drawing.Color.Yellow
        Me.butDeleteScene.Location = New System.Drawing.Point(0, 58)
        Me.butDeleteScene.Name = "butDeleteScene"
        Me.butDeleteScene.Size = New System.Drawing.Size(121, 29)
        Me.butDeleteScene.TabIndex = 0
        Me.butDeleteScene.Text = "&Delete scene"
        Me.butDeleteScene.UseVisualStyleBackColor = False
        '
        'butNewScene
        '
        Me.butNewScene.BackColor = System.Drawing.Color.Blue
        Me.butNewScene.Dock = System.Windows.Forms.DockStyle.Top
        Me.butNewScene.Enabled = False
        Me.butNewScene.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butNewScene.ForeColor = System.Drawing.Color.Yellow
        Me.butNewScene.Location = New System.Drawing.Point(0, 0)
        Me.butNewScene.Name = "butNewScene"
        Me.butNewScene.Size = New System.Drawing.Size(121, 29)
        Me.butNewScene.TabIndex = 8
        Me.butNewScene.Text = "Ne&w scene"
        Me.butNewScene.UseVisualStyleBackColor = False
        '
        'pnlRight
        '
        Me.pnlRight.Controls.Add(Me.txtVariables)
        Me.pnlRight.Controls.Add(Me.Label2)
        Me.pnlRight.Controls.Add(Me.Splitter1)
        Me.pnlRight.Controls.Add(Me.txtCharacters)
        Me.pnlRight.Controls.Add(Me.Label1)
        Me.pnlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlRight.Location = New System.Drawing.Point(1274, 76)
        Me.pnlRight.Name = "pnlRight"
        Me.pnlRight.Size = New System.Drawing.Size(181, 711)
        Me.pnlRight.TabIndex = 6
        '
        'txtVariables
        '
        Me.txtVariables.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtVariables.Enabled = False
        Me.txtVariables.Location = New System.Drawing.Point(0, 375)
        Me.txtVariables.Multiline = True
        Me.txtVariables.Name = "txtVariables"
        Me.txtVariables.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtVariables.Size = New System.Drawing.Size(181, 336)
        Me.txtVariables.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 353)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Variables"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 350)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(181, 3)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'txtCharacters
        '
        Me.txtCharacters.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtCharacters.Enabled = False
        Me.txtCharacters.Location = New System.Drawing.Point(0, 22)
        Me.txtCharacters.Multiline = True
        Me.txtCharacters.Name = "txtCharacters"
        Me.txtCharacters.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCharacters.Size = New System.Drawing.Size(181, 328)
        Me.txtCharacters.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Characters"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlPages
        '
        Me.pnlPages.Controls.Add(Me.lstPages)
        Me.pnlPages.Controls.Add(Me.butDeleteScene)
        Me.pnlPages.Controls.Add(Me.butNewSceneAdj)
        Me.pnlPages.Controls.Add(Me.butNewScene)
        Me.pnlPages.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlPages.Location = New System.Drawing.Point(1153, 76)
        Me.pnlPages.Name = "pnlPages"
        Me.pnlPages.Size = New System.Drawing.Size(121, 711)
        Me.pnlPages.TabIndex = 2
        '
        'lstPages
        '
        Me.lstPages.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstPages.Enabled = False
        Me.lstPages.FormattingEnabled = True
        Me.lstPages.ItemHeight = 16
        Me.lstPages.Location = New System.Drawing.Point(0, 87)
        Me.lstPages.Name = "lstPages"
        Me.lstPages.Size = New System.Drawing.Size(121, 624)
        Me.lstPages.TabIndex = 0
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1455, 787)
        Me.Controls.Add(Me.pnlCanvasContainer)
        Me.Controls.Add(Me.pnlPages)
        Me.Controls.Add(Me.pnlRight)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DigitalStoryBoard"
        Me.pnlCanvasContainer.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pnlRight.ResumeLayout(False)
        Me.pnlRight.PerformLayout()
        Me.pnlPages.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCanvasContainer As Panel
    Friend WithEvents butNewGame As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblGameName As Label
    Friend WithEvents butNewScene As Button
    Friend WithEvents butSaveGame As Button
    Friend WithEvents butOpenGame As Button
    Friend WithEvents butEditDetails As Button
    Friend WithEvents butExport As Button
    Friend WithEvents Canvas1 As Canvas
    Friend WithEvents pnlRight As Panel
    Friend WithEvents txtVariables As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents pnlPages As Panel
    Friend WithEvents lstPages As ListBox
    Friend WithEvents txtCharacters As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents butAbout As Button
    Friend WithEvents butNewSceneAdj As Button
    Friend WithEvents butDeleteScene As Button
    Friend WithEvents lblPAgeDetails As Label
    Friend WithEvents txtPAgename As TextBox
    Friend WithEvents butSaveAs As Button
    Friend WithEvents butRecover As Button
    Friend WithEvents chkShowoutline As CheckBox
End Class
