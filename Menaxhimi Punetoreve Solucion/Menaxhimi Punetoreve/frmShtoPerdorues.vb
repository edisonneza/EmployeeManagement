Option Explicit On
Option Infer Off
Option Strict On

Imports System.Data
Imports System.Data.OleDb


Public Class frmShtoPerdorues
    'krijojme variablin qe deklaron nje lidhje me databasem
    Dim lidhja As New OleDb.OleDbConnection

    Private Sub FreskoTeDhenat()
        'kontrollojme nese lidhja eshte hapur, nese jo e hapim
        If Not lidhja.State = ConnectionState.Open Then
            'hapim lidhjen
            lidhja.Open()
        End If
        'deklarojme variablin qe permban komanden select per te afishuar te dhenat
        Dim query As New OleDb.OleDbDataAdapter("SELECT PERD_ID as [ID], PERD_EMER as [Perdoruesi], " & _
                                             " PERD_FJALEKALIM as [Fjalekalimi], PERD_DEP AS [Departamenti], PERD_DATE as [Data] FROM Perdorues ORDER BY Perd_ID", lidhja)
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
        txtfjalekalimi.Text = String.Empty
        txtperdoruesi.Text = ""
    End Sub

    Private Sub frmShtoPerdorues_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pergj As New DialogResult
        pergj = MessageBox.Show("Dëshironi të mbyllni programin?", "Kujdes !!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If pergj = DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub frmShtoPerdorues_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtperdoruesi.Focus()

        lidhja = New OleDb.OleDbConnection
        lidhja.ConnectionString = "Provider=Microsoft.Jet.Oledb.4.0; Data Source=database.mdb"
        'marrim te dhenat
        Me.FreskoTeDhenat()
        'mbushim combobox-in e Departamentit me element
        cbDep.Items.Add("Teknologji")
        cbDep.Items.Add("Marketing")
        cbDep.Items.Add("Prodhim")
        cbDep.Items.Add("Sherbim")
        cbDep.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmKryesore.Show()

    End Sub


    Private Sub btnShto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShto.Click
        Dim komanda As New OleDb.OleDbCommand
        If Not lidhja.State = ConnectionState.Open Then
            lidhja.Open()
        End If

        komanda.Connection = lidhja
        If (txtfjalekalimi.Text = "" OrElse txtperdoruesi.Text = "") Then
            MsgBox("Ju lutemi plotesoni te dhenat", vbInformation, "Kujdes!!")
        Else
            'shfaqim daten ne labelin lbldate
            lbldata.Text = Now.Date().ToString
            'shtojme te dhena te reja
            'i vendosim te dhenat

            komanda.CommandText = "INSERT INTO Perdorues( PERD_EMER, PERD_FJALEKALIM, PERD_DEP, PERD_DATE ) " & _
                                "VALUES ('" & txtperdoruesi.Text & "','" & txtfjalekalimi.Text & "','" & cbDep.Text & "','" & lbldata.Text & "')"

            komanda.ExecuteNonQuery()

            'freskojme te dhenat
            FreskoTeDhenat()

            'mbyllim lidhjen()
            lidhja.Close()

            'funksioni qe pastron textbox-et
            pastrotxtbox()
            'fokusojme tek txtID.text
            txtperdoruesi.Focus()

        End If
    End Sub


    Private Sub btnFshi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFshi.Click
        'kontrollojme per elementin e selektuar
        If dgvData.Rows.Count > 0 Then
            If dgvData.SelectedRows.Count > 0 Then
                Dim intPerd_ID As Integer = Convert.ToInt16(dgvData.SelectedRows(0).Cells("ID").Value)
                'hapim lidhjen
                If Not lidhja.State = ConnectionState.Open Then
                    lidhja.Open()

                End If
                Dim pergj As DialogResult = MessageBox.Show("Dëshironi të fshini këtë Përgjegjës?", "Kujdes!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If pergj = DialogResult.Yes Then
                    'fshijme te dhenat
                    Dim komanda As New OleDb.OleDbCommand
                    komanda.Connection = lidhja
                    komanda.CommandText = "DELETE FROM Perdorues WHERE Perd_ID= " & intPerd_ID
                    komanda.ExecuteNonQuery()
                    'freskojme te dhenat
                    FreskoTeDhenat()
                    'mbyllim lidhjen
                    lidhja.Close()
                End If
            Else
                MsgBox("Ju duhet të keni selektuar një rrjesht ", vbInformation, "Kujdes!")
            End If
        End If

        txtperdoruesi.Focus()

    End Sub
    'mos te pranoje pervec shkronjave dhe numrave. Duke perdorur ngjarjen KEYPRESS
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtperdoruesi.KeyPress, txtfjalekalimi.KeyPress
        If (e.KeyChar = "\" Or e.KeyChar = "!" Or e.KeyChar = "@" Or e.KeyChar = "#" Or e.KeyChar = "$" Or e.KeyChar = "%" Or e.KeyChar = "^" Or _
              e.KeyChar = "&" Or e.KeyChar = "*" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "-" Or e.KeyChar = "=" Or _
               e.KeyChar = "_" Or e.KeyChar = "+" Or e.KeyChar = "`" Or e.KeyChar = "~" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "/" Or _
                  e.KeyChar = "?" Or e.KeyChar = "'" Or e.KeyChar = "[" Or e.KeyChar = "]" Or e.KeyChar = "{" Or e.KeyChar = "}" _
                   Or e.KeyChar = "," Or e.KeyChar = "." Or e.KeyChar = ";" Or e.KeyChar = ":") Then
            e.Handled = True
        End If
    End Sub
  
End Class