<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddProduct))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNumeroProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProdPrice = New System.Windows.Forms.TextBox()
        Me.txtUnitsMayaguez = New System.Windows.Forms.TextBox()
        Me.txtUnitsSanJuan = New System.Windows.Forms.TextBox()
        Me.txtProductDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProdName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblAddedPrice = New System.Windows.Forms.Label()
        Me.lblAddedUnits = New System.Windows.Forms.Label()
        Me.lblAddedProduct = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnAddProduct = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNumeroProducto)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtProdPrice)
        Me.GroupBox1.Controls.Add(Me.txtUnitsMayaguez)
        Me.GroupBox1.Controls.Add(Me.txtUnitsSanJuan)
        Me.GroupBox1.Controls.Add(Me.txtProductDescription)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtProdName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 164)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos"
        '
        'txtNumeroProducto
        '
        Me.txtNumeroProducto.Location = New System.Drawing.Point(148, 27)
        Me.txtNumeroProducto.Name = "txtNumeroProducto"
        Me.txtNumeroProducto.Size = New System.Drawing.Size(141, 20)
        Me.txtNumeroProducto.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(58, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Product Number:"
        '
        'txtProdPrice
        '
        Me.txtProdPrice.Location = New System.Drawing.Point(148, 132)
        Me.txtProdPrice.Name = "txtProdPrice"
        Me.txtProdPrice.Size = New System.Drawing.Size(141, 20)
        Me.txtProdPrice.TabIndex = 4
        '
        'txtUnitsMayaguez
        '
        Me.txtUnitsMayaguez.Location = New System.Drawing.Point(148, 106)
        Me.txtUnitsMayaguez.Name = "txtUnitsMayaguez"
        Me.txtUnitsMayaguez.Size = New System.Drawing.Size(141, 20)
        Me.txtUnitsMayaguez.TabIndex = 3
        '
        'txtUnitsSanJuan
        '
        Me.txtUnitsSanJuan.Location = New System.Drawing.Point(148, 80)
        Me.txtUnitsSanJuan.Name = "txtUnitsSanJuan"
        Me.txtUnitsSanJuan.Size = New System.Drawing.Size(141, 20)
        Me.txtUnitsSanJuan.TabIndex = 2
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Location = New System.Drawing.Point(148, 53)
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.Size = New System.Drawing.Size(186, 20)
        Me.txtProductDescription.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(68, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Product Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(56, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Mayaguez Units:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(60, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "San Juan Units:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(42, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Product Description:"
        '
        'txtProdName
        '
        Me.txtProdName.Location = New System.Drawing.Point(182, -21)
        Me.txtProdName.Name = "txtProdName"
        Me.txtProdName.Size = New System.Drawing.Size(141, 20)
        Me.txtProdName.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(62, -18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Número del Producto:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblAddedPrice)
        Me.GroupBox2.Controls.Add(Me.lblAddedUnits)
        Me.GroupBox2.Controls.Add(Me.lblAddedProduct)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(411, 103)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Results"
        '
        'lblAddedPrice
        '
        Me.lblAddedPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddedPrice.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAddedPrice.Location = New System.Drawing.Point(17, 72)
        Me.lblAddedPrice.Name = "lblAddedPrice"
        Me.lblAddedPrice.Size = New System.Drawing.Size(368, 23)
        Me.lblAddedPrice.TabIndex = 16
        Me.lblAddedPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAddedUnits
        '
        Me.lblAddedUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddedUnits.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAddedUnits.Location = New System.Drawing.Point(17, 45)
        Me.lblAddedUnits.Name = "lblAddedUnits"
        Me.lblAddedUnits.Size = New System.Drawing.Size(368, 23)
        Me.lblAddedUnits.TabIndex = 15
        Me.lblAddedUnits.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAddedProduct
        '
        Me.lblAddedProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAddedProduct.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAddedProduct.Location = New System.Drawing.Point(17, 15)
        Me.lblAddedProduct.Name = "lblAddedProduct"
        Me.lblAddedProduct.Size = New System.Drawing.Size(368, 23)
        Me.lblAddedProduct.TabIndex = 12
        Me.lblAddedProduct.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(435, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.SalirToolStripMenuItem.Text = "E&xit"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.Location = New System.Drawing.Point(168, 394)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(92, 46)
        Me.btnAddProduct.TabIndex = 5
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.frmJugueteria.My.Resources.Resources.smallertux
        Me.PictureBox1.Location = New System.Drawing.Point(101, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(359, 86)
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'frmAddProduct
        '
        Me.AcceptButton = Me.btnAddProduct
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 458)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmAddProduct"
        Me.Text = "Add a Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProdPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitsMayaguez As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitsSanJuan As System.Windows.Forms.TextBox
    Friend WithEvents txtProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProdName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAddedPrice As System.Windows.Forms.Label
    Friend WithEvents lblAddedUnits As System.Windows.Forms.Label
    Friend WithEvents lblAddedProduct As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtNumeroProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAddProduct As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
