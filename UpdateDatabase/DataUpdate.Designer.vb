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
        Me.dgvAnswer = New System.Windows.Forms.DataGridView()
        Me.IDQuestionAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContentAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvQuestion = New System.Windows.Forms.DataGridView()
        Me.IDSubjectQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContentQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AnswerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SubjectBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvAnswer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSubject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnswerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAnswer
        '
        Me.dgvAnswer.AllowUserToAddRows = False
        Me.dgvAnswer.AllowUserToDeleteRows = False
        Me.dgvAnswer.AllowUserToResizeColumns = False
        Me.dgvAnswer.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvAnswer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDQuestionAnswer, Me.IDAnswer, Me.ContentAnswer, Me.Correct})
        Me.dgvAnswer.Location = New System.Drawing.Point(81, 310)
        Me.dgvAnswer.Name = "dgvAnswer"
        Me.dgvAnswer.RowHeadersVisible = False
        Me.dgvAnswer.Size = New System.Drawing.Size(1076, 329)
        Me.dgvAnswer.TabIndex = 1
        '
        'IDQuestionAnswer
        '
        Me.IDQuestionAnswer.HeaderText = "ID Câu hỏi"
        Me.IDQuestionAnswer.Name = "IDQuestionAnswer"
        Me.IDQuestionAnswer.ReadOnly = True
        Me.IDQuestionAnswer.Width = 130
        '
        'IDAnswer
        '
        Me.IDAnswer.HeaderText = "ID Đáp án"
        Me.IDAnswer.Name = "IDAnswer"
        Me.IDAnswer.ReadOnly = True
        Me.IDAnswer.Width = 130
        '
        'ContentAnswer
        '
        Me.ContentAnswer.FillWeight = 500.0!
        Me.ContentAnswer.HeaderText = "Nội dung đáp án"
        Me.ContentAnswer.Name = "ContentAnswer"
        Me.ContentAnswer.Width = 700
        '
        'Correct
        '
        Me.Correct.HeaderText = "True/false"
        Me.Correct.Name = "Correct"
        Me.Correct.Width = 130
        '
        'dgvQuestion
        '
        Me.dgvQuestion.AllowUserToAddRows = False
        Me.dgvQuestion.AllowUserToDeleteRows = False
        Me.dgvQuestion.AllowUserToOrderColumns = True
        Me.dgvQuestion.AllowUserToResizeColumns = False
        Me.dgvQuestion.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuestion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSubjectQuestion, Me.IDQuestion, Me.ContentQuestion})
        Me.dgvQuestion.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvQuestion.Location = New System.Drawing.Point(532, 94)
        Me.dgvQuestion.Name = "dgvQuestion"
        Me.dgvQuestion.RowHeadersVisible = False
        Me.dgvQuestion.RowHeadersWidth = 50
        Me.dgvQuestion.Size = New System.Drawing.Size(689, 200)
        Me.dgvQuestion.TabIndex = 2
        '
        'IDSubjectQuestion
        '
        Me.IDSubjectQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IDSubjectQuestion.HeaderText = "ID Môn học"
        Me.IDSubjectQuestion.Name = "IDSubjectQuestion"
        Me.IDSubjectQuestion.ReadOnly = True
        '
        'IDQuestion
        '
        Me.IDQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.IDQuestion.HeaderText = "ID Câu hỏi"
        Me.IDQuestion.Name = "IDQuestion"
        Me.IDQuestion.ReadOnly = True
        '
        'ContentQuestion
        '
        Me.ContentQuestion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ContentQuestion.HeaderText = "Nội dung câu hỏi"
        Me.ContentQuestion.Name = "ContentQuestion"
        Me.ContentQuestion.Width = 600
        '
        'dgvSubject
        '
        Me.dgvSubject.AllowUserToAddRows = False
        Me.dgvSubject.AllowUserToDeleteRows = False
        Me.dgvSubject.AllowUserToResizeColumns = False
        Me.dgvSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSubject.BackgroundColor = System.Drawing.Color.AliceBlue
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
        Me.IDSubject.FillWeight = 5.076141!
        Me.IDSubject.HeaderText = "ID Môn học"
        Me.IDSubject.Name = "IDSubject"
        Me.IDSubject.ReadOnly = True
        '
        'NameSubject
        '
        Me.NameSubject.FillWeight = 194.9239!
        Me.NameSubject.HeaderText = "Tên Môn học"
        Me.NameSubject.Name = "NameSubject"
        Me.NameSubject.Width = 400
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(188, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Link File"
        '
        'btnExecute
        '
        Me.btnExecute.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExecute.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnExecute.Location = New System.Drawing.Point(799, 41)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(98, 26)
        Me.btnExecute.TabIndex = 4
        Me.btnExecute.Text = "GO!"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'txtIDSubject
        '
        Me.txtIDSubject.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtIDSubject.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtIDSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIDSubject.Location = New System.Drawing.Point(299, 41)
        Me.txtIDSubject.Name = "txtIDSubject"
        Me.txtIDSubject.Size = New System.Drawing.Size(92, 26)
        Me.txtIDSubject.TabIndex = 2
        '
        'btnOpen
        '
        Me.btnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpen.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnOpen.Location = New System.Drawing.Point(799, 9)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(98, 26)
        Me.btnOpen.TabIndex = 1
        Me.btnOpen.Text = "Open"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'openFileDialog
        '
        Me.openFileDialog.Filter = "Excel Worksheets|*.xls;*.xlsx"
        '
        'txtLinkFile
        '
        Me.txtLinkFile.Enabled = False
        Me.txtLinkFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLinkFile.Location = New System.Drawing.Point(299, 9)
        Me.txtLinkFile.Name = "txtLinkFile"
        Me.txtLinkFile.Size = New System.Drawing.Size(459, 26)
        Me.txtLinkFile.TabIndex = 7
        '
        'txtNameSubject
        '
        Me.txtNameSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNameSubject.Location = New System.Drawing.Point(517, 41)
        Me.txtNameSubject.Name = "txtNameSubject"
        Me.txtNameSubject.Size = New System.Drawing.Size(241, 26)
        Me.txtNameSubject.TabIndex = 3
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnSave.Location = New System.Drawing.Point(1014, 11)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(162, 56)
        Me.btnSave.TabIndex = 5
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
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(188, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ID ‫Môn Học"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label3.Location = New System.Drawing.Point(402, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Tên Môn Học"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnReset.Location = New System.Drawing.Point(918, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(74, 52)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Reset All"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Chocolate
        Me.Label4.Location = New System.Drawing.Point(299, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "*Lưu ý: mỗi file đưa vào sẽ chứa nội dung 1 môn học"
        '
        'AnswerBindingSource
        '
        Me.AnswerBindingSource.DataMember = "Answer"
        '
        'QuestionBindingSource
        '
        Me.QuestionBindingSource.DataMember = "Question"
        '
        'SubjectBindingSource
        '
        Me.SubjectBindingSource.DataMember = "Subject"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBack.Location = New System.Drawing.Point(24, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 45)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Trở về"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'DataUpdate
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackgroundImage = Global.DemoProject.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1235, 642)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnReset)
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thêm câu hỏi"
        Me.TransparencyKey = System.Drawing.Color.MediumBlue
        CType(Me.dgvAnswer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvQuestion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSubject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnswerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FileSystemWatcher1 As System.IO.FileSystemWatcher
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents IDQuestionAnswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDAnswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContentAnswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSubjectQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContentQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameSubject As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
