Public Class frmEliminarProv

    Private Sub frmEliminarProv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If txtProvE.Text = "" Then
            MsgBox("Debe ingresar un nombre", MsgBoxStyle.Information, "AVISO")
            txtProvE.Select()
        Else
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = ""
            sql = "UPDATE tblProveedor SET ActivoProv = " & 0 & " WHERE NomProv = '" & txtProvE.Text & "' "

            Cmd.CommandText = sql

            Try
                Cmd.ExecuteNonQuery()
                MsgBox("¿Seguro qué desea eliminar a " & txtProvE.Text & "?", MsgBoxStyle.Question, "AVISO")
                MsgBox("Proveedor eliminado exitósamente.", MsgBoxStyle.OkOnly, "AVISO")
                My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Cancel.wav")

                txtProvE.Text = ""
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtProvE_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtProvE.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtProvE.Text = "" Then
                MsgBox("Debe ingresar un nombre", MsgBoxStyle.Information, "AVISO")
                txtProvE.Select()
            Else
                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                sql = ""
                sql = "UPDATE tblProveedor SET ActivoProv = " & 0 & " WHERE NomProv = '" & txtProvE.Text & "' "

                Cmd.CommandText = sql

                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("¿Seguro qué desea eliminar a " & txtProvE.Text & "?", MsgBoxStyle.Question, "AVISO")
                    MsgBox("Proveedor eliminado exitósamente.", MsgBoxStyle.OkOnly, "AVISO")
                    My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Cancel.wav")

                    txtProvE.Text = ""
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        End If
    End Sub

    Private Sub txtProvE_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtProvE.TextChanged

    End Sub
End Class