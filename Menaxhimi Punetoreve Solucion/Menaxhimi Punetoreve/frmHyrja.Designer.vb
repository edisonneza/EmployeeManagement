<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHyrja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHyrja))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtperdoruesi = New System.Windows.Forms.TextBox()
        Me.txtfjalekalimi = New System.Windows.Forms.TextBox()
        Me.btnHyni = New System.Windows.Forms.Button()
        Me.btnDilni = New System.Windows.Forms.Button()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbPergj = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Përdoruesi:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fjalëkalimi:"
        '
        'txtperdoruesi
        '
        Me.txtperdoruesi.Location = New System.Drawing.Point(127, 17)
        Me.txtperdoruesi.Name = "txtperdoruesi"
        Me.txtperdoruesi.Size = New System.Drawing.Size(189, 20)
        Me.txtperdoruesi.TabIndex = 1
        '
        'txtfjalekalimi
        '
        Me.txtfjalekalimi.Location = New System.Drawing.Point(127, 48)
        Me.txtfjalekalimi.Name = "txtfjalekalimi"
        Me.txtfjalekalimi.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtfjalekalimi.Size = New System.Drawing.Size(189, 20)
        Me.txtfjalekalimi.TabIndex = 2
        '
        'btnHyni
        '
        Me.btnHyni.BackColor = System.Drawing.SystemColors.Control
        Me.btnHyni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHyni.Image = CType(resources.GetObject("btnHyni.Image"), System.Drawing.Image)
        Me.btnHyni.Location = New System.Drawing.Point(127, 97)
        Me.btnHyni.Name = "btnHyni"
        Me.btnHyni.Size = New System.Drawing.Size(91, 26)
        Me.btnHyni.TabIndex = 5
        Me.btnHyni.Text = "Hyni"
        Me.btnHyni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnHyni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHyni.UseVisualStyleBackColor = False
        '
        'btnDilni
        '
        Me.btnDilni.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDilni.Image = CType(resources.GetObject("btnDilni.Image"), System.Drawing.Image)
        Me.btnDilni.Location = New System.Drawing.Point(240, 97)
        Me.btnDilni.Name = "btnDilni"
        Me.btnDilni.Size = New System.Drawing.Size(76, 26)
        Me.btnDilni.TabIndex = 6
        Me.btnDilni.Text = "Dilni"
        Me.btnDilni.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDilni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnDilni.UseVisualStyleBackColor = True
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Location = New System.Drawing.Point(127, 74)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(91, 17)
        Me.rbAdmin.TabIndex = 3
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Administratore"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'rbPergj
        '
        Me.rbPergj.AutoSize = True
        Me.rbPergj.Location = New System.Drawing.Point(240, 74)
        Me.rbPergj.Name = "rbPergj"
        Me.rbPergj.Size = New System.Drawing.Size(74, 17)
        Me.rbPergj.TabIndex = 4
        Me.rbPergj.TabStop = True
        Me.rbPergj.Text = "Përgjegjës"
        Me.rbPergj.UseVisualStyleBackColor = True
        '
        'frmHyrja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(348, 135)
        Me.Controls.Add(Me.rbPergj)
        Me.Controls.Add(Me.rbAdmin)
        Me.Controls.Add(Me.btnDilni)
        Me.Controls.Add(Me.btnHyni)
        Me.Controls.Add(Me.txtfjalekalimi)
        Me.Controls.Add(Me.txtperdoruesi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmHyrja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mirësevini (Nga Edison Neza)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtperdoruesi As System.Windows.Forms.TextBox
    Friend WithEvents txtfjalekalimi As System.Windows.Forms.TextBox
    Friend WithEvents btnHyni As System.Windows.Forms.Button
    Friend WithEvents btnDilni As System.Windows.Forms.Button
    Friend WithEvents rbAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents rbPergj As System.Windows.Forms.RadioButton

End Class
