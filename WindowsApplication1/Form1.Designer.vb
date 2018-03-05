<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextMarks = New System.Windows.Forms.TextBox()
        Me.TextGrade = New System.Windows.Forms.TextBox()
        Me.TextComment = New System.Windows.Forms.TextBox()
        Me.Commands = New System.Windows.Forms.GroupBox()
        Me.BtnCase = New System.Windows.Forms.Button()
        Me.BtnGrade = New System.Windows.Forms.Button()
        Me.BtnAssgn = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnForm2 = New System.Windows.Forms.Button()
        Me.Commands.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mark"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Grade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comment"
        '
        'TextMarks
        '
        Me.TextMarks.Location = New System.Drawing.Point(103, 25)
        Me.TextMarks.Name = "TextMarks"
        Me.TextMarks.Size = New System.Drawing.Size(100, 20)
        Me.TextMarks.TabIndex = 3
        '
        'TextGrade
        '
        Me.TextGrade.Location = New System.Drawing.Point(103, 57)
        Me.TextGrade.Name = "TextGrade"
        Me.TextGrade.Size = New System.Drawing.Size(100, 20)
        Me.TextGrade.TabIndex = 4
        '
        'TextComment
        '
        Me.TextComment.Location = New System.Drawing.Point(103, 93)
        Me.TextComment.Name = "TextComment"
        Me.TextComment.Size = New System.Drawing.Size(100, 20)
        Me.TextComment.TabIndex = 5
        '
        'Commands
        '
        Me.Commands.Controls.Add(Me.BtnForm2)
        Me.Commands.Controls.Add(Me.BtnClear)
        Me.Commands.Controls.Add(Me.BtnCase)
        Me.Commands.Controls.Add(Me.BtnGrade)
        Me.Commands.Controls.Add(Me.BtnAssgn)
        Me.Commands.Location = New System.Drawing.Point(385, 5)
        Me.Commands.Name = "Commands"
        Me.Commands.Size = New System.Drawing.Size(200, 178)
        Me.Commands.TabIndex = 6
        Me.Commands.TabStop = False
        Me.Commands.Text = "Commands"
        '
        'BtnCase
        '
        Me.BtnCase.Location = New System.Drawing.Point(31, 88)
        Me.BtnCase.Name = "BtnCase"
        Me.BtnCase.Size = New System.Drawing.Size(75, 23)
        Me.BtnCase.TabIndex = 2
        Me.BtnCase.Text = "Case Grade"
        Me.BtnCase.UseVisualStyleBackColor = True
        '
        'BtnGrade
        '
        Me.BtnGrade.Location = New System.Drawing.Point(31, 52)
        Me.BtnGrade.Name = "BtnGrade"
        Me.BtnGrade.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrade.TabIndex = 1
        Me.BtnGrade.Text = "Grade"
        Me.BtnGrade.UseVisualStyleBackColor = True
        '
        'BtnAssgn
        '
        Me.BtnAssgn.Location = New System.Drawing.Point(31, 17)
        Me.BtnAssgn.Name = "BtnAssgn"
        Me.BtnAssgn.Size = New System.Drawing.Size(75, 23)
        Me.BtnAssgn.TabIndex = 0
        Me.BtnAssgn.Text = "Assign grade"
        Me.BtnAssgn.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(31, 118)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 3
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnForm2
        '
        Me.BtnForm2.Location = New System.Drawing.Point(31, 148)
        Me.BtnForm2.Name = "BtnForm2"
        Me.BtnForm2.Size = New System.Drawing.Size(75, 23)
        Me.BtnForm2.TabIndex = 4
        Me.BtnForm2.Text = "Form 2"
        Me.BtnForm2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 261)
        Me.Controls.Add(Me.Commands)
        Me.Controls.Add(Me.TextComment)
        Me.Controls.Add(Me.TextGrade)
        Me.Controls.Add(Me.TextMarks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Commands.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextMarks As System.Windows.Forms.TextBox
    Friend WithEvents TextGrade As System.Windows.Forms.TextBox
    Friend WithEvents TextComment As System.Windows.Forms.TextBox
    Friend WithEvents Commands As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCase As System.Windows.Forms.Button
    Friend WithEvents BtnGrade As System.Windows.Forms.Button
    Friend WithEvents BtnAssgn As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnForm2 As System.Windows.Forms.Button

End Class
