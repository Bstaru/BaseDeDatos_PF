Public Class frmEliminarSubD

    Private Sub frmEliminarSubD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If txtSubDE.Text = "" Then
            MsgBox("Debe ingresar un nombre", MsgBoxStyle.Information, "AVISO")
            txtSubDE.Select()
        Else
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = ""
            sql = "UPDATE tblSubdireccion SET ActivoSD = " & 0 & " WHERE NomSubD = '" & txtSubDE.Text & "' "

            Cmd.CommandText = sql

            Try
                Cmd.ExecuteNonQuery()
                MsgBox("¿Seguro qué desea eliminar a " & txtSubDE.Text & "?", MsgBoxStyle.Question, "AVISO")
                MsgBox("Subdirección eliminada exitósamente.", MsgBoxStyle.OkOnly, "AVISO")
                My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Cancel.wav")

                txtSubDE.Text = ""
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtSubDE_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtSubDE.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtSubDE.Text = "" Then
                MsgBox("Debe ingresar un nombre", MsgBoxStyle.Information, "AVISO")
                txtSubDE.Select()
            Else
                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                sql = ""
                sql = "UPDATE tblSubdireccion SET ActivoSD = " & 0 & " WHERE NomSubD = '" & txtSubDE.Text & "' "

                Cmd.CommandText = sql

                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("¿Seguro qué desea eliminar a " & txtSubDE.Text & "?", MsgBoxStyle.Question, "AVISO")
                    MsgBox("Subdirección eliminada exitósamente.", MsgBoxStyle.OkOnly, "AVISO")
                    My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Cancel.wav")

                    txtSubDE.Text = ""
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        End If
    End Sub

    Private Sub txtSubDE_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtSubDE.TextChanged

    End Sub
End Class