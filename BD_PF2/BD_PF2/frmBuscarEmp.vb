Public Class frmBuscarEmp

    Private Sub frmBuscar_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ConectarBD()
    End Sub


    Private Sub btnAceptarBus_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarBus.Click
        If txtIDBuscar.Text = "" Then
            MsgBox("Ingrese el Empleado", MsgBoxStyle.Information, "AVISO")

        Else
            Dim vEmpBus As String
            vEmpBus = txtIDBuscar.Text

            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = ""
            sql = "SELECT NomEmp,APEmp,AMEmp,FeNacEmp,FeIngEmp,IdPuesto,IdSubD,IdRol,Email,ContEmp FROM tblEmpleado WHERE NomEmp = '" & vEmpBus & "'"

            Cmd.CommandText = sql

            Try
                dr = Cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()

                    txtNomEmpB.Text = dr(0).ToString
                    txtAPEmpB.Text = dr(1).ToString
                    txtAMEmpB.Text = dr(2).ToString
                    txtFeNacB.Text = dr(3).ToString
                    txtFeIngB.Text = dr(4).ToString
                    txtPuestoB.Text = dr(5).ToString
                    txtSubDB.Text = dr(6).ToString
                    txtRolB.Text = dr(7).ToString
                    txtEmailB.Text = dr(8).ToString
                    txtContB.Text = dr(9).ToString

                Else
                    MsgBox("No se encontró el empleado", MsgBoxStyle.Critical, "ERROR")

                    txtNomEmpB.Text = ""
                    txtAPEmpB.Text = ""
                    txtAMEmpB.Text = ""
                    txtFeNacB.Text = ""
                    txtFeIngB.Text = ""
                    txtPuestoB.Text = ""
                    txtRolB.Text = ""
                    txtSubDB.Text = ""
                    txtEmailB.Text = ""
                    txtContB.Text = ""

                    txtNomEmpB.Select()

                End If
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub txtIDBuscar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtIDBuscar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtIDBuscar.Text = "" Then
                MsgBox("Ingrese el Empleado", MsgBoxStyle.Information, "AVISO")

            Else
                Dim vEmpBus As String
                vEmpBus = txtIDBuscar.Text

                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                sql = ""
                sql = "SELECT NomEmp,APEmp,AMEmp,FeNacEmp,FeIngEmp,IdPuesto,IdSubD,IdRol,Email,ContEmp FROM tblEmpleado WHERE NomEmp = '" & vEmpBus & "'"

                Cmd.CommandText = sql

                Try
                    dr = Cmd.ExecuteReader
                    If dr.HasRows Then
                        dr.Read()

                        txtNomEmpB.Text = dr(0).ToString
                        txtAPEmpB.Text = dr(1).ToString
                        txtAMEmpB.Text = dr(2).ToString
                        txtFeNacB.Text = dr(3).ToString
                        txtFeIngB.Text = dr(4).ToString
                        txtPuestoB.Text = dr(5).ToString
                        txtSubDB.Text = dr(6).ToString
                        txtRolB.Text = dr(7).ToString
                        txtEmailB.Text = dr(8).ToString
                        txtContB.Text = dr(9).ToString

                    Else
                        MsgBox("No se encontró el empleado", MsgBoxStyle.Critical, "ERROR")

                        txtNomEmpB.Text = ""
                        txtAPEmpB.Text = ""
                        txtAMEmpB.Text = ""
                        txtFeNacB.Text = ""
                        txtFeIngB.Text = ""
                        txtPuestoB.Text = ""
                        txtRolB.Text = ""
                        txtSubDB.Text = ""
                        txtEmailB.Text = ""
                        txtContB.Text = ""

                        txtNomEmpB.Select()

                    End If
                    dr.Close()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If

        End If
    End Sub

    Private Sub txtIDBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtIDBuscar.TextChanged

    End Sub
End Class