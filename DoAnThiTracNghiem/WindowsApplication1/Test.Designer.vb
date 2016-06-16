<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
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
        Me.cbAutoNext = New System.Windows.Forms.CheckBox()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.flpButtonQues = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbtAnswerB = New System.Windows.Forms.RadioButton()
        Me.rbtAnswerC = New System.Windows.Forms.RadioButton()
        Me.rbtAnswerD = New System.Windows.Forms.RadioButton()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.grbQuestion = New System.Windows.Forms.GroupBox()
        Me.rbtAnswerA = New System.Windows.Forms.RadioButton()
        Me.btnEndTest = New System.Windows.Forms.Button()
        Me.lblTimeOut = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblLastChecked = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblChecked = New System.Windows.Forms.Label()
        Me.lblNotCheck = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSubjectName = New System.Windows.Forms.Label()
        Me.grbQuestion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbAutoNext
        '
        Me.cbAutoNext.AutoSize = True
        Me.cbAutoNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAutoNext.Location = New System.Drawing.Point(767, 559)
        Me.cbAutoNext.Name = "cbAutoNext"
        Me.cbAutoNext.Size = New System.Drawing.Size(91, 22)
        Me.cbAutoNext.TabIndex = 9
        Me.cbAutoNext.Text = "Auto Next"
        Me.cbAutoNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(444, 557)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(82, 24)
        Me.btnPrevious.TabIndex = 11
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(617, 557)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 24)
        Me.btnNext.TabIndex = 12
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'flpButtonQues
        '
        Me.flpButtonQues.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpButtonQues.Location = New System.Drawing.Point(22, 70)
        Me.flpButtonQues.Name = "flpButtonQues"
        Me.flpButtonQues.Size = New System.Drawing.Size(228, 537)
        Me.flpButtonQues.TabIndex = 14
        '
        'rbtAnswerB
        '
        Me.rbtAnswerB.AutoSize = True
        Me.rbtAnswerB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerB.Location = New System.Drawing.Point(52, 198)
        Me.rbtAnswerB.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerB.Name = "rbtAnswerB"
        Me.rbtAnswerB.Size = New System.Drawing.Size(44, 24)
        Me.rbtAnswerB.TabIndex = 12
        Me.rbtAnswerB.TabStop = True
        Me.rbtAnswerB.Text = "txt"
        Me.rbtAnswerB.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerB.UseVisualStyleBackColor = True
        '
        'rbtAnswerC
        '
        Me.rbtAnswerC.AutoSize = True
        Me.rbtAnswerC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerC.Location = New System.Drawing.Point(52, 270)
        Me.rbtAnswerC.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerC.Name = "rbtAnswerC"
        Me.rbtAnswerC.Size = New System.Drawing.Size(44, 24)
        Me.rbtAnswerC.TabIndex = 14
        Me.rbtAnswerC.TabStop = True
        Me.rbtAnswerC.Text = "txt"
        Me.rbtAnswerC.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerC.UseVisualStyleBackColor = True
        '
        'rbtAnswerD
        '
        Me.rbtAnswerD.AutoSize = True
        Me.rbtAnswerD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerD.Location = New System.Drawing.Point(52, 347)
        Me.rbtAnswerD.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerD.Name = "rbtAnswerD"
        Me.rbtAnswerD.Size = New System.Drawing.Size(44, 24)
        Me.rbtAnswerD.TabIndex = 16
        Me.rbtAnswerD.TabStop = True
        Me.rbtAnswerD.Text = "txt"
        Me.rbtAnswerD.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerD.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(6, 35)
        Me.lblQuestion.MaximumSize = New System.Drawing.Size(600, 60)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(100, 24)
        Me.lblQuestion.TabIndex = 18
        Me.lblQuestion.Text = "question"
        '
        'grbQuestion
        '
        Me.grbQuestion.Controls.Add(Me.lblQuestion)
        Me.grbQuestion.Controls.Add(Me.rbtAnswerD)
        Me.grbQuestion.Controls.Add(Me.rbtAnswerC)
        Me.grbQuestion.Controls.Add(Me.rbtAnswerA)
        Me.grbQuestion.Controls.Add(Me.rbtAnswerB)
        Me.grbQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbQuestion.Location = New System.Drawing.Point(265, 94)
        Me.grbQuestion.Name = "grbQuestion"
        Me.grbQuestion.Size = New System.Drawing.Size(614, 424)
        Me.grbQuestion.TabIndex = 15
        Me.grbQuestion.TabStop = False
        Me.grbQuestion.Text = "Câu 1"
        '
        'rbtAnswerA
        '
        Me.rbtAnswerA.AutoSize = True
        Me.rbtAnswerA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerA.Location = New System.Drawing.Point(52, 127)
        Me.rbtAnswerA.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerA.Name = "rbtAnswerA"
        Me.rbtAnswerA.Size = New System.Drawing.Size(44, 24)
        Me.rbtAnswerA.TabIndex = 12
        Me.rbtAnswerA.TabStop = True
        Me.rbtAnswerA.Text = "txt"
        Me.rbtAnswerA.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerA.UseVisualStyleBackColor = True
        '
        'btnEndTest
        '
        Me.btnEndTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndTest.Location = New System.Drawing.Point(1088, 547)
        Me.btnEndTest.Name = "btnEndTest"
        Me.btnEndTest.Size = New System.Drawing.Size(110, 43)
        Me.btnEndTest.TabIndex = 0
        Me.btnEndTest.Text = "Nộp bài"
        Me.btnEndTest.UseVisualStyleBackColor = True
        '
        'lblTimeOut
        '
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.Location = New System.Drawing.Point(6, 16)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(89, 31)
        Me.lblTimeOut.TabIndex = 0
        Me.lblTimeOut.Text = "00 : 00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTimeOut)
        Me.GroupBox1.Location = New System.Drawing.Point(1028, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(120, 54)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblSex)
        Me.GroupBox2.Controls.Add(Me.lblBirthday)
        Me.GroupBox2.Controls.Add(Me.lblName)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(940, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(258, 214)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Thông tin thí sinh"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Giới tính :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ngày sinh :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Họ tên :"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(74, 157)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(38, 18)
        Me.lblSex.TabIndex = 0
        Me.lblSex.Text = "Nam"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.Location = New System.Drawing.Point(74, 111)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(56, 18)
        Me.lblBirthday.TabIndex = 0
        Me.lblBirthday.Text = "1/1/1990"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(74, 65)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 18)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Họ tên"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblLastChecked)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.lblChecked)
        Me.GroupBox3.Controls.Add(Me.lblNotCheck)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.lblSubjectName)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(940, 338)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 180)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Thông tin bài thi"
        '
        'lblLastChecked
        '
        Me.lblLastChecked.AutoSize = True
        Me.lblLastChecked.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastChecked.ForeColor = System.Drawing.Color.Gold
        Me.lblLastChecked.Location = New System.Drawing.Point(177, 137)
        Me.lblLastChecked.Name = "lblLastChecked"
        Me.lblLastChecked.Size = New System.Drawing.Size(24, 25)
        Me.lblLastChecked.TabIndex = 0
        Me.lblLastChecked.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 18)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Thay đổi gần nhất"
        '
        'lblChecked
        '
        Me.lblChecked.AutoSize = True
        Me.lblChecked.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChecked.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblChecked.Location = New System.Drawing.Point(177, 99)
        Me.lblChecked.Name = "lblChecked"
        Me.lblChecked.Size = New System.Drawing.Size(24, 25)
        Me.lblChecked.TabIndex = 0
        Me.lblChecked.Text = "0"
        '
        'lblNotCheck
        '
        Me.lblNotCheck.AutoSize = True
        Me.lblNotCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotCheck.ForeColor = System.Drawing.Color.Red
        Me.lblNotCheck.Location = New System.Drawing.Point(177, 65)
        Me.lblNotCheck.Name = "lblNotCheck"
        Me.lblNotCheck.Size = New System.Drawing.Size(24, 25)
        Me.lblNotCheck.TabIndex = 0
        Me.lblNotCheck.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Số câu đã chọn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số câu chưa chọn"
        '
        'lblSubjectName
        '
        Me.lblSubjectName.AutoSize = True
        Me.lblSubjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjectName.Location = New System.Drawing.Point(24, 33)
        Me.lblSubjectName.Name = "lblSubjectName"
        Me.lblSubjectName.Size = New System.Drawing.Size(67, 18)
        Me.lblSubjectName.TabIndex = 0
        Me.lblSubjectName.Text = "Môn học"
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 619)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEndTest)
        Me.Controls.Add(Me.grbQuestion)
        Me.Controls.Add(Me.flpButtonQues)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.cbAutoNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MinimizeBox = False
        Me.Name = "Test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kiểm Tra"
        Me.grbQuestion.ResumeLayout(False)
        Me.grbQuestion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbAutoNext As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents flpButtonQues As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents rbtAnswerB As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAnswerC As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAnswerD As System.Windows.Forms.RadioButton
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents grbQuestion As System.Windows.Forms.GroupBox
    Friend WithEvents btnEndTest As System.Windows.Forms.Button
    Friend WithEvents rbtAnswerA As System.Windows.Forms.RadioButton
    Friend WithEvents lblTimeOut As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblBirthday As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastChecked As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblChecked As System.Windows.Forms.Label
    Friend WithEvents lblNotCheck As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSubjectName As System.Windows.Forms.Label

End Class
