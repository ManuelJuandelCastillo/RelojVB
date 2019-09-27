Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("hh:mm")
        lbl_seg.Text = DateTime.Now.ToString("ss")
        lbl_fecha.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy")

        ProgressBar1.PerformStep()
        ProgressBar1.Value = TimeOfDay.ToString("ss")
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PararToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PararToolStripMenuItem.Click
        Timer1.Enabled = False
    End Sub

    Private Sub EncenderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncenderToolStripMenuItem.Click
        Timer1.Enabled = True
    End Sub

    Private Sub FondoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FondoToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Form1.ActiveForm.BackColor = ColorDialog1.Color
        FuenteToolStripMenuItem.BackColor = ColorDialog1.Color
        FechaToolStripMenuItem.BackColor = ColorDialog1.Color
        HoraYMinutosToolStripMenuItem.BackColor = ColorDialog1.Color
        SegundosToolStripMenuItem.BackColor = ColorDialog1.Color
        ColorToolStripMenuItem.BackColor = ColorDialog1.Color
        FondoToolStripMenuItem.BackColor = ColorDialog1.Color
        FechaToolStripMenuItem1.BackColor = ColorDialog1.Color
        HoraYMinutosToolStripMenuItem1.BackColor = ColorDialog1.Color
        SegundosToolStripMenuItem1.BackColor = ColorDialog1.Color
        PararToolStripMenuItem.BackColor = ColorDialog1.Color
        EncenderToolStripMenuItem.BackColor = ColorDialog1.Color
        SalirToolStripMenuItem.BackColor = ColorDialog1.Color
    End Sub

    Private Sub FechaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FechaToolStripMenuItem1.Click
        ColorDialog1.ShowDialog()
        lbl_fecha.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub HoraYMinutosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HoraYMinutosToolStripMenuItem1.Click
        ColorDialog1.ShowDialog()
        lbl_hora.ForeColor = ColorDialog1.Color
        MenuStrip1.ForeColor = ColorDialog1.Color
        FuenteToolStripMenuItem.ForeColor = ColorDialog1.Color
        FechaToolStripMenuItem.ForeColor = ColorDialog1.Color
        HoraYMinutosToolStripMenuItem.ForeColor = ColorDialog1.Color
        SegundosToolStripMenuItem.ForeColor = ColorDialog1.Color
        ColorToolStripMenuItem.ForeColor = ColorDialog1.Color
        FondoToolStripMenuItem.ForeColor = ColorDialog1.Color
        FechaToolStripMenuItem1.ForeColor = ColorDialog1.Color
        HoraYMinutosToolStripMenuItem1.ForeColor = ColorDialog1.Color
        SegundosToolStripMenuItem1.ForeColor = ColorDialog1.Color
        PararToolStripMenuItem.ForeColor = ColorDialog1.Color
        EncenderToolStripMenuItem.ForeColor = ColorDialog1.Color
        SalirToolStripMenuItem.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub SegundosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SegundosToolStripMenuItem1.Click
        ColorDialog1.ShowDialog()
        lbl_seg.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub FechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FechaToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        lbl_fecha.Font = FontDialog1.Font
    End Sub

    Private Sub HoraYMinutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoraYMinutosToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        lbl_hora.Font = FontDialog1.Font
    End Sub

    Private Sub SegundosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegundosToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        lbl_seg.Font = FontDialog1.Font
    End Sub

End Class
