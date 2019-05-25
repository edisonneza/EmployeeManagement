Imports System.Data
Imports System.Data.OleDb


Public Class frmHyrja
    Dim lidhja As New OleDbConnection
    Dim komandat As New OleDbCommand
    Dim adaptor As New OleDbDataAdapter
    Dim leximi As OleDbDataReader
    Dim pyetja As String

    Private Sub frmHyrja_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pergj As New DialogResult
        pergj = MessageBox.Show("Dëshironi të mbyllni programin?", "Kujdes !!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If pergj = DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

 

    Private Sub frmHyrja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'lidhja e vertet
            'lidhja.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=database.mdb"
            lidhja.ConnectionString = My.Settings.ConnectionString
            If Not lidhja.State = ConnectionState.Open Then
                lidhja.Open()
            End If

        Catch ex As Exception
            ' lidhja jo e sakt
            MsgBox("Gabime ne lidhje", vbCritical, "Shiko lidhjen")
        End Try
        'mqs aplikacioni perdoret me se shumti nga pergjegjesit ate default caktojme rbpergj
        rbPergj.PerformClick()
    End Sub
    Private Sub pastro()
        txtperdoruesi.Text = String.Empty
        txtfjalekalimi.Text = String.Empty
        txtperdoruesi.Focus()

    End Sub
    Private Sub btnHyni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHyni.Click
        If rbAdmin.Checked Then
            'per te vendosur ne tabelen Hyrjet veprimin e kryer dmth loggin
            If Not lidhja.State = ConnectionState.Open Then
                lidhja.Open()
            End If

            pyetja = "SELECT * FROM Administratore WHERE ADMIN_EMER = '" & txtperdoruesi.Text &
                    "' AND ADMIN_FJALEKALIM = '" & txtfjalekalimi.Text & "'"
            
            komandat = New OleDbCommand(pyetja, lidhja)
            adaptor.SelectCommand = komandat
            leximi = komandat.ExecuteReader

            If (txtfjalekalimi.Text = "" OrElse txtperdoruesi.Text = "") Then
                MsgBox("Te dhena te pa plotesuara ", vbInformation, "Kujdes!!")
                txtperdoruesi.Focus()
            End If

            If leximi.HasRows = True Then


                'marrim vlerat e ID, Emrit dhe Mbiemrit
                Dim id As New OleDb.OleDbDataAdapter("SELECT * FROM Administratore " & _
                                                      " WHERE ADMIN_EMER='" & txtperdoruesi.Text & "' AND ADMIN_FJALEKALIM='" & txtfjalekalimi.Text & "'", lidhja)
                Dim dt As New DataTable
                id.Fill(dt)

                Dim perd_id As String = dt.Rows(0).Item("ADMIN_ID")
                Dim perd_emer As String = dt.Rows(0).Item("ADMIN_EMER")


                Dim komanda2 As New OleDb.OleDbCommand("INSERT INTO Hyrjet ([HYRJET_DATE], [HYRJET_PERD_ID], [HYRJET_PERD_EMER], [HYRJET_VEPRIMI]) VALUES (@DATA, @PERD_ID, @PERD_EMER, @VEPR)", lidhja)

                Dim data As New DateTime
                data = Now
                'vendosja e ementeve me parametra si me poshte
                With komanda2.Parameters
                    .AddWithValue("@DATA", data.ToString)
                    .AddWithValue("@PERD_ID", perd_id)
                    .AddWithValue("@PERD_EMER", perd_emer)
                    .AddWithValue("@VEPR", "Administratori " & perd_emer & " ka hyre ne sistem")
                End With
                komanda2.ExecuteNonQuery()


                'mbyllim lidhjen
                lidhja.Close()
                'pastrojm textbox
                pastro()
                'fshehim formen aktuale
                Me.Hide()
                'shfaqim formen kryesore
                frmKryesore.Show()
            ElseIf (txtfjalekalimi.Text <> "" And txtfjalekalimi.Text <> "" And leximi.HasRows = False) Then
                MsgBox("Te dhena te gabuara", vbInformation, "Kujdes!!")
                pastro()
            End If

        ElseIf rbPergj.Checked Then
            'per te vendosur ne tabelen Hyrjet veprimin e kryer dmth loggin
            If Not lidhja.State = ConnectionState.Open Then
                lidhja.Open()
            End If
            pyetja = "SELECT PERD_EMER, PERD_FJALEKALIM FROM Perdorues WHERE PERD_EMER = '" & txtperdoruesi.Text &
                    "'AND PERD_FJALEKALIM = '" & txtfjalekalimi.Text & "'"
            komandat = New OleDbCommand(pyetja, lidhja)
            adaptor.SelectCommand = komandat
            leximi = komandat.ExecuteReader

            If (txtfjalekalimi.Text = "" OrElse txtperdoruesi.Text = "") Then
                MsgBox("Te dhena te pa plotesuara ", vbInformation, "Kujdes!!")
                txtperdoruesi.Focus()
            End If

            If leximi.HasRows = True Then

                'marrim vlerat e ID, Emrit dhe Mbiemrit
                Dim id As New OleDb.OleDbDataAdapter("SELECT * FROM Perdorues " & _
                                                      " WHERE PERD_EMER='" & txtperdoruesi.Text & "' AND PERD_FJALEKALIM='" & txtfjalekalimi.Text & "'", lidhja)
                Dim dt As New DataTable
                id.Fill(dt)

                Dim perd_id As String = dt.Rows(0).Item("PERD_ID")
                Dim perd_emer As String = dt.Rows(0).Item("PERD_EMER")


                Dim komanda2 As New OleDb.OleDbCommand("INSERT INTO Hyrjet ([HYRJET_DATE], [HYRJET_PERD_ID], [HYRJET_PERD_EMER], [HYRJET_VEPRIMI]) VALUES (@DATA, @PERD_ID, @PERD_EMER, @VEPR)", lidhja)

                Dim data As New DateTime
                data = Now
                With komanda2.Parameters
                    .AddWithValue("@DATA", data.ToString)
                    .AddWithValue("@PERD_ID", perd_id)
                    .AddWithValue("@PERD_EMER", perd_emer)
                    .AddWithValue("@VEPR", "Përgjegjësi " & perd_emer & " ka hyre ne sistem")

                End With
                komanda2.ExecuteNonQuery()
                pastro()
                Me.Hide()
                frmShtoPuntore.Show()
           ElseIf (txtfjalekalimi.Text <> "" And txtfjalekalimi.Text <> "" And leximi.HasRows = False) Then
                MsgBox("Te dhena te gabuara", vbInformation, "Kujdes!!")
                pastro()
            End If

        End If
        lidhja.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDilni.Click
        Me.Close()
    End Sub

   
    'mos te pranoje pervec shkronjave dhe numrave. Duke perdorur ngjarjen KEYPRESS
    Private Sub txtperdoruesi_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtperdoruesi.KeyPress, txtfjalekalimi.KeyPress
        If (e.KeyChar = "\" Or e.KeyChar = "!" Or e.KeyChar = "@" Or e.KeyChar = "#" Or e.KeyChar = "$" Or e.KeyChar = "%" Or e.KeyChar = "^" Or _
              e.KeyChar = "&" Or e.KeyChar = "*" Or e.KeyChar = "(" Or e.KeyChar = ")" Or e.KeyChar = "-" Or e.KeyChar = "=" Or _
               e.KeyChar = "_" Or e.KeyChar = "+" Or e.KeyChar = "`" Or e.KeyChar = "~" Or e.KeyChar = ">" Or e.KeyChar = "<" Or e.KeyChar = "/" Or _
                  e.KeyChar = "?" Or e.KeyChar = "'" Or e.KeyChar = "[" Or e.KeyChar = "]" Or e.KeyChar = "{" Or e.KeyChar = "}" _
                   Or e.KeyChar = "," Or e.KeyChar = "." Or e.KeyChar = ";" Or e.KeyChar = ":") Then
            e.Handled = True
        End If
    End Sub

End Class
