Option Explicit On
Option Strict Off
Option Infer On
'MIS 322
'Damanbir Singh
'Final Project
'12/1/2022

Imports System.Security.Policy

Public Class Form1
    Private Sub TblProductsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblProductsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblProductsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ProductListDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ProductListDataSet.tblProducts' table. You can move, or remove it, as needed.
        Me.TblProductsTableAdapter.Fill(Me.ProductListDataSet.tblProducts)

        BackColor = Color.Tomato

    End Sub

    Private Sub RunROPReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RunROPReportToolStripMenuItem.Click


        Dim product As String
        Dim currentROP, avegDem, stanDevi As Integer

        reportType = runROPReport

        ReportForm.ShowDialog()

        For Each myRow In ProductListDataSet.tblProducts.Rows
            product = myRow.item("ProductName")
            FuncsVariables.product = product
            currentROP = myRow.item("ReorderLevel")
            FuncsVariables.currentROP = currentROP
            avegDem = myRow.item("AverageDemandLT")
            stanDevi = myRow.item("StandardDevLT")
            averageDemand = avegDem
            standardDev = stanDevi
            Call ROP_Calculation(avegDem, stanDevi)

        Next

    End Sub

    Private Sub StockLevelReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockLevelReportToolStripMenuItem.Click

        Try
            If inventoryLimitText.Text >= 0 Then
                inventoryLimit = inventoryLimitText.Text
                ReportForm.ShowDialog()
            ElseIf inventoryLimitText.Text < 0 Then
                MessageBox.Show("Inventory limit must be a positive integer")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show("Inventory limit must be a positive integer")
            Exit Sub
        End Try
    End Sub

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub serviceLevelBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles serviceLevelBox.SelectedIndexChanged
        Dim servLevel As Integer

        If serviceLevelBox.SelectedIndex = 0 Then
            serviceLevel = 50
        ElseIf serviceLevelBox.SelectedIndex = 1 Then
            serviceLevel = 60
        ElseIf serviceLevelBox.SelectedIndex = 2 Then
            serviceLevel = 70
        ElseIf serviceLevelBox.SelectedIndex = 3 Then
            serviceLevel = 80
        ElseIf serviceLevelBox.SelectedIndex = 4 Then
            serviceLevel = 90
        ElseIf serviceLevelBox.SelectedIndex = 5 Then
            serviceLevel = 95
        ElseIf serviceLevelBox.SelectedIndex = 6 Then
            serviceLevel = 99
        End If
        Call Z_Value(servLevel)

    End Sub

    Private Sub leadTimeBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles leadTimeBox.SelectedIndexChanged
        If leadTimeBox.SelectedIndex = 0 Then
            leadTime = 1
        ElseIf leadTimeBox.SelectedIndex = 1 Then
            leadTime = 2
        ElseIf leadTimeBox.SelectedIndex = 2 Then
            leadTime = 3
        ElseIf leadTimeBox.SelectedIndex = 3 Then
            leadTime = 4
        ElseIf leadTimeBox.SelectedIndex = 4 Then
            leadTime = 5
        ElseIf leadTimeBox.SelectedIndex = 5 Then
            leadTime = 6
        End If
    End Sub
End Class
