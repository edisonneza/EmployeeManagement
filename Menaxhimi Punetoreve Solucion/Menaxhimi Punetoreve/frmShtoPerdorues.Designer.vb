<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmShtoPerdorues
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmShtoPerdorues))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtperdoruesi = New System.Windows.Forms.TextBox()
        Me.txtfjalekalimi = New System.Windows.Forms.TextBox()
        Me.btnShto = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnFshi = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbldata = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbDep = New System.Windows.Forms.ComboBox()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Emër_Përdoruesi:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Fjalekalimi:"
        '
        'txtperdoruesi
        '
        Me.txtperdoruesi.Location = New System.Drawing.Point(98, 12)
        Me.txtperdoruesi.Name = "txtperdoruesi"
        Me.txtperdoruesi.Size = New System.Drawing.Size(100, 20)
        Me.txtperdoruesi.TabIndex = 0
        '
        'txtfjalekalimi
        '
        Me.txtfjalekalimi.Location = New System.Drawing.Point(98, 42)
        Me.txtfjalekalimi.Name = "txtfjalekalimi"
        Me.txtfjalekalimi.Size = New System.Drawing.Size(100, 20)
        Me.txtfjalekalimi.TabIndex = 1
        '
        'btnShto
        '
        Me.btnShto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnShto.Image = CType(resources.GetObject("btnShto.Image"), System.Drawing.Image)
        Me.btnShto.Location = New System.Drawing.Point(82, 133)
        Me.btnShto.Name = "btnShto"
        Me.btnShto.Size = New System.Drawing.Size(100, 31)
        Me.btnShto.TabIndex = 3
        Me.btnShto.Text = "Shtoni"
        Me.btnShto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnShto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnShto.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(14, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(55, 62)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Mbyll"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnFshi
        '
        Me.btnFshi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFshi.Image = CType(resources.GetObject("btnFshi.Image"), System.Drawing.Image)
        Me.btnFshi.Location = New System.Drawing.Point(82, 168)
        Me.btnFshi.Name = "btnFshi"
        Me.btnFshi.Size = New System.Drawing.Size(100, 27)
        Me.btnFshi.TabIndex = 4
        Me.btnFshi.Text = "Fshini"
        Me.btnFshi.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFshi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFshi.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(204, 12)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(548, 183)
        Me.dgvData.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Data:"
        '
        'lbldata
        '
        Me.lbldata.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbldata.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbldata.Location = New System.Drawing.Point(98, 105)
        Me.lbldata.Name = "lbldata"
        Me.lbldata.Size = New System.Drawing.Size(65, 21)
        Me.lbldata.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Departamenti:"
        '
        'cbDep
        '
        Me.cbDep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDep.FormattingEnabled = True
        Me.cbDep.Location = New System.Drawing.Point(98, 74)
        Me.cbDep.Name = "cbDep"
        Me.cbDep.Size = New System.Drawing.Size(100, 21)
        Me.cbDep.TabIndex = 2
        '
        'frmShtoPerdorues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(764, 207)
        Me.Controls.Add(Me.cbDep)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbldata)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.btnFshi)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnShto)
        Me.Controls.Add(Me.txtfjalekalimi)
        Me.Controls.Add(Me.txtperdoruesi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmShtoPerdorues"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Zona e Përgjegjësve (Nga Edison Neza)"
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtperdoruesi As System.Windows.Forms.TextBox
    Friend WithEvents txtfjalekalimi As System.Windows.Forms.TextBox
    Friend WithEvents btnShto As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnFshi As System.Windows.Forms.Button
    Friend WithEvents dgvData As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbldata As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbDep As System.Windows.Forms.ComboBox
End Class
