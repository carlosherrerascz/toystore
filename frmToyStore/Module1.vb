Option Strict On
Option Explicit On
Imports System.IO

Module Module1
    Public strFileName As String
    Public streamReaderInventory As StreamReader

    Public Structure Inventory
        Dim strProductNumber As String
        Dim strProductName As String
        Dim intSanJuanUnits As Integer
        Dim intMayaguezUnits As Integer
        Dim decProductPrice As Decimal
        Dim decImportPrice As Decimal
    End Structure

    'Array Structure of type Inventory. This will be used for a large part of the project.
    Public ProductLine() As Inventory

    Public intLinesCount As Integer = 0
    Public intTotalProducts As Integer = 0
    Public chrComma As Char = CChar(", ")

    'Since the document consists of commas and spaces, this sub procedure will split everything according to these parameters.
    Public Sub subFillArrays(ByRef intCounter As Integer)
        Dim strInputRecordLine As String = String.Empty
        Dim strDelimiterArray() As String
        Dim intCountElements As Integer
        Dim intNumElement As Integer
        streamReaderInventory = File.OpenText(strFileName)

        Do While Not streamReaderInventory.EndOfStream
            strInputRecordLine = streamReaderInventory.ReadLine
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
        streamReaderInventory.Close()
    End Sub
End Module
