<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RunROPReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockLevelReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.leadTimeBox = New System.Windows.Forms.ComboBox()
        Me.serviceLevelBox = New System.Windows.Forms.ComboBox()
        Me.leadTimeLabel = New System.Windows.Forms.Label()
        Me.serviceLevelLabel = New System.Windows.Forms.Label()
        Me.groupBox2 = New System.Windows.Forms.GroupBox()
        Me.inventoryLimitText = New System.Windows.Forms.TextBox()
        Me.inventoryLimitLabel = New System.Windows.Forms.Label()
        Me.ProductListDataSet = New Final.ProductListDataSet()
        Me.TblProductsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblProductsTableAdapter = New Final.ProductListDataSetTableAdapters.tblProductsTableAdapter()
        Me.TableAdapterManager = New Final.ProductListDataSetTableAdapters.TableAdapterManager()
        Me.TblProductsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblProductsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblProductsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.groupBox2.SuspendLayout()
        CType(Me.ProductListDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblProductsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblProductsBindingNavigator.SuspendLayout()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunROPReportToolStripMenuItem, Me.StockLevelReportToolStripMenuItem, Me.ExitApplicationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1652, 36)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RunROPReportToolStripMenuItem
        '
        Me.RunROPReportToolStripMenuItem.Name = "RunROPReportToolStripMenuItem"
        Me.RunROPReportToolStripMenuItem.Size = New System.Drawing.Size(157, 29)
        Me.RunROPReportToolStripMenuItem.Text = "&Run ROP Report"
        '
        'StockLevelReportToolStripMenuItem
        '
        Me.StockLevelReportToolStripMenuItem.Name = "StockLevelReportToolStripMenuItem"
        Me.StockLevelReportToolStripMenuItem.Size = New System.Drawing.Size(173, 29)
        Me.StockLevelReportToolStripMenuItem.Text = "&Stock Level Report"
        '
        'ExitApplicationToolStripMenuItem
        '
        Me.ExitApplicationToolStripMenuItem.Name = "ExitApplicationToolStripMenuItem"
        Me.ExitApplicationToolStripMenuItem.Size = New System.Drawing.Size(150, 29)
        Me.ExitApplicationToolStripMenuItem.Text = "E&xit Application"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.leadTimeBox)
        Me.GroupBox1.Controls.Add(Me.serviceLevelBox)
        Me.GroupBox1.Controls.Add(Me.leadTimeLabel)
        Me.GroupBox1.Controls.Add(Me.serviceLevelLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(465, 143)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Reorder Point (ROP) Report Information"
        '
        'leadTimeBox
        '
        Me.leadTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.leadTimeBox.FormattingEnabled = True
        Me.leadTimeBox.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7"})
        Me.leadTimeBox.Location = New System.Drawing.Point(170, 81)
        Me.leadTimeBox.Name = "leadTimeBox"
        Me.leadTimeBox.Size = New System.Drawing.Size(144, 28)
        Me.leadTimeBox.TabIndex = 3
        '
        'serviceLevelBox
        '
        Me.serviceLevelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.serviceLevelBox.FormattingEnabled = True
        Me.serviceLevelBox.Items.AddRange(New Object() {"50%", "60%", "70%", "80%", "90%", "95%", "99%"})
        Me.serviceLevelBox.Location = New System.Drawing.Point(170, 43)
        Me.serviceLevelBox.Name = "serviceLevelBox"
        Me.serviceLevelBox.Size = New System.Drawing.Size(144, 28)
        Me.serviceLevelBox.TabIndex = 2
        '
        'leadTimeLabel
        '
        Me.leadTimeLabel.Location = New System.Drawing.Point(18, 81)
        Me.leadTimeLabel.Name = "leadTimeLabel"
        Me.leadTimeLabel.Size = New System.Drawing.Size(137, 23)
        Me.leadTimeLabel.TabIndex = 1
        Me.leadTimeLabel.Text = "Lead Time (Days):"
        '
        'serviceLevelLabel
        '
        Me.serviceLevelLabel.Location = New System.Drawing.Point(47, 43)
        Me.serviceLevelLabel.Name = "serviceLevelLabel"
        Me.serviceLevelLabel.Size = New System.Drawing.Size(108, 23)
        Me.serviceLevelLabel.TabIndex = 0
        Me.serviceLevelLabel.Text = "Service Level:"
        '
        'groupBox2
        '
        Me.groupBox2.Controls.Add(Me.inventoryLimitText)
        Me.groupBox2.Controls.Add(Me.inventoryLimitLabel)
        Me.groupBox2.Location = New System.Drawing.Point(544, 65)
        Me.groupBox2.Name = "groupBox2"
        Me.groupBox2.Size = New System.Drawing.Size(366, 143)
        Me.groupBox2.TabIndex = 2
        Me.groupBox2.TabStop = False
        Me.groupBox2.Text = "Stock Level"
        '
        'inventoryLimitText
        '
        Me.inventoryLimitText.Location = New System.Drawing.Point(171, 43)
        Me.inventoryLimitText.Multiline = True
        Me.inventoryLimitText.Name = "inventoryLimitText"
        Me.inventoryLimitText.Size = New System.Drawing.Size(106, 26)
        Me.inventoryLimitText.TabIndex = 2
        '
        'inventoryLimitLabel
        '
        Me.inventoryLimitLabel.Location = New System.Drawing.Point(27, 43)
        Me.inventoryLimitLabel.Name = "inventoryLimitLabel"
        Me.inventoryLimitLabel.Size = New System.Drawing.Size(115, 23)
        Me.inventoryLimitLabel.TabIndex = 1
        Me.inventoryLimitLabel.Text = "Inventory Limit:"
        '
        'ProductListDataSet
        '
        Me.ProductListDataSet.DataSetName = "ProductListDataSet"
        Me.ProductListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblProductsBindingSource
        '
        Me.TblProductsBindingSource.DataMember = "tblProducts"
        Me.TblProductsBindingSource.DataSource = Me.ProductListDataSet
        '
        'TblProductsTableAdapter
        '
        Me.TblProductsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblProductsTableAdapter = Me.TblProductsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Final.ProductListDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblProductsBindingNavigator
        '
        Me.TblProductsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblProductsBindingNavigator.BindingSource = Me.TblProductsBindingSource
        Me.TblProductsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblProductsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblProductsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TblProductsBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.TblProductsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblProductsBindingNavigatorSaveItem})
        Me.TblProductsBindingNavigator.Location = New System.Drawing.Point(0, 496)
        Me.TblProductsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblProductsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblProductsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblProductsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblProductsBindingNavigator.Name = "TblProductsBindingNavigator"
        Me.TblProductsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblProductsBindingNavigator.Size = New System.Drawing.Size(1652, 38)
        Me.TblProductsBindingNavigator.TabIndex = 3
        Me.TblProductsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(34, 33)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 33)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(34, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 33)
        '
        'TblProductsBindingNavigatorSaveItem
        '
        Me.TblProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblProductsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblProductsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblProductsBindingNavigatorSaveItem.Name = "TblProductsBindingNavigatorSaveItem"
        Me.TblProductsBindingNavigatorSaveItem.Size = New System.Drawing.Size(34, 28)
        Me.TblProductsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblProductsDataGridView
        '
        Me.TblProductsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TblProductsDataGridView.AutoGenerateColumns = False
        Me.TblProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblProductsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.TblProductsDataGridView.DataSource = Me.TblProductsBindingSource
        Me.TblProductsDataGridView.Location = New System.Drawing.Point(48, 251)
        Me.TblProductsDataGridView.Name = "TblProductsDataGridView"
        Me.TblProductsDataGridView.RowHeadersWidth = 62
        Me.TblProductsDataGridView.RowTemplate.Height = 28
        Me.TblProductsDataGridView.Size = New System.Drawing.Size(1422, 220)
        Me.TblProductsDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ProductID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ProductID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProductName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "QuantityPerUnit"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Qty Per Unit"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 180
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "UnitPrice"
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Unit Price"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "UnitsInStock"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Units In Stock"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "UnitsOnOrder"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Units Ordered"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ReorderLevel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Reorder Level"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "AverageDemandLT"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Average Demand"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "StandardDevLT"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Std Dev Demand "
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1652, 534)
        Me.Controls.Add(Me.TblProductsDataGridView)
        Me.Controls.Add(Me.TblProductsBindingNavigator)
        Me.Controls.Add(Me.groupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Final - Inventory Reporting System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.groupBox2.ResumeLayout(False)
        Me.groupBox2.PerformLayout()
        CType(Me.ProductListDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblProductsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblProductsBindingNavigator.ResumeLayout(False)
        Me.TblProductsBindingNavigator.PerformLayout()
        CType(Me.TblProductsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RunROPReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StockLevelReportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitApplicationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents leadTimeBox As ComboBox
    Friend WithEvents serviceLevelBox As ComboBox
    Friend WithEvents leadTimeLabel As Label
    Friend WithEvents serviceLevelLabel As Label
    Friend WithEvents groupBox2 As GroupBox
    Friend WithEvents inventoryLimitLabel As Label
    Friend WithEvents ProductListDataSet As ProductListDataSet
    Friend WithEvents TblProductsBindingSource As BindingSource
    Friend WithEvents TblProductsTableAdapter As ProductListDataSetTableAdapters.tblProductsTableAdapter
    Friend WithEvents TableAdapterManager As ProductListDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblProductsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblProductsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblProductsDataGridView As DataGridView
    Friend WithEvents inventoryLimitText As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
End Class
