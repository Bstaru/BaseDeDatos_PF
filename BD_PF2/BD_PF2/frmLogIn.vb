Public Class frmLogIn


    Private Sub frmLogIn_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

    Private Sub btnEntrar_Click(sender As System.Object, e As System.EventArgs) Handles btnEntrar.Click
        ConectarBD()
        If txtEmail.Text = "" Or txtCont.Text = "" Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ERROR")
            txtEmail.Select()
        Else

            Dim EmailTxt As String
            Dim ContTxt As String

            EmailTxt = txtEmail.Text
            ContTxt = txtCont.Text

            LogIn(EmailTxt, ContTxt)
        End If
    End Sub

    Private Sub txtCont_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtCont.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            frmPrincipal.Show()

        End If

    End Sub

End Class