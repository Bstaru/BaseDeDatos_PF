Public Class frmAgregarProv

    Private Sub frmAgregarProv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

    Private Sub frmAceptarNProv_Click(sender As System.Object, e As System.EventArgs) Handles frmAceptarNProv.Click
        If txtNomProvA.Text = "" Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
            txtNomProvA.Select()
        ElseIf IsNumeric(txtNomProvA.Text) Then
            MsgBox("El Nombre del proveedor no puede contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")
        Else
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            ' sql = ""
            sql = "INSERT INTO tblProveedor (NomProv,ActivoProv) VALUES ('" & txtNomProvA.Text & "'," & 1 & ")"
            Cmd.CommandText = sql
            Try
                Cmd.ExecuteNonQuery()
                MsgBox(" Proveedor registrado correctamente", MsgBoxStyle.OkOnly, "AVISO")
                My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_PressStart.wav")

                txtNomProvA.Text = ""
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtNomProvA_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNomProvA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtNomProvA.Text = "" Then
                MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
                txtNomProvA.Select()
            ElseIf IsNumeric(txtNomProvA.Text) Then
                MsgBox("El Nombre del proveedor no puede contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")
            Else
                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                ' sql = ""
                sql = "INSERT INTO tblProveedor (NomProv,ActivoProv) VALUES ('" & txtNomProvA.Text & "'," & 1 & ")"
                Cmd.CommandText = sql
                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox(" Proveedor registrado correctamente", MsgBoxStyle.OkOnly, "AVISO")
                    My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_PressStart.wav")

                    txtNomProvA.Text = ""
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        End If

    End Sub

    Private Sub txtNomProvA_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNomProvA.TextChanged

    End Sub
End Class