Imports tik4net
Public Class Form1
    Private Connection As ITikConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Connection = ConnectionFactory.CreateConnection(TikConnectionType.Api)
            Connection.Open("192.168.200.1", "user1", "user1234")
        Catch ex As Exception
            MessageBox.Show("Error connecting to MikroTik: " & ex.Message)
        End Try
        LblStatus.Text = "Status : Terhubung ke Mikrotik"
        LblStatus.ForeColor = Color.Green
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        If TxtName.Text = "" Or TxtPassword.Text = "" Then
            MessageBox.Show("Nama dan Password tidak boleh kosong", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim addCommand As ITikCommand = Connection.CreateCommand("/ppp/secret/add")
            addCommand.AddParameter("name", TxtName.Text)
            addCommand.AddParameter("password", TxtPassword.Text)
            addCommand.AddParameter("service", "pppoe")
            addCommand.ExecuteNonQuery()
            MessageBox.Show("Client PPPoE berhasil ditambahkan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtName.Clear()
            TxtPassword.Clear()
            TxtName.Focus()
        Catch ex As Exception
            MessageBox.Show("Error adding PPPoE client: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        If TxtName.Text <> "" Then
            TxtName.Clear()
        End If
        If TxtPassword.Text <> "" Then
            TxtPassword.Clear()
        End If
    End Sub
End Class
