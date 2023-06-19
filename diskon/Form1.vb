Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Deklarasi variabel
        Dim Harga, Jumlah As Integer
        Dim Total, Diskon, Bayar As Double
        Dim Bonus As String

        'Deklarasi Input Harga
        Harga = TextBox2.Text
        Jumlah = TextBox3.Text

        'Perhitungan Total Harga
        Total = Harga * Jumlah

        'Penentuan Diskon dan Bonus
        If Total >= 500000 Then
            Diskon = 0.2 * Total
            Bonus = "Gelas"
        ElseIf Total >= 200000 Then
            Diskon = 0.15 * Total
            Bonus = "Sendal"
        ElseIf Total >= 100000 Then
            Diskon = 0.1 * Total
            Bonus = "Cokelat"
        ElseIf Total >= 50000 Then
            Diskon = 0.05 * Total
            Bonus = "Permen"
        Else
            Diskon = 0
            Bonus = "Tidak"
        End If

        'Perhitungan Total bayar
        Bayar = Total - Diskon

        'Deklarasi keluaran Total, Diskon, Bayar, Bonus
        TextBox4.Text = Total
        TextBox5.Text = Diskon
        TextBox6.Text = Bayar
        TextBox7.Text = Bonus
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
