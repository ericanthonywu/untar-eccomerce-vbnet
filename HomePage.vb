Public Class HomePage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sign_in_btn.Click
        If SessionUser.currentUser Is "" Then
            SignInPage.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label8.Show()
        Label9.Show()
        Label10.Show()
        PictureBox3.Show()
        PictureBox1.Hide()
        Label6.Hide()
        Label7.Hide()
        Button2.Hide()
        Button3.Hide()
        Button4.Hide()
        Button5.Hide()
        Panel1.Hide()
        Panel2.Hide()
        Panel3.Hide()
        Panel4.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Button2.Show()
        Button3.Show()
        Button4.Show()
        Button5.Show()
        Panel1.Show()
        Panel2.Show()
        Panel3.Show()
        Panel4.Show()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        PictureBox3.Hide()
        PictureBox1.Hide()
        Label6.Hide()
        Label7.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SessionUser.currentUser IsNot "" Then
            sign_in_btn.Hide()
            signed_label.Text = "Hi, " + SessionUser.currentUser + " !"
            Label8.Hide()
            Label9.Hide()
            Label10.Hide()
            PictureBox3.Hide()
            PictureBox1.Show()
            Label6.Show()
            Label7.Show()
            Button2.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            Panel1.Hide()
            Panel2.Hide()
            Panel3.Hide()
            Panel4.Hide()
        Else
            sign_in_btn.Show()
            signed_label.Hide()
            Label8.Hide()
            Label9.Hide()
            Label10.Hide()
            PictureBox3.Hide()
            PictureBox1.Show()
            Label6.Show()
            Label7.Show()
            Button2.Hide()
            Button3.Hide()
            Button4.Hide()
            Button5.Hide()
            Panel1.Hide()
            Panel2.Hide()
            Panel3.Hide()
            Panel4.Hide()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        PictureBox3.Hide()
        PictureBox1.Show()
        Label6.Show()
        Label7.Show()
    End Sub

    Private Sub HomePage_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If SessionUser.currentUser IsNot "" Then
            sign_in_btn.Text = "Hi, " + SessionUser.currentUser + " !"
        End If
    End Sub

    Private Sub HomePage_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Hide()

    End Sub

    Private Sub HomePage_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        If SessionUser.currentUser IsNot "" Then
            sign_in_btn.Hide()
            signed_label.Text = "Hi, " + SessionUser.currentUser + " !"
        Else
            sign_in_btn.Show()
            signed_label.Hide()
        End If
    End Sub

    Private Sub HomePage_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter
        MessageBox.Show("on enter")
    End Sub
End Class