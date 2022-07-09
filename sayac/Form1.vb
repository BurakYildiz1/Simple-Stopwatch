Public Class Form1
    Dim KalanSure As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmbInterval_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbInterval.SelectedIndexChanged
    End Sub

    Private Sub btnbasla_Click(sender As Object, e As EventArgs) Handles btnbasla.Click
        KalanSure = txtSure.Text
        lblsure.Text = KalanSure
        lbKayit.Items.Add("Kronometre başladı: " & Now.TimeOfDay.ToString)
        tmrKronometre.Interval = cmbInterval.Text
        tmrKronometre.Start()

    End Sub

    Private Sub lbKayit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbKayit.SelectedIndexChanged
    End Sub

    Private Sub btndur_Click(sender As Object, e As EventArgs) Handles btndur.Click
        tmrKronometre.Stop()
        lbKayit.Items.Add("Kronometre durduruldu: " & Now.TimeOfDay.ToString)
    End Sub

    Private Sub tmrKronometre_Tick(sender As Object, e As EventArgs) Handles tmrKronometre.Tick
        KalanSure = KalanSure - 1
        lblsure.Text = KalanSure

        If KalanSure = 0 Then
            tmrKronometre.Stop()
            lbKayit.Items.Add("Süre Doldu: " & Now.TimeOfDay.ToString)
            MsgBox("Süre doldu")
        End If

    End Sub
End Class
