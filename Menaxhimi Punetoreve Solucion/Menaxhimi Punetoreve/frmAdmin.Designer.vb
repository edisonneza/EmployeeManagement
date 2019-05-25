<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.lbldata = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.btnFshi = New System.Windows.Forms.Button()
        Me.btnMbyll = New System.Windows.Forms.Button()
        Me.btnShto = New System.Windows.Forms.Button()
        Me.txtAdmin_Fjalekalim = New System.Windows.Forms.TextBox()
        Me.txtAdmin_Emer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbldata
        '
        Me.lbldata.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldata.Location = New System.Drawing.Point(80, 83)
        Me.lbldata.Name = "lbldata"
        Me.lbldata.Size = New System.Drawing.Size(65, 23)
        Me.lbldata.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Data:"
        '
        'dgvData
        '
        Me.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(199, 5)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(447, 192)
        Me.dgvData.TabIndex = 23
        '
        'btnFshi
        '
        Me.btnFshi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFshi.Image = CType(resources.GetObject("btnFshi.Image"), System.Drawing.Image)
        Me.btnFshi.Location = New System.Drawing.Point(80, 166)
        Me.btnFshi.Name = "btnFshi"
        Me.btnFshi.Size = New System.Drawing.Size(100, 25)
        Me.btnFshi.TabIndex = 22
        Me.btnFshi.Text = "Fshini"
        Me.btnFshi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFshi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFshi.UseVisualStyleBackColor = True
        '
        'btnMbyll
        '
        Me.btnMbyll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMbyll.Image = CType(resources.GetObject("btnMbyll.Image"), System.Drawing.Image)
        Me.btnMbyll.Location = New System.Drawing.Point(12, 131)
        Me.btnMbyll.Name = "btnMbyll"
        Me.btnMbyll.Size = New System.Drawing.Size(55, 60)
        Me.btnMbyll.TabIndex = 21
        Me.btnMbyll.Text = "Mbyll"
        Me.btnMbyll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMbyll.UseVisualStyleBackColor = True
        '
        'btnShto
        '
        Me.btnShto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShto.Image = CType(resources.GetObject("btnShto.Image"), System.Drawing.Image)
        Me.btnShto.Location = New System.Drawing.Point(80, 125)
        Me.btnShto.Name = "btnShto"
        Me.btnShto.Size = New System.Drawing.Size(100, 35)
        Me.btnShto.TabIndex = 20
        Me.btnShto.Text = "Shtoni"
        Me.btnShto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShto.UseVisualStyleBackColor = True
        '
        'txtAdmin_Fjalekalim
        '
        Me.txtAdmin_Fjalekalim.Location = New System.Drawing.Point(80, 54)
        Me.txtAdmin_Fjalekalim.Name = "txtAdmin_Fjalekalim"
        Me.txtAdmin_Fjalekalim.Size = New System.Drawing.Size(100, 20)
        Me.txtAdmin_Fjalekalim.TabIndex = 19
        '
        'txtAdmin_Emer
        '
        Me.txtAdmin_Emer.Location = New System.Drawing.Point(80, 25)
        Me.txtAdmin_Emer.Name = "txtAdmin_Emer"
        Me.txtAdmin_Emer.Size = New System.Drawing.Size(100, 20)
        Me.txtAdmin_Emer.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Fjalëkalimi:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Admin_Emër:"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(650, 203)
        Me.Controls.Add(Me.lbldata)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnFshi)
        Me.Controls.Add(Me.btnMbyll)
        Me.Controls.Add(Me.btnShto)
        Me.Controls.Add(Me.txtAdmin_Fjalekalim)
        Me.Controls.Add(Me.txtAdmin_Emer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zona e Administratorëve (Nga Edison Neza)"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbldata As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents btnFshi As System.Windows.Forms.Button
    Friend WithEvents btnMbyll As System.Windows.Forms.Button
    Friend WithEvents btnShto As System.Windows.Forms.Button
    Friend WithEvents txtAdmin_Fjalekalim As System.Windows.Forms.TextBox
    Friend WithEvents txtAdmin_Emer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
