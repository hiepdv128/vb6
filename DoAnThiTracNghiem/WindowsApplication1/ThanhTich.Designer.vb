<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Achievement
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
        Me.dgvAchieve = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.subject = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mark = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateTime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvAchieve, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAchieve
        '
        Me.dgvAchieve.BackgroundColor = System.Drawing.Color.White
        Me.dgvAchieve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAchieve.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.subject, Me.Mark, Me.dateTime})
        Me.dgvAchieve.GridColor = System.Drawing.SystemColors.Control
        Me.dgvAchieve.Location = New System.Drawing.Point(45, 119)
        Me.dgvAchieve.Name = "dgvAchieve"
        Me.dgvAchieve.Size = New System.Drawing.Size(406, 291)
        Me.dgvAchieve.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(449, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bảng thành tích cá nhân các lần thi"
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = Global.DoAnThiTracNghiem.My.Resources.Resources.ic_back_form
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnBack.Location = New System.Drawing.Point(558, 358)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(73, 52)
        Me.btnBack.TabIndex = 2
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'subject
        '
        Me.subject.DataPropertyName = "NameSubject"
        Me.subject.HeaderText = "Môn học"
        Me.subject.Name = "subject"
        Me.subject.Width = 150
        '
        'Mark
        '
        Me.Mark.DataPropertyName = "Mark"
        Me.Mark.HeaderText = "Điểm"
        Me.Mark.Name = "Mark"
        Me.Mark.Width = 60
        '
        'dateTime
        '
        Me.dateTime.DataPropertyName = "TimeTest"
        Me.dateTime.HeaderText = "Ngày thi"
        Me.dateTime.Name = "dateTime"
        Me.dateTime.Width = 150
        '
        'Achievement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DoAnThiTracNghiem.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(656, 422)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvAchieve)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.Name = "Achievement"
        Me.Text = "Thành tích cá nhân"
        CType(Me.dgvAchieve, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvAchieve As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents subject As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mark As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateTime As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
