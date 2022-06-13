Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If IsValidData() Then
                Dim Fname As String = Convert.ToString(txtfirstname.Text)
                Dim Lname As String = Convert.ToString(txtlastname.Text)
                Dim User As String = Convert.ToString(txtusername.Text)
                Dim IC As String = Convert.ToString(txtIC.Text)
                ListBox.Items.Add(String.Format("    " & Fname & "    " & Lname & "    " & User & "   " & IC & "   " & Fname & Lname & "@vb.net"))
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & vbCrLf & ex.GetType.ToString & vbCrLf & vbCrLf & ex.StackTrace, "Exception")
        End Try
    End Sub

    Private Function IsValidData() As Boolean
        Return _
        IsPresent(txtfirstname, "First Name") AndAlso
        IsPresent(txtlastname, "Last Name") AndAlso
        IsPresent(txtusername, "Username") AndAlso
        IsPresent(txtIC, "IC Number")
    End Function

    Private Function IsPresent(ByVal textbox As TextBox, ByVal name As String) As Boolean
        If textbox.Text = "" Then
            MessageBox.Show(name & " is required", "Entry Error")
            textbox.Select()
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtfirstname.Text = ""
        txtlastname.Text = ""
        txtusername.Text = ""
        txtIC.Text = ""
        ListBox.Items.Clear()
        txtfirstname.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const Name As String = "AIMAN HAZIQ BIN AMIR"
        Dim id As String = lblname.Text
        Dim text As String
        text = id + Name
        lblname.Text = text
    End Sub

    Private Sub txtIC_TextChanged(sender As Object, e As EventArgs) Handles txtIC.TextChanged
        If txtIC.TextLength > 12 Then
            MessageBox.Show("Must 12 chatacter only")
        End If
    End Sub

    Private Sub txtIC_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIC.KeyPress

        If e.KeyChar <> ChrW(8) AndAlso Not (e.KeyChar >= "0"c AndAlso e.KeyChar <= "9"c) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtICnumber_KeyPress_Click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtIC.KeyPress
        If e.KeyChar <> ChrW(8) AndAlso Not (e.KeyChar >= "0"c AndAlso e.KeyChar <= "9"c) Then
            e.Handled = True
        End If
    End Sub
End Class
