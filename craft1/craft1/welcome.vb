Public Class Form1
    Private Sub الزبائنToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الزبائنToolStripMenuItem.Click
        client.MdiParent = Me
        pb1.Hide()

        client.Show()
        outly.Hide()
        employee.Hide()
        reservation_date.Hide()
        job.Hide()
        shipping_order.Hide()
        squeeze_details.Hide()
        price.Hide()
    End Sub

    Private Sub المصاريفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المصاريفToolStripMenuItem.Click
        outly.MdiParent = Me
        pb1.Hide()

        outly.Show()
        client.Hide()

        employee.Hide()
        reservation_date.Hide()
        job.Hide()
        shipping_order.Hide()
        squeeze_details.Hide()
        price.Hide()
    End Sub

    Private Sub حجزموعدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حجزموعدToolStripMenuItem.Click
        reservation_date.MdiParent = Me
        pb1.Hide()

        reservation_date.Show()
        client.Hide()
        outly.Hide()
        employee.Hide()

        job.Hide()
        shipping_order.Hide()
        squeeze_details.Hide()
        price.Hide()
    End Sub

    Private Sub العملToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles العملToolStripMenuItem.Click
        job.MdiParent = Me
        pb1.Hide()

        job.Show()
        client.Hide()

        outly.Hide()
        employee.Hide()
        reservation_date.Hide()

        shipping_order.Hide()
        squeeze_details.Hide()
        price.Hide()

    End Sub

    Private Sub طلباتشحنToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles طلباتشحنToolStripMenuItem.Click
        shipping_order.MdiParent = Me
        pb1.Hide()

        shipping_order.Show()
        client.Hide()
        outly.Hide()
        employee.Hide()
        reservation_date.Hide()
        job.Hide()

        squeeze_details.Hide()
        price.Hide()
    End Sub

    Private Sub الموضفينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الموضفينToolStripMenuItem.Click
        employee.MdiParent = Me
        pb1.Hide()

        employee.Show()
        client.Hide()
        outly.Hide()

        reservation_date.Hide()
        job.Hide()
        shipping_order.Hide()
        squeeze_details.Hide()
        price.Hide()
    End Sub

    Private Sub السعرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles السعرToolStripMenuItem.Click
        price.MdiParent = Me
        pb1.Hide()

        price.Show()
        client.Hide()
        outly.Hide()
        employee.Hide()
        reservation_date.Hide()
        job.Hide()
        shipping_order.Hide()
        squeeze_details.Hide()
    End Sub

    Private Sub معلوماتالعصرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles معلوماتالعصرToolStripMenuItem.Click
        squeeze_details.MdiParent = Me
        pb1.Hide()

        squeeze_details.Show()
        client.Hide()
        outly.Hide()
        employee.Hide()
        reservation_date.Hide()
        job.Hide()
        shipping_order.Hide()

        price.Hide()

    End Sub
End Class