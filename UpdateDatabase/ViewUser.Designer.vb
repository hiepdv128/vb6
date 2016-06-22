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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.dgvUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMark, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvUser
        '
        Me.dgvUser.AllowUserToAddRows = False
        Me.dgvUser.AllowUserToResizeColumns = False
        Me.dgvUser.AllowUserToResizeRows = False
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
        Me.UserName.Width = 96
        '
        'Password
        '
        Me.Password.DataPropertyName = "Password"
        Me.Password.HeaderText = "Password"
        Me.Password.Name = "Password"
        Me.Password.Width = 95
        '
        'FullName
        '
        Me.FullName.DataPropertyName = "Name"
        Me.FullName.HeaderText = "Họ tên"
        Me.FullName.Name = "FullName"
        Me.FullName.Width = 96
        '
        'Sex
        '
        Me.Sex.DataPropertyName = "Sex"
        Me.Sex.HeaderText = "Giới tính"
        Me.Sex.Name = "Sex"
        Me.Sex.Width = 95
        '
        'Birthday
        '
        Me.Birthday.DataPropertyName = "Birthday"
        Me.Birthday.HeaderText = "Ngày sinh"
        Me.Birthday.Name = "Birthday"
        Me.Birthday.Width = 96
        '
        'dgvMark
        '
        Me.dgvMark.AllowUserToAddRows = False
        Me.dgvMark.AllowUserToOrderColumns = True
        Me.dgvMark.AllowUserToResizeColumns = False
        Me.dgvMark.AllowUserToResizeRows = False
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
        Me.User.FillWeight = 58.48539!
        Me.User.HeaderText = "Tài khoản"
        Me.User.Name = "User"
        Me.User.Width = 64
        '
        'Subject
        '
        Me.Subject.DataPropertyName = "NameSubject"
        Me.Subject.FillWeight = 223.3503!
        Me.Subject.HeaderText = "Môn học"
        Me.Subject.Name = "Subject"
        Me.Subject.Width = 245
        '
        'Mark
        '
        Me.Mark.DataPropertyName = "Mark"
        Me.Mark.FillWeight = 59.67897!
        Me.Mark.HeaderText = "Điểm"
        Me.Mark.Name = "Mark"
        Me.Mark.Width = 65
        '
        'TimeTest
        '
        Me.TimeTest.DataPropertyName = "TimeTest"
        Me.TimeTest.FillWeight = 58.48539!
        Me.TimeTest.HeaderText = "Ngày thi"
        Me.TimeTest.Name = "TimeTest"
        Me.TimeTest.Width = 64
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
        Me.btnFilter.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnFilter.Location = New System.Drawing.Point(663, 44)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(89, 44)
        Me.btnFilter.TabIndex = 5
        Me.btnFilter.Text = "Lọc"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("High Tower Text", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(301, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nhập để tìm kiếm"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnReset.Location = New System.Drawing.Point(774, 44)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(89, 44)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Hủy Lọc"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddUser.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.btnAddUser.Location = New System.Drawing.Point(882, 44)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(89, 44)
        Me.btnAddUser.TabIndex = 5
        Me.btnAddUser.Text = "Thêm Tài khoản"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(35, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 45)
        Me.btnBack.TabIndex = 8
        Me.btnBack.Text = "Trở về"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ViewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DemoProject.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1120, 523)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddUser)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.cmbMode)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.dgvMark)
        Me.Controls.Add(Me.dgvUser)
        Me.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Name = "ViewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Birthday As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents btnAddUser As System.Windows.Forms.Button
    Friend WithEvents User As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TimeTest As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDSubject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
