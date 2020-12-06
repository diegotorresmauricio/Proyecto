Imports System
Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Dim comando As New OleDb.OleDbCommand
    Dim adaptador As New OleDb.OleDbDataAdapter
    Dim registro As New DataSet
    Dim codigocontro2 As Integer
    Dim consulta As String
    Dim lista As New Byte
    Dim Codicontro2 As Long
    Dim Opcion As Integer
    Private Sub TXBnum_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXBnum.KeyPress
        Dim conexion As New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C: \Users\Diego\source\repos\Proyecto\bin\Debug\Database4.mdb")
        conexion.Open()

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
            If Asc(e.KeyChar) = 46 Then
                e.Handled = False
            End If
        End If
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            TXBapell.Focus()
        End If
        Codicontro2 = Convert.ToInt64(TXBnum.Text)
        TXBnum.Text = Codicontro2

        Dim comando As New OleDb.OleDbCommand
        Dim adaptador As New OleDb.OleDbDataAdapter
        Dim registro As New DataSet
        Dim consulta As String
        Dim lista As New Byte
        If TXBnum.Text <> "" Then
            consulta = "SELECT * FROM Tabla1 WHERE Numero = " &
TXBnum.Text & ""
            adaptador = New OleDb.OleDbDataAdapter(consulta,
conexion)
            registro = New DataSet
            adaptador.Fill(registro, "Tabla1")
            lista = registro.Tables("Tabla1").Rows.Count
            If lista <> 0 Then
                TXBapell.Text =
registro.Tables("Tabla1").Rows(0).Item("apellido")
                TXBnom.Text =
registro.Tables("Tabla1").Rows(0).Item("nombre")
                TXBdire.Text =
registro.Tables("Tabla1").Rows(0).Item("direccion")
                TXBcat.Text =
registro.Tables("Tabla1").Rows(0).Item("categoria")
                TXBsexo.Text =
registro.Tables("Tabla1").Rows(0).Item("sexo")
                TXBcelu.Text =
registro.Tables("Tabla1").Rows(0).Item("celular")
                TXBmail.Text =
registro.Tables("Tabla1").Rows(0).Item("mail")
            Else
                MsgBox("resgistro inexistente")
                TXBapell.Focus()
            End If
        End If
    End Sub
    Private Sub TXBapell_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXBapell.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            TXBnom.Focus()
        End If
    End Sub
    Private Sub TXBnom_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXBnom.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            TXBdire.Focus()
        End If
    End Sub
    Private Sub TXBdire_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXBdire.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            DTP1.Focus()
        End If
    End Sub
    Private Sub TXBcat_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXBcat.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            TXBsexo.Focus()
        End If
    End Sub
    Private Sub TXBsexo_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXBsexo.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            TXBcelu.Focus()
        End If
    End Sub
    Private Sub TXBcelu_keypress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXBcelu.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            e.Handled = True
            TXBmail.Focus()
        End If
    End Sub
    Private Sub ButtonCancelar_Click(sender As Object, e As EventArgs) Handles ButtonCancelar.Click
        Call blanquea()
    End Sub
    Private Sub ButtonSalir_Click(sender As Object, e As EventArgs) Handles ButtonSalir.Click
        End
    End Sub
    Private Sub ButtonGuardar_Click(sender As Object, e As EventArgs) Handles ButtonGuardar.Click
        Call grabar()
    End Sub
    Public Sub grabar()
        Dim conexion1 As New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C: \Users\Diego\source\repos\Proyecto\bin\Debug\Database4.mdb")
        conexion1.Open()
        Try
            MsgBox("conexion correcta")
        Catch ex As Exception
            MsgBox("conexion incorrecta")
        End Try
        Dim consulta As String = "insert into tabla1(n_socio,apellido,nombre,direccion,fecha_nac,categoria,sexo,celular,mail)values('" & TXBnum.Text & "','" & TXBapell.Text & "','" & TXBnom.Text & "','" & TXBdire.Text & "','" & DTP1.Value & "','" & TXBcat.Text & "','" & TXBsexo.Text & "','" & TXBcelu.Text & "','" & TXBmail.Text & "')"
        Dim COMANDO As New OleDbCommand(consulta, conexion1)
        Dim DR As OleDbDataReader = COMANDO.ExecuteReader
        conexion1.Close()
        MsgBox("datos guardados")
        Call blanquea()
    End Sub
    Private Sub blanquea()
        TXBnum.Text = ""
        TXBapell.Text = ""
        TXBnom.Text = ""
        TXBdire.Text = ""
        TXBcat.Text = ""
        TXBsexo.Text = ""
        TXBcelu.Text = ""
        TXBmail.Text = ""
        ' CHKlbox1.Hide()
        TXBnum.Focus()
    End Sub
    Private Sub ButtonEliminar_Click(sender As Object, e As EventArgs) Handles ButtonEliminar.Click
        Dim conexion2 As New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C: \Users\Diego\source\repos\Proyecto\bin\Debug\Database4.mdb")
        conexion2.Open()
        Dim borra As String = "DELETE * From Tabla1 WHERE Numero = " &
        TXBnum.Text & ""
        Dim COMANDOb As New OleDbCommand(borra, conexion2)
        Dim DRb As OleDbDataReader = COMANDOb.ExecuteReader
        MsgBox("Borrado")
        conexion2.Close()
        Call blanquea()
    End Sub
    Private Sub ButtonModificar_Click(sender As Object, e As EventArgs) Handles ButtonModificar.Click
        Dim conexion3 As New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C: \Users\Diego\source\repos\Proyecto\bin\Debug\Database4.mdb")
        conexion3.Open()
        Try
            MsgBox("conexion correcta")
        Catch ex As Exception
            MsgBox("conexion incorrecta")
        End Try
        codigocontro2 = Val(TXBnum.Text)
        Dim consulta1 As String
        Dim lista1 As New Byte
        Dim adaptador1 As New OleDbDataAdapter
        Dim registro1 As New DataSet
        consulta1 = "SELECT * FROM Tabla1 WHERE numero = " &
        Codicontro2 & ""
        adaptador1 = New OleDbDataAdapter(consulta1, conexion3)
        registro1 = New DataSet
        adaptador1.Fill(registro1, "Tabla1")
        lista1 = registro1.Tables("Tabla1").Rows.Count
        consulta1 = "UPDATE Tabla1 SET Apellido = '" & TXBapell.Text &
        "', Nombre = '" & TXBnom.Text & "', direccion = '" &
        TXBdire.Text & "', fecha_nac ='" & DTP1.Value & "', categoria ='" & TXBcat.Text & "', sexo = '" &
        TXBsexo.Text & "', celular = '" & TXBcelu.Text & "', mail = '" & TXBmail.Text & "' WHERE numero = " & codigocontro2 & ""
        Dim COMANDOtbostk As New OleDbCommand(consulta1, conexion3)
        Dim ahoratk As OleDbDataReader = COMANDOtbostk.ExecuteReader
        conexion3.Close()
        MsgBox("datos modificados")
        Call blanquea()
    End Sub
End Class
