Option Strict On
Option Explicit On
Imports System.IO

Public Class frmInventory
    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        System.Threading.Thread.Sleep(5000)
        Me.Show()
        With ofdOpenFile
            .Filter = "Text Files (*.txt)|*.txt"
            .Title = "Choose a file"
        End With
        'Intenta abrir un archivo. Si el archivo no existe o se cancela la acción,
        'el programa desplegará una advertencia y cierra el programa.
        If ofdOpenFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            strFileName = ofdOpenFile.FileName
            streamReaderInventario = File.OpenText(strFileName)
            'Cuenta la cantidad de lineas en el texto.
            Do While (Not streamReaderInventario.EndOfStream)
                streamReaderInventario.ReadLine()
                intLinesCount = intLinesCount + 1
            Loop
            streamReaderInventario.Close()

            Dim intArrayCounter = 0
            subFillArrays(intArrayCounter)
        Else
            MessageBox.Show("You must select a text file to begin.")
            Me.Close()
        End If
    End Sub

    'Procedimiento para borrar todos los datos desplegados en la forma.
    Sub ClearEntries()
        txtProductNumber.Clear()
        lblProductName.Text = String.Empty
        lblSanJuanUnits.Text = String.Empty
        lblMayaguezUnits.Text = String.Empty
        lblProductPrice.Text = String.Empty
        lblImportPrice.Text = String.Empty

        lblImportSanJuan.Text = String.Empty
        lblImportMayaguez.Text = String.Empty
        lblImportTotal.Text = String.Empty
    End Sub

    Private Sub AñadirProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuAdd.Click
        Me.Hide()
        frmAddProduct.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub BuscarProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuSearch.Click
        Dim blnNotFound As Boolean = True
        Dim intCurrentProductNum As Integer = 0
        'Continuará buscando el archivop hasta que se encuentra el número de producto o hasta que se llega 
        'al final de del arreglo.
        Do While blnNotFound And intCurrentProductNum <= ProductLine.Length - 1
            If ProductLine(intCurrentProductNum).strProductNumber = txtProductNumber.Text Then
                blnNotFound = False
            Else
                intCurrentProductNum = intCurrentProductNum + 1
            End If
        Loop
        If blnNotFound Or txtProductNumber.Text = String.Empty Then
            MessageBox.Show("Couldn't find product in record.")
            ClearEntries()
        Else
            'Desplega y computa resultados.
            With ProductLine(intCurrentProductNum)
                lblProductName.Text = .strProductName
                lblSanJuanUnits.Text = .intSanJuanUnits.ToString
                lblMayaguezUnits.Text = .intMayaguezUnits.ToString
                lblProductPrice.Text = .decProductPrice.ToString("C")

                Dim decImport As Decimal = (.intSanJuanUnits + .intMayaguezUnits) * .decProductPrice

                lblImportPrice.Text = decImport.ToString("C")
            End With
        End If
    End Sub

    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ClearEntries()
    End Sub

    Private Sub ListarInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuInventoryList.Click
        Me.Hide()
        frmListInventory.Show()
    End Sub

    Private Sub CalculateTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuCalculateTotal.Click
        'Calcula y computa totales segun los pueblos que escogió el usario.
        Dim decSanJuanTotal As Decimal = 0
        Dim decMayaguezTotal As Decimal = 0
        Dim decGrandTotal As Decimal = 0
        If mnuTotalImportSanJuan.Checked = True And mnuTotalImportMayaguez.Checked = True Then
            '
            For intCurrentProduct As Integer = 0 To intLinesCount - 1
                With ProductLine(intCurrentProduct)
                    decSanJuanTotal += (.intSanJuanUnits * .decProductPrice)
                    decMayaguezTotal += (.intMayaguezUnits * .decProductPrice)
                    decGrandTotal = decSanJuanTotal + decMayaguezTotal

                    lblImportSanJuan.Text = decSanJuanTotal.ToString("c")
                    lblImportMayaguez.Text = decMayaguezTotal.ToString("c")
                    lblImportTotal.Text = decGrandTotal.ToString("c")
                End With
            Next
        ElseIf mnuTotalImportMayaguez.Checked = True Then
            For intCurrentProduct As Integer = 0 To intLinesCount - 1
                With ProductLine(intCurrentProduct)
                    decMayaguezTotal += (.intMayaguezUnits * .decProductPrice)
                    decGrandTotal = decMayaguezTotal

                    lblImportSanJuan.Text = String.Empty
                    lblImportMayaguez.Text = decMayaguezTotal.ToString("c")
                    lblImportTotal.Text = decGrandTotal.ToString("c")
                End With
            Next
        ElseIf mnuTotalImportSanJuan.Checked = True Then
            For intCurrentProduct As Integer = 0 To intLinesCount - 1
                With ProductLine(intCurrentProduct)
                    decSanJuanTotal += (.intSanJuanUnits * .decProductPrice)
                    decMayaguezTotal += (.intMayaguezUnits * .decProductPrice)
                    decGrandTotal = decSanJuanTotal

                    lblImportSanJuan.Text = decSanJuanTotal.ToString("c")
                    lblImportMayaguez.Text = String.Empty
                    lblImportTotal.Text = decGrandTotal.ToString("c")
                End With
            Next
        Else
            MessageBox.Show("Please select a city!")

        End If



    End Sub
End Class
