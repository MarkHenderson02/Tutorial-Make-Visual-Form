Public Class frmcoba
    Private Sub frmcoba_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btntampilkan_Click(sender As Object, e As EventArgs) Handles Btntampilkan.Click
        MessageBox.Show(txtnama.Text & vbCrLf & cbojeniskelamin.Text & vbCrLf & cbofakultas.Text,
                        "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
