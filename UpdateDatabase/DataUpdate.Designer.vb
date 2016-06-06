<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataUpdate
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
        Me.AnswerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvAnswer = New System.Windows.Forms.DataGridView()
        Me.IDQuestionAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContentAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvQuestion = New System.Windows.Forms.DataGridView()
        Me.IDSubjectQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContentQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgvSubject = New System.Windows.Forms.DataGridView()
        Me.IDSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.txtIDSubject = New System.Windows.Forms.TextBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtLinkFile = New System.Windows.Forms.TextBox()
        Me.txtNameSubject = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.AnswerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnswerBindingSource
        '
        Me.AnswerBindingSource.DataMember = "Answer"
        '
        'dgvAnswer
        '
        Me.dgvAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAnswer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDQuestionAnswer, Me.IDAnswer, Me.ContentAnswer, Me.Correct})
        Me.dgvAnswer.Location = New System.Drawing.Point(12, 313)
        Me.dgvAnswer.Name = "dgvAnswer"
        Me.dgvAnswer.RowHeadersVisible = False
        Me.dgvAnswer.Size = New System.Drawing.Size(1209, 329)
        Me.dgvAnswer.TabIndex = 1
        '
        'IDQuestionAnswer
        '
        Me.IDQuestionAnswer.HeaderText = "ID Question"
        Me.IDQuestionAnswer.Name = "IDQuestionAnswer"
        Me.IDQuestionAnswer.ReadOnly = True
        Me.IDQuestionAnswer.Width = 302
        '
        'IDAnswer
        '
        Me.IDAnswer.HeaderText = "ID Answer"
        Me.IDAnswer.Name = "IDAnswer"
        Me.IDAnswer.ReadOnly = True
        Me.IDAnswer.Width = 301
        '
        'ContentAnswer
        '
        Me.ContentAnswer.HeaderText = "Content Answer"
        Me.ContentAnswer.Name = "ContentAnswer"
        Me.ContentAnswer.Width = 302
        '
        'Correct
        '
        Me.Correct.HeaderText = "Correct"
        Me.Correct.Name = "Correct"
        Me.Correct.Width = 301
        '
        'QuestionBindingSource
        '
        Me.QuestionBindingSource.DataMember = "Question"
        '
        'dgvQuestion
        '
        Me.dgvQuestion.AllowUserToOrderColumns = True
        Me.dgvQuestion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuestion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSubjectQuestion, Me.IDQuestion, Me.ContentQuestion})
        Me.dgvQuestion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvQuestion.Location = New System.Drawing.Point(535, 94)
        Me.dgvQuestion.Name = "dgvQuestion"
        Me.dgvQuestion.RowHeadersVisible = False
        Me.dgvQuestion.RowHeadersWidth = 50
        Me.dgvQuestion.Size = New System.Drawing.Size(686, 200)
        Me.dgvQuestion.TabIndex = 2
        '
        'IDSubjectQuestion
        '
        Me.IDSubjectQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IDSubjectQuestion.HeaderText = "ID Subject"
        Me.IDSubjectQuestion.Name = "IDSubjectQuestion"
        Me.IDSubjectQuestion.ReadOnly = True
        Me.IDSubjectQuestion.Width = 228
        '
        'IDQuestion
        '
        Me.IDQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IDQuestion.HeaderText = "ID Question"
        Me.IDQuestion.Name = "IDQuestion"
        Me.IDQuestion.ReadOnly = True
        Me.IDQuestion.Width = 227
        '
        'ContentQuestion
        '
        Me.ContentQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ContentQuestion.HeaderText = "Content Question"
        Me.ContentQuestion.Name = "ContentQuestion"
        Me.ContentQuestion.Width = 228
        '
        'SubjectBindingSource
        '
        Me.SubjectBindingSource.DataMember = "Subject"
        '
        'dgvSubject
        '
        Me.dgvSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSubject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSubject.ColumnHeadersHeight = 21
        Me.dgvSubject.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSubject, Me.NameSubject})
        Me.dgvSubject.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvSubject.Location = New System.Drawing.Point(12, 94)
        Me.dgvSubject.Name = "dgvSubject"
        Me.dgvSubject.RowHeadersVisible = False
        Me.dgvSubject.RowHeadersWidth = 50
        Me.dgvSubject.Size = New System.Drawing.Size(460, 200)
        Me.dgvSubject.TabIndex = 3
        '
        'IDSubject
        '
        Me.IDSubject.HeaderText = "ID Subject"
        Me.IDSubject.Name = "IDSubject"
        Me.IDSubject.ReadOnly = True
        '
        'NameSubject
        '
        Me.NameSubject.HeaderText = "Name Subject"
        Me.NameSubject.Name = "NameSubject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Link File"
        '
        'btnExecute
        '
        Me.btnExecute.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExecute.Location = New System.Drawing.Point(670, 41)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(98, 26)
        Me.btnExecute.TabIndex = 6
        Me.btnExecute.Text = "GO!"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'txtIDSubject
        '
        Me.txtIDSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDSubject.Location = New System.Drawing.Point(170, 41)
        Me.txtIDSubject.Name = "txtIDSubject"
        Me.txtIDSubject.Size = New System.Drawing.Size(92, 26)
        Me.txtIDSubject.TabIndex = 7
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.Location = New System.Drawing.Point(670, 9)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(98, 26)
        Me.btnOpen.TabIndex = 8
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'openFileDialog
        '
        Me.openFileDialog.FileName = "OpenFileDialog"
        '
        'txtLinkFile
        '
        Me.txtLinkFile.Enabled = False
        Me.txtLinkFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinkFile.Location = New System.Drawing.Point(170, 9)
        Me.txtLinkFile.Name = "txtLinkFile"
        Me.txtLinkFile.Size = New System.Drawing.Size(459, 26)
        Me.txtLinkFile.TabIndex = 7
        '
        'txtNameSubject
        '
        Me.txtNameSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameSubject.Location = New System.Drawing.Point(388, 41)
        Me.txtNameSubject.Name = "txtNameSubject"
        Me.txtNameSubject.Size = New System.Drawing.Size(241, 26)
        Me.txtNameSubject.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(885, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(162, 56)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save to DB"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ID ‫Môn Học"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(273, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tên Môn Học"
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(1124, 14)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(97, 53)
        Me.btnView.TabIndex = 12
        Me.btnView.Text = "View Data"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(789, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(74, 52)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "Reset All"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(170, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "*Lưu ý: mỗi file đưa vào sẽ chứa nội dung 1 môn học"
        '
        'DataUpdate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1235, 642)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.txtLinkFile)
        Me.Controls.Add(Me.txtNameSubject)
        Me.Controls.Add(Me.txtIDSubject)
        Me.Controls.Add(Me.btnExecute)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvSubject)
        Me.Controls.Add(Me.dgvQuestion)
        Me.Controls.Add(Me.dgvAnswer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "DataUpdate"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.MediumBlue
        CType(Me.AnswerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSubject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AnswerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvAnswer As System.Windows.Forms.DataGridView
    Friend WithEvents QuestionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvQuestion As System.Windows.Forms.DataGridView
    Friend WithEvents SubjectBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgvSubject As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExecute As System.Windows.Forms.Button
    Friend WithEvents txtIDSubject As System.Windows.Forms.TextBox
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtLinkFile As System.Windows.Forms.TextBox
    Friend WithEvents txtNameSubject As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents IDQuestionAnswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAnswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContentAnswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSubjectQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContentQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
