Public Class frmEditarSubD

    Private Sub frmEditarSubD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Tablas.tblEmpleado' table. You can move, or remove it, as needed.
        Me.TblEmpleadoTableAdapter.Fill(Me.DataSet_Tablas.tblEmpleado)
        ConectarBD()
    End Sub


    Private Sub btnAceptarBusC_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarBusC.Click
        If txtNomSubDBuscar.Text = "" Then
            MsgBox("Ingrese una subdireciónr", MsgBoxStyle.Information, "AVISO")
            txtNomSubDBuscar.Select()
        ElseIf IsNumeric(txtNomSubDC.Text) Then
            MsgBox("El Nombre de la subdirección no puede contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")
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

                    txtNomSubDC.Text = dr(0).ToString
                    cbEmpEncarC.Text = dr(1).ToString
                    txtActivoSubDC.Text = dr(2).ToString

                Else
                    MsgBox("No se encontró la subdirección", MsgBoxStyle.Critical, "ERROR")

                    txtNomSubDC.Text = ""
                    txtActivoSubDC.Text = ""
                    cbEmpEncarC.Text = ""

                    txtNomSubDBuscar.Select()
                End If
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnAceptarSubDC_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarSubDC.Click
        If txtNomSubDC.Text = "" Or cbEmpEncarC.Text = "" Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
            txtNomSubDC.Select()
        Else
            Dim vEmpEncarC As Integer
            vEmpEncarC = cbEmpEncarC.SelectedValue

            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = "UPDATE tblSubdireccion SET NomSubD = '" & txtNomSubDC.Text & "',IdEmpEncar = '" & vEmpEncarC & "',ActivoSD = '" & txtActivoSubDC.Text & "' "

            Cmd.CommandText = sql
            Try
                Cmd.ExecuteNonQuery()
                MsgBox("Subdirección actualizada correctamente", MsgBoxStyle.OkOnly, "AVISO")
                My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Select.wav")

                txtNomSubDC.Text = ""
                txtActivoSubDC.Text = ""

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If

    End Sub

    Private Sub cbEmpEncarC_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cbEmpEncarC.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtNomSubDC.Text = "" Or cbEmpEncarC.Text = "" Then
                MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
                txtNomSubDC.Select()
            Else
                Dim vEmpEncarC As Integer
                vEmpEncarC = cbEmpEncarC.SelectedValue

                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                sql = "UPDATE tblSubdireccion SET NomSubD = '" & txtNomSubDC.Text & "',IdEmpEncar = '" & vEmpEncarC & "',ActivoSD = '" & txtActivoSubDC.Text & "' "

                Cmd.CommandText = sql
                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("Subdirección actualizada correctamente", MsgBoxStyle.OkOnly, "AVISO")
                    My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Select.wav")

                    txtNomSubDC.Text = ""
                    txtActivoSubDC.Text = ""

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        End If
    End Sub

    Private Sub cbEmpEncarC_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbEmpEncarC.SelectedIndexChanged

    End Sub
End Class