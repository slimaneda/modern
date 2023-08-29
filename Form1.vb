Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Sub switchpanel(ByVal panel As Form)
        Panel5.Controls.Clear()
        panel.TopLevel = False
        Panel5.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        switchpanel(Dashboard)
    End Sub

    Private Sub btn_orders_Click(sender As Object, e As EventArgs) Handles btn_orders.Click
        switchpanel(Orders)
    End Sub

    Private Sub btn_products_Click(sender As Object, e As EventArgs) Handles btn_products.Click
        switchpanel(Products)
    End Sub

    Private Sub btn_customers_Click(sender As Object, e As EventArgs) Handles btn_customers.Click
        switchpanel(Customers)
    End Sub

    Private Sub btn_marketing_Click(sender As Object, e As EventArgs) Handles btn_marketing.Click
        switchpanel(Marketing)
    End Sub

    Private Sub btn_setting_Click(sender As Object, e As EventArgs) Handles btn_setting.Click

    End Sub
End Class
