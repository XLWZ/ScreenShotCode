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
        Dim TempArr(len) As Integer
        For index = 0 To len
            TempArr(index) = Convert.ToInt32(StrInputFrames(index))
        Next
        Array.Sort(TempArr)
        For index = 0 To len
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

            'Dim fi As IO.FileInfo
            Dim LstInputFilesName As New List(Of String)()

            For index = 0 To InputFiles.GetUpperBound(0)
                'fi = New IO.FileInfo(InputFiles(index))
                'InputFilesName(index) = fi.Name
                If (IO.Path.GetExtension(InputFiles(index)).ToLower = ".png") Then
                    LstInputFilesName.Add(IO.Path.GetFileNameWithoutExtension(InputFiles(index)))
                End If
            Next

            Dim InputFilesName(LstInputFilesName.Count - 1) As String
            LstInputFilesName.CopyTo(InputFilesName)

            Dim InputFrames(InputFilesName.GetUpperBound(0)) As String
            For index = 0 To InputFilesName.GetUpperBound(0)
                InputFrames(index) = System.Text.RegularExpressions.Regex.Replace(InputFilesName(index), "[^0-9]", "")
            Next

            Dim LstOutputFrames As New List(Of String)()
            For Each eachFrames As String In InputFrames
                If Not LstOutputFrames.Contains(eachFrames) Then
                    LstOutputFrames.Add(eachFrames)
                End If
            Next

            Dim OutputFrames(LstOutputFrames.Count - 1) As String
            LstOutputFrames.CopyTo(OutputFrames)
            For index = 0 To OutputFrames.GetUpperBound(0)
                LstBoxFrames.Items.Add(OutputFrames(index))
            Next

        End If
    End Sub
End Class




