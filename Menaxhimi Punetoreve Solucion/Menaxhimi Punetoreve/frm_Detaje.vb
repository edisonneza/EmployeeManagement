Imports System.Data
Imports System.Data.OleDb
Public Class frm_Detaje
    'deklarojme lidhjen

    Dim lidhja As New OleDb.OleDbConnection
    Private Sub FreskoTeDhenat()
        'nqs lidhja nuk eshte hapur atehere e hapim
        If Not lidhja.State = ConnectionState.Open Then
            lidhja.Open()
        End If
        Dim pyetja As New OleDb.OleDbDataAdapter("SELECT PUNT_ID AS [ID], PUNT_EMER AS [EMRI], PUNT_MBIEMER AS [MBIEMRI], " & _
                                                 "PUNT_GJINI AS [GJINIA], PUNT_DEP AS [DEPARTAMENTI], PUNT_DTLINDJE AS [DATELINDJA], PUNT_TEL AS [TEL], PUNT_STATUS AS [STATUSI], " & _
                                                 "PUNT_POZ AS [POZICIONI], PUNT_ADRESE AS [ADRESA], PUNT_POSTKOD AS [ZIP], PUNT_STCIVIL AS [ST_CIVIL] FROM Punetore ORDER BY PUNT_ID", lidhja)
        
        Dim dt As New DataTable
        'vendosim te dhenat ne datatable
        pyetja.Fill(dt)
        'vendosim te dhenat ne datagridview
        dgvPunt.DataSource = dt

        'mbyllim lidhjen
        lidhja.Close()

    End Sub
    Public Sub modDGV()
        With dgvPunt
            .Columns(0).Width = 33
            .Columns(1).Width = 95
            .Columns(2).Width = 90
            .Columns(3).Width = 90
            .Columns(4).Width = 90
            .Columns(5).Width = 90
            .Columns(6).Width = 90
            .Columns(7).Width = 90
            .Columns(8).Width = 90
            .Columns(9).Width = 90
            .Columns(10).Width = 90
            .Columns(11).Width = 90

        End With
    End Sub

    Private Sub frm_Detaje_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pergj As New DialogResult
        pergj = MessageBox.Show("Dëshironi të mbyllni programin?", "Kujdes !!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If pergj = DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub
    Private Sub frm_Detaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'lidhja.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=database.mdb"
        lidhja.ConnectionString = My.Settings.ConnectionString
        'therrasim  fresko te dhenat
        FreskoTeDhenat()
        'therrasim modDGV per te bere modifikimin e DataGridView
        modDGV()
    End Sub

    Private Sub btnFiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltro.Click
        If Not lidhja.State = ConnectionState.Open Then
            lidhja.Open()
        End If
        Try

            Dim pyetja As String = "SELECT PUNT_ID AS [ID], PUNT_EMER AS [EMRI], PUNT_MBIEMER AS [MBIEMRI], " & _
                                    "PUNT_GJINI AS [GJINIA], PUNT_DEP AS [DEPARTAMENTI], PUNT_DTLINDJE AS [DATELINDJA], PUNT_TEL AS [TEL], PUNT_STATUS AS [STATUSI], " & _
                                    "PUNT_POZ AS [POZICIONI], PUNT_ADRESE AS [ADRESA], PUNT_POSTKOD AS [ZIP], PUNT_STCIVIL AS [ST_CIVIL] FROM Punetore  "
            Dim ku As String = ""
            If chTeknologji.Checked Then ku &= " PUNT_DEP = 'Teknologji' OR"
            If chMarketing.Checked Then ku &= " PUNT_DEP = 'Marketing' OR"
            If chProdhim.Checked Then ku &= " PUNT_DEP = 'Prodhim' OR"
            If chSherbim.Checked Then ku &= " PUNT_DEP = 'Sherbim' OR"
            If chFemra.Checked Then ku &= " PUNT_GJINI = 'Femer' OR"
            If chMeshkuj.Checked Then ku &= " PUNT_GJINI= 'Mashkull' OR"
            If chKontrate.Checked Then ku &= " PUNT_STATUS= 'Kontrat' OR"
            If chPerkohshem.Checked Then ku &= " PUNT_STATUS= 'Përkohshëm' OR"
            If ku <> "" Then pyetja &= "WHERE" & ku
            pyetja = pyetja.Substring(0, Len(pyetja) - 2)
            Dim kom As New OleDb.OleDbCommand(pyetja, lidhja)
            Dim adapter As New OleDb.OleDbDataAdapter

            Dim dt As New DataTable
            adapter.SelectCommand = kom
            adapter.Fill(dt)
            dgvPunt.DataSource = dt
            adapter.Dispose()
            kom.Dispose()
            lidhja.Close()

        Catch
                MsgBox("Ju lutem zgjidhni nje nga opsionet per te filtruar!", vbInformation)
        End Try
        'therrasim modDGV
        modDGV()

    End Sub

    Private Sub btnKthehuni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKthehuni.Click
        Me.Hide()
        frmShtoPuntore.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPastro.Click
        chFemra.Checked = False
        chMeshkuj.Checked = False
        chKontrate.Checked = False
        chPerkohshem.Checked = False
        chMarketing.Checked = False
        chSherbim.Checked = False
        chProdhim.Checked = False
        chTeknologji.Checked = False

    End Sub

End Class