Option Explicit On
Option Infer Off
Option Strict On

Imports System.Data
Imports System.Data.OleDb

Public Class frmAdmin
    'lidhja me DB
    Dim lidhja As New OleDb.OleDbConnection

    Private Sub FreskoTeDhenat()
        'kontrollojme nese lidhja eshte hapur, nese jo e hapim
        If Not lidhja.State = ConnectionState.Open Then
            'hapim lidhjen
            lidhja.Open()
        End If
        'deklarojme variablin qe permban komanden select per te afishuar te dhenat
        Dim query As New OleDb.OleDbDataAdapter("SELECT ADMIN_ID as [ID], ADMIN_EMER as [Admin], " & _
                                             " ADMIN_FJALEKALIM as [Fjalekalimi], ADMIN_DATE as [Data] FROM Administratore ORDER BY ADMIN_ID", lidhja)
        Dim datatable As New DataTable
        'vendosim te dhenat ne datatable
        query.Fill(datatable)
        'vendosim te dhenat e datatable brenda datagridview
        Me.dgvData.DataSource = datatable

        'shfaqim daten ne labelin lbldate
        lbldata.Text = Now.Date().ToString

        'mbyllim lidhjen
        lidhja.Close()
    End Sub
    Private Sub pastrotxtbox()
        txtAdmin_Fjalekalim.Text = String.Empty
        txtAdmin_Emer.Text = ""
    End Sub


    'form closing
    Private Sub frmAdmin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pergj As New DialogResult
        pergj = MessageBox.Show("Dëshironi të mbyllni programin?", "Kujdes !!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If pergj = DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub




    Private Sub frmAdmin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'fokusojme kontrollerin tek txtadmin
        txtAdmin_Emer.Focus()

        lidhja = New OleDb.OleDbConnection
        lidhja.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=database.mdb"
        'marrim te dhenat
        Me.FreskoTeDhenat()

    End Sub

    Private Sub btnShto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShto.Click
        Dim komanda As New OleDb.OleDbCommand
        If Not lidhja.State = ConnectionState.Open Then
            lidhja.Open()
        End If

        komanda.Connection = lidhja
        If (txtAdmin_Fjalekalim.Text = "" OrElse txtAdmin_Emer.Text = "") Then
            MsgBox("Ju lutemi plotesoni te dhenat", vbInformation, "Kujdes!!")
        Else
            'shfaqim daten ne labelin lbldate
            lbldata.Text = Now.Date().ToString
            'shtojme te dhena te reja
            'i vendosim te dhenat

            komanda.CommandText = "INSERT INTO Administratore( ADMIN_EMER, ADMIN_FJALEKALIM, ADMIN_DATE ) " & _
                                "VALUES ('" & txtAdmin_Emer.Text & "','" & txtAdmin_Fjalekalim.Text & "','" & lbldata.Text & "')"

            komanda.ExecuteNonQuery()

            'freskojme te dhenat
            FreskoTeDhenat()

            'mbyllim lidhjen()
            lidhja.Close()

            'funksioni qe pastron textbox-et
            pastrotxtbox()
            'fokusojme tek txtID.text
            txtAdmin_Emer.Focus()
        End If

    End Sub

    Private Sub btnFshi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFshi.Click
        'kontrollojme per elementin e selektuar
        If dgvData.Rows.Count > 0 Then
            If dgvData.SelectedRows.Count > 0 Then
                Dim intAdmin_ID As Integer = Convert.ToInt16(dgvData.SelectedRows(0).Cells("ID").Value)
                'hapim lidhjen
                If Not lidhja.State = ConnectionState.Open Then
                    lidhja.Open()

                End If
                Dim pergj As DialogResult = MessageBox.Show("Dëshironi të fshini këtë Administrator?", "Kujdes!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If pergj = DialogResult.Yes Then
                    'fshijme te dhenat
                    Dim komanda As New OleDb.OleDbCommand
                    komanda.Connection = lidhja
                    komanda.CommandText = "DELETE FROM Administratore WHERE ADMIN_ID= " & intAdmin_ID
                    komanda.ExecuteNonQuery()
                    'freskojme te dhenat
                    FreskoTeDhenat()
                    'mbyllim lidhjen
                    lidhja.Close()
                End If
            Else
                MsgBox("Ju duhet të selektoni një rrjesht", vbInformation, "Kujdes!")
            End If
        End If

        txtAdmin_Emer.Focus()
    End Sub

    Private Sub btnMbyll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMbyll.Click
        Me.Hide()
        frmKryesore.Show()
    End Sub
    'mos te pranoje pervec shkronjave dhe numrave. Duke perdorur ngjarjen KEYPRESS
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAdmin_Emer.KeyPress, txtAdmin_Fjalekalim.KeyPress
        If (e.KeyChar = "\" Or e.KeyChar = "!" Or e.KeyChar = "@" Or e.KeyChar = "#" Or e.KeyChar = "$" Or e.KeyChar = "%" Or e.KeyChar = "^" Or _
              e.KeyChar = "&" Or e.KeyChar = "*" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "-" Or e.KeyChar = "=" Or _
               e.KeyChar = "_" Or e.KeyChar = "+" Or e.KeyChar = "`" Or e.KeyChar = "~" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "/" Or _
                  e.KeyChar = "?" Or e.KeyChar = "'" Or e.KeyChar = "[" Or e.KeyChar = "]" Or e.KeyChar = "{" Or e.KeyChar = "}" _
                   Or e.KeyChar = "," Or e.KeyChar = "." Or e.KeyChar = ";" Or e.KeyChar = ":") Then
            e.Handled = True
        End If
    End Sub
End Class