Public Class Form1
    Dim FirstNumber As Decimal
    Dim SecondNumber As Decimal
    Dim Result As Decimal

    Dim emptyTextBoxes =
    From txt In Me.Controls.OfType(Of TextBox)()
    Where txt.Text.Length = 0
    Select txt.Name

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '   emptyTextBoxes =
        '   From txt In Me.Controls.OfType(Of TextBox)()
        '   Where txt.Text.Length = 0
        '   Select Case txt.Name

        '   If emptyTextBoxes.Any Then
        '   MessageBox.Show(String.Format("Please fill following textboxes: {0}",
        '   String.Join(",", emptyTextBoxes)))
        '   End If
        'If String.IsNullOrEmpty(TextBox1.Text) & String.IsNullOrEmpty(TextBox2.Text) Then
        If TextBox1.Text = Nothing And TextBox2.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 1 and Operand 2"))
        ElseIf TextBox1.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 1 "))
        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 2 "))
        Else
            FirstNumber = TextBox1.Text
            SecondNumber = TextBox2.Text
            Result = FirstNumber + SecondNumber
            TextBox3.Text = Result
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '   If emptyTextBoxes.Any Then
        '   MessageBox.Show(String.Format("Please fill following textboxes: {0}",
        '   String.Join(",", emptyTextBoxes)))
        '   End If
        ' If String.IsNullOrEmpty(TextBox1.Text) & String.IsNullOrEmpty(TextBox2.Text) Then
        'MessageBox.Show(String.Format("Please fill Operand 1 and Operand 2"))
        'ElseIf String.IsNullOrEmpty(TextBox1.Text) Then
        'MessageBox.Show(String.Format("Please fill Operand 1 "))
        'ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
        'MessageBox.Show(String.Format("Please fill Operand 2 "))
        If TextBox1.Text = Nothing And TextBox2.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 1 and Operand 2"))
        ElseIf TextBox1.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 1 "))
        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 2 "))
        Else
            FirstNumber = TextBox1.Text
        SecondNumber = TextBox2.Text
        Result = FirstNumber - SecondNumber
        TextBox3.Text = Result
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Close()
    End Sub

    ' Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    ' String todaysdate
    'Me.Text = String.Format("{0:yyyy/MM/dd HH:mm}", DateTime.Now)
    '= todaysdate
    ' End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Timer1.Start()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '  If emptyTextBoxes.Any Then
        ' MessageBox.Show(String.Format("Please fill following textboxes: {0}",
        ' String.Join(",", emptyTextBoxes)))
        ' End If
        ' If String.IsNullOrEmpty(TextBox1.Text) & String.IsNullOrEmpty(TextBox2.Text) Then
        'MessageBox.Show(String.Format("Please fill Operand 1 and Operand 2"))
        'ElseIf String.IsNullOrEmpty(TextBox1.Text) Then
        'MessageBox.Show(String.Format("Please fill Operand 1 "))
        'ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
        'MessageBox.Show(String.Format("Please fill Operand 2 "))
        'Else
        If TextBox1.Text = Nothing And TextBox2.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 1 and Operand 2"))
        ElseIf TextBox1.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 1 "))
        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 2 "))
        Else
            FirstNumber = TextBox1.Text
            SecondNumber = TextBox2.Text
            Result = FirstNumber * SecondNumber
            TextBox3.Text = Result
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' If emptyTextBoxes.Any Then
        ' MessageBox.Show(String.Format("Please fill following textboxes: {0}",
        '   String.Join(",", emptyTextBoxes)))
        'Else
        ' If String.IsNullOrEmpty(TextBox1.Text) & String.IsNullOrEmpty(TextBox2.Text) Then
        '  MessageBox.Show(String.Format("Please fill Operand 1 and Operand 2"))
        ' ElseIf String.IsNullOrEmpty(TextBox1.Text) Then
        'MessageBox.Show(String.Format("Please fill Operand 1 "))
        'ElseIf String.IsNullOrEmpty(TextBox2.Text) Then
        'MessageBox.Show(String.Format("Please fill Operand 2 "))
        'Else
        If TextBox1.Text = Nothing And TextBox2.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 1 and Operand 2"))
        ElseIf TextBox1.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 1 "))
        ElseIf TextBox2.Text = Nothing Then
            MessageBox.Show(String.Format("Please fill Operand 2 "))
        Else
            FirstNumber = TextBox1.Text
            SecondNumber = TextBox2.Text
            If TextBox2.Text <> 0 Then
                Result = FirstNumber / SecondNumber
                TextBox3.Text = Result
            Else
                TextBox3.Text = "Error !"
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Text = DateTime.Now.ToString("MM/dd/yyyy h:mm:ss tt")

    End Sub




End Class
