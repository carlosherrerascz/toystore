Option Strict On
Option Explicit On
Imports System.IO

Module Module1
    Public strFileName As String
    Public streamReaderInventario As StreamReader

    Public Structure Inventario
        Dim strProductNumber As String
        Dim strProductName As String
        Dim intSanJuanUnits As Integer
        Dim intMayaguezUnits As Integer
        Dim decProductPrice As Decimal
        Dim decImportPrice As Decimal
    End Structure

    'Arreglo de tipo inventario. Es lo que usaremos mayormente en este proyecto.
    Public ProductLine() As Inventario

    Public intLinesCount As Integer = 0
    Public intTotalProducts As Integer = 0
    Public chrComma As Char = CChar(", ")

    'Como el documento de texto esta arreglado en forma de comas y espacios, este procedimiento las delimita por los mismos.
    Public Sub subFillArrays(ByRef intCounter As Integer)
        Dim strInputRecordLine As String = String.Empty
        Dim strDelimiterArray() As String
        Dim intCountElements As Integer
        Dim intNumElement As Integer
        streamReaderInventario = File.OpenText(strFileName)

        Do While Not streamReaderInventario.EndOfStream
            strInputRecordLine = streamReaderInventario.ReadLine
            strDelimiterArray = Split(strInputRecordLine, chrComma)
            intCountElements = strDelimiterArray.Length
            ReDim Preserve strDelimiterArray(intCountElements)
            ReDim Preserve ProductLine(intCounter)
            intNumElement = 0
            Do While intNumElement < intCountElements
                If strDelimiterArray(intNumElement) <> " " Then
                    With ProductLine(intCounter)
                        Select Case intNumElement
                            Case Is = 0
                                .strProductNumber = strDelimiterArray(intNumElement)
                            Case Is = 1
                                .strProductName = strDelimiterArray(intNumElement)
                            Case Is = 2
                                .intSanJuanUnits = CInt(strDelimiterArray(intNumElement))
                            Case Is = 3
                                .intMayaguezUnits = CInt(strDelimiterArray(intNumElement))
                            Case Is = 4
                                .decProductPrice = CDec(strDelimiterArray(intNumElement))
                        End Select
                    End With
                    intNumElement += 1
                Else
                    intNumElement = intCountElements
                End If
            Loop
            intCounter += 1
        Loop
        streamReaderInventario.Close()
    End Sub
End Module
