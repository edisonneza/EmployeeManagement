Imports System.Data
Imports System.Data.OleDb


Public Class frmShtoPuntore

    Dim lidhja As New OleDb.OleDbConnection
    'funksion per modifikimin e aparences se DGV
    Public Sub modDGV()
        With dgvPunt
            .Columns(0).Width = 24
            .Columns(1).Width = 85
            .Columns(2).Width = 85
            .Columns(3).Width = 85
            .Columns(4).Width = 85
            .Columns(7).Width = 70
            .Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns(8).Width = 70
            .Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub frmShtoPuntore_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim pergj As DialogResult
        pergj = MessageBox.Show("Dëshironi të dilni nga programi?", "Kujdes!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If pergj = DialogResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub

    Private Sub frmShtoPuntore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lidhja = New OleDb.OleDbConnection
        lidhja.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data source=database.mdb"
        'therrasim funksionin fresko te dhenat
        FreskoTeDhenat()
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'ngarkojme elemente ne listbox Ditore
        For nr As Double = 0.5 To 12 Step 0.5
            lstDitore.Items.Add(nr).ToString("D1")
        Next nr
        lstDitore.SelectedIndex = 15
        'ngarkojme elementet ne listbox Javore
        For nr1 As Double = 35 To 70 Step 0.5
            lstJavore.Items.Add(nr1).ToString("D1")
        Next nr1
        lstJavore.SelectedIndex = 10

        'kontrollojme radiobuttons
        If rbOre.Checked = False OrElse rbPunt.Checked = False OrElse rbModifiko.Checked = False Then
            grpOre.Visible = False
            grpPunt.Visible = False
            grpModifiko.Visible = False

        End If

        ' shtojme oren tek lblData
        lblData.Text = Now.Date().ToString
        lblData2.Text = Now.Date().ToString
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'mbushim vlerat e combobox-eve
        cbCivil.Items.Add("Martuar")
        cbCivil.Items.Add("Beqar")
        cbCivil.SelectedIndex = 1
        'cbCivil1
        cbCivil1.Items.Add("Martuar")
        cbCivil1.Items.Add("Beqar")


        'mbushim dhe caktojme default tek gjinia mashkull
        cbGjinia.Items.Add("Mashkull")
        cbGjinia.Items.Add("Femer")
        cbGjinia.SelectedIndex = 0

        'mbushim caktojme statusin default i perkohshem
        cbStatusi.Items.Add("Kontrat")
        cbStatusi.Items.Add("Përkohshëm")
        cbStatusi.SelectedIndex = 0

        'mbushim dhe caktojme default tek departamenti 
        cbDepartamenti.Items.Add("Teknologji")
        cbDepartamenti.Items.Add("Marketing")
        cbDepartamenti.Items.Add("Prodhim")
        cbDepartamenti.Items.Add("Sherbim")
        cbDepartamenti.SelectedIndex = 0


    End Sub
    Private Sub FreskoTeDhenat()
        'nqs lidhja nuk eshte hapur atehere e hapim
        If Not lidhja.State = ConnectionState.Open Then
            lidhja.Open()
        End If
        Dim pyetja As New OleDb.OleDbDataAdapter("SELECT PUNT_ID AS [ID], PUNT_EMER AS [EMRI], PUNT_MBIEMER AS [MBIEMRI], " & _
                                                 "PUNT_GJINI AS [GJINIA], PUNT_DEP AS [DEPARTAMENTI], PUNT_ADRESE AS [ADRESA], PUNT_TEL AS [TEL], PAGA_ORE AS [ORET], " & _
                                                 "PAGA_CMIM AS [CMIMI/ORE] FROM Punetore, Paga  WHERE Punetore.PUNT_ID = Paga.PAGA_ID ORDER BY PUNT_ID", lidhja)
      
        Dim dt As New DataTable
        'vendosim te dhenat ne datatable
        pyetja.Fill(dt)
        'vendosim te dhenat ne datagridview
        dgvPunt.DataSource = dt
        'therrasim modDGV
        modDGV()
        'mbyllim lidhjen
        lidhja.Close()

    End Sub
    
    Private Sub rbOre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbOre.CheckedChanged

        grpOre.Visible = True
        grpPunt.Visible = False
        grpModifiko.Visible = False
        grpDitore.Visible = False
        grpJavore.Visible = False
        rbDitore.Checked = True
        rbZbritOre.Checked = False
        grpZbritOre.Visible = False
        
    End Sub

    Private Sub rbPunt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbPunt.CheckedChanged

        grpPunt.Visible = True
        grpOre.Visible = False
        grpModifiko.Visible = False

    End Sub

    Private Sub btnOre_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOre.Click
        If rbDitore.Checked = False AndAlso rbJavore.Checked = False Then
            MsgBox("Ju duhet të keni te zgjedhur Ditore ose Javore", vbExclamation, "Kujdes!")
        End If
        If lstDitore.SelectedItem.ToString = "" OrElse lstJavore.SelectedItem.ToString = "" Then
            MsgBox("Ju lutem zgjidhni oret!", vbExclamation, "Kujdes!!")
        End If
        Dim komanda As New OleDbCommand

        'kontrollojme per elementin e selektuar
        If dgvPunt.Rows.Count > 0 Then
            If dgvPunt.SelectedRows.Count > 0 Then
                Dim intPUNT_ID As Integer = dgvPunt.SelectedRows(0).Cells("ID").Value

                'kontrollojme lidhjen
                If Not lidhja.State = ConnectionState.Open Then
                    lidhja.Open()
                End If
                Dim oret As Double
                'kontrollojme nese jemi ne lstOret apo lstJavet
                If rbDitore.Checked = True Then
                    'deklarojme variablin oret qe mban elementin e selektuar ne listbox
                    oret = Convert.ToDouble(lstDitore.SelectedItem)
                ElseIf rbJavore.Checked = True Then
                    oret = Convert.ToDouble(lstJavore.SelectedItem)
                End If
                'shkruajme komanden
                komanda.Connection = lidhja

                komanda.CommandText = "UPDATE Paga SET PAGA_ORE= PAGA_ORE + " & oret & " WHERE PAGA_ID =" & intPUNT_ID
                Dim komanda2 As New OleDbCommand
                komanda2.Connection = lidhja
                komanda2.CommandText = "UPDATE Paga SET PAGA_TOTAL = PAGA_ORE * PAGA_CMIM"

                komanda.ExecuteNonQuery()
                komanda2.ExecuteNonQuery()

                'bejme refresh te dhenave
                FreskoTeDhenat()
                'mbyllim lidhjen
                lidhja.Close()
            Else
                MsgBox("Ju duhet të keni selektuar një rrjesht Punonjësi", vbInformation, "Kujdes!")
            End If
        End If

    End Sub

    Private Sub rbModifiko_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbModifiko.CheckedChanged

        grpModifiko.Visible = True
        grpOre.Visible = False
        grpPunt.Visible = False


    End Sub
    Private Sub BoshApoJo()
        If txtAdrese.Text = "" Or txtDep.Text = "" Or txtEmer.Text = "" Or txtMbiemer.Text = "" Or
            txtPostkodi.Text = "" Or txtPoz.Text = "" Or txtStatusi.Text = "" Or txtTel.Text = "" Then
            MsgBox("Ju lutemi plotësoni të gjithë të dhënat e kërkuara", vbInformation, "Kujdes!!")

        End If
    End Sub


    Private Sub btnShto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShto.Click
        Dim komanda As New OleDb.OleDbCommand
        Dim komanda2 As New OleDb.OleDbCommand
        If Not lidhja.State = ConnectionState.Open Then
            lidhja.Open()
        End If
        'kontrollojme nese ka te dhena te paplotesuara


        Dim koha As DateTime
        koha = Now()
        If txtAdrese.Text = "" Or txtDep.Text = "" Or txtEmer.Text = "" Or txtMbiemer.Text = "" Or
             txtPostkodi.Text = "" Or txtPoz.Text = "" Or txtStatusi.Text = "" Or txtTel.Text = "" Then
            MsgBox("Ju lutemi plotësoni të gjithë të dhënat e kërkuara", vbInformation, "Kujdes!!")
        Else
            komanda.Connection = lidhja
            komanda2.Connection = lidhja
            komanda.CommandText = "INSERT INTO Punetore(PUNT_EMER, PUNT_MBIEMER, PUNT_GJINI, PUNT_DEP, PUNT_DTLINDJE, PUNT_TEL, PUNT_STATUS, PUNT_POZ, PUNT_ADRESE, PUNT_POSTKOD, PUNT_STCIVIL, PUNT_DT_RREG) " & _
                "VALUES ('" & txtEmer.Text & "','" & txtMbiemer.Text & "','" & cbGjinia.Text & "','" & cbDepartamenti.Text & "','" & dtDatelindje.Text & "','" & _
                txtTel.Text & "','" & cbStatusi.Text & "','" & txtPoz.Text & "','" & txtAdrese.Text & "','" & txtPostkodi.Text & "', '" & cbCivil.Text & "','" & koha & "')"

            komanda2.CommandText = "INSERT INTO Paga (PAGA_ORE, PAGA_TOTAL, PAGA_CMIM, PAGA_DATE) VALUES ( 0, 0, 0, '" & koha & "')"

            komanda.ExecuteNonQuery()
            komanda2.ExecuteNonQuery()
        End If
        'freskojme te dhenat
        FreskoTeDhenat()
        'mbyllim lidhjen
        lidhja.Close()

    End Sub

    Private Sub btnModifiko_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifiko.Click
        If Me.dgvPunt.Rows.Count > 0 Then
            If Me.dgvPunt.SelectedRows.Count > 0 Then
                Dim intPUNTID As Integer = Me.dgvPunt.SelectedRows(0).Cells("ID").Value
                'marrim te dhenat nga DB duke ndjekur ID
                'hapim lidhjen
                If Not lidhja.State = ConnectionState.Open Then
                    lidhja.Open()
                End If
                'vendosim te dhenat ne datatable
                Dim pyetja As New OleDb.OleDbDataAdapter("SELECT * FROM Punetore " & _
                                                     " WHERE PUNT_ID=" & intPUNTID, lidhja)
                Dim dt As New DataTable
                pyetja.Fill(dt)

                txtID_Fshehur.Text = intPUNTID
                txtEmer1.Text = dt.Rows(0).Item("PUNT_EMER")
                txtMbiemer1.Text = dt.Rows(0).Item("PUNT_MBIEMER")
                cbGjinia1.Text = dt.Rows(0).Item("PUNT_GJINI")
                dtDatelindje1.Text = dt.Rows(0).Item("PUNT_DTLINDJE")
                txtAdrese1.Text = dt.Rows(0).Item("PUNT_ADRESE")
                txtPostkodi1.Text = dt.Rows(0).Item("PUNT_POSTKOD")
                cbStatusi1.Text = dt.Rows(0).Item("PUNT_STATUS")
                cbDepartamenti1.Text = dt.Rows(0).Item("PUNT_DEP")
                txtPozicioni1.Text = dt.Rows(0).Item("PUNT_POZ")
                txtTel1.Text = dt.Rows(0).Item("PUNT_TEL")
                cbCivil1.Text = dt.Rows(0).Item("PUNT_STCIVIL")


                'caktivizojme butonin Modifiko
                Me.btnModifiko.Enabled = False
                'mbyllim lidhjen
                lidhja.Close()
            Else
                MsgBox("Ju duhet të keni selektuar një rrjesht Punonjësi", vbInformation, "Kujdes!")
            End If
        End If
    End Sub

    Private Sub btnRuaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRuaje.Click
        Dim komanda As New OleDb.OleDbCommand
        'kontrollojme lidhjen
        If Not lidhja.State = ConnectionState.Open Then
            lidhja.Open()
        End If
        If btnModifiko.Enabled = True Then
            MsgBox("Ju duhet të keni klikuar Modifiko si fillim", vbInformation, "Kujdes!")
        Else
            komanda.Connection = lidhja
            'bejme perditesimin e vlerave qe kerkojme
            komanda.CommandText = "UPDATE Punetore SET " & _
                "  PUNT_EMER='" & txtEmer1.Text & "'" & _
                ", PUNT_MBIEMER='" & txtMbiemer1.Text & "'" & _
                ", PUNT_GJINI='" & cbGjinia1.Text & "'" & _
                ", PUNT_DTLINDJE='" & dtDatelindje1.Text & "'" & _
                ", PUNT_DEP='" & cbDepartamenti1.Text & "'" & _
                ", PUNT_TEL='" & txtTel1.Text & "'" & _
                ", PUNT_STATUS='" & cbStatusi1.Text & "'" & _
                ", PUNT_POZ='" & txtPozicioni1.Text & "'" & _
                ", PUNT_ADRESE='" & txtAdrese1.Text & "'" & _
                ", PUNT_POSTKOD='" & txtPostkodi1.Text & "'" & _
                ", PUNT_STCIVIL ='" & cbCivil1.Text & "'" & _
                " WHERE PUNT_ID=" & txtID_Fshehur.Text
            komanda.ExecuteNonQuery()
        End If
        'pasi ruajme te dhenat btnmodifiko e bejme serisht te aktivizuar per te tjera te dhena
        btnModifiko.Enabled = True
        'freskojm te dhenat
        FreskoTeDhenat()

    End Sub

    Private Sub btnFshi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFshi.Click
        'kontrollojme elementin e selektuar ne liste
        If dgvPunt.Rows.Count > 0 Then
            If dgvPunt.SelectedRows.Count > 0 Then
                Dim intPunt As Integer = dgvPunt.SelectedRows(0).Cells("ID").Value
                'hapim lidhjen
                If Not lidhja.State = ConnectionState.Open Then
                    lidhja.Open()
                End If
                'pyesim nese jemi te sigurt per te fshire te dhenat
                Dim pergj As DialogResult
                pergj = MessageBox.Show("Jeni të sigurt që dëshironi të fshini të dhënat?", "Kujdes!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                If pergj = DialogResult.Yes Then


                    'fshijme te dhenat 
                    Dim komanda As New OleDb.OleDbCommand
                    komanda.Connection = lidhja
                    komanda.CommandText = "DELETE FROM Punetore WHERE PUNT_ID=" & intPunt
                    komanda.ExecuteNonQuery()
                    'perditesojme te dhenat
                    FreskoTeDhenat()
                    'mbyllim lidhjen
                    lidhja.Close()
               
                End If
            Else
                MsgBox("Ju duhet të keni selektuar një rrjesht Punonjësi", vbInformation, "Kujdes!")
            End If
        End If
    End Sub

    Private Sub btn_Detaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Detaje.Click
        Me.Hide()
        frm_Detaje.Show()

    End Sub

    Private Sub rbDitore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDitore.CheckedChanged
        
        grpDitore.Visible = True
        grpJavore.Visible = False
        grpZbritOre.Visible = False
    End Sub

    Private Sub rbJavore_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbJavore.CheckedChanged
        grpDitore.Visible = False
        grpJavore.Visible = True
        grpZbritOre.Visible = False
    End Sub


   
    Private Sub btnKryesore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKryesore.Click
        'per te vendosur ne tabelen Hyrjet veprimin e kryer dmth loggin
        If Not lidhja.State = ConnectionState.Open Then
            lidhja.Open()
        End If

        Dim adaptor As New OleDbDataAdapter
        Dim leximi As OleDbDataReader
        Dim pyetja As String = "SELECT ADMIN_FJALEKALIM FROM Administratore WHERE ADMIN_FJALEKALIM = '" & txtPassKryefaqja.Text & "'"
        Dim komand1 As New OleDb.OleDbCommand
        komand1 = New OleDbCommand(pyetja, lidhja)
        adaptor.SelectCommand = komand1
        leximi = komand1.ExecuteReader

        If txtPassKryefaqja.Text <> String.Empty And leximi.HasRows = True Then
            txtPassKryefaqja.Text = ""
            Me.Hide()
            frmKryesore.Show()
        Else
            MsgBox("Vetëm administratori ka akses !!", vbInformation, "Provoni përsëri !")
        End If
    End Sub

    Private Sub rbZbritOre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbZbritOre.CheckedChanged
        grpZbritOre.Visible = True
        grpDitore.Visible = False
        grpJavore.Visible = False

    End Sub

    Private Sub btnZbritOre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZbritOre.Click

        Dim komanda As New OleDbCommand
        Dim komanda2 As New OleDbCommand

        'kontrollojme per elementin e selektuar
        If dgvPunt.Rows.Count > 0 Then
            If dgvPunt.SelectedRows.Count > 0 Then
                If txtZbritOre.Text = "" OrElse txtZbritOre.Text < "-99999" OrElse txtZbritOre.Text > "99999" Then
                    MsgBox("Ju duhet të vendosni një numër! ", vbInformation, "Kujdes")
                Else
                    Dim intPAGA_ID As Integer = dgvPunt.SelectedRows(0).Cells("ID").Value
                    'marrim vleren e ores per te shikuar  nese eshte >=0 ose <0
                    Dim dblora As Double = dgvPunt.SelectedRows(0).Cells("ORET").Value

                    'kontrollojme lidhjen
                    If Not lidhja.State = ConnectionState.Open Then
                        lidhja.Open()
                    End If
                    Dim oret As Double
                    'kontrollojme nese nr i vendosur eshte negativ apo pozitiv dhe kryejme veprimet e duhura
                    'nese eshte neg (psh -50) atehere eshte ne rreg
                    'nese eshte poz (psh 50) atehere do e kthejme ne -50
                    oret = Convert.ToDouble(txtZbritOre.Text)
                    'lidhim komanden
                    komanda.Connection = lidhja
                    komanda2.Connection = lidhja

                    If oret < 0 AndAlso dblora > 0 Then
                        'shkruajme komanden
                        komanda.CommandText = "UPDATE Paga SET PAGA_ORE= PAGA_ORE + " & oret & " WHERE PAGA_ID =" & intPAGA_ID

                    ElseIf oret > 0 AndAlso dblora > 0 Then
                        komanda.CommandText = "UPDATE Paga SET PAGA_ORE= PAGA_ORE - " & oret & " WHERE PAGA_ID =" & intPAGA_ID
                        'bejme update automatikisht tek PAGA_TOTAL
                        komanda2.CommandText = "UPDATE Paga SET PAGA_TOTAL = PAGA_ORE * PAGA_CMIM"

                        komanda.ExecuteNonQuery()
                        komanda2.ExecuteNonQuery()

                        'bejme refresh te dhenave
                        FreskoTeDhenat()
                        'mbyllim lidhjen
                        lidhja.Close()
                        'nese oret jane 0 ose nr me i vogel veprimi nuk mund te kryhet, sepse nuk ke cfare zbret kur nje punonjes ka 0 ore
                    ElseIf dblora <= 0 Then
                        MsgBox("E dhëna e selektuar në tabele duhet të jetë numër pozitiv për të kryer këtë veprim", vbInformation, "Kujdes!")
                    End If

                End If
            Else
                MsgBox("Ju lutem selektoni një rrjesht në tabelë", vbInformation, "Kujdes!")
            End If
        End If
        txtZbritOre.Text = ""
    End Sub
End Class