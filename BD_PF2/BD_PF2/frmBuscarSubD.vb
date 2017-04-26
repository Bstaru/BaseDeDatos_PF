Public Class frmBuscarSubD

    Private Sub frmBuscarSubD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub

    Private Sub btnAceptarBus_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarBus.Click
        If txtNomSubDBuscar.Text = "" Then
            MsgBox("Ingrese una subdireciónr", MsgBoxStyle.Information, "AVISO")
            txtNomSubDBuscar.Select()
        Else
            Dim vSubDBusM As String
            vSubDBusM = txtNomSubDBuscar.Text

            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = ""
            sql = "SELECT NomSubD, IdEmpEncar, ActivoSD FROM tblsubdireccion WHERE NomSubD = '" & vSubDBusM & "' "

            Cmd.CommandText = sql

            Try
                dr = Cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()

                    txtNomSubDB.Text = dr(0).ToString
                    txtEmpEnB.Text = dr(1).ToString
                    txtActivoSubDB.Text = dr(2).ToString

                Else
                    MsgBox("No se encontró la subdirección", MsgBoxStyle.Critical, "ERROR")

                    txtNomSubDB.Text = ""
                    txtActivoSubDB.Text = ""
                    txtEmpEnB.Text = ""

                    txtNomSubDBuscar.Select()
                End If
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtNomSubDBuscar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtNomSubDBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If txtNomSubDBuscar.Text = "" Then
                MsgBox("Ingrese una subdireciónr", MsgBoxStyle.Information, "AVISO")
                txtNomSubDBuscar.Select()
            Else
                Dim vSubDBusM As String
                vSubDBusM = txtNomSubDBuscar.Text

                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                sql = ""
                sql = "SELECT NomSubD, IdEmpEncar, ActivoSD FROM tblsubdireccion WHERE NomSubD = '" & vSubDBusM & "' "

                Cmd.CommandText = sql

                Try
                    dr = Cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()

                        txtNomSubDB.Text = dr(0).ToString
                        txtEmpEnB.Text = dr(1).ToString
                        txtActivoSubDB.Text = dr(2).ToString

                    Else
                        MsgBox("No se encontró la subdirección", MsgBoxStyle.Critical, "ERROR")

                        txtNomSubDB.Text = ""
                        txtActivoSubDB.Text = ""
                        txtEmpEnB.Text = ""

                        txtNomSubDBuscar.Select()
                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If


        End If
    End Sub

    Private Sub txtNomSubDBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtNomSubDBuscar.TextChanged

    End Sub
End Class