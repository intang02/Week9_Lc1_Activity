Public Class Form1
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        Dim empFile As System.IO.StreamReader
        Dim rec, strRec() As String
        empFile = New System.IO.StreamReader("C:\Users\user\Documents\UTP\FOUNDATION\SEM 3 MAY21\VISUAL PROGRAMMING\w9lc1activity.txt")
        Do Until empFile.Peek = -1
            rec = empFile.ReadLine
            strRec = rec.Split(",")
            lstEmployeeInfo.Items.Add(strRec(0) & vbTab & strRec(3) & vbTab & strRec(4))
        Loop
        empFile.Close()
    End Sub
End Class
