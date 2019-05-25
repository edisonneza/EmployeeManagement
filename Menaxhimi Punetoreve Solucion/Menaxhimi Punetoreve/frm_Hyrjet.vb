Imports System.Data
Imports System.Data.OleDb


Public Class frm_Hyrjet
    Dim lidhja As New OleDbConnection
    Dim pyetja As String

    Private Sub frm_Hyrjet_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pergj As New DialogResult
        pergj = MessageBox.Show("Dëshironi të mbyllni programin?", "Kujdes !!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If pergj = DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub
    Private Sub frm_Hyrjet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'lidhja.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=database.mdb"
        lidhja.ConnectionString = My.Settings.ConnectionString

        freskoTeDhenat()
    End Sub
    Private Sub freskoTeDhenat()
        If Not lidhja.State = ConnectionState.Open Then
            lidhja.Open()
        End If
        Dim pyetja As New OleDbDataAdapter("SELECT HYRJET_ID AS [ID], HYRJET_DATE AS [DATE], HYRJET_PERD_ID AS [PERD_ID], HYRJET_PERD_EMER AS [PERD_EMER], HYRJET_VEPRIMI AS [VEPRIMI KRYER] FROM Hyrjet ORDER BY HYRJET_ID DESC", lidhja)
        Dim dt As New DataTable
        pyetja.Fill(dt)
        'vendosim te dhenat ne datatable
        Me.dgvHyrjet.DataSource = dt
        'funksionin per ndryshimin e dukjes se DGV
        modDGV()
        'mbyllim lidhjen
        lidhja.Close()

    End Sub
    Public Sub modDGV()
        With dgvHyrjet
            .Columns(0).Width = 30
            .Columns(1).Width = 140
            .Columns(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(2).Width = 45
            .Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(3).Width = 87
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).Width = 272
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End With
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmKryesore.Show()

    End Sub

  
End Class