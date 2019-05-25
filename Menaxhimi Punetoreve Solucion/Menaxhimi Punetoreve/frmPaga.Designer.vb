<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaga
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaga))
        Me.dgvPAGA = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPagesa = New System.Windows.Forms.TextBox()
        Me.btnDergo = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblBruto = New System.Windows.Forms.Label()
        Me.btnLlogarit = New System.Windows.Forms.Button()
        Me.lblNeto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgvPAGA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPAGA
        '
        Me.dgvPAGA.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvPAGA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPAGA.Location = New System.Drawing.Point(3, 3)
        Me.dgvPAGA.Name = "dgvPAGA"
        Me.dgvPAGA.Size = New System.Drawing.Size(589, 220)
        Me.dgvPAGA.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(519, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 54)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Mbyll"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 244)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Çmimi/Orë:"
        '
        'txtPagesa
        '
        Me.txtPagesa.Location = New System.Drawing.Point(86, 241)
        Me.txtPagesa.Name = "txtPagesa"
        Me.txtPagesa.Size = New System.Drawing.Size(100, 20)
        Me.txtPagesa.TabIndex = 3
        '
        'btnDergo
        '
        Me.btnDergo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDergo.Image = CType(resources.GetObject("btnDergo.Image"), System.Drawing.Image)
        Me.btnDergo.Location = New System.Drawing.Point(192, 239)
        Me.btnDergo.Name = "btnDergo"
        Me.btnDergo.Size = New System.Drawing.Size(75, 23)
        Me.btnDergo.TabIndex = 0
        Me.btnDergo.Text = "Dërgo"
        Me.btnDergo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDergo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDergo.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(322, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "PAGA BRUTO:"
        '
        'lblBruto
        '
        Me.lblBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblBruto.Location = New System.Drawing.Point(408, 240)
        Me.lblBruto.Name = "lblBruto"
        Me.lblBruto.Size = New System.Drawing.Size(89, 21)
        Me.lblBruto.TabIndex = 6
        '
        'btnLlogarit
        '
        Me.btnLlogarit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLlogarit.Image = CType(resources.GetObject("btnLlogarit.Image"), System.Drawing.Image)
        Me.btnLlogarit.Location = New System.Drawing.Point(325, 306)
        Me.btnLlogarit.Name = "btnLlogarit"
        Me.btnLlogarit.Size = New System.Drawing.Size(172, 54)
        Me.btnLlogarit.TabIndex = 1
        Me.btnLlogarit.Text = "Llogarit Pagën"
        Me.btnLlogarit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLlogarit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnLlogarit.UseVisualStyleBackColor = True
        '
        'lblNeto
        '
        Me.lblNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNeto.Location = New System.Drawing.Point(408, 272)
        Me.lblNeto.Name = "lblNeto"
        Me.lblNeto.Size = New System.Drawing.Size(89, 21)
        Me.lblNeto.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(322, 277)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "PAGA NETO:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 268)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(252, 92)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kontributi"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(219, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(27, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "15%"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(219, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "1.7%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(219, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "9.5%"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(219, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "1.7%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Shoqëror paguar nga Punëdhënësi:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Shëndetesor paguar nga Punëdhënësi:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Shoqeror paguar nga Punonjësi:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Shëndetesor paguar nga Punonjësi:"
        '
        'frmPaga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(595, 369)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblNeto)
        Me.Controls.Add(Me.btnLlogarit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblBruto)
        Me.Controls.Add(Me.btnDergo)
        Me.Controls.Add(Me.txtPagesa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvPAGA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmPaga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paga Mujore (Nga Edison Neza)"
        CType(Me.dgvPAGA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvPAGA As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPagesa As System.Windows.Forms.TextBox
    Friend WithEvents btnDergo As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblBruto As System.Windows.Forms.Label
    Friend WithEvents btnLlogarit As System.Windows.Forms.Button
    Friend WithEvents lblNeto As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
