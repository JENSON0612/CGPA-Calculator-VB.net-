<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cgpatitle = New System.Windows.Forms.Label()
        Me.subject = New System.Windows.Forms.Label()
        Me.grade = New System.Windows.Forms.Label()
        Me.subject1 = New System.Windows.Forms.MaskedTextBox()
        Me.subject2 = New System.Windows.Forms.MaskedTextBox()
        Me.subject3 = New System.Windows.Forms.MaskedTextBox()
        Me.grade1 = New System.Windows.Forms.MaskedTextBox()
        Me.grade2 = New System.Windows.Forms.MaskedTextBox()
        Me.grade3 = New System.Windows.Forms.MaskedTextBox()
        Me.calculateButton = New System.Windows.Forms.Button()
        Me.gradeM = New System.Windows.Forms.Label()
        Me.gradeDisplay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cgpatitle
        '
        Me.cgpatitle.AutoSize = True
        Me.cgpatitle.Font = New System.Drawing.Font("Showcard Gothic", 24.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.cgpatitle.Location = New System.Drawing.Point(89, 48)
        Me.cgpatitle.Name = "cgpatitle"
        Me.cgpatitle.Size = New System.Drawing.Size(327, 42)
        Me.cgpatitle.TabIndex = 0
        Me.cgpatitle.Text = "CGPA CALCULATOR"
        '
        'subject
        '
        Me.subject.AutoSize = True
        Me.subject.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.subject.Location = New System.Drawing.Point(109, 111)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(60, 20)
        Me.subject.TabIndex = 1
        Me.subject.Text = "Subject"
        '
        'grade
        '
        Me.grade.AutoSize = True
        Me.grade.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.grade.Location = New System.Drawing.Point(254, 111)
        Me.grade.Name = "grade"
        Me.grade.Size = New System.Drawing.Size(51, 20)
        Me.grade.TabIndex = 2
        Me.grade.Text = "Grade"
        '
        'subject1
        '
        Me.subject1.Location = New System.Drawing.Point(89, 154)
        Me.subject1.Name = "subject1"
        Me.subject1.Size = New System.Drawing.Size(100, 23)
        Me.subject1.TabIndex = 3
        '
        'subject2
        '
        Me.subject2.Location = New System.Drawing.Point(89, 194)
        Me.subject2.Name = "subject2"
        Me.subject2.Size = New System.Drawing.Size(100, 23)
        Me.subject2.TabIndex = 4
        '
        'subject3
        '
        Me.subject3.Location = New System.Drawing.Point(89, 235)
        Me.subject3.Name = "subject3"
        Me.subject3.Size = New System.Drawing.Size(100, 23)
        Me.subject3.TabIndex = 5
        '
        'grade1
        '
        Me.grade1.Location = New System.Drawing.Point(226, 154)
        Me.grade1.Name = "grade1"
        Me.grade1.Size = New System.Drawing.Size(100, 23)
        Me.grade1.TabIndex = 6
        '
        'grade2
        '
        Me.grade2.Location = New System.Drawing.Point(226, 194)
        Me.grade2.Name = "grade2"
        Me.grade2.Size = New System.Drawing.Size(100, 23)
        Me.grade2.TabIndex = 7
        '
        'grade3
        '
        Me.grade3.Location = New System.Drawing.Point(226, 235)
        Me.grade3.Name = "grade3"
        Me.grade3.Size = New System.Drawing.Size(100, 23)
        Me.grade3.TabIndex = 8
        '
        'calculateButton
        '
        Me.calculateButton.BackColor = System.Drawing.Color.RosyBrown
        Me.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.calculateButton.Location = New System.Drawing.Point(383, 194)
        Me.calculateButton.Name = "calculateButton"
        Me.calculateButton.Size = New System.Drawing.Size(75, 23)
        Me.calculateButton.TabIndex = 9
        Me.calculateButton.Text = "Calculate"
        Me.calculateButton.UseVisualStyleBackColor = False
        '
        'gradeM
        '
        Me.gradeM.AutoSize = True
        Me.gradeM.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gradeM.Location = New System.Drawing.Point(161, 305)
        Me.gradeM.Name = "gradeM"
        Me.gradeM.Size = New System.Drawing.Size(44, 13)
        Me.gradeM.TabIndex = 10
        Me.gradeM.Text = "Grade :"
        '
        'gradeDisplay
        '
        Me.gradeDisplay.AutoSize = True
        Me.gradeDisplay.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.gradeDisplay.Location = New System.Drawing.Point(211, 305)
        Me.gradeDisplay.Name = "gradeDisplay"
        Me.gradeDisplay.Size = New System.Drawing.Size(22, 13)
        Me.gradeDisplay.TabIndex = 11
        Me.gradeDisplay.Text = "0.0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(61, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(61, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(61, 239)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "3"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 355)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gradeDisplay)
        Me.Controls.Add(Me.gradeM)
        Me.Controls.Add(Me.calculateButton)
        Me.Controls.Add(Me.grade3)
        Me.Controls.Add(Me.grade2)
        Me.Controls.Add(Me.grade1)
        Me.Controls.Add(Me.subject3)
        Me.Controls.Add(Me.subject2)
        Me.Controls.Add(Me.subject1)
        Me.Controls.Add(Me.grade)
        Me.Controls.Add(Me.subject)
        Me.Controls.Add(Me.cgpatitle)
        Me.Name = "Form1"
        Me.Text = "Assignment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cgpatitle As Label
    Friend WithEvents subject As Label
    Friend WithEvents grade As Label
    Friend WithEvents subject1 As MaskedTextBox
    Friend WithEvents subject2 As MaskedTextBox
    Friend WithEvents subject3 As MaskedTextBox
    Friend WithEvents grade1 As MaskedTextBox
    Friend WithEvents grade2 As MaskedTextBox
    Friend WithEvents grade3 As MaskedTextBox
    Friend WithEvents calculateButton As Button
    Friend WithEvents gradeM As Label
    Friend WithEvents gradeDisplay As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
