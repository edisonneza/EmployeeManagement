<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Detaje
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Detaje))
        Me.dgvPunt = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chTeknologji = New System.Windows.Forms.CheckBox()
        Me.chFemra = New System.Windows.Forms.CheckBox()
        Me.chMarketing = New System.Windows.Forms.CheckBox()
        Me.chProdhim = New System.Windows.Forms.CheckBox()
        Me.chMeshkuj = New System.Windows.Forms.CheckBox()
        Me.chSherbim = New System.Windows.Forms.CheckBox()
        Me.chKontrate = New System.Windows.Forms.CheckBox()
        Me.chPerkohshem = New System.Windows.Forms.CheckBox()
        Me.btnPastro = New System.Windows.Forms.Button()
        Me.btnKthehuni = New System.Windows.Forms.Button()
        Me.btnFiltro = New System.Windows.Forms.Button()
        CType(Me.dgvPunt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPunt
        '
        Me.dgvPunt.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvPunt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPunt.Location = New System.Drawing.Point(12, 54)
        Me.dgvPunt.Name = "dgvPunt"
        Me.dgvPunt.Size = New System.Drawing.Size(1089, 472)
        Me.dgvPunt.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chTeknologji)
        Me.GroupBox2.Controls.Add(Me.chFemra)
        Me.GroupBox2.Controls.Add(Me.chMarketing)
        Me.GroupBox2.Controls.Add(Me.chProdhim)
        Me.GroupBox2.Controls.Add(Me.chMeshkuj)
        Me.GroupBox2.Controls.Add(Me.chSherbim)
        Me.GroupBox2.Controls.Add(Me.chKontrate)
        Me.GroupBox2.Controls.Add(Me.chPerkohshem)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 40)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Zgjidhni opsionin për filtrimin e të dhënave"
        '
        'chTeknologji
        '
        Me.chTeknologji.AutoSize = True
        Me.chTeknologji.Location = New System.Drawing.Point(7, 17)
        Me.chTeknologji.Name = "chTeknologji"
        Me.chTeknologji.Size = New System.Drawing.Size(75, 17)
        Me.chTeknologji.TabIndex = 20
        Me.chTeknologji.Text = "Teknologji"
        Me.chTeknologji.UseVisualStyleBackColor = True
        '
        'chFemra
        '
        Me.chFemra.AutoSize = True
        Me.chFemra.Location = New System.Drawing.Point(576, 17)
        Me.chFemra.Name = "chFemra"
        Me.chFemra.Size = New System.Drawing.Size(55, 17)
        Me.chFemra.TabIndex = 27
        Me.chFemra.Text = "Femra"
        Me.chFemra.UseVisualStyleBackColor = True
        '
        'chMarketing
        '
        Me.chMarketing.AutoSize = True
        Me.chMarketing.Location = New System.Drawing.Point(88, 17)
        Me.chMarketing.Name = "chMarketing"
        Me.chMarketing.Size = New System.Drawing.Size(73, 17)
        Me.chMarketing.TabIndex = 21
        Me.chMarketing.Text = "Marketing"
        Me.chMarketing.UseVisualStyleBackColor = True
        '
        'chProdhim
        '
        Me.chProdhim.AutoSize = True
        Me.chProdhim.Location = New System.Drawing.Point(167, 17)
        Me.chProdhim.Name = "chProdhim"
        Me.chProdhim.Size = New System.Drawing.Size(64, 17)
        Me.chProdhim.TabIndex = 22
        Me.chProdhim.Text = "Prodhim"
        Me.chProdhim.UseVisualStyleBackColor = True
        '
        'chMeshkuj
        '
        Me.chMeshkuj.AutoSize = True
        Me.chMeshkuj.Location = New System.Drawing.Point(504, 17)
        Me.chMeshkuj.Name = "chMeshkuj"
        Me.chMeshkuj.Size = New System.Drawing.Size(66, 17)
        Me.chMeshkuj.TabIndex = 26
        Me.chMeshkuj.Text = "Meshkuj"
        Me.chMeshkuj.UseVisualStyleBackColor = True
        '
        'chSherbim
        '
        Me.chSherbim.AutoSize = True
        Me.chSherbim.Location = New System.Drawing.Point(237, 17)
        Me.chSherbim.Name = "chSherbim"
        Me.chSherbim.Size = New System.Drawing.Size(64, 17)
        Me.chSherbim.TabIndex = 23
        Me.chSherbim.Text = "Shërbim"
        Me.chSherbim.UseVisualStyleBackColor = True
        '
        'chKontrate
        '
        Me.chKontrate.AutoSize = True
        Me.chKontrate.Location = New System.Drawing.Point(307, 17)
        Me.chKontrate.Name = "chKontrate"
        Me.chKontrate.Size = New System.Drawing.Size(84, 17)
        Me.chKontrate.TabIndex = 24
        Me.chKontrate.Text = "Me Kontratë"
        Me.chKontrate.UseVisualStyleBackColor = True
        '
        'chPerkohshem
        '
        Me.chPerkohshem.AutoSize = True
        Me.chPerkohshem.Location = New System.Drawing.Point(397, 17)
        Me.chPerkohshem.Name = "chPerkohshem"
        Me.chPerkohshem.Size = New System.Drawing.Size(101, 17)
        Me.chPerkohshem.TabIndex = 25
        Me.chPerkohshem.Text = "Të Përkohshëm"
        Me.chPerkohshem.UseVisualStyleBackColor = True
        '
        'btnPastro
        '
        Me.btnPastro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPastro.Image = CType(resources.GetObject("btnPastro.Image"), System.Drawing.Image)
        Me.btnPastro.Location = New System.Drawing.Point(801, 18)
        Me.btnPastro.Name = "btnPastro"
        Me.btnPastro.Size = New System.Drawing.Size(84, 30)
        Me.btnPastro.TabIndex = 19
        Me.btnPastro.Text = "Pastro"
        Me.btnPastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPastro.UseVisualStyleBackColor = True
        '
        'btnKthehuni
        '
        Me.btnKthehuni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnKthehuni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKthehuni.Image = CType(resources.GetObject("btnKthehuni.Image"), System.Drawing.Image)
        Me.btnKthehuni.Location = New System.Drawing.Point(1009, 20)
        Me.btnKthehuni.Name = "btnKthehuni"
        Me.btnKthehuni.Size = New System.Drawing.Size(92, 26)
        Me.btnKthehuni.TabIndex = 18
        Me.btnKthehuni.Text = "Kthehuni"
        Me.btnKthehuni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnKthehuni.UseVisualStyleBackColor = True
        '
        'btnFiltro
        '
        Me.btnFiltro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltro.Image = CType(resources.GetObject("btnFiltro.Image"), System.Drawing.Image)
        Me.btnFiltro.Location = New System.Drawing.Point(891, 19)
        Me.btnFiltro.Name = "btnFiltro"
        Me.btnFiltro.Size = New System.Drawing.Size(84, 27)
        Me.btnFiltro.TabIndex = 17
        Me.btnFiltro.Text = "Filtro"
        Me.btnFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnFiltro.UseVisualStyleBackColor = True
        '
        'frm_Detaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1113, 535)
        Me.Controls.Add(Me.btnPastro)
        Me.Controls.Add(Me.btnKthehuni)
        Me.Controls.Add(Me.btnFiltro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvPunt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_Detaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Të dhëna të Detajuara (Nga Edison Neza)"
        CType(Me.dgvPunt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvPunt As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltro As System.Windows.Forms.Button
    Friend WithEvents btnKthehuni As System.Windows.Forms.Button
    Friend WithEvents chTeknologji As System.Windows.Forms.CheckBox
    Friend WithEvents chMarketing As System.Windows.Forms.CheckBox
    Friend WithEvents chProdhim As System.Windows.Forms.CheckBox
    Friend WithEvents chSherbim As System.Windows.Forms.CheckBox
    Friend WithEvents chKontrate As System.Windows.Forms.CheckBox
    Friend WithEvents chPerkohshem As System.Windows.Forms.CheckBox
    Friend WithEvents chMeshkuj As System.Windows.Forms.CheckBox
    Friend WithEvents chFemra As System.Windows.Forms.CheckBox
    Friend WithEvents btnPastro As System.Windows.Forms.Button
End Class
