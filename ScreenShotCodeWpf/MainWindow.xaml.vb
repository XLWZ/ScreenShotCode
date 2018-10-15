Class MainWindow
    Private Sub MainWindow_Initialized(sender As Object, e As EventArgs) Handles Me.Initialized

    End Sub

    Private Sub MainWindow_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        TxtBoxDate.Text = DateTime.Now.ToString("yyyy/MM/dd")
    End Sub

    Private Sub LstBoxInput_DragEnter(sender As Object, e As DragEventArgs) Handles LstBoxInput.DragEnter
        e.Effects = IIf(e.Data.GetDataPresent(DataFormats.FileDrop), DragDropEffects.Link, DragDropEffects.None)
    End Sub

    Private Sub LstBoxInput_Drop(sender As Object, e As DragEventArgs) Handles LstBoxInput.Drop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim InputFiles() As String

            InputFiles = e.Data.GetData(DataFormats.FileDrop)

            For Each eachFile As String In InputFiles
                If (IO.Path.GetExtension(eachFile).ToLower = ".png") Then
                    If Not LstBoxInput.Items.Contains(System.Text.RegularExpressions.Regex.Replace(IO.Path.GetFileNameWithoutExtension(eachFile), "[^0-9]", "")) Then
                        LstBoxInput.Items.Add(System.Text.RegularExpressions.Regex.Replace(IO.Path.GetFileNameWithoutExtension(eachFile), "[^0-9]", ""))
                    End If
                End If
            Next

        End If
    End Sub

    Private Sub LstBoxInput_KeyUp(sender As Object, e As KeyEventArgs) Handles LstBoxInput.KeyUp
        If (e.Key = Key.Delete) Then
            LstBoxInput.Items.Remove(LstBoxInput.SelectedItem)
        End If
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As RoutedEventArgs) Handles BtnGet.Click
        TxtBoxOutput.Clear()

        Dim StrInputFrames() As String = LstBoxInput.Items.Cast(Of String)().ToArray()

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
        TxtBoxOutput.AppendText("Comparison (right click on the image and open it in a new tab to see the full-size one)<br/>" & vbCrLf & "Source________________________________________________Encode<br/>" & vbCrLf)
        For Each eachFrame In InputFrames
            TxtBoxOutput.AppendText("<a href=""https://img.2222.moe/images/" & eachFrame & ".png""><img src=""https://img.2222.moe/images/" & eachFrame & "s.png""></a> <a href=""https://img.2222.moe/images/" & eachFrame & "v.png""><img src=""https://img.2222.moe/images/" & eachFrame & "s.png""></a><br/>" & vbCrLf)
        Next
        TxtBoxOutput.AppendText(vbCrLf & vbCrLf)
    End Sub

    Private Sub BBCode(ByVal InputFrames() As String)
        TxtBoxOutput.AppendText("Comparison (right click on the image and open it in a new tab to see the full-size one)" & vbCrLf & "Source________________________________________________Encode" & vbCrLf)
        For Each eachFrame In InputFrames
            TxtBoxOutput.AppendText("[URL=https://img.2222.moe/images/" & eachFrame & ".png][IMG]https://img.2222.moe/images/" & eachFrame & "s.png[/IMG][/URL] [URL=https://img.2222.moe/images/" & eachFrame & "v.png][IMG]https://img.2222.moe/images/" & eachFrame & "s.png[/IMG][/URL]" & vbCrLf)
        Next
        TxtBoxOutput.AppendText(vbCrLf & vbCrLf)
    End Sub

    Private Sub MarkDown(ByVal InputFrames() As String)
        TxtBoxOutput.AppendText("Comparison (right click on the image and open it in a new tab to see the full-size one)" & vbCrLf & "Source________________________________________________Encode" & vbCrLf)
        For Each eachFrame In InputFrames
            TxtBoxOutput.AppendText("[![](https://img.2222.moe/images/" & eachFrame & "s.png)](https://img.2222.moe/images/" & eachFrame & ".png) [![](https://img.2222.moe/images/" & eachFrame & "s.png)](https://img.2222.moe/images/" & eachFrame & "v.png)" & vbCrLf)
        Next
    End Sub

End Class
