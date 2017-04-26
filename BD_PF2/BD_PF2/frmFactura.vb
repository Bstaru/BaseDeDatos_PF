Public Class frmFactura

    Private Sub frmFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Tablas.tblEmpleado' table. You can move, or remove it, as needed.
        Me.TblEmpleadoTableAdapter.Fill(Me.DataSet_Tablas.tblEmpleado)
        'TODO: This line of code loads data into the 'DataSet_Tablas.tblProveedor' table. You can move, or remove it, as needed.
        Me.TblProveedorTableAdapter.Fill(Me.DataSet_Tablas.tblProveedor)
        'TODO: This line of code loads data into the 'DataSet_Tablas.tblImpuesto' table. You can move, or remove it, as needed.
        Me.TblImpuestoTableAdapter.Fill(Me.DataSet_Tablas.tblImpuesto)
        ConectarBD()
    End Sub

    Private Sub btnAceptarFac_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptarFac.Click
        If txtCantidad.Text = "" Or cbIVA.Text = "" Or cbProv.Text = "" Or cbEmp.Text = "" Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
            txtCantidad.Select()
        ElseIf Not IsNumeric(txtCantidad.Text) Then
            MsgBox("La cantidad debe ser un valor numérico", MsgBoxStyle.Critical, "ALERTA")
        Else
            Dim vEmp As Integer
            vEmp = cbEmp.SelectedValue
            Dim vProv As Integer
            vProv = cbProv.SelectedValue

            Dim vCant As Double
            vCant = txtCantidad.Text
            Dim vMul As Double
            Dim vTotal As Double
            Dim vIVA As Double 'Double or Single son float
            vIVA = cbIVA.SelectedValue

            vMul = vCant * vIVA
            vTotal = vCant + vMul

            Dim vIdImp As Integer
            If cbIVA.Text = "0" Then
                vIdImp = 1
            ElseIf cbIVA.Text = "0.16" Then
                vIdImp = 2
            End If

            Cmd.Connection = Conn
            Cmd.CommandType = CommandType.Text

            sql = ""
            sql = "INSERT INTO tblFactura (TotalFact,IdEmp,IdProv,IdImp) VALUES ('" & vTotal & "','" & vEmp & "','" & vProv & "','" & vIdImp & "')"
            Cmd.CommandText = sql

            Try
                Cmd.ExecuteNonQuery()
                MsgBox("Factura corectamente registrada " & Environment.NewLine & Environment.NewLine &
                        Environment.NewLine & "TOTAL FINAL:" & vTotal, MsgBoxStyle.Information, "AVISO")

                txtCantidad.Text = ""
                cbIVA.Text = ""
                cbProv.Text = ""
                cbEmp.Text = ""

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub cbEmp_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles cbEmp.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtCantidad.Text = "" Or cbIVA.Text = "" Or cbProv.Text = "" Or cbEmp.Text = "" Then
                MsgBox("Faltan datos por llenar", MsgBoxStyle.Critical, "ALERTA")
                txtCantidad.Select()
            ElseIf Not IsNumeric(txtCantidad.Text) Then
                MsgBox("La cantidad debe ser un valor numérico", MsgBoxStyle.Critical, "ALERTA")
            Else
                Dim vEmp As Integer
                vEmp = cbEmp.SelectedValue
                Dim vProv As Integer
                vProv = cbProv.SelectedValue

                Dim vCant As Double
                vCant = txtCantidad.Text
                Dim vMul As Double
                Dim vTotal As Double
                Dim vIVA As Double 'Double or Single son float
                vIVA = cbIVA.SelectedValue

                vMul = vCant * vIVA
                vTotal = vCant + vMul

                Dim vIdImp As Integer
                If cbIVA.Text = "0" Then
                    vIdImp = 1
                ElseIf cbIVA.Text = "0.16" Then
                    vIdImp = 2
                End If

                Cmd.Connection = Conn
                Cmd.CommandType = CommandType.Text

                sql = ""
                sql = "INSERT INTO tblFactura (TotalFact,IdEmp,IdProv,IdImp) VALUES ('" & vTotal & "','" & vEmp & "','" & vProv & "','" & vIdImp & "')"
                Cmd.CommandText = sql

                Try
                    Cmd.ExecuteNonQuery()
                    MsgBox("Factura corectamente registrada " & Environment.NewLine & Environment.NewLine &
                            Environment.NewLine & "TOTAL FINAL:" & vTotal, MsgBoxStyle.Information, "AVISO")

                    txtCantidad.Text = ""
                    cbIVA.Text = ""
                    cbProv.Text = ""
                    cbEmp.Text = ""

                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try

            End If

        End If
    End Sub

    Private Sub cbEmp_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbEmp.SelectedIndexChanged

    End Sub
End Class