<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btn_dashboard = New FontAwesome.Sharp.IconButton()
        Panel1 = New Panel()
        Panel2 = New Panel()
        btn_setting = New FontAwesome.Sharp.IconButton()
        btn_marketing = New FontAwesome.Sharp.IconButton()
        btn_products = New FontAwesome.Sharp.IconButton()
        btn_customers = New FontAwesome.Sharp.IconButton()
        btn_orders = New FontAwesome.Sharp.IconButton()
        Panel3 = New Panel()
        Panel5 = New Panel()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn_dashboard
        ' 
        btn_dashboard.FlatStyle = FlatStyle.Popup
        btn_dashboard.ForeColor = SystemColors.ControlLightLight
        btn_dashboard.IconChar = FontAwesome.Sharp.IconChar.Shekel
        btn_dashboard.IconColor = SystemColors.Control
        btn_dashboard.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_dashboard.IconSize = 30
        btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft
        btn_dashboard.Location = New Point(3, 149)
        btn_dashboard.Name = "btn_dashboard"
        btn_dashboard.Size = New Size(147, 34)
        btn_dashboard.TabIndex = 0
        btn_dashboard.Text = "           Dashboard"
        btn_dashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(40, 68)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(0, 0)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Navy
        Panel2.Controls.Add(btn_setting)
        Panel2.Controls.Add(btn_marketing)
        Panel2.Controls.Add(btn_products)
        Panel2.Controls.Add(btn_customers)
        Panel2.Controls.Add(btn_orders)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(btn_dashboard)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(153, 679)
        Panel2.TabIndex = 2
        ' 
        ' btn_setting
        ' 
        btn_setting.FlatStyle = FlatStyle.Popup
        btn_setting.ForeColor = SystemColors.ControlLightLight
        btn_setting.IconChar = FontAwesome.Sharp.IconChar.Gears
        btn_setting.IconColor = SystemColors.ButtonHighlight
        btn_setting.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_setting.IconSize = 30
        btn_setting.ImageAlign = ContentAlignment.MiddleLeft
        btn_setting.Location = New Point(3, 347)
        btn_setting.Name = "btn_setting"
        btn_setting.Size = New Size(147, 34)
        btn_setting.TabIndex = 8
        btn_setting.Text = "      Setting"
        btn_setting.UseVisualStyleBackColor = True
        ' 
        ' btn_marketing
        ' 
        btn_marketing.FlatStyle = FlatStyle.Popup
        btn_marketing.ForeColor = SystemColors.ControlLightLight
        btn_marketing.IconChar = FontAwesome.Sharp.IconChar.NotesMedical
        btn_marketing.IconColor = SystemColors.ButtonHighlight
        btn_marketing.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_marketing.IconSize = 30
        btn_marketing.ImageAlign = ContentAlignment.MiddleLeft
        btn_marketing.Location = New Point(1, 309)
        btn_marketing.Name = "btn_marketing"
        btn_marketing.Size = New Size(147, 34)
        btn_marketing.TabIndex = 7
        btn_marketing.Text = "        Marketing"
        btn_marketing.UseVisualStyleBackColor = True
        ' 
        ' btn_products
        ' 
        btn_products.FlatStyle = FlatStyle.Popup
        btn_products.ForeColor = SystemColors.ControlLightLight
        btn_products.IconChar = FontAwesome.Sharp.IconChar.LongArrowAltUp
        btn_products.IconColor = SystemColors.ButtonHighlight
        btn_products.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_products.IconSize = 30
        btn_products.ImageAlign = ContentAlignment.MiddleLeft
        btn_products.Location = New Point(0, 229)
        btn_products.Name = "btn_products"
        btn_products.Size = New Size(147, 34)
        btn_products.TabIndex = 6
        btn_products.Text = "        Products"
        btn_products.UseVisualStyleBackColor = True
        ' 
        ' btn_customers
        ' 
        btn_customers.FlatStyle = FlatStyle.Popup
        btn_customers.ForeColor = SystemColors.ControlLightLight
        btn_customers.IconChar = FontAwesome.Sharp.IconChar.Users
        btn_customers.IconColor = SystemColors.ButtonHighlight
        btn_customers.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_customers.IconSize = 30
        btn_customers.ImageAlign = ContentAlignment.MiddleLeft
        btn_customers.Location = New Point(3, 269)
        btn_customers.Name = "btn_customers"
        btn_customers.Size = New Size(147, 34)
        btn_customers.TabIndex = 5
        btn_customers.Text = "        Customers"
        btn_customers.UseVisualStyleBackColor = True
        ' 
        ' btn_orders
        ' 
        btn_orders.FlatStyle = FlatStyle.Popup
        btn_orders.ForeColor = SystemColors.ControlLightLight
        btn_orders.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart
        btn_orders.IconColor = SystemColors.ControlLight
        btn_orders.IconFont = FontAwesome.Sharp.IconFont.Auto
        btn_orders.IconSize = 30
        btn_orders.ImageAlign = ContentAlignment.MiddleLeft
        btn_orders.Location = New Point(3, 189)
        btn_orders.Name = "btn_orders"
        btn_orders.Size = New Size(147, 34)
        btn_orders.TabIndex = 4
        btn_orders.Text = "        Orders"
        btn_orders.UseVisualStyleBackColor = True
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.MidnightBlue
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(153, 74)
        Panel3.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(153, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1074, 679)
        Panel5.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1227, 679)
        Controls.Add(Panel5)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        ShowIcon = False
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_dashboard As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_marketing As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_products As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_customers As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_orders As FontAwesome.Sharp.IconButton
    Friend WithEvents btn_setting As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel5 As Panel
End Class
