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
        Me.SuspendLayout()
        '
        'btnAddSubject
        '
        Me.btnAddSubject.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSubject.Location = New System.Drawing.Point(367, 99)
        Me.btnAddSubject.Name = "btnAddSubject"
        Me.btnAddSubject.Size = New System.Drawing.Size(207, 82)
        Me.btnAddSubject.TabIndex = 0
        Me.btnAddSubject.Text = "Thêm môn học"
        Me.btnAddSubject.UseVisualStyleBackColor = True
        '
        'btnViewSubject
        '
        Me.btnViewSubject.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewSubject.Location = New System.Drawing.Point(422, 207)
        Me.btnViewSubject.Name = "btnViewSubject"
        Me.btnViewSubject.Size = New System.Drawing.Size(207, 82)
        Me.btnViewSubject.TabIndex = 0
        Me.btnViewSubject.Text = "Xem danh sách câu hỏi"
        Me.btnViewSubject.UseVisualStyleBackColor = True
        '
        'btnViewUser
        '
        Me.btnViewUser.Font = New System.Drawing.Font("Lucida Bright", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewUser.Location = New System.Drawing.Point(482, 312)
        Me.btnViewUser.Name = "btnViewUser"
        Me.btnViewUser.Size = New System.Drawing.Size(207, 82)
        Me.btnViewUser.TabIndex = 0
        Me.btnViewUser.Text = "Xem danh sách người dùng"
        Me.btnViewUser.UseVisualStyleBackColor = True
        '
        'ShowMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 460)
        Me.Controls.Add(Me.btnViewUser)
        Me.Controls.Add(Me.btnViewSubject)
        Me.Controls.Add(Me.btnAddSubject)
        Me.Name = "ShowMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAddSubject As System.Windows.Forms.Button
    Friend WithEvents btnViewSubject As System.Windows.Forms.Button
    Friend WithEvents btnViewUser As System.Windows.Forms.Button
End Class
