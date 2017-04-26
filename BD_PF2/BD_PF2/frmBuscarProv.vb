Public Class frmBuscarProv

    Private Sub frmBuscarProv_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

    Private Sub btnAceptarBus_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarBus.Click
        If txtNomProvBuscar.Text = "" Then
            MsgBox("Ingrese un proveedor", MsgBoxStyle.Information, "AVISO")

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

                    txtNomProvB.Text = dr(0).ToString
                    txtActivoProvB.Text = dr(1).ToString

                Else
                    MsgBox("No se encontró el proveedor", MsgBoxStyle.Critical, "ERROR")

                    txtNomProvB.Text = ""
                    txtActivoProvB.Text = ""

                    txtNomProvBuscar.Select()

                End If
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtNomProvBuscar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNomProvBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtNomProvBuscar.Text = "" Then
                MsgBox("Ingrese un proveedor", MsgBoxStyle.Information, "AVISO")

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

                        txtNomProvB.Text = dr(0).ToString
                        txtActivoProvB.Text = dr(1).ToString

                    Else
                        MsgBox("No se encontró el proveedor", MsgBoxStyle.Critical, "ERROR")

                        txtNomProvB.Text = ""
                        txtActivoProvB.Text = ""

                        txtNomProvBuscar.Select()

                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        End If
    End Sub

    Private Sub txtNomProvBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNomProvBuscar.TextChanged

    End Sub
End Class