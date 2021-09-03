Public Class SignInPage

    Private Sub SignInPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SessionUser.currentUser IsNot "" Then
            Me.Hide()
            HomePage.Show()
            HomePage.Refresh()
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sign_in_btn.Click
        If String.Compare(email_txt.Text, "user") = 0 And String.Compare(password_txt.Text, "password") = 0 Then
            SessionUser.currentUser = "User"
            Me.Hide()
            HomePage.Show()
            HomePage.sign_in_btn.Hide()
            HomePage.signed_label.Show()
            HomePage.signed_label.Text = "Hi, " + SessionUser.currentUser + " !"

        Else
            MessageBox.Show(Me, "Username atau password salah", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If



    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles create_account_link.Click
        SignUpPage.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        HomePage.Show()
        Me.Hide()
    End Sub
End Class