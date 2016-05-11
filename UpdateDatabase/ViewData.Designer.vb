<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewData))
        Me.DB_DataSet = New DemoProject.DB_DataSet()
        Me.AnswerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnswerTableAdapter = New DemoProject.DB_DataSetTableAdapters.AnswerTableAdapter()
        Me.TableAdapterManager = New DemoProject.DB_DataSetTableAdapters.TableAdapterManager()
        Me.AnswerBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.AnswerBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AnswerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuestionTableAdapter = New DemoProject.DB_DataSetTableAdapters.QuestionTableAdapter()
        Me.QuestionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectTableAdapter = New DemoProject.DB_DataSetTableAdapters.SubjectTableAdapter()
        Me.SubjectDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DB_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnswerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnswerBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnswerBindingNavigator.SuspendLayout()
        CType(Me.AnswerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DB_DataSet
        '
        Me.DB_DataSet.DataSetName = "DB_DataSet"
        Me.DB_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnswerBindingSource
        '
        Me.AnswerBindingSource.DataMember = "Answer"
        Me.AnswerBindingSource.DataSource = Me.DB_DataSet
        '
        'AnswerTableAdapter
        '
        Me.AnswerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AnswerTableAdapter = Me.AnswerTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.QuestionTableAdapter = Me.QuestionTableAdapter
        Me.TableAdapterManager.SubjectTableAdapter = Me.SubjectTableAdapter
        Me.TableAdapterManager.UpdateOrder = DemoProject.DB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AnswerBindingNavigator
        '
        Me.AnswerBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AnswerBindingNavigator.BindingSource = Me.AnswerBindingSource
        Me.AnswerBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AnswerBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AnswerBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AnswerBindingNavigatorSaveItem})
        Me.AnswerBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.AnswerBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AnswerBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AnswerBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AnswerBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AnswerBindingNavigator.Name = "AnswerBindingNavigator"
        Me.AnswerBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AnswerBindingNavigator.Size = New System.Drawing.Size(1303, 25)
        Me.AnswerBindingNavigator.TabIndex = 0
        Me.AnswerBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'AnswerBindingNavigatorSaveItem
        '
        Me.AnswerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnswerBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnswerBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnswerBindingNavigatorSaveItem.Name = "AnswerBindingNavigatorSaveItem"
        Me.AnswerBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.AnswerBindingNavigatorSaveItem.Text = "Save Data"
        '
        'AnswerDataGridView
        '
        Me.AnswerDataGridView.AutoGenerateColumns = False
        Me.AnswerDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AnswerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnswerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.AnswerDataGridView.DataSource = Me.AnswerBindingSource
        Me.AnswerDataGridView.Location = New System.Drawing.Point(710, 38)
        Me.AnswerDataGridView.Name = "AnswerDataGridView"
        Me.AnswerDataGridView.RowHeadersVisible = False
        Me.AnswerDataGridView.Size = New System.Drawing.Size(593, 490)
        Me.AnswerDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDQuestion"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDQuestion"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDAnswer"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDAnswer"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ContentAnswer"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ContentAnswer"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Correct"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Correct"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'QuestionBindingSource
        '
        Me.QuestionBindingSource.DataMember = "Question"
        Me.QuestionBindingSource.DataSource = Me.DB_DataSet
        '
        'QuestionTableAdapter
        '
        Me.QuestionTableAdapter.ClearBeforeFill = True
        '
        'QuestionDataGridView
        '
        Me.QuestionDataGridView.AutoGenerateColumns = False
        Me.QuestionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.QuestionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.QuestionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.QuestionDataGridView.DataSource = Me.QuestionBindingSource
        Me.QuestionDataGridView.Location = New System.Drawing.Point(289, 38)
        Me.QuestionDataGridView.Name = "QuestionDataGridView"
        Me.QuestionDataGridView.RowHeadersVisible = False
        Me.QuestionDataGridView.Size = New System.Drawing.Size(415, 490)
        Me.QuestionDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IDSubject"
        Me.DataGridViewTextBoxColumn5.HeaderText = "IDSubject"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IDQuestion"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IDQuestion"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "ContentQuestion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ContentQuestion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'SubjectBindingSource
        '
        Me.SubjectBindingSource.DataMember = "Subject"
        Me.SubjectBindingSource.DataSource = Me.DB_DataSet
        '
        'SubjectTableAdapter
        '
        Me.SubjectTableAdapter.ClearBeforeFill = True
        '
        'SubjectDataGridView
        '
        Me.SubjectDataGridView.AutoGenerateColumns = False
        Me.SubjectDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SubjectDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.SubjectDataGridView.DataSource = Me.SubjectBindingSource
        Me.SubjectDataGridView.Location = New System.Drawing.Point(0, 38)
        Me.SubjectDataGridView.Name = "SubjectDataGridView"
        Me.SubjectDataGridView.RowHeadersVisible = False
        Me.SubjectDataGridView.Size = New System.Drawing.Size(283, 490)
        Me.SubjectDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "IDSubject"
        Me.DataGridViewTextBoxColumn8.HeaderText = "IDSubject"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "NameSubject"
        Me.DataGridViewTextBoxColumn9.HeaderText = "NameSubject"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'ViewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1303, 562)
        Me.Controls.Add(Me.SubjectDataGridView)
        Me.Controls.Add(Me.QuestionDataGridView)
        Me.Controls.Add(Me.AnswerDataGridView)
        Me.Controls.Add(Me.AnswerBindingNavigator)
        Me.Name = "ViewData"
        Me.Text = "ViewData"
        CType(Me.DB_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnswerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnswerBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnswerBindingNavigator.ResumeLayout(False)
        Me.AnswerBindingNavigator.PerformLayout()
        CType(Me.AnswerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DB_DataSet As DemoProject.DB_DataSet
    Friend WithEvents AnswerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnswerTableAdapter As DemoProject.DB_DataSetTableAdapters.AnswerTableAdapter
    Friend WithEvents TableAdapterManager As DemoProject.DB_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AnswerBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AnswerBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents QuestionTableAdapter As DemoProject.DB_DataSetTableAdapters.QuestionTableAdapter
    Friend WithEvents AnswerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuestionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectTableAdapter As DemoProject.DB_DataSetTableAdapters.SubjectTableAdapter
    Friend WithEvents QuestionDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
