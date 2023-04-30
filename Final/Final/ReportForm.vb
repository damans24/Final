
'MIS 322
'Damanbir Singh
'Final Project
'12/1/2022

Option Explicit On
Option Strict On
Option Infer On

Public Class ReportForm

    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        BackColor = Color.Tomato

    End Sub

    Private Sub ReportForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim zones As String = "{0,-30}   {1,6}   {2,10}"

        If reportType = runROPReport Then
            reportFormText.Text = String.Format(zones, "Product", "Current ROP", "Calculated ROP") & vbNewLine
            reportFormText.Text += String.Format(zones, "------------------------------", "------", "----------") & vbNewLine
            reportFormText.Text += String.Format(zones, product, currentROP, ROP)
        End If
    End Sub


End Class