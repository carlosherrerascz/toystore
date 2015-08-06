Option Explicit On
Option Strict On
Imports System.IO
Public Class frmAddProduct
    Public streamWriterInventario As StreamWriter

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
        frmInventory.Show()
    End Sub


    Private Sub btnAddProduct_Click(sender As Object, e As EventArgs) Handles btnAddProduct.Click
        Dim blnNoMatch As Boolean = True
        Dim intProduct As Integer = 0
        'Si el usuario escribió un numero de producto igual al que estaba en el array,
        'no permitirá al usuario añadirlo al archivo y le dará una advertencia. 
        Do While blnNoMatch
            If txtNumeroProducto.Text = ProductLine(intProduct).strProductNumber Then
                blnNoMatch = False
            End If
            intProduct = intProduct + 1
        Loop
        If blnNoMatch Then
            streamWriterInventario = File.AppendText(strFileName)
            streamWriterInventario.WriteLine(txtNumeroProducto.Text + ", " + txtProductDescription.Text + ", " _
                                             + txtUnitsSanJuan.Text + ", " + txtUnitsMayaguez.Text + ", " + txtProdPrice.Text)
            streamWriterInventario.Close()

            intLinesCount = intLinesCount + 1

            subFillArrays(intLinesCount)

            'Confirmación de datos.
            lblAddedProduct.Text = ("Product Added: " & txtProductDescription.Text)
            lblAddedUnits.Text = ("Units in San Juan: " & txtUnitsSanJuan.Text & " and Units in Mayaguez: " & txtUnitsMayaguez.Text)
            lblAddedPrice.Text = ("Price: " & txtProdPrice.Text)
        Else
            MessageBox.Show("Cannot add; product number already in text file!")
            txtNumeroProducto.Clear()
            txtNumeroProducto.Focus()
        End If

        
    End Sub
End Class