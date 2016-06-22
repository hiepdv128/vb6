<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShowMenu
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
        Me.btnAddSubject = New System.Windows.Forms.Button()
        Me.btnViewSubject = New System.Windows.Forms.Button()
        Me.btnViewUser = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAddSubject
        '
        Me.btnAddSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnAddSubject.BackgroundImage = Global.DemoProject.My.Resources.Resources.ic_add_question
        Me.btnAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddSubject.FlatAppearance.BorderSize = 0
        Me.btnAddSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSubject.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubject.Location = New System.Drawing.Point(367, 99)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(207, 82)
        Me.btnAddSubject.TabIndex = 0
        Me.btnAddSubject.UseVisualStyleBackColor = False
        '
        'btnViewSubject
        '
        Me.btnViewSubject.BackColor = System.Drawing.Color.Transparent
        Me.btnViewSubject.BackgroundImage = Global.DemoProject.My.Resources.Resources.ic_view_question
        Me.btnViewSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewSubject.FlatAppearance.BorderSize = 0
        Me.btnViewSubject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnViewSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewSubject.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSubject.Location = New System.Drawing.Point(422, 207)
        Me.btnViewSubject.Name = "btnViewSubject"
        Me.btnViewSubject.Size = New System.Drawing.Size(207, 82)
        Me.btnViewSubject.TabIndex = 1
        Me.btnViewSubject.UseVisualStyleBackColor = False
        '
        'btnViewUser
        '
        Me.btnViewUser.BackColor = System.Drawing.Color.Transparent
        Me.btnViewUser.BackgroundImage = Global.DemoProject.My.Resources.Resources.ic_view_alluser
        Me.btnViewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnViewUser.FlatAppearance.BorderSize = 0
        Me.btnViewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.btnViewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnViewUser.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewUser.Location = New System.Drawing.Point(482, 312)
        Me.btnViewUser.Name = "btnViewUser"
        Me.btnViewUser.Size = New System.Drawing.Size(207, 82)
        Me.btnViewUser.TabIndex = 2
        Me.btnViewUser.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(12, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 154)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Công cụ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "quản lý"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShowMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DemoProject.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(728, 460)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnViewUser)
        Me.Controls.Add(Me.btnViewSubject)
        Me.Controls.Add(Me.btnAddSubject)
        Me.Name = "ShowMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddSubject As System.Windows.Forms.Button
    Friend WithEvents btnViewSubject As System.Windows.Forms.Button
    Friend WithEvents btnViewUser As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
