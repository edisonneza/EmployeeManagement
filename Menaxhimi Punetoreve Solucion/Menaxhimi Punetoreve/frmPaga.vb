Imports System.Data
Imports System.Data.OleDb



Public Class frmPaga
    'deklarojme lidhjen
    Dim lidhja As New OleDb.OleDbConnection

    Private Sub FreskoTeDhenat()
        'nqs lidhja nuk eshte hapur atehere e hapim
        If Not lidhja.State = ConnectionState.Open Then
            lidhja.Open()
        End If
        Dim pyetja As New OleDb.OleDbDataAdapter("SELECT PUNT_ID AS [ID], PUNT_EMER AS [EMRI], PUNT_MBIEMER AS [MBIEMRI], " & _
                                                 "PAGA_ORE AS [ORE], PAGA_CMIM AS [CMIM/ORE (leke)], PAGA_TOTAL AS [TOTAL (leke)] , PAGA_DATE AS [DT/FILLIMIT] FROM Punetore, Paga WHERE PUNT_ID = PAGA_ID ORDER BY PUNT_ID", lidhja)

        Dim dt As New DataTable
        'vendosim te dhenat ne datatable
        pyetja.Fill(dt)
        'vendosim te dhenat ne datagridview
        dgvPAGA.DataSource = dt
        'therrasim modDGV
        modDGV()
        'mbyllim lidhjen
        lidhja.Close()

    End Sub
    Public Sub modDGV()
        With dgvPAGA
            .Columns(0).Width = 33
            .Columns(1).Width = 85
            .Columns(2).Width = 85
            .Columns(3).Width = 42
            .Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(4).Width = 85
            .Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(5).Width = 85
            .Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(6).Width = 110
            .Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub frmPaga_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pergj As New DialogResult
        pergj = MessageBox.Show("Dëshironi të mbyllni programin?", "Kujdes !!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If pergj = DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub
    Private Sub Print_Rroga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        lidhja = New OleDb.OleDbConnection
        'lidhja.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=database.mdb"
        lidhja.ConnectionString = My.Settings.ConnectionString
        'therrasim funksionin fresko te dhenat
        FreskoTeDhenat()
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        frmKryesore.Show()
    End Sub

    Private Sub btnDergo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDergo.Click
      
        Dim komanda As New OleDbCommand

        'kontrollojme per elementin e selektuar ne DGV
        If dgvPAGA.Rows.Count > 0 Then
            If dgvPAGA.SelectedRows.Count > 0 Then
                Dim intPUNT_ID As Integer = dgvPAGA.SelectedRows(0).Cells("ID").Value

                'kontrollojme lidhjen
                If Not lidhja.State = ConnectionState.Open Then
                    lidhja.Open()
                End If
                Dim cmimi As Double = Convert.ToDouble(txtPagesa.Text)
               
                'shkruajme komanden
                komanda.Connection = lidhja
                'vendosim cmimin dmth i behet update nga gjendja fillestare 0
                komanda.CommandText = "UPDATE Paga SET PAGA_CMIM= PAGA_CMIM + " & cmimi & " WHERE PAGA_ID =" & intPUNT_ID
                Dim komanda2 As New OleDbCommand
                'bejme llogaritjen direkte te pages_totale
                komanda2.Connection = lidhja
                komanda2.CommandText = "UPDATE Paga SET PAGA_TOTAL = PAGA_ORE * PAGA_CMIM"

                komanda.ExecuteNonQuery()
                komanda2.ExecuteNonQuery()
                
                'bejme refresh te dhenave
                FreskoTeDhenat()
                'mbyllim lidhjen
                lidhja.Close()
            ElseIf txtPagesa.Text = "" Then
                MsgBox("E dhëna që kërkohet e pa plotësuar !", vbExclamation, "Kujdes!!")

            Else
                MsgBox("Ju duhet të selektoni një rrjesht", vbInformation, "Kujdes!")
            End If
        End If
        'pastrojme txtpagesa
        txtPagesa.Text = ""
        'focusojme textbox
        txtPagesa.Focus()
    End Sub

    Private Sub btnLLogarit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLlogarit.Click
        'kontrollojme per elementin e selektuar ne DGV
        If dgvPAGA.Rows.Count > 0 Then
            If dgvPAGA.SelectedRows.Count > 0 Then
                Dim dblPAGA_TOTAL As Double = dgvPAGA.SelectedRows(0).Cells("TOTAL (leke)").Value
                'llogarisim pagen Neto ne varesi taksave dhe kontributeve
                'Formula e re e tatimit progresiv mbi pagën konsiston tani në tri shkallë:
                'Të ardhurat nga pagat nga 0 deri në 30 mijë lekë në muaj, tatohen me zero përqind, pra mbeten të përjashtuar nga tatimi mbi të ardhurat personale 
                'Të ardhurat pagat nga 30 mijë lekë/muaji deri në 130 mijë lekë/muaji, tatohen me 13% të diferencës midis pagës me pragun 30 mijë lekë/muaji 
                'Të ardhurat nga paga mbi 130 mijë lekë/muaji tatohen me 13,000 lekë plus 23% e diferencës së pagës me 130 mijë lek. 
                Dim dblNeto As Double
                If dblPAGA_TOTAL <= 30000 Then
                    'marrim vetem kontributet qe paguhen nga punjonesi dhe i zbresim 
                    'dblNeto = dblPAGA_TOTAL * 0.017 * 0.095
                    'marrim kontributet 0.279 qe eshte shuma e gjithe kontributeve
                    dblNeto = dblPAGA_TOTAL - (dblPAGA_TOTAL * 0.112)
                    lblNeto.Text = dblNeto.ToString
                ElseIf dblPAGA_TOTAL > 30000 OrElse dblPAGA_TOTAL <= 130000 Then
                    dblNeto = dblPAGA_TOTAL - ((dblPAGA_TOTAL * 0.112) + ((dblPAGA_TOTAL - 30000) * 0.13))
                    lblNeto.Text = dblNeto.ToString
                ElseIf dblPAGA_TOTAL > 130000 Then
                    dblNeto = dblPAGA_TOTAL - ((dblPAGA_TOTAL * 0.112) + (100000 * 0.13)) + ((dblPAGA_TOTAL - 130000) * 0.23)
                    lblNeto.Text = dblNeto.ToString
                End If
                'kontrollojme nese gjatesia e pages eshte me e madhe se 3 karaktere 
                'qe mos te kemi problem me strpaga.insert
                Dim strpaga As String = dblPAGA_TOTAL.ToString
                Dim strneto As String = dblNeto.ToString
                If strpaga.Length > 3 AndAlso strneto.Length > 3 Then
                    lblBruto.Text = strpaga.Insert(strpaga.Length - 3, ",")
                    lblNeto.Text = strneto.Insert(strneto.Length - 3, ",")
                Else
                    lblBruto.Text = dblPAGA_TOTAL.ToString
                    lblNeto.Text = dblNeto.ToString
                End If

                'pastrojme txtpagesa
                txtPagesa.Text = ""
                'bejme refresh te dhenave
                FreskoTeDhenat()
                'mbyllim lidhjen
                lidhja.Close()
            Else
                MsgBox("Ju duhet të selektoni një rrjesht", vbInformation, "Kujdes!")
            End If
        End If
    End Sub
    'mos te pranoje pervec  numrave , backspace  dhe presjes . Duke perdorur ngjarjen KEYPRESS
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPagesa.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "," AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
  

End Class