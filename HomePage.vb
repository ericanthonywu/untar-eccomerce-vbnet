Public Class HomePage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles sign_in_btn.Click
        If SessionUser.currentUser Is "" Then
            SignInPage.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        AboutUsPage.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        OurProductPage.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If SessionUser.currentUser IsNot "" Then
            sign_in_btn.Hide()
            signed_label.Text = "Hi, " + SessionUser.currentUser + " !"
        Else
            sign_in_btn.Show()
            signed_label.Hide()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

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