<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewUser
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
        Me.dgvUser = New System.Windows.Forms.DataGridView()
        Me.UserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Birthday = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvMark = New System.Windows.Forms.DataGridView()
        Me.User = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeTest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDSubject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cmbMode = New System.Windows.Forms.ComboBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToResizeColumns = False
        Me.dgvUser.AllowUserToResizeRows = False
        Me.dgvUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvUser.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserName, Me.Password, Me.FullName, Me.Sex, Me.Birthday})
        Me.dgvUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvUser.Location = New System.Drawing.Point(35, 122)
        Me.dgvUser.Name = "dgvUser"
        Me.dgvUser.Size = New System.Drawing.Size(521, 366)
        Me.dgvUser.TabIndex = 0
        '
        'UserName
        '
        Me.UserName.DataPropertyName = "UserName"
        Me.UserName.HeaderText = "Tài khoản"
        Me.UserName.Name = "UserName"
        '
        'Password
        '
        Me.Password.DataPropertyName = "Password"
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        '
        'FullName
        '
        Me.FullName.DataPropertyName = "Name"
        Me.FullName.HeaderText = "Họ tên"
        Me.FullName.Name = "FullName"
        '
        'Sex
        '
        Me.Sex.DataPropertyName = "Sex"
        Me.Sex.HeaderText = "Giới tính"
        Me.Sex.Name = "Sex"
        '
        'Birthday
        '
        Me.Birthday.DataPropertyName = "Birthday"
        Me.Birthday.HeaderText = "Ngày sinh"
        Me.Birthday.Name = "Birthday"
        '
        'dgvMark
        '
        Me.dgvMark.AllowUserToOrderColumns = True
        Me.dgvMark.AllowUserToResizeColumns = False
        Me.dgvMark.AllowUserToResizeRows = False
        Me.dgvMark.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMark.BackgroundColor = System.Drawing.Color.AliceBlue
        Me.dgvMark.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMark.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.User, Me.Subject, Me.Mark, Me.TimeTest, Me.IDSubject})
        Me.dgvMark.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvMark.Location = New System.Drawing.Point(608, 122)
        Me.dgvMark.Name = "dgvMark"
        Me.dgvMark.Size = New System.Drawing.Size(481, 366)
        Me.dgvMark.TabIndex = 1
        '
        'User
        '
        Me.User.DataPropertyName = "UserName"
        Me.User.HeaderText = "Tài khoản"
        Me.User.Name = "User"
        '
        'Subject
        '
        Me.Subject.DataPropertyName = "NameSubject"
        Me.Subject.HeaderText = "Môn học"
        Me.Subject.Name = "Subject"
        '
        'Mark
        '
        Me.Mark.DataPropertyName = "Mark"
        Me.Mark.HeaderText = "Điểm"
        Me.Mark.Name = "Mark"
        '
        'TimeTest
        '
        Me.TimeTest.DataPropertyName = "TimeTest"
        Me.TimeTest.HeaderText = "Ngày thi"
        Me.TimeTest.Name = "TimeTest"
        '
        'IDSubject
        '
        Me.IDSubject.DataPropertyName = "IDSubject"
        Me.IDSubject.HeaderText = "ID Môn học"
        Me.IDSubject.Name = "IDSubject"
        Me.IDSubject.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(380, 58)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(224, 29)
        Me.txtSearch.TabIndex = 2
        '
        'cmbMode
        '
        Me.cmbMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMode.FormattingEnabled = True
        Me.cmbMode.Items.AddRange(New Object() {"User", "Subject"})
        Me.cmbMode.Location = New System.Drawing.Point(236, 56)
        Me.cmbMode.Name = "cmbMode"
        Me.cmbMode.Size = New System.Drawing.Size(110, 32)
        Me.cmbMode.TabIndex = 4
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(663, 54)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(88, 31)
        Me.btnFilter.TabIndex = 5
        Me.btnFilter.Text = "Lọc"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(35, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(99, 37)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Trở về"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(301, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 28)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nhập để tìm kiếm"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(774, 54)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(89, 31)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Hủy Lọc"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'ViewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 523)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvMark)
        Me.Controls.Add(Me.dgvUser)
        Me.Name = "ViewUser"
        Me.Text = "ViewUser"
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMark, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvUser As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMark As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cmbMode As System.Windows.Forms.ComboBox
    Friend WithEvents btnFilter As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Birthday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents User As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeTest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnReset As System.Windows.Forms.Button
End Class
