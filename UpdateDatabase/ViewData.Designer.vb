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
        Me.DB_DataSet = New DemoProject.DB_DataSet()
        Me.AnswerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnswerTableAdapter = New DemoProject.DB_DataSetTableAdapters.AnswerTableAdapter()
        Me.TableAdapterManager = New DemoProject.DB_DataSetTableAdapters.TableAdapterManager()
        Me.QuestionTableAdapter = New DemoProject.DB_DataSetTableAdapters.QuestionTableAdapter()
        Me.SubjectTableAdapter = New DemoProject.DB_DataSetTableAdapters.SubjectTableAdapter()
        Me.dgvAnswerView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvQuestionView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvSubjectView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DB_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnswerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAnswerView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvQuestionView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSubjectView, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableAdapterManager.AllUserTableAdapter = Nothing
        Me.TableAdapterManager.AnswerTableAdapter = Me.AnswerTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.QuestionTableAdapter = Me.QuestionTableAdapter
        Me.TableAdapterManager.SubjectTableAdapter = Me.SubjectTableAdapter
        Me.TableAdapterManager.UpdateOrder = DemoProject.DB_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'QuestionTableAdapter
        '
        Me.QuestionTableAdapter.ClearBeforeFill = True
        '
        'SubjectTableAdapter
        '
        Me.SubjectTableAdapter.ClearBeforeFill = True
        '
        'dgvAnswerView
        '
        Me.dgvAnswerView.AutoGenerateColumns = False
        Me.dgvAnswerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnswerView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvAnswerView.DataSource = Me.AnswerBindingSource
        Me.dgvAnswerView.Location = New System.Drawing.Point(695, 59)
        Me.dgvAnswerView.Name = "dgvAnswerView"
        Me.dgvAnswerView.Size = New System.Drawing.Size(570, 480)
        Me.dgvAnswerView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IDSubject"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IDSubject"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IDQuestion"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IDQuestion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IDAnswer"
        Me.DataGridViewTextBoxColumn3.HeaderText = "IDAnswer"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ContentAnswer"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ContentAnswer"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Correct"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Correct"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'QuestionBindingSource
        '
        Me.QuestionBindingSource.DataMember = "Question"
        Me.QuestionBindingSource.DataSource = Me.DB_DataSet
        '
        'dgvQuestionView
        '
        Me.dgvQuestionView.AutoGenerateColumns = False
        Me.dgvQuestionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuestionView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.dgvQuestionView.DataSource = Me.QuestionBindingSource
        Me.dgvQuestionView.Location = New System.Drawing.Point(288, 59)
        Me.dgvQuestionView.Name = "dgvQuestionView"
        Me.dgvQuestionView.Size = New System.Drawing.Size(355, 480)
        Me.dgvQuestionView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "IDSubject"
        Me.DataGridViewTextBoxColumn6.HeaderText = "IDSubject"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "IDQuestion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "IDQuestion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "ContentQuestion"
        Me.DataGridViewTextBoxColumn8.HeaderText = "ContentQuestion"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'SubjectBindingSource
        '
        Me.SubjectBindingSource.DataMember = "Subject"
        Me.SubjectBindingSource.DataSource = Me.DB_DataSet
        '
        'dgvSubjectView
        '
        Me.dgvSubjectView.AutoGenerateColumns = False
        Me.dgvSubjectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjectView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.dgvSubjectView.DataSource = Me.SubjectBindingSource
        Me.dgvSubjectView.Location = New System.Drawing.Point(12, 59)
        Me.dgvSubjectView.Name = "dgvSubjectView"
        Me.dgvSubjectView.Size = New System.Drawing.Size(228, 480)
        Me.dgvSubjectView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "IDSubject"
        Me.DataGridViewTextBoxColumn9.HeaderText = "IDSubject"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "NameSubject"
        Me.DataGridViewTextBoxColumn10.HeaderText = "NameSubject"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'ViewData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 551)
        Me.Controls.Add(Me.dgvSubjectView)
        Me.Controls.Add(Me.dgvQuestionView)
        Me.Controls.Add(Me.dgvAnswerView)
        Me.Name = "ViewData"
        Me.Text = "ViewData"
        CType(Me.DB_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnswerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAnswerView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvQuestionView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSubjectView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DB_DataSet As DemoProject.DB_DataSet
    Friend WithEvents AnswerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AnswerTableAdapter As DemoProject.DB_DataSetTableAdapters.AnswerTableAdapter
    Friend WithEvents TableAdapterManager As DemoProject.DB_DataSetTableAdapters.TableAdapterManager
    Friend WithEvents dgvAnswerView As System.Windows.Forms.DataGridView
    Friend WithEvents QuestionTableAdapter As DemoProject.DB_DataSetTableAdapters.QuestionTableAdapter
    Friend WithEvents QuestionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectTableAdapter As DemoProject.DB_DataSetTableAdapters.SubjectTableAdapter
    Friend WithEvents dgvQuestionView As System.Windows.Forms.DataGridView
    Friend WithEvents SubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvSubjectView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
