Imports System.Data
Imports System.Data.OleDb
Public Class frmKryesore
    Dim lidhja As New OleDbConnection
    Dim komandat As New OleDbCommand
    Dim adaptor As New OleDbDataAdapter
    Dim leximi As OleDbDataReader
    Dim pyetja As String
   

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKyc.Click
        frmHyrja.Show()
        Me.Hide()
    End Sub

    Private Sub btnShtoPerdorues_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShtoAdmin.Click
        Me.Hide()
        frmAdmin.Show()

    End Sub

    Private Sub frmKryesore_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pergj As New DialogResult
        pergj = MessageBox.Show("Dëshironi të mbyllni programin?", "Kujdes !!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If pergj = DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPunonjes.Click
        Me.Hide()
        frmShtoPuntore.Show()

    End Sub

    Private Sub btnPergjegjes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPergjegjes.Click
        Me.Hide()
        frmShtoPerdorues.Show()

    End Sub

    Private Sub btnPaga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaga.Click
        Me.Hide()
        frmPaga.Show()
    End Sub

    Private Sub btnDB_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDB.Click
        Dim pergj As DialogResult
        pergj = MessageBox.Show("Jeni të sigurt që doni të kryeni këtë veprim?", "Kujdes!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)



        If rbBackup.Checked = False And rbRimerre.Checked = False Then
            MsgBox("Ju lutem zgjidhni një nga opsionet!", vbInformation)

            'veprimet per krijimin e backup-it te DB
        ElseIf rbBackup.Checked = True And pergj = DialogResult.Yes Then
            'deklarojme variablat per zhvendosje, vendodhje dhe fshirje te databazes
            Dim db_per_zhvendosje As String
            Dim db_vendodhja As String
            Dim db_per_fshirje As String

            db_per_zhvendosje = "" & System.Environment.CurrentDirectory & "\database.mdb"
            db_vendodhja = "" & System.Environment.CurrentDirectory & "\backup\database.mdb"
            db_per_fshirje = "" & System.Environment.CurrentDirectory & "\backup\database.mdb"

            System.IO.File.Delete(db_per_fshirje)
            System.IO.File.Copy(db_per_zhvendosje, db_vendodhja)
            MsgBox("Krijimi i Backup-it për DB u krye me sukses!", vbInformation)
            'bejme checkimin e rb false
            rbBackup.Checked = False
            rbRimerre.Checked = False


            'veprimet per rimarrjen e databases

        ElseIf rbRimerre.Checked = True And pergj = DialogResult.Yes Then
            Dim db_per_zhvendosje As String
            Dim db_vendodhja As String
            Dim db_per_fshirje As String


            'per te bere rimarrjen duhet te fshijme db aktuale dhe ta rimarrim ate ne folderin qe kemi kryer backup
            db_per_zhvendosje = "" & System.Environment.CurrentDirectory & "\backup\database.mdb"
            db_vendodhja = "" & System.Environment.CurrentDirectory & "\database.mdb"
            db_per_fshirje = "" & System.Environment.CurrentDirectory & "\database.mdb"

            System.IO.File.Delete(db_per_fshirje)
            System.IO.File.Copy(db_per_zhvendosje, db_vendodhja)
            MsgBox("Rimarrja e Backup-it për DB u krye me sukses!", vbInformation)
            'bejme checkimin e rb false
            rbBackup.Checked = False
            rbRimerre.Checked = False

        End If

        btnKyc.Focus()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDilni.Click
        Me.Close()
    End Sub

  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVeprimet.Click
        Me.Hide()
        frm_Hyrjet.Show()

    End Sub

    Private Sub frmKryesore_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lidhja = New OleDb.OleDbConnection
        'lidhja.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=database.mdb"
        lidhja.ConnectionString = My.Settings.ConnectionString
    End Sub
    'mos te pranoje pervec shkronjave dhe numrave. Duke perdorur ngjarjen KEYPRESS
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar = "\" Or e.KeyChar = "!" Or e.KeyChar = "@" Or e.KeyChar = "#" Or e.KeyChar = "$" Or e.KeyChar = "%" Or e.KeyChar = "^" Or _
              e.KeyChar = "&" Or e.KeyChar = "*" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "-" Or e.KeyChar = "=" Or _
               e.KeyChar = "_" Or e.KeyChar = "+" Or e.KeyChar = "`" Or e.KeyChar = "~" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "/" Or _
                  e.KeyChar = "?" Or e.KeyChar = "'" Or e.KeyChar = "[" Or e.KeyChar = "]" Or e.KeyChar = "{" Or e.KeyChar = "}" _
                   Or e.KeyChar = "," Or e.KeyChar = "." Or e.KeyChar = ";" Or e.KeyChar = ":") Then
            e.Handled = True
        End If
    End Sub

    
    Private Sub rbBackup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbBackup.CheckedChanged

    End Sub
End Class