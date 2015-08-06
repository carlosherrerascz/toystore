Public Class frmListInventory
    'Desplegar resultados en listbox.
    Private Sub frmListInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstInventory.Items.Add("Product" & vbTab & _
                               "Units" & vbTab & _
                               "Units" & vbTab & vbTab & _
                               "Price" & vbTab & _
                               "Product" & vbTab)
        lstInventory.Items.Add("Number" & vbTab & _
                               "San Juan" & vbTab & _
                               "Mayaguez" & vbTab & _
                               "Per Unit" & vbTab & _
                               "Description" & vbTab
                               )
        lstInventory.Items.Add("-------------------------------------------------------------------------------------------------------------------------------------------------------------------------")
        For intCurrentProduct As Integer = 0 To intLinesCount - 1
            With ProductLine(intCurrentProduct)
                lstInventory.Items.Add(.strProductNumber & vbTab &
                                       .intSanJuanUnits & vbTab &
                                       .intMayaguezUnits & vbTab & vbTab &
                                       .decProductPrice.ToString("c") & vbTab & _
                                       .strProductName & vbTab & vbTab)
            End With

        Next
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
        frmInventory.Show()
    End Sub
End Class