﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewQuestion
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
        Me.dgvSubjectView = New System.Windows.Forms.DataGridView()
        Me.idSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nameSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvQuestionView = New System.Windows.Forms.DataGridView()
        Me.idSubjectQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contentQuestion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvAnswerView = New System.Windows.Forms.DataGridView()
        Me.IDSubjectAswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idQuestionAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contentAnswer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.correct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.cmbSubjectFilter = New System.Windows.Forms.ComboBox()
        Me.cmbQuestionFilter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSubjectFilter = New System.Windows.Forms.TextBox()
        Me.txtQuestionFilter = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvSubjectView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvQuestionView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAnswerView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSubjectView
        '
        Me.dgvSubjectView.AllowUserToAddRows = False
        Me.dgvSubjectView.AllowUserToResizeColumns = False
        Me.dgvSubjectView.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvSubjectView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSubjectView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSubject, Me.nameSubject})
        Me.dgvSubjectView.Location = New System.Drawing.Point(12, 168)
        Me.dgvSubjectView.Name = "dgvSubjectView"
        Me.dgvSubjectView.Size = New System.Drawing.Size(253, 439)
        Me.dgvSubjectView.TabIndex = 0
        '
        'idSubject
        '
        Me.idSubject.DataPropertyName = "IDSubject"
        Me.idSubject.HeaderText = "ID Môn học"
        Me.idSubject.Name = "idSubject"
        Me.idSubject.ReadOnly = True
        Me.idSubject.Width = 60
        '
        'nameSubject
        '
        Me.nameSubject.DataPropertyName = "NameSubject"
        Me.nameSubject.HeaderText = "Tên Môn Học"
        Me.nameSubject.Name = "nameSubject"
        Me.nameSubject.Width = 150
        '
        'dgvQuestionView
        '
        Me.dgvQuestionView.AllowUserToAddRows = False
        Me.dgvQuestionView.AllowUserToResizeColumns = False
        Me.dgvQuestionView.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvQuestionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuestionView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idSubjectQuestion, Me.idQuestion, Me.contentQuestion})
        Me.dgvQuestionView.Location = New System.Drawing.Point(295, 168)
        Me.dgvQuestionView.Name = "dgvQuestionView"
        Me.dgvQuestionView.Size = New System.Drawing.Size(412, 439)
        Me.dgvQuestionView.TabIndex = 0
        '
        'idSubjectQuestion
        '
        Me.idSubjectQuestion.DataPropertyName = "IDSubject"
        Me.idSubjectQuestion.HeaderText = "ID Môn học"
        Me.idSubjectQuestion.Name = "idSubjectQuestion"
        Me.idSubjectQuestion.ReadOnly = True
        Me.idSubjectQuestion.Width = 60
        '
        'idQuestion
        '
        Me.idQuestion.DataPropertyName = "IDQuestion"
        Me.idQuestion.HeaderText = "ID Câu hỏi"
        Me.idQuestion.Name = "idQuestion"
        Me.idQuestion.ReadOnly = True
        Me.idQuestion.Width = 60
        '
        'contentQuestion
        '
        Me.contentQuestion.DataPropertyName = "ContentQuestion"
        Me.contentQuestion.HeaderText = "Nội dung câu hỏi"
        Me.contentQuestion.Name = "contentQuestion"
        Me.contentQuestion.Width = 250
        '
        'dgvAnswerView
        '
        Me.dgvAnswerView.AllowUserToAddRows = False
        Me.dgvAnswerView.AllowUserToResizeColumns = False
        Me.dgvAnswerView.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvAnswerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAnswerView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDSubjectAswer, Me.idQuestionAnswer, Me.idAnswer, Me.contentAnswer, Me.correct})
        Me.dgvAnswerView.Location = New System.Drawing.Point(729, 168)
        Me.dgvAnswerView.Name = "dgvAnswerView"
        Me.dgvAnswerView.Size = New System.Drawing.Size(551, 439)
        Me.dgvAnswerView.TabIndex = 0
        '
        'IDSubjectAswer
        '
        Me.IDSubjectAswer.DataPropertyName = "IDSubject"
        Me.IDSubjectAswer.HeaderText = "Column1"
        Me.IDSubjectAswer.Name = "IDSubjectAswer"
        Me.IDSubjectAswer.Visible = False
        '
        'idQuestionAnswer
        '
        Me.idQuestionAnswer.DataPropertyName = "IDQuestion"
        Me.idQuestionAnswer.HeaderText = "ID Câu Hỏi"
        Me.idQuestionAnswer.Name = "idQuestionAnswer"
        Me.idQuestionAnswer.ReadOnly = True
        Me.idQuestionAnswer.Width = 60
        '
        'idAnswer
        '
        Me.idAnswer.DataPropertyName = "IDAnswer"
        Me.idAnswer.HeaderText = "ID Câu TL"
        Me.idAnswer.Name = "idAnswer"
        Me.idAnswer.ReadOnly = True
        Me.idAnswer.Width = 60
        '
        'contentAnswer
        '
        Me.contentAnswer.DataPropertyName = "ContentAnswer"
        Me.contentAnswer.HeaderText = "ND câu trả lời"
        Me.contentAnswer.Name = "contentAnswer"
        Me.contentAnswer.Width = 330
        '
        'correct
        '
        Me.correct.DataPropertyName = "Correct"
        Me.correct.HeaderText = "True/False"
        Me.correct.Name = "correct"
        Me.correct.Width = 50
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnReset.Location = New System.Drawing.Point(950, 75)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 42)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'cmbSubjectFilter
        '
        Me.cmbSubjectFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSubjectFilter.FormattingEnabled = True
        Me.cmbSubjectFilter.Items.AddRange(New Object() {"ID", "NAME"})
        Me.cmbSubjectFilter.Location = New System.Drawing.Point(259, 61)
        Me.cmbSubjectFilter.Name = "cmbSubjectFilter"
        Me.cmbSubjectFilter.Size = New System.Drawing.Size(102, 24)
        Me.cmbSubjectFilter.TabIndex = 2
        '
        'cmbQuestionFilter
        '
        Me.cmbQuestionFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbQuestionFilter.FormattingEnabled = True
        Me.cmbQuestionFilter.Items.AddRange(New Object() {"ID", "CONTENT"})
        Me.cmbQuestionFilter.Location = New System.Drawing.Point(259, 102)
        Me.cmbQuestionFilter.Name = "cmbQuestionFilter"
        Me.cmbQuestionFilter.Size = New System.Drawing.Size(102, 24)
        Me.cmbQuestionFilter.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(169, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Môn học"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(169, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Câu hỏi"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Kristen ITC", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label3.Location = New System.Drawing.Point(375, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(332, 40)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nhập vào để tìm kiếm"
        '
        'txtSubjectFilter
        '
        Me.txtSubjectFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSubjectFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSubjectFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubjectFilter.Location = New System.Drawing.Point(383, 62)
        Me.txtSubjectFilter.Name = "txtSubjectFilter"
        Me.txtSubjectFilter.Size = New System.Drawing.Size(424, 22)
        Me.txtSubjectFilter.TabIndex = 7
        '
        'txtQuestionFilter
        '
        Me.txtQuestionFilter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtQuestionFilter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtQuestionFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuestionFilter.Location = New System.Drawing.Point(383, 104)
        Me.txtQuestionFilter.Name = "txtQuestionFilter"
        Me.txtQuestionFilter.Size = New System.Drawing.Size(424, 22)
        Me.txtQuestionFilter.TabIndex = 7
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnFilter.Location = New System.Drawing.Point(840, 75)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(75, 42)
        Me.btnFilter.TabIndex = 1
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnBack.Location = New System.Drawing.Point(31, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 45)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Trở về"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ViewQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DemoProject.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1292, 637)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtQuestionFilter)
        Me.Controls.Add(Me.txtSubjectFilter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbQuestionFilter)
        Me.Controls.Add(Me.cmbSubjectFilter)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.dgvAnswerView)
        Me.Controls.Add(Me.dgvQuestionView)
        Me.Controls.Add(Me.dgvSubjectView)
        Me.Name = "ViewQuestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewData"
        CType(Me.dgvSubjectView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvQuestionView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAnswerView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvSubjectView As System.Windows.Forms.DataGridView
    Friend WithEvents dgvQuestionView As System.Windows.Forms.DataGridView
    Friend WithEvents dgvAnswerView As System.Windows.Forms.DataGridView
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents cmbSubjectFilter As System.Windows.Forms.ComboBox
    Friend WithEvents cmbQuestionFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSubjectFilter As System.Windows.Forms.TextBox
    Friend WithEvents txtQuestionFilter As System.Windows.Forms.TextBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents idSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nameSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idSubjectQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contentQuestion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSubjectAswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idQuestionAnswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idAnswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents contentAnswer As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents correct As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
