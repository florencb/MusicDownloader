<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.tmrDownload = New System.Windows.Forms.Timer(Me.components)
        Me.txtURL = New System.Windows.Forms.TextBox()
        Me.txtSaveAs = New System.Windows.Forms.TextBox()
        Me.prgDownload = New System.Windows.Forms.ProgressBar()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmrDownload
        '
        '
        'txtURL
        '
        Me.txtURL.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtURL.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.txtURL.Location = New System.Drawing.Point(140, 62)
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(511, 21)
        Me.txtURL.TabIndex = 0
        '
        'txtSaveAs
        '
        Me.txtSaveAs.BackColor = System.Drawing.SystemColors.ControlLight
        Me.txtSaveAs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSaveAs.Location = New System.Drawing.Point(140, 136)
        Me.txtSaveAs.Name = "txtSaveAs"
        Me.txtSaveAs.Size = New System.Drawing.Size(417, 21)
        Me.txtSaveAs.TabIndex = 1
        '
        'prgDownload
        '
        Me.prgDownload.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prgDownload.Location = New System.Drawing.Point(50, 195)
        Me.prgDownload.Name = "prgDownload"
        Me.prgDownload.Size = New System.Drawing.Size(602, 27)
        Me.prgDownload.TabIndex = 2
        '
        'btnBrowse
        '
        Me.btnBrowse.ForeColor = System.Drawing.Color.White
        Me.btnBrowse.Location = New System.Drawing.Point(564, 134)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(87, 27)
        Me.btnBrowse.TabIndex = 3
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'btnDownload
        '
        Me.btnDownload.ForeColor = System.Drawing.Color.White
        Me.btnDownload.Location = New System.Drawing.Point(268, 271)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(87, 27)
        Me.btnDownload.TabIndex = 4
        Me.btnDownload.Text = "&DownLoad"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "URL:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Save As:"
        '
        'btnExit
        '
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(381, 271)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 27)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(678, 317)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.prgDownload)
        Me.Controls.Add(Me.txtSaveAs)
        Me.Controls.Add(Me.txtURL)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Downloader"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmrDownload As System.Windows.Forms.Timer
    Friend WithEvents txtURL As System.Windows.Forms.TextBox
    Friend WithEvents txtSaveAs As System.Windows.Forms.TextBox
    Friend WithEvents prgDownload As System.Windows.Forms.ProgressBar
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents btnDownload As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
