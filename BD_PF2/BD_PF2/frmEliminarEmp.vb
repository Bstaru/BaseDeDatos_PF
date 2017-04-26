Public Class frmEliminarEmp

    Private Sub frmEliminarEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If txtNomEmpBE.Text = "" Then
            MsgBox("Debe ingresar un nombre", MsgBoxStyle.Information, "AVISO")
            txtNomEmpBE.Select()
        Else
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = ""
            sql = "UPDATE tblEmpleado SET ActivoEmp = " & 0 & " WHERE NomEmp = '" & txtNomEmpBE.Text & "' "

            Cmd.CommandText = sql

            Try
                Cmd.ExecuteNonQuery()
                MsgBox("¿Seguro qué desea eliminar a " & txtNomEmpBE.Text & "?", MsgBoxStyle.Question, "AVISO")
                MsgBox("Empleado eliminado", MsgBoxStyle.OkOnly, "AVISO")
                My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Cancel.wav")

                txtNomEmpBE.Text = ""
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtNomEmpBE_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNomEmpBE.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtNomEmpBE.Text = "" Then
                MsgBox("Debe ingresar un nombre", MsgBoxStyle.Information, "AVISO")
                txtNomEmpBE.Select()
            Else
                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                sql = ""
                sql = "UPDATE tblEmpleado SET ActivoEmp = " & 0 & " WHERE NomEmp = '" & txtNomEmpBE.Text & "' "

                Cmd.CommandText = sql

                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("¿Seguro qué desea eliminar a " & txtNomEmpBE.Text & "?", MsgBoxStyle.Question, "AVISO")
                    MsgBox("Empleado eliminado", MsgBoxStyle.OkOnly, "AVISO")
                    My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Cancel.wav")

                    txtNomEmpBE.Text = ""
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        End If
    End Sub

    Private Sub txtNomEmpBE_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNomEmpBE.TextChanged

    End Sub
End Class