Public Class frmAgregarEmp
    Private Sub frmAgregarEmp_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Tablas._tblSubD_Emp' table. You can move, or remove it, as needed.
        Me.TblSubD_EmpTableAdapter.Fill(Me.DataSet_Tablas._tblSubD_Emp)
        'TODO: This line of code loads data into the 'DataSet_Tablas.tblSubdireccion' table. You can move, or remove it, as needed.
        Me.TblSubdireccionTableAdapter.Fill(Me.DataSet_Tablas.tblSubdireccion)
        'TODO: This line of code loads data into the 'DataSet_Tablas.tblPuesto2' table. You can move, or remove it, as needed.
        Me.TblPuesto2TableAdapter.Fill(Me.DataSet_Tablas.tblPuesto2)
        ConectarBD()
    End Sub

    Private Sub frmAceptarNuevo_Click(sender As System.Object, e As System.EventArgs) Handles frmAceptarNuevo.Click
        If txtNomEmpA.Text = "" Or txtAPEmpA.Text = "" Or txtAMEmpA.Text = "" Or dtpFeNacEmpA.Text = "" Or
            txtEmailA.Text = "" Or txtContA.Text = "" Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
            txtNomEmpA.Select()
        ElseIf IsNumeric(txtNomEmpA.Text) Or IsNumeric(txtAPEmpA.Text) Or IsNumeric(txtAMEmpA.Text) Then
            MsgBox("El Nombre y sus apellidos no pueden contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")
        Else
            Dim vFecha As String
            vFecha = Format(dtpFeNacEmpA.Value, "yyyy-MM-dd")

            Dim vFechaActual As String
            vFechaActual = DateTime.Now.ToString("yyyy-MM-dd")

            Dim vPuesto As Integer
            vPuesto = cbPuestoNuevo.SelectedValue

            Dim vSubD As Integer
            vSubD = cbSubDNuevo.SelectedValue

            Dim vRol As Integer
            If rbEmpleadoA.Checked = True Then
                vRol = 1
            ElseIf rbContaA.Checked = True Then
                vRol = 2
            ElseIf rbAdminA.Checked = True Then
                vRol = 3
            End If

            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text
            'cuando se uiera poner valor int solo se pone las "" sin las ''
            sql = "INSERT INTO tblEmpleado (NomEmp,APEmp,AMEmp,FeNacEmp,FeIngEmp,IdPuesto,IdSubD,IdRol,ActivoEmp,Email,ContEmp) VALUES ('" & txtNomEmpA.Text & "','" & txtAPEmpA.Text & "','" & txtAMEmpA.Text & "','" & vFecha & "','" & vFechaActual & "','" & vPuesto & "','" & vSubD & "','" & vRol & "'," & 1 & ",'" & txtEmailA.Text & "','" & txtContA.Text & "')"
            Cmd.CommandText = sql
            Try
                Cmd.ExecuteNonQuery()
                MsgBox(" Empleado registrado correctamente", MsgBoxStyle.OkOnly, "AVISO")
                My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_PressStart.wav")

                txtNomEmpA.Text = ""
                txtAPEmpA.Text = ""
                txtAMEmpA.Text = ""
                txtEmailA.Text = ""
                txtContA.Text = ""
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub txtContA_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtContA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtNomEmpA.Text = "" Or txtAPEmpA.Text = "" Or txtAMEmpA.Text = "" Or dtpFeNacEmpA.Text = "" Or
            txtEmailA.Text = "" Or txtContA.Text = "" Then
                MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
                txtNomEmpA.Select()
            ElseIf IsNumeric(txtNomEmpA.Text) Or IsNumeric(txtAPEmpA.Text) Or IsNumeric(txtAMEmpA.Text) Then
                MsgBox("El Nombre y sus apellidos no pueden contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")
            Else
                Dim vFecha As String
                vFecha = Format(dtpFeNacEmpA.Value, "yyyy-MM-dd")

                Dim vFechaActual As String
                vFechaActual = DateTime.Now.ToString("yyyy-MM-dd")

                Dim vPuesto As Integer
                vPuesto = cbPuestoNuevo.SelectedValue

                Dim vSubD As Integer
                vSubD = cbSubDNuevo.SelectedValue

                Dim vRol As Integer
                If rbEmpleadoA.Checked = True Then
                    vRol = 1
                ElseIf rbContaA.Checked = True Then
                    vRol = 2
                ElseIf rbAdminA.Checked = True Then
                    vRol = 3
                End If

                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text
                'cuando se uiera poner valor int solo se pone las "" sin las ''
                sql = "INSERT INTO tblEmpleado (NomEmp,APEmp,AMEmp,FeNacEmp,FeIngEmp,IdPuesto,IdSubD,IdRol,ActivoEmp,Email,ContEmp) VALUES ('" & txtNomEmpA.Text & "','" & txtAPEmpA.Text & "','" & txtAMEmpA.Text & "','" & vFecha & "','" & vFechaActual & "','" & vPuesto & "','" & vSubD & "','" & vRol & "'," & 1 & ",'" & txtEmailA.Text & "','" & txtContA.Text & "')"
                Cmd.CommandText = sql
                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox(" Empleado registrado correctamente", MsgBoxStyle.OkOnly, "AVISO")
                    My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_PressStart.wav")

                    txtNomEmpA.Text = ""
                    txtAPEmpA.Text = ""
                    txtAMEmpA.Text = ""
                    txtEmailA.Text = ""
                    txtContA.Text = ""
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If

        End If
    End Sub
End Class