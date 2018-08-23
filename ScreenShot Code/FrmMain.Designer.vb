<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxDate = New System.Windows.Forms.TextBox()
        Me.LstBoxFrames = New System.Windows.Forms.ListBox()
        Me.TxtBoxFrameInput = New System.Windows.Forms.TextBox()
        Me.BtnFunc = New System.Windows.Forms.Button()
        Me.TxtBoxCodeOutput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(578, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "日期"
        '
        'TxtBoxDate
        '
        Me.TxtBoxDate.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtBoxDate.Location = New System.Drawing.Point(646, 12)
        Me.TxtBoxDate.Name = "TxtBoxDate"
        Me.TxtBoxDate.Size = New System.Drawing.Size(142, 39)
        Me.TxtBoxDate.TabIndex = 1
        '
        'LstBoxFrames
        '
        Me.LstBoxFrames.AllowDrop = True
        Me.LstBoxFrames.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LstBoxFrames.FormattingEnabled = True
        Me.LstBoxFrames.ItemHeight = 17
        Me.LstBoxFrames.Location = New System.Drawing.Point(12, 57)
        Me.LstBoxFrames.Name = "LstBoxFrames"
        Me.LstBoxFrames.Size = New System.Drawing.Size(564, 106)
        Me.LstBoxFrames.TabIndex = 2
        '
        'TxtBoxFrameInput
        '
        Me.TxtBoxFrameInput.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtBoxFrameInput.Location = New System.Drawing.Point(12, 12)
        Me.TxtBoxFrameInput.Name = "TxtBoxFrameInput"
        Me.TxtBoxFrameInput.Size = New System.Drawing.Size(564, 39)
        Me.TxtBoxFrameInput.TabIndex = 3
        '
        'BtnFunc
        '
        Me.BtnFunc.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.BtnFunc.Location = New System.Drawing.Point(584, 57)
        Me.BtnFunc.Name = "BtnFunc"
        Me.BtnFunc.Size = New System.Drawing.Size(204, 106)
        Me.BtnFunc.TabIndex = 4
        Me.BtnFunc.Text = "Get!✔"
        Me.BtnFunc.UseVisualStyleBackColor = True
        '
        'TxtBoxCodeOutput
        '
        Me.TxtBoxCodeOutput.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TxtBoxCodeOutput.Location = New System.Drawing.Point(12, 169)
        Me.TxtBoxCodeOutput.Multiline = True
        Me.TxtBoxCodeOutput.Name = "TxtBoxCodeOutput"
        Me.TxtBoxCodeOutput.ReadOnly = True
        Me.TxtBoxCodeOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBoxCodeOutput.Size = New System.Drawing.Size(776, 269)
        Me.TxtBoxCodeOutput.TabIndex = 5
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtBoxCodeOutput)
        Me.Controls.Add(Me.BtnFunc)
        Me.Controls.Add(Me.TxtBoxFrameInput)
        Me.Controls.Add(Me.LstBoxFrames)
        Me.Controls.Add(Me.TxtBoxDate)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmMain"
        Me.Text = "ScreenShot Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxDate As TextBox
    Friend WithEvents LstBoxFrames As ListBox
    Friend WithEvents TxtBoxFrameInput As TextBox
    Friend WithEvents BtnFunc As Button
    Friend WithEvents TxtBoxCodeOutput As TextBox
End Class
