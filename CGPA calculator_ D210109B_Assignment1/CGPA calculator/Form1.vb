Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cgpatitle_Click(sender As Object, e As EventArgs) Handles cgpatitle.Click

    End Sub

    Private Sub gradeM_Click(sender As Object, e As EventArgs) Handles gradeM.Click

    End Sub

    Private Sub gradeDisplay_Click(sender As Object, e As EventArgs) Handles gradeDisplay.Click

    End Sub

    Private Sub calculateButton_Click(sender As Object, e As EventArgs) Handles calculateButton.Click

        Dim n1marks As Double = 0
        Dim n2marks As Double = 0
        Dim n3marks As Double = 0

        If grade1.Text = "A" Then
            n1marks = "4.00"
        ElseIf grade1.Text = "A-" Then
            n1marks = "3.67"
        ElseIf grade1.Text = "B+" Then
            n1marks = "3.33"
        ElseIf grade1.Text = "B" Then
            n1marks = "3.00"
        ElseIf grade1.Text = "B-" Then
            n1marks = "2.67"
        ElseIf grade1.Text = "C+" Then
            n1marks = "2.33"
        ElseIf grade1.Text = "C" Then
            n1marks = "2.00"
        ElseIf grade1.Text = "D" Then
            n1marks = "1.67"
        ElseIf grade1.Text = "D-" Then
            n1marks = "1.33"
        ElseIf grade1.Text = "F" Then
            n1marks = "0.00"
        End If

        If grade2.Text = "A" Then
            n2marks = "4.00"
        ElseIf grade2.Text = "A-" Then
            n2marks = "3.67"
        ElseIf grade2.Text = "B+" Then
            n2marks = "3.33"
        ElseIf grade2.Text = "B" Then
            n2marks = "3.00"
        ElseIf grade2.Text = "B-" Then
            n2marks = "2.67"
        ElseIf grade2.Text = "C+" Then
            n2marks = "2.33"
        ElseIf grade2.Text = "C" Then
            n2marks = "2.00"
        ElseIf grade2.Text = "D" Then
            n2marks = "1.67"
        ElseIf grade2.Text = "D-" Then
            n2marks = "1.33"
        ElseIf grade2.Text = "F" Then
            n2marks = "0.00"
        End If

        If grade3.Text = "A" Then
            n3marks = "4.00"
        ElseIf grade3.Text = "A-" Then
            n3marks = "3.67"
        ElseIf grade3.Text = "B+" Then
            n3marks = "3.33"
        ElseIf grade3.Text = "B" Then
            n3marks = "3.00"
        ElseIf grade3.Text = "B-" Then
            n3marks = "2.67"
        ElseIf grade3.Text = "C+" Then
            n3marks = "2.33"
        ElseIf grade3.Text = "C" Then
            n3marks = "2.00"
        ElseIf grade3.Text = "D" Then
            n3marks = "1.67"
        ElseIf grade3.Text = "D-" Then
            n3marks = "1.33"
        ElseIf grade3.Text = "F" Then
            n3marks = "0.00"
        End If

        Dim cgpam As Double = 0
        cgpam = (n1marks + n2marks + n3marks) / 3
        gradeDisplay.Text = cgpam.ToString("N2")
    End Sub
End Class
