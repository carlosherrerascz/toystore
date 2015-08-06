<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblImportPrice = New System.Windows.Forms.Label()
        Me.lblProductPrice = New System.Windows.Forms.Label()
        Me.lblMayaguezUnits = New System.Windows.Forms.Label()
        Me.lblSanJuanUnits = New System.Windows.Forms.Label()
        Me.lblProductName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductNumber = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInventoryList = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTotalImport = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTotalImportSanJuan = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTotalImportMayaguez = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalculateTotal = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveFile = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblImportTotal = New System.Windows.Forms.Label()
        Me.lblImportMayaguez = New System.Windows.Forms.Label()
        Me.lblImportSanJuan = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblImportPrice)
        Me.GroupBox1.Controls.Add(Me.lblProductPrice)
        Me.GroupBox1.Controls.Add(Me.lblMayaguezUnits)
        Me.GroupBox1.Controls.Add(Me.lblSanJuanUnits)
        Me.GroupBox1.Controls.Add(Me.lblProductName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtProductNumber)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selected Product"
        '
        'lblImportPrice
        '
        Me.lblImportPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImportPrice.Location = New System.Drawing.Point(149, 168)
        Me.lblImportPrice.Name = "lblImportPrice"
        Me.lblImportPrice.Size = New System.Drawing.Size(247, 23)
        Me.lblImportPrice.TabIndex = 19
        '
        'lblProductPrice
        '
        Me.lblProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductPrice.Location = New System.Drawing.Point(149, 142)
        Me.lblProductPrice.Name = "lblProductPrice"
        Me.lblProductPrice.Size = New System.Drawing.Size(247, 23)
        Me.lblProductPrice.TabIndex = 18
        '
        'lblMayaguezUnits
        '
        Me.lblMayaguezUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMayaguezUnits.Location = New System.Drawing.Point(149, 116)
        Me.lblMayaguezUnits.Name = "lblMayaguezUnits"
        Me.lblMayaguezUnits.Size = New System.Drawing.Size(247, 23)
        Me.lblMayaguezUnits.TabIndex = 17
        '
        'lblSanJuanUnits
        '
        Me.lblSanJuanUnits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSanJuanUnits.Location = New System.Drawing.Point(149, 88)
        Me.lblSanJuanUnits.Name = "lblSanJuanUnits"
        Me.lblSanJuanUnits.Size = New System.Drawing.Size(247, 23)
        Me.lblSanJuanUnits.TabIndex = 16
        '
        'lblProductName
        '
        Me.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductName.Location = New System.Drawing.Point(149, 62)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(247, 23)
        Me.lblProductName.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Import Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(69, 143)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Product Price:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(60, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Mayagüez Units"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "San Juan Units:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Number:"
        '
        'txtProductNumber
        '
        Me.txtProductNumber.Location = New System.Drawing.Point(149, 34)
        Me.txtProductNumber.Name = "txtProductNumber"
        Me.txtProductNumber.Size = New System.Drawing.Size(149, 20)
        Me.txtProductNumber.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAdd, Me.mnuSearch, Me.mnuInventoryList, Me.mnuTotalImport, Me.mnuClear, Me.mnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(467, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuAdd
        '
        Me.mnuAdd.Name = "mnuAdd"
        Me.mnuAdd.Size = New System.Drawing.Size(86, 20)
        Me.mnuAdd.Text = "&Add Product"
        '
        'mnuSearch
        '
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(99, 20)
        Me.mnuSearch.Text = "&Search Product"
        '
        'mnuInventoryList
        '
        Me.mnuInventoryList.Name = "mnuInventoryList"
        Me.mnuInventoryList.Size = New System.Drawing.Size(90, 20)
        Me.mnuInventoryList.Text = "Inventory &List"
        '
        'mnuTotalImport
        '
        Me.mnuTotalImport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTotalImportSanJuan, Me.mnuTotalImportMayaguez, Me.mnuCalculateTotal})
        Me.mnuTotalImport.Name = "mnuTotalImport"
        Me.mnuTotalImport.Size = New System.Drawing.Size(84, 20)
        Me.mnuTotalImport.Text = "&Total Import"
        '
        'mnuTotalImportSanJuan
        '
        Me.mnuTotalImportSanJuan.CheckOnClick = True
        Me.mnuTotalImportSanJuan.Name = "mnuTotalImportSanJuan"
        Me.mnuTotalImportSanJuan.Size = New System.Drawing.Size(152, 22)
        Me.mnuTotalImportSanJuan.Text = "&San Juan"
        '
        'mnuTotalImportMayaguez
        '
        Me.mnuTotalImportMayaguez.CheckOnClick = True
        Me.mnuTotalImportMayaguez.Name = "mnuTotalImportMayaguez"
        Me.mnuTotalImportMayaguez.Size = New System.Drawing.Size(152, 22)
        Me.mnuTotalImportMayaguez.Text = "&Mayagüez"
        '
        'mnuCalculateTotal
        '
        Me.mnuCalculateTotal.Name = "mnuCalculateTotal"
        Me.mnuCalculateTotal.Size = New System.Drawing.Size(152, 22)
        Me.mnuCalculateTotal.Text = "&Calculate Total"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(46, 20)
        Me.mnuClear.Text = "C&lear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(37, 20)
        Me.mnuExit.Text = "E&xit"
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblImportTotal)
        Me.GroupBox2.Controls.Add(Me.lblImportMayaguez)
        Me.GroupBox2.Controls.Add(Me.lblImportSanJuan)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 325)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(443, 103)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Inventory"
        '
        'lblImportTotal
        '
        Me.lblImportTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImportTotal.Location = New System.Drawing.Point(155, 77)
        Me.lblImportTotal.Name = "lblImportTotal"
        Me.lblImportTotal.Size = New System.Drawing.Size(241, 23)
        Me.lblImportTotal.TabIndex = 16
        '
        'lblImportMayaguez
        '
        Me.lblImportMayaguez.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImportMayaguez.Location = New System.Drawing.Point(155, 47)
        Me.lblImportMayaguez.Name = "lblImportMayaguez"
        Me.lblImportMayaguez.Size = New System.Drawing.Size(241, 23)
        Me.lblImportMayaguez.TabIndex = 15
        '
        'lblImportSanJuan
        '
        Me.lblImportSanJuan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImportSanJuan.Location = New System.Drawing.Point(154, 19)
        Me.lblImportSanJuan.Name = "lblImportSanJuan"
        Me.lblImportSanJuan.Size = New System.Drawing.Size(242, 23)
        Me.lblImportSanJuan.TabIndex = 12
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(86, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(66, 13)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Total Import:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(145, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Total Mayagüez Import Price:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Total San Juan Import Price:"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.frmJugueteria.My.Resources.Resources.smallertux
        Me.PictureBox1.Location = New System.Drawing.Point(122, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(359, 86)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 462)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmInventory"
        Me.Text = "Inventory"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblImportPrice As System.Windows.Forms.Label
    Friend WithEvents lblProductPrice As System.Windows.Forms.Label
    Friend WithEvents lblMayaguezUnits As System.Windows.Forms.Label
    Friend WithEvents lblSanJuanUnits As System.Windows.Forms.Label
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProductNumber As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuInventoryList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTotalImport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents ofdOpenFile As System.Windows.Forms.OpenFileDialog
    Public WithEvents sfdSaveFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblImportTotal As System.Windows.Forms.Label
    Friend WithEvents lblImportMayaguez As System.Windows.Forms.Label
    Friend WithEvents lblImportSanJuan As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTotalImportSanJuan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTotalImportMayaguez As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCalculateTotal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
