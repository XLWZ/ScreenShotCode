Public Class FrmMain
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myDate As String = DateTime.Now.ToString("yyyy/MM/dd")
        TxtBoxDate.Text = myDate
    End Sub

    Private Sub LstBoxFrames_KeyUp(sender As Object, e As KeyEventArgs) Handles LstBoxFrames.KeyUp
        If (e.KeyCode = Keys.Delete) Then
            LstBoxFrames.Items.Remove(LstBoxFrames.SelectedItem)
        End If
    End Sub

    Private Sub TxtBoxFrameInput_KeyUp(sender As Object, e As KeyEventArgs) Handles TxtBoxFrameInput.KeyUp
        If (e.KeyCode = Keys.Enter) Then
            LstBoxFrames.Items.Add(TxtBoxFrameInput.Text)
            TxtBoxFrameInput.Clear()
        End If
    End Sub

    Private Sub BtnFunc_Click(sender As Object, e As EventArgs) Handles BtnFunc.Click
        If (TxtBoxCodeOutput.Text IsNot "") Then
            TxtBoxCodeOutput.Clear()
        End If
        Dim len = LstBoxFrames.Items.Count - 1
        Dim StrInputFrames(len) As String
        For index = 0 To len
            StrInputFrames(index) = LstBoxFrames.Items(index).ToString
        Next
        'Dim IntInputFrames(len) As Integer
        'IntInputFrames = Str2Int(StrInputFrames)
        Array.Sort(StrInputFrames)
        For index = 0 To StrInputFrames.GetUpperBound(0)
            StrInputFrames(index) = TxtBoxDate.Text & "/" & StrInputFrames(index)
        Next
        HTML(StrInputFrames)
        BBCode(StrInputFrames)
        MarkDown(StrInputFrames)
    End Sub

    Private Sub HTML(ByVal InputFrames() As String)
        TxtBoxCodeOutput.AppendText("Comparison (right click on the image and open it in a new tab to see the full-size one)<br/>
Source________________________________________________Encode<br/>" & vbCrLf)
        For index = 0 To InputFrames.GetUpperBound(0)
            TxtBoxCodeOutput.AppendText("<a href=""http://img.2222.moe/images/" & InputFrames(index) & ".png""><img src=""http://img.2222.moe/images/" & InputFrames(index) & "s.png""></a> <a href=""http://img.2222.moe/images/" & InputFrames(index) & "v.png""><img src=""http://img.2222.moe/images/" & InputFrames(index) & "s.png""></a><br/>" & vbCrLf)
        Next
        TxtBoxCodeOutput.AppendText(vbCrLf & vbCrLf)
    End Sub

    Private Sub BBCode(ByVal InputFrames() As String)
        TxtBoxCodeOutput.AppendText("Comparison (right click on the image and open it in a new tab to see the full-size one)<br/>
Source________________________________________________Encode<br/>" & vbCrLf)
        For index = 0 To InputFrames.GetUpperBound(0)
            TxtBoxCodeOutput.AppendText("[URL=http://img.2222.moe/images/" & InputFrames(index) & ".png][IMG]http://img.2222.moe/images/" & InputFrames(index) & "s.png[/IMG][/URL] [URL=http://img.2222.moe/images/" & InputFrames(index) & "v.png][IMG]http://img.2222.moe/images/" & InputFrames(index) & "s.png[/IMG][/URL]" & vbCrLf)
        Next
        TxtBoxCodeOutput.AppendText(vbCrLf & vbCrLf)
    End Sub

    Private Sub MarkDown(ByVal InputFrames() As String)
        TxtBoxCodeOutput.AppendText("Comparison (right click on the image and open it in a new tab to see the full-size one)<br/>
Source________________________________________________Encode<br/>" & vbCrLf)
        For index = 0 To InputFrames.GetUpperBound(0)
            TxtBoxCodeOutput.AppendText("[![](http://img.2222.moe/images/" & InputFrames(index) & "s.png)](http://img.2222.moe/images/" & InputFrames(index) & ".png) [![](http://img.2222.moe/images/" & InputFrames(index) & "s.png)](http://img.2222.moe/images/" & InputFrames(index) & "v.png)" & vbCrLf)
        Next
    End Sub

End Class


