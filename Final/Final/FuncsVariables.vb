'MIS 322
'Damanbir Singh
'Final Project
'12/1/2022

Option Explicit On
Option Strict On
Option Infer On

Module FuncsVariables

    Public runROPReport, product As String
    Public runStockReport As String
    Public inventoryLimit, currentROP As Integer
    Public serviceLevel As Integer
    Public zValue As Double
    Public leadTime As Integer
    Public ROP, averageDemand, standardDev As Double
    Public reportType As String
    Public Sub Z_Value(ByVal servLevel As Integer)
        If serviceLevel = 50 Then
            zValue = 0.0
        ElseIf serviceLevel = 60 Then
            zValue = 0.2533
        ElseIf serviceLevel = 70 Then
            zValue = 0.5244
        ElseIf serviceLevel = 80 Then
            zValue = 0.8416
        ElseIf serviceLevel = 90 Then
            zValue = 1.2816
        ElseIf serviceLevel = 95 Then
            zValue = 1.6449
        ElseIf serviceLevel = 99 Then
            zValue = 2.3263
        End If
    End Sub

    Public Function ROP_Calculation(ByVal avgDemand As Double, ByVal standDev As Double) As Double
        ROP = averageDemand * leadTime + zValue * standardDev * Math.Sqrt(leadTime)
        Math.Round(ROP, 0)
    End Function
End Module
