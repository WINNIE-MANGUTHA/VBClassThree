<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Patname = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPatname = New System.Windows.Forms.TextBox()
        Me.TxtPatage = New System.Windows.Forms.TextBox()
        Me.Operation = New System.Windows.Forms.GroupBox()
        Me.BtnAdmit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtNoFemale = New System.Windows.Forms.TextBox()
        Me.TxtNoMale = New System.Windows.Forms.TextBox()
        Me.TxtNoChild = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Female = New System.Windows.Forms.ListBox()
        Me.Male = New System.Windows.Forms.ListBox()
        Me.Child = New System.Windows.Forms.ListBox()
        Me.CmbPatgender = New System.Windows.Forms.ComboBox()
        Me.Operation.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Patname
        '
        Me.Patname.AutoSize = True
        Me.Patname.Location = New System.Drawing.Point(27, 27)
        Me.Patname.Name = "Patname"
        Me.Patname.Size = New System.Drawing.Size(49, 13)
        Me.Patname.TabIndex = 0
        Me.Patname.Text = "Patname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Patgender"
        '
        'TxtPatname
        '
        Me.TxtPatname.Location = New System.Drawing.Point(96, 27)
        Me.TxtPatname.Name = "TxtPatname"
        Me.TxtPatname.Size = New System.Drawing.Size(100, 20)
        Me.TxtPatname.TabIndex = 3
        '
        'TxtPatage
        '
        Me.TxtPatage.Location = New System.Drawing.Point(96, 50)
        Me.TxtPatage.Name = "TxtPatage"
        Me.TxtPatage.Size = New System.Drawing.Size(100, 20)
        Me.TxtPatage.TabIndex = 4
        '
        'Operation
        '
        Me.Operation.Controls.Add(Me.BtnAdmit)
        Me.Operation.Controls.Add(Me.BtnDelete)
        Me.Operation.Location = New System.Drawing.Point(348, 27)
        Me.Operation.Name = "Operation"
        Me.Operation.Size = New System.Drawing.Size(200, 117)
        Me.Operation.TabIndex = 6
        Me.Operation.TabStop = False
        Me.Operation.Text = "Operation"
        '
        'BtnAdmit
        '
        Me.BtnAdmit.Location = New System.Drawing.Point(32, 19)
        Me.BtnAdmit.Name = "BtnAdmit"
        Me.BtnAdmit.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdmit.TabIndex = 2
        Me.BtnAdmit.Text = "Admit"
        Me.BtnAdmit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(32, 54)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 1
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNoFemale)
        Me.GroupBox1.Controls.Add(Me.TxtNoMale)
        Me.GroupBox1.Controls.Add(Me.TxtNoChild)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Female)
        Me.GroupBox1.Controls.Add(Me.Male)
        Me.GroupBox1.Controls.Add(Me.Child)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 176)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 274)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ward"
        '
        'TxtNoFemale
        '
        Me.TxtNoFemale.Location = New System.Drawing.Point(395, 166)
        Me.TxtNoFemale.Name = "TxtNoFemale"
        Me.TxtNoFemale.Size = New System.Drawing.Size(100, 20)
        Me.TxtNoFemale.TabIndex = 8
        '
        'TxtNoMale
        '
        Me.TxtNoMale.Location = New System.Drawing.Point(200, 166)
        Me.TxtNoMale.Name = "TxtNoMale"
        Me.TxtNoMale.Size = New System.Drawing.Size(100, 20)
        Me.TxtNoMale.TabIndex = 7
        '
        'TxtNoChild
        '
        Me.TxtNoChild.Location = New System.Drawing.Point(10, 166)
        Me.TxtNoChild.Name = "TxtNoChild"
        Me.TxtNoChild.Size = New System.Drawing.Size(100, 20)
        Me.TxtNoChild.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(395, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "No. female"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No. male"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. child"
        '
        'Female
        '
        Me.Female.FormattingEnabled = True
        Me.Female.Location = New System.Drawing.Point(395, 48)
        Me.Female.Name = "Female"
        Me.Female.Size = New System.Drawing.Size(120, 95)
        Me.Female.TabIndex = 2
        '
        'Male
        '
        Me.Male.FormattingEnabled = True
        Me.Male.Location = New System.Drawing.Point(200, 48)
        Me.Male.Name = "Male"
        Me.Male.Size = New System.Drawing.Size(120, 95)
        Me.Male.TabIndex = 1
        '
        'Child
        '
        Me.Child.FormattingEnabled = True
        Me.Child.Location = New System.Drawing.Point(6, 48)
        Me.Child.Name = "Child"
        Me.Child.Size = New System.Drawing.Size(120, 95)
        Me.Child.TabIndex = 0
        '
        'CmbPatgender
        '
        Me.CmbPatgender.FormattingEnabled = True
        Me.CmbPatgender.Location = New System.Drawing.Point(96, 72)
        Me.CmbPatgender.Name = "CmbPatgender"
        Me.CmbPatgender.Size = New System.Drawing.Size(121, 21)
        Me.CmbPatgender.TabIndex = 8
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 533)
        Me.Controls.Add(Me.CmbPatgender)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Operation)
        Me.Controls.Add(Me.TxtPatage)
        Me.Controls.Add(Me.TxtPatname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Patname)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Operation.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Patname As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPatname As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatage As System.Windows.Forms.TextBox
    Friend WithEvents Operation As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNoMale As System.Windows.Forms.TextBox
    Friend WithEvents TxtNoChild As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Female As System.Windows.Forms.ListBox
    Friend WithEvents Male As System.Windows.Forms.ListBox
    Friend WithEvents Child As System.Windows.Forms.ListBox
    Friend WithEvents TxtNoFemale As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdmit As System.Windows.Forms.Button
    Friend WithEvents CmbPatgender As System.Windows.Forms.ComboBox
End Class
