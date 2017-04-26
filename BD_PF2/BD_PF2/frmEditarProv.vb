Public Class frmEditarProv

    Private Sub frmEditarProv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

    Private Sub btnAceptarBusC_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarBusC.Click
        If txtNomProvBuscar.Text = "" Then
            MsgBox("Ingrese un proveedor", MsgBoxStyle.Information, "AVISO")
            txtNomProvBuscar.Select()
        Else
            Dim vProvBusM As String
            vProvBusM = txtNomProvBuscar.Text

            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = ""
            sql = "SELECT NomProv, ActivoProv FROM tblProveedor WHERE NomProv = '" & vProvBusM & "' "

            Cmd.CommandText = sql

            Try
                dr = Cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()

                    txtNomProvC.Text = dr(0).ToString
                    txtActivoProvC.Text = dr(1).ToString

                Else
                    MsgBox("No se encontró el proveedor", MsgBoxStyle.Critical, "ERROR")

                    txtNomProvC.Text = ""
                    txtActivoProvC.Text = ""

                    txtNomProvBuscar.Select()

                End If
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnEditarProv_Click(sender As System.Object, e As System.EventArgs) Handles btnEditarProv.Click
        If txtNomProvC.Text = "" Or txtActivoProvC.Text = "" Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
            txtNomProvC.Select()
        ElseIf IsNumeric(txtNomProvC.Text) Then
            MsgBox("El Nombre del proveedor no puede contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")
        Else
            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = "UPDATE tblProveedor SET NomProv = '" & txtNomProvC.Text & "',ActivoProv = '" & txtActivoProvC.Text & "'WHERE NomProv = '" & txtNomProvBuscar.Text & "'"

            Cmd.CommandText = sql
            Try
                Cmd.ExecuteNonQuery()
                MsgBox("Proveedor actualizado correctamente", MsgBoxStyle.OkOnly, "AVISO")
                My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Select.wav")

                txtNomProvC.Text = ""
                txtActivoProvC.Text = ""

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtActivoProvC_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtActivoProvC.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtNomProvC.Text = "" Or txtActivoProvC.Text = "" Then
                MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
                txtNomProvC.Select()
            ElseIf IsNumeric(txtNomProvC.Text) Then
                MsgBox("El Nombre del proveedor no puede contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")
            Else
                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                sql = "UPDATE tblProveedor SET NomProv = '" & txtNomProvC.Text & "',ActivoProv = '" & txtActivoProvC.Text & "'WHERE NomProv = '" & txtNomProvBuscar.Text & "'"

                Cmd.CommandText = sql
                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("Proveedor actualizado correctamente", MsgBoxStyle.OkOnly, "AVISO")
                    My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Select.wav")

                    txtNomProvC.Text = ""
                    txtActivoProvC.Text = ""

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        End If
    End Sub

    Private Sub txtActivoProvC_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtActivoProvC.TextChanged

    End Sub
End Class