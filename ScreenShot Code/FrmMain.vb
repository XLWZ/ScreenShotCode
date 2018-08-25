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

        Dim StrInputFrames() As String = LstBoxFrames.Items.Cast(Of String)().ToArray()

        Dim TempArr(StrInputFrames.GetUpperBound(0)) As Integer

        For index = 0 To TempArr.GetUpperBound(0)
            TempArr(index) = Convert.ToInt32(StrInputFrames(index))
        Next
        Array.Sort(TempArr)
        For index = 0 To StrInputFrames.GetUpperBound(0)
            StrInputFrames(index) = Convert.ToString(TempArr(index))
        Next

        For index = 0 To StrInputFrames.GetUpperBound(0)
            StrInputFrames(index) = TxtBoxDate.Text & "/" & StrInputFrames(index)
        Next
        HTML(StrInputFrames)
        BBCode(StrInputFrames)
        MarkDown(StrInputFrames)
    End Sub

    Private Sub HTML(ByVal InputFrames() As String)
        TxtBoxCodeOutput.AppendText("Comparison (right click on the image and open it in a new tab to see the full-size one)<br/>" & vbCrLf & "Source________________________________________________Encode<br/>" & vbCrLf)
        For Each eachFrame In InputFrames
            TxtBoxCodeOutput.AppendText("<a href=""http://img.2222.moe/images/" & eachFrame & ".png""><img src=""http://img.2222.moe/images/" & eachFrame & "s.png""></a> <a href=""http://img.2222.moe/images/" & eachFrame & "v.png""><img src=""http://img.2222.moe/images/" & eachFrame & "s.png""></a><br/>" & vbCrLf)
        Next
        TxtBoxCodeOutput.AppendText(vbCrLf & vbCrLf)
    End Sub

    Private Sub BBCode(ByVal InputFrames() As String)
        TxtBoxCodeOutput.AppendText("Comparison (right click on the image and open it in a new tab to see the full-size one)" & vbCrLf & "Source________________________________________________Encode" & vbCrLf)
        For Each eachFrame In InputFrames
            TxtBoxCodeOutput.AppendText("[URL=http://img.2222.moe/images/" & eachFrame & ".png][IMG]http://img.2222.moe/images/" & eachFrame & "s.png[/IMG][/URL] [URL=http://img.2222.moe/images/" & eachFrame & "v.png][IMG]http://img.2222.moe/images/" & eachFrame & "s.png[/IMG][/URL]" & vbCrLf)
        Next
        TxtBoxCodeOutput.AppendText(vbCrLf & vbCrLf)
    End Sub

    Private Sub MarkDown(ByVal InputFrames() As String)
        TxtBoxCodeOutput.AppendText("Comparison (right click on the image and open it in a new tab to see the full-size one)" & vbCrLf & "Source________________________________________________Encode" & vbCrLf)
        For Each eachFrame In InputFrames
            TxtBoxCodeOutput.AppendText("[![](http://img.2222.moe/images/" & eachFrame & "s.png)](http://img.2222.moe/images/" & eachFrame & ".png) [![](http://img.2222.moe/images/" & eachFrame & "s.png)](http://img.2222.moe/images/" & eachFrame & "v.png)" & vbCrLf)
        Next
    End Sub

    Private Sub TxtBoxFrameInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxFrameInput.KeyPress
        If ((e.KeyChar <> vbBack) And Not Char.IsDigit(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub LstBoxFrames_DragEnter(sender As Object, e As DragEventArgs) Handles LstBoxFrames.DragEnter
        If (e.Data.GetDataPresent(DataFormats.FileDrop)) Then
            e.Effect = DragDropEffects.Link
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub LstBoxFrames_DragDrop(sender As Object, e As DragEventArgs) Handles LstBoxFrames.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim InputFiles() As String

            InputFiles = e.Data.GetData(DataFormats.FileDrop)

            For Each eachFile As String In InputFiles
                If (IO.Path.GetExtension(eachFile).ToLower = ".png") Then
                    If Not LstBoxFrames.Items.Contains(System.Text.RegularExpressions.Regex.Replace(IO.Path.GetFileNameWithoutExtension(eachFile), "[^0-9]", "")) Then
                        LstBoxFrames.Items.Add(System.Text.RegularExpressions.Regex.Replace(IO.Path.GetFileNameWithoutExtension(eachFile), "[^0-9]", ""))
                    End If
                End If
            Next

        End If
    End Sub
End Class




