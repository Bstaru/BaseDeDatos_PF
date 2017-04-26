Public Class frmEditarEmp

    Private Sub frmEditarEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Tablas.tblSubdireccion' table. You can move, or remove it, as needed.
        Me.TblSubdireccionTableAdapter.Fill(Me.DataSet_Tablas.tblSubdireccion)
        'TODO: This line of code loads data into the 'DataSet_Tablas.tblPuesto2' table. You can move, or remove it, as needed.
        Me.TblPuesto2TableAdapter.Fill(Me.DataSet_Tablas.tblPuesto2)
        ConectarBD()
    End Sub

    Private Sub btnAceptarBus_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarBusC.Click
        If txtNomEmpBuscar.Text = "" Then
            MsgBox("Ingrese el Empleado", MsgBoxStyle.Information, "AVISO")

        Else
            Dim vEmpBusM As String
            vEmpBusM = txtNomEmpBuscar.Text

            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = ""
            sql = "SELECT NomEmp,APEmp,AMEmp,FeNacEmp,FeIngEmp,IdPuesto,IdSubD,IdRol,ActivoEmp,Email,ContEmp FROM tblEmpleado WHERE NomEmp = '" & vEmpBusM & "'"

            Cmd.CommandText = sql

            Try
                dr = Cmd.ExecuteReader
                If dr.HasRows Then
                    dr.Read()

                    txtNomEmpC.Text = dr(0).ToString
                    txtAPEmpC.Text = dr(1).ToString
                    txtAMEmpC.Text = dr(2).ToString
                    dtpFeNacEmpC.Text = dr(3).ToString
                    dtpFeIngEmpM.Text = dr(4).ToString
                    cbPuestoC.Text = dr(5).ToString
                    cbSubDC.Text = dr(6).ToString

                    txtActivoM.Text = dr(8).ToString
                    txtEmailC.Text = dr(9).ToString
                    txtContC.Text = dr(10).ToString

                Else
                    MsgBox("No se encontró el empleado", MsgBoxStyle.Critical, "ERROR")


                    txtNomEmpC.Text = ""
                    txtAPEmpC.Text = ""
                    txtAMEmpC.Text = ""
                    txtActivoM.Text = ""
                    txtEmailC.Text = ""
                    txtContC.Text = ""

                    txtNomEmpC.Select()

                End If
                dr.Close()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub btnEditar_Click(sender As System.Object, e As System.EventArgs) Handles btnEditar.Click

        If txtNomEmpC.Text = "" Or txtAPEmpC.Text = "" Or txtAMEmpC.Text = "" Or
            dtpFeNacEmpC.Text = "" Or dtpFeIngEmpM.Text = "" Or cbPuestoC.Text = "" Or cbSubDC.Text = "" Or
            txtActivoM.Text = "" Or txtEmailC.Text = "" Or txtContC.Text = "" Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
            txtNomEmpC.Select()
        ElseIf IsNumeric(txtNomEmpC.Text) Or IsNumeric(txtAPEmpC.Text) Or IsNumeric(txtAMEmpC.Text) Then
            MsgBox("El Nombre y sus apellidos no pueden contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")

        Else
            Dim vFechaM As String
            vFechaM = Format(dtpFeNacEmpC.Value, "yyyy-MM-dd")

            Dim vFechaIngM As String
            vFechaIngM = Format(dtpFeIngEmpM.Value, "yyyy-MM-dd")

            Dim vPuestoM As Integer
            vPuestoM = cbPuestoC.SelectedValue

            Dim vSubDM As Integer
            vSubDM = cbSubDC.SelectedValue

            Dim vRolM As Integer
            If rbEmpleadoC.Checked = True Then
                vRolM = 1
            ElseIf rbContaC.Checked = True Then
                vRolM = 2
            ElseIf rbAdminC.Checked = True Then
                vRolM = 3
            End If

            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = "UPDATE tblEmpleado SET NomEmp ='" & txtNomEmpC.Text & "', APEmp= '" & txtAPEmpC.Text & "',AMEmp = '" & txtAMEmpC.Text & "',FeNacEmp = '" & vFechaM & "',FeIngEmp = '" & vFechaIngM & "',IdPuesto = '" & vPuestoM & "', IdSubD = '" & vSubDM & "', IdRol = '" & vRolM & "', ActivoEmp = '" & txtActivoM.Text & "', Email =  '" & txtEmailC.Text & "', ContEmp = '" & txtContC.Text & "'WHERE NomEmp = '" & txtNomEmpBuscar.Text & "' "
            Cmd.CommandText = sql
            Try
                Cmd.ExecuteNonQuery()
                MsgBox(" Empleado actualizado correctamente", MsgBoxStyle.OkOnly, "AVISO")
                My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Select.wav")

                txtNomEmpC.Text = ""
                txtAPEmpC.Text = ""
                txtAMEmpC.Text = ""
                dtpFeNacEmpC.Text = ""
                dtpFeIngEmpM.Text = ""
                cbPuestoC.Text = ""
                cbSubDC.Text = ""
                txtActivoM.Text = ""
                txtEmailC.Text = ""
                txtContC.Text = ""
                txtNomEmpBuscar.Text = ""

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If

    End Sub

    Private Sub txtContC_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtContC.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtNomEmpC.Text = "" Or txtAPEmpC.Text = "" Or txtAMEmpC.Text = "" Or
            dtpFeNacEmpC.Text = "" Or dtpFeIngEmpM.Text = "" Or cbPuestoC.Text = "" Or cbSubDC.Text = "" Or
            txtActivoM.Text = "" Or txtEmailC.Text = "" Or txtContC.Text = "" Then
                MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
                txtNomEmpC.Select()
            ElseIf IsNumeric(txtNomEmpC.Text) Or IsNumeric(txtAPEmpC.Text) Or IsNumeric(txtAMEmpC.Text) Then
                MsgBox("El Nombre y sus apellidos no pueden contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")

            Else
                Dim vFechaM As String
                vFechaM = Format(dtpFeNacEmpC.Value, "yyyy-MM-dd")

                Dim vFechaIngM As String
                vFechaIngM = Format(dtpFeIngEmpM.Value, "yyyy-MM-dd")

                Dim vPuestoM As Integer
                vPuestoM = cbPuestoC.SelectedValue

                Dim vSubDM As Integer
                vSubDM = cbSubDC.SelectedValue

                Dim vRolM As Integer
                If rbEmpleadoC.Checked = True Then
                    vRolM = 1
                ElseIf rbContaC.Checked = True Then
                    vRolM = 2
                ElseIf rbAdminC.Checked = True Then
                    vRolM = 3
                End If

                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                sql = "UPDATE tblEmpleado SET NomEmp ='" & txtNomEmpC.Text & "', APEmp= '" & txtAPEmpC.Text & "',AMEmp = '" & txtAMEmpC.Text & "',FeNacEmp = '" & vFechaM & "',FeIngEmp = '" & vFechaIngM & "',IdPuesto = '" & vPuestoM & "', IdSubD = '" & vSubDM & "', IdRol = '" & vRolM & "', ActivoEmp = '" & txtActivoM.Text & "', Email =  '" & txtEmailC.Text & "', ContEmp = '" & txtContC.Text & "'WHERE NomEmp = '" & txtNomEmpBuscar.Text & "' "
                Cmd.CommandText = sql
                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox(" Empleado actualizado correctamente", MsgBoxStyle.OkOnly, "AVISO")
                    My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_Prompt_Select.wav")

                    txtNomEmpC.Text = ""
                    txtAPEmpC.Text = ""
                    txtAMEmpC.Text = ""
                    dtpFeNacEmpC.Text = ""
                    dtpFeIngEmpM.Text = ""
                    cbPuestoC.Text = ""
                    cbSubDC.Text = ""
                    txtActivoM.Text = ""
                    txtEmailC.Text = ""
                    txtContC.Text = ""
                    txtNomEmpBuscar.Text = ""

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If

        End If
    End Sub

    Private Sub txtContC_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtContC.TextChanged

    End Sub
End Class