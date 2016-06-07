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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
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
        Me.grbQuestion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(857, 555)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(91, 22)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Auto Next"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(323, 554)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "<<"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(441, 553)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(82, 24)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(682, 553)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(82, 24)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = ">>"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(564, 553)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 24)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = ">"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'flpButtonQues
        '
        Me.flpButtonQues.Font = New System.Drawing.Font("Palatino Linotype", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.flpButtonQues.Location = New System.Drawing.Point(12, 21)
        Me.flpButtonQues.Name = "flpButtonQues"
        Me.flpButtonQues.Size = New System.Drawing.Size(228, 537)
        Me.flpButtonQues.TabIndex = 14
        '
        'rbtAnswerB
        '
        Me.rbtAnswerB.AutoSize = True
        Me.rbtAnswerB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerB.Location = New System.Drawing.Point(52, 198)
        Me.rbtAnswerB.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerB.Name = "rbtAnswerB"
        Me.rbtAnswerB.Size = New System.Drawing.Size(38, 20)
        Me.rbtAnswerB.TabIndex = 12
        Me.rbtAnswerB.TabStop = True
        Me.rbtAnswerB.Text = "txt"
        Me.rbtAnswerB.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerB.UseVisualStyleBackColor = True
        '
        'rbtAnswerC
        '
        Me.rbtAnswerC.AutoSize = True
        Me.rbtAnswerC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerC.Location = New System.Drawing.Point(52, 270)
        Me.rbtAnswerC.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerC.Name = "rbtAnswerC"
        Me.rbtAnswerC.Size = New System.Drawing.Size(38, 20)
        Me.rbtAnswerC.TabIndex = 14
        Me.rbtAnswerC.TabStop = True
        Me.rbtAnswerC.Text = "txt"
        Me.rbtAnswerC.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerC.UseVisualStyleBackColor = True
        '
        'rbtAnswerD
        '
        Me.rbtAnswerD.AutoSize = True
        Me.rbtAnswerD.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerD.Location = New System.Drawing.Point(52, 347)
        Me.rbtAnswerD.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerD.Name = "rbtAnswerD"
        Me.rbtAnswerD.Size = New System.Drawing.Size(38, 20)
        Me.rbtAnswerD.TabIndex = 16
        Me.rbtAnswerD.TabStop = True
        Me.rbtAnswerD.Text = "txt"
        Me.rbtAnswerD.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerD.UseVisualStyleBackColor = True
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("MS Reference Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(6, 35)
        Me.lblQuestion.MaximumSize = New System.Drawing.Size(600, 60)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(88, 20)
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
        Me.grbQuestion.Location = New System.Drawing.Point(246, 90)
        Me.grbQuestion.Name = "grbQuestion"
        Me.grbQuestion.Size = New System.Drawing.Size(614, 424)
        Me.grbQuestion.TabIndex = 15
        Me.grbQuestion.TabStop = False
        Me.grbQuestion.Text = "Câu 1"
        '
        'rbtAnswerA
        '
        Me.rbtAnswerA.AutoSize = True
        Me.rbtAnswerA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtAnswerA.Location = New System.Drawing.Point(52, 127)
        Me.rbtAnswerA.MaximumSize = New System.Drawing.Size(500, 50)
        Me.rbtAnswerA.Name = "rbtAnswerA"
        Me.rbtAnswerA.Size = New System.Drawing.Size(38, 20)
        Me.rbtAnswerA.TabIndex = 12
        Me.rbtAnswerA.TabStop = True
        Me.rbtAnswerA.Text = "txt"
        Me.rbtAnswerA.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.rbtAnswerA.UseVisualStyleBackColor = True
        '
        'btnEndTest
        '
        Me.btnEndTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEndTest.Location = New System.Drawing.Point(12, 564)
        Me.btnEndTest.Name = "btnEndTest"
        Me.btnEndTest.Size = New System.Drawing.Size(190, 43)
        Me.btnEndTest.TabIndex = 0
        Me.btnEndTest.Text = "Nộp bài - kết thúc"
        Me.btnEndTest.UseVisualStyleBackColor = True
        '
        'lblTimeOut
        '
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.Font = New System.Drawing.Font("Modern No. 20", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.Location = New System.Drawing.Point(19, 16)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(83, 29)
        Me.lblTimeOut.TabIndex = 0
        Me.lblTimeOut.Text = "10 : 00"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblTimeOut)
        Me.GroupBox1.Location = New System.Drawing.Point(692, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 54)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 619)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEndTest)
        Me.Controls.Add(Me.grbQuestion)
        Me.Controls.Add(Me.flpButtonQues)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CheckBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Test"
        Me.Text = "Kiểm Tra"
        Me.grbQuestion.ResumeLayout(False)
        Me.grbQuestion.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
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

End Class
