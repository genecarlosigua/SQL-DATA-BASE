Imports System.Data
Imports System.Drawing.Text
Imports System.Windows.Forms.VisualStyles
Imports Npgsql



Public Class Form1

    Dim lv As ListViewItem
    Dim selected As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Poplistview()

    End Sub

    Private Sub Poplistview()
        ListView1.Clear()
        With ListView1
            .View = View.Details
            .GridLines = True
            .Columns.Add("ID", 40)
            .Columns.Add("Last Name", 110)
            .Columns.Add("First Name", 110)
            .Columns.Add("Position", 110)
        End With

        openCon()
        sql = "Select * from tbl_empinfo"
        cmd = New NpgsqlCommand(sql, cn)
        dr = cmd.ExecuteReader()

        Do While dr.Read() = True
            lv = New ListViewItem(dr("empno").ToString)
            lv.SubItems.Add(dr("emplastname"))
            lv.SubItems.Add(dr("empfirstname"))
            lv.SubItems.Add(dr("empposition"))
            ListView1.Items.Add(lv)
        Loop
        cn.Close()



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If MsgBox("are you sure to save this record?", vbQuestion + vbYesNo) = vbYes Then
            openCon()
            sql = "INSERT INTO tbl_empinfo (empno, emplastname, empfirstname, empmidinitial, empaddress, empgender, empcontact, empposition)" _
            & " VALUES ('" & Me.txtempno.Text & " ' , ' " & Me.txtlastname.Text & " ' , ' " & Me.txtfirstname.Text & " ' , ' " & Me.txtMI.Text & "' , '" & Me.txtaddress.Text & "' , '" & Me.cmbgender.Text & "' , '" & Me.txtcontact.Text & "' , '" & Me.cmbposition.Text & " ')"

            cmd = New NpgsqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
        End If
        Poplistview()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If MsgBox("are you sure to Change this record?", vbQuestion + vbYesNo) = vbYes Then
            openCon()
            sql = "UPDATE tbl_empinfo SET empno ='" & Me.txtempno.Text & " ' , emplastname=' " & Me.txtlastname.Text & " ' ,empfirstname=' " & Me.txtfirstname.Text & " ' ,empmidinitial=' " & Me.txtMI.Text & "' ,empaddress='" & Me.txtaddress.Text & "' ,empgender='" & Me.cmbgender.Text & "' ,empcontact='" & Me.txtcontact.Text & "' ,empposition='" & Me.cmbposition.Text & " ' WHERE empno= ' " & selected & " ' "
            cmd = New NpgsqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            cn.Close()

        End If
        Poplistview()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If MsgBox("are you sure To Delete this record?", vbQuestion + vbYesNo) = vbYes Then
            openCon()
            sql = "DELETE FROM tbl_empinfo Where empno = ' " & selected & " ' "
            cmd = New NpgsqlCommand(sql, cn)
            cmd.ExecuteNonQuery()
            cn.Close()
        End If
        Poplistview()
    End Sub



    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim i As Integer
        For i = 0 To ListView1.SelectedItems.Count - 1

            selected = ListView1.SelectedItems(i).Text
            openCon()
            sql = "Select * from tbl_empinfo where empno = ' " & selected & "'"
            cmd = New NpgsqlCommand(sql, cn)
            dr = cmd.ExecuteReader

            dr.Read()
            Me.txtempno.Text = dr("empno")
            Me.txtlastname.Text = dr("emplastname")
            Me.txtfirstname.Text = dr("empfirstname")
            Me.txtMI.Text = dr("empmidinitial")
            Me.txtaddress.Text = dr("empaddress")
            Me.cmbgender.Text = dr("empgender")
            Me.txtcontact.Text = dr("empcontact")
            Me.cmbposition.Text = dr("empposition")
            cn.Close()
        Next

    End Sub
End Class
