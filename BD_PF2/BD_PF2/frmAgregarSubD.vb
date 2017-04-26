Public Class frmAgregarSubD

    Private Sub frmAgregarSubD_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Tablas.tblEmpleado' table. You can move, or remove it, as needed.
        Me.TblEmpleadoTableAdapter.Fill(Me.DataSet_Tablas.tblEmpleado)
        ConectarBD()
    End Sub

    Private Sub btnAceptarSubDA_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarSubDA.Click
        If txtNomSubDA.Text = "" Or cbEmpEncarA.Text = "" Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
            txtNomSubDA.Select()
        ElseIf IsNumeric(txtNomSubDA.Text) Then
            MsgBox("El Nombre de la subdirección no puede contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")
        Else
            Dim vEmpEncar As Integer
            vEmpEncar = cbEmpEncarA.SelectedValue

            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = "INSERT INTO tblSubdireccion(NomSubD,IdEmpEncar,ActivoSD) VALUES ('" & txtNomSubDA.Text & "','" & vEmpEncar & "'," & 1 & ")"
            Cmd.CommandText = sql
            Try
                Cmd.ExecuteNonQuery()
                MsgBox(" Proveedor registrado correctamente", MsgBoxStyle.OkOnly, "AVISO")
                My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_PressStart.wav")

                txtNomSubDA.Text = ""

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub cbEmpEncarA_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cbEmpEncarA.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            If txtNomSubDA.Text = "" Or cbEmpEncarA.Text = "" Then
                MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
                txtNomSubDA.Select()
            ElseIf IsNumeric(txtNomSubDA.Text) Then
                MsgBox("El Nombre de la subdirección no puede contener valores numéricos", MsgBoxStyle.Critical, "ALERTA")
            Else
                Dim vEmpEncar As Integer
                vEmpEncar = cbEmpEncarA.SelectedValue

                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                sql = "INSERT INTO tblSubdireccion(NomSubD,IdEmpEncar,ActivoSD) VALUES ('" & txtNomSubDA.Text & "','" & vEmpEncar & "'," & 1 & ")"
                Cmd.CommandText = sql
                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox(" Proveedor registrado correctamente", MsgBoxStyle.OkOnly, "AVISO")
                    My.Computer.Audio.Play("C:\Users\Usuario\Desktop\BD\BD_PF2\ZSS_PressStart.wav")

                    txtNomSubDA.Text = ""

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            End If
        End If
    End Sub

    Private Sub cbEmpEncarA_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbEmpEncarA.SelectedIndexChanged

    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.TblEmpleadoTableAdapter.FillBy(Me.DataSet_Tablas.tblEmpleado)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillBy1ToolStripButton_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.TblEmpleadoTableAdapter.FillBy1(Me.DataSet_Tablas.tblEmpleado)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class