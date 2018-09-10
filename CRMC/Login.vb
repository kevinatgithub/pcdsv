Imports MySql.Data.MySqlClient

Public Class Login
    Inherits MetroFramework.Forms.MetroForm

    Private Sub processLogin()
        If mtxt_user_id.Text = "" Or mtxt_pword.Text = "" Then
            Return
        End If

        Dim cmd As String = "SELECT user_id, disable_flag FROM r_user WHERE user_id = '" & mtxt_user_id.Text & "' AND password = md5('" & mtxt_pword.Text & "') AND disable_flag = 'N'"

        Try
            Dim reader As MySqlDataReader = Database.db.execute(cmd)

            If Not reader.HasRows Then
                MsgBox("Login Failed! Check User Name and Password")
                Return
            Else
                Dim list As New Donors
                list.Show()
                Me.Hide()
            End If

        Catch ex As Exception
            MsgBox("Something is wrong!")
        End Try

    End Sub

    Private Sub txt_user_id_KeyDown(sender As Object, e As KeyEventArgs) Handles mtxt_user_id.KeyDown
        If e.KeyCode = Keys.Enter Then
            processLogin()
        End If
    End Sub


    Private Sub txt_pword_KeyDown(sender As Object, e As KeyEventArgs) Handles mtxt_pword.KeyDown
        If e.KeyCode = Keys.Enter Then
            processLogin()
        End If
    End Sub

    Private Sub mbtn_login_Click(sender As Object, e As EventArgs) Handles mbtn_login.Click
        processLogin()
    End Sub

    Private Sub mbtn_cancel_Click(sender As Object, e As EventArgs) Handles mbtn_cancel.Click
        Me.Close()
    End Sub
End Class