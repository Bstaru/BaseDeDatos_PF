Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports VB = Microsoft.VisualBasic


Module ModuloBaseDeDatos
    Public Conn As New SqlConnection("Data Source=HP;Initial Catalog=ProyectoFinal_BD;Integrated Security=True")

    Public Cmd As New SqlCommand 'consulta
    Public dr As SqlDataReader  'resultado

    Public cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter

    Public sql As String = ""

    'conexion
    Public Sub ConectarBD()
        Try
            Conn.Open()
            'MsgBox("Conectado a SQL SERVER")
        Catch ex As Exception
            ' MsgBox("Error al conectar")
            'Finally
            '    Conn.Close()
        End Try
    End Sub

    'LogIn
    Public Sub LogIn(ByVal EmailVar As String, ByVal ContVar As String)
        Cmd.Connection = Conn                   'conexion al cmd para saber donde hacer la consulta
        Cmd.CommandType = CommandType.Text      'Decirle al cmd que tipo es (en este caso un TXT)
        Dim sql As String                       'hacer consulta sql, meter la consulta en una variable tipo TXT
        sql = "SELECT Email,ContEmp FROM tblEmpleado WHERE Email = '" + EmailVar + "' AND ContEmp = '" + ContVar + "' "
        'MsgBox(sql)
        Cmd.CommandText = sql
        Try
            dr = Cmd.ExecuteReader
            If dr.HasRows Then
                dr.Close()   'cierra el datareader
                frmPrincipal.Show()
                frmLogIn.Hide()
            Else
                MsgBox("Datos Incorrectos. El programa se cerrará", MsgBoxStyle.Critical, "Error")
                End
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Consulta(ByVal squl As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(squl, Conn)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub



    Public Sub wait(ByVal seconds As Single)
        Static start As Single
        start = VB.Timer()
        Do While VB.Timer() < start + seconds
            System.Windows.Forms.Application.DoEvents()
        Loop
    End Sub

End Module
