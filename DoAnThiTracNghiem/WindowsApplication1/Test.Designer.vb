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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Test))
        Me.cbAutoNext = New System.Windows.Forms.CheckBox()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.flpButtonQues = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnEndTest = New System.Windows.Forms.Button()
        Me.lblTimeOut = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSex = New System.Windows.Forms.Label()
        Me.lblBirthday = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblLastChecked = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblChecked = New System.Windows.Forms.Label()
        Me.lblNotCheck = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblNameSubject = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.rbtAnswerA = New System.Windows.Forms.RadioButton()
        Me.rbtAnswerC = New System.Windows.Forms.RadioButton()
        Me.rbtAnswerB = New System.Windows.Forms.RadioButton()
        Me.rbtAnswerD = New System.Windows.Forms.RadioButton()
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbAutoNext
        '
        Me.cbAutoNext.AutoSize = True
        Me.cbAutoNext.BackColor = System.Drawing.Color.Transparent
        Me.cbAutoNext.FlatAppearance.BorderSize = 0
        Me.cbAutoNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAutoNext.ForeColor = System.Drawing.Color.Blue
        Me.cbAutoNext.Location = New System.Drawing.Point(763, 555)
        Me.cbAutoNext.Name = "cbAutoNext"
        Me.cbAutoNext.Size = New System.Drawing.Size(125, 29)
        Me.cbAutoNext.TabIndex = 0
        Me.cbAutoNext.Text = "Auto Next"
        Me.cbAutoNext.UseVisualStyleBackColor = False
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'flpButtonQues
        '
        Me.flpButtonQues.BackColor = System.Drawing.Color.Transparent
        Me.flpButtonQues.BackgroundImage = Global.DoAnThiTracNghiem.My.Resources.Resources.ic_list_button
        Me.flpButtonQues.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpButtonQues.Location = New System.Drawing.Point(12, 16)
        Me.flpButtonQues.Name = "flpButtonQues"
        Me.flpButtonQues.Size = New System.Drawing.Size(185, 537)
        Me.flpButtonQues.TabIndex = 14
        '
        'btnEndTest
        '
        Me.btnEndTest.BackColor = System.Drawing.Color.Transparent
        Me.btnEndTest.BackgroundImage = CType(resources.GetObject("btnEndTest.BackgroundImage"), System.Drawing.Image)
        Me.btnEndTest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEndTest.FlatAppearance.BorderSize = 0
        Me.btnEndTest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue
        Me.btnEndTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEndTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndTest.Location = New System.Drawing.Point(25, 559)
        Me.btnEndTest.Name = "btnEndTest"
        Me.btnEndTest.Size = New System.Drawing.Size(155, 48)
        Me.btnEndTest.TabIndex = 3
        Me.btnEndTest.UseVisualStyleBackColor = False
        '
        'lblTimeOut
        '
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.Font = New System.Drawing.Font("Modern No. 20", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.Location = New System.Drawing.Point(46, 16)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(89, 31)
        Me.lblTimeOut.TabIndex = 0
        Me.lblTimeOut.Text = "00 : 00"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Giới tính :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ngày sinh :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Họ tên :"
        '
        'lblSex
        '
        Me.lblSex.AutoSize = True
        Me.lblSex.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSex.Location = New System.Drawing.Point(78, 174)
        Me.lblSex.Name = "lblSex"
        Me.lblSex.Size = New System.Drawing.Size(51, 24)
        Me.lblSex.TabIndex = 0
        Me.lblSex.Text = "Nam"
        '
        'lblBirthday
        '
        Me.lblBirthday.AutoSize = True
        Me.lblBirthday.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthday.Location = New System.Drawing.Point(78, 128)
        Me.lblBirthday.Name = "lblBirthday"
        Me.lblBirthday.Size = New System.Drawing.Size(78, 24)
        Me.lblBirthday.TabIndex = 0
        Me.lblBirthday.Text = "1/1/1990"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(78, 82)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(67, 24)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Họ tên"
        '
        'lblLastChecked
        '
        Me.lblLastChecked.AutoSize = True
        Me.lblLastChecked.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastChecked.ForeColor = System.Drawing.Color.Gold
        Me.lblLastChecked.Location = New System.Drawing.Point(181, 167)
        Me.lblLastChecked.Name = "lblLastChecked"
        Me.lblLastChecked.Size = New System.Drawing.Size(24, 25)
        Me.lblLastChecked.TabIndex = 0
        Me.lblLastChecked.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 171)
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
        Me.lblChecked.Location = New System.Drawing.Point(181, 129)
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
        Me.lblNotCheck.Location = New System.Drawing.Point(181, 95)
        Me.lblNotCheck.Name = "lblNotCheck"
        Me.lblNotCheck.Size = New System.Drawing.Size(24, 25)
        Me.lblNotCheck.TabIndex = 0
        Me.lblNotCheck.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 18)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Số câu đã chọn"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 18)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Số câu chưa chọn"
        '
        'lblNameSubject
        '
        Me.lblNameSubject.AutoSize = True
        Me.lblNameSubject.Font = New System.Drawing.Font("Franklin Gothic Medium", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameSubject.Location = New System.Drawing.Point(22, 58)
        Me.lblNameSubject.Name = "lblNameSubject"
        Me.lblNameSubject.Size = New System.Drawing.Size(89, 26)
        Me.lblNameSubject.TabIndex = 0
        Me.lblNameSubject.Text = "Môn học"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.DoAnThiTracNghiem.My.Resources.Resources.ic_button
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.FlatAppearance.BorderSize = 0
        Me.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(580, 558)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(104, 42)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnPrevious.BackgroundImage = Global.DoAnThiTracNghiem.My.Resources.Resources.ic_button
        Me.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrevious.FlatAppearance.BorderSize = 0
        Me.btnPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevious.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevious.Location = New System.Drawing.Point(380, 557)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(98, 43)
        Me.btnPrevious.TabIndex = 1
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.lblLastChecked)
        Me.Panel1.Controls.Add(Me.lblNameSubject)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblChecked)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblNotCheck)
        Me.Panel1.Location = New System.Drawing.Point(940, 322)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(258, 204)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = Global.DoAnThiTracNghiem.My.Resources.Resources.ic_info1
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblName)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblBirthday)
        Me.Panel2.Controls.Add(Me.lblSex)
        Me.Panel2.Location = New System.Drawing.Point(940, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(258, 222)
        Me.Panel2.TabIndex = 19
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BackgroundImage = CType(resources.GetObject("btnBack.BackgroundImage"), System.Drawing.Image)
        Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBack.FlatAppearance.BorderSize = 0
        Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Location = New System.Drawing.Point(38, 559)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(65, 51)
        Me.btnBack.TabIndex = 20
        Me.btnBack.UseVisualStyleBackColor = False
        Me.btnBack.Visible = False
        '
        'rbtAnswerA
        '
        Me.rbtAnswerA.AutoSize = True
        Me.rbtAnswerA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerA.Location = New System.Drawing.Point(53, 113)
        Me.rbtAnswerA.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerA.Name = "rbtAnswerA"
        Me.rbtAnswerA.Size = New System.Drawing.Size(44, 24)
        Me.rbtAnswerA.TabIndex = 12
        Me.rbtAnswerA.TabStop = True
        Me.rbtAnswerA.Text = "txt"
        Me.rbtAnswerA.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerA.UseVisualStyleBackColor = True
        '
        'rbtAnswerC
        '
        Me.rbtAnswerC.AutoSize = True
        Me.rbtAnswerC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerC.Location = New System.Drawing.Point(53, 256)
        Me.rbtAnswerC.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerC.Name = "rbtAnswerC"
        Me.rbtAnswerC.Size = New System.Drawing.Size(44, 24)
        Me.rbtAnswerC.TabIndex = 14
        Me.rbtAnswerC.TabStop = True
        Me.rbtAnswerC.Text = "txt"
        Me.rbtAnswerC.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerC.UseVisualStyleBackColor = True
        '
        'rbtAnswerB
        '
        Me.rbtAnswerB.AutoSize = True
        Me.rbtAnswerB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerB.Location = New System.Drawing.Point(53, 184)
        Me.rbtAnswerB.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerB.Name = "rbtAnswerB"
        Me.rbtAnswerB.Size = New System.Drawing.Size(44, 24)
        Me.rbtAnswerB.TabIndex = 12
        Me.rbtAnswerB.TabStop = True
        Me.rbtAnswerB.Text = "txt"
        Me.rbtAnswerB.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerB.UseVisualStyleBackColor = True
        '
        'rbtAnswerD
        '
        Me.rbtAnswerD.AutoSize = True
        Me.rbtAnswerD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerD.Location = New System.Drawing.Point(53, 324)
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
        Me.lblQuestion.Location = New System.Drawing.Point(38, 34)
        Me.lblQuestion.MaximumSize = New System.Drawing.Size(580, 60)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(100, 24)
        Me.lblQuestion.TabIndex = 18
        Me.lblQuestion.Text = "question"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.lblQuestion)
        Me.Panel3.Controls.Add(Me.rbtAnswerD)
        Me.Panel3.Controls.Add(Me.rbtAnswerB)
        Me.Panel3.Controls.Add(Me.rbtAnswerC)
        Me.Panel3.Controls.Add(Me.rbtAnswerA)
        Me.Panel3.Location = New System.Drawing.Point(247, 108)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(641, 430)
        Me.Panel3.TabIndex = 21
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BackgroundImage = Global.DoAnThiTracNghiem.My.Resources.Resources.ic_logo
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel4.Location = New System.Drawing.Point(229, 12)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(683, 64)
        Me.Panel4.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.DoAnThiTracNghiem.My.Resources.Resources.ic_time
        Me.GroupBox1.Controls.Add(Me.lblTimeOut)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(957, 544)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 63)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1219, 619)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEndTest)
        Me.Controls.Add(Me.flpButtonQues)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.cbAutoNext)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kiểm Tra"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbAutoNext As System.Windows.Forms.CheckBox
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents flpButtonQues As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btnEndTest As System.Windows.Forms.Button
    Friend WithEvents lblTimeOut As System.Windows.Forms.Label
    Friend WithEvents lblSex As System.Windows.Forms.Label
    Friend WithEvents lblBirthday As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLastChecked As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblChecked As System.Windows.Forms.Label
    Friend WithEvents lblNotCheck As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblNameSubject As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents rbtAnswerA As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAnswerC As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAnswerB As System.Windows.Forms.RadioButton
    Friend WithEvents rbtAnswerD As System.Windows.Forms.RadioButton
    Friend WithEvents lblQuestion As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox

End Class
