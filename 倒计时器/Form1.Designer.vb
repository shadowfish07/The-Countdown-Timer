<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblEndString = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblFstLine = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblSndLine = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.设定时间ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重新载入文本ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.自动更新开ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "距"
        '
        'LblEndString
        '
        Me.LblEndString.AutoSize = True
        Me.LblEndString.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblEndString.ForeColor = System.Drawing.Color.White
        Me.LblEndString.Location = New System.Drawing.Point(56, 9)
        Me.LblEndString.Name = "LblEndString"
        Me.LblEndString.Size = New System.Drawing.Size(63, 41)
        Me.LblEndString.TabIndex = 1
        Me.LblEndString.Text = "***"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(125, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 41)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "还有"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblTime.Font = New System.Drawing.Font("微软雅黑", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblTime.ForeColor = System.Drawing.Color.Red
        Me.LblTime.Location = New System.Drawing.Point(8, 48)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(111, 62)
        Me.LblTime.TabIndex = 3
        Me.LblTime.Text = "000"
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(103, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 31)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "天"
        '
        'LblFstLine
        '
        Me.LblFstLine.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFstLine.ForeColor = System.Drawing.Color.White
        Me.LblFstLine.Location = New System.Drawing.Point(3, 0)
        Me.LblFstLine.Name = "LblFstLine"
        Me.LblFstLine.Size = New System.Drawing.Size(328, 29)
        Me.LblFstLine.TabIndex = 6
        Me.LblFstLine.Text = "Attitude is everything"
        Me.LblFstLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.LblFstLine)
        Me.Panel1.Controls.Add(Me.LblSndLine)
        Me.Panel1.Location = New System.Drawing.Point(-2, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 56)
        Me.Panel1.TabIndex = 7
        '
        'LblSndLine
        '
        Me.LblSndLine.Font = New System.Drawing.Font("华文楷体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LblSndLine.ForeColor = System.Drawing.Color.White
        Me.LblSndLine.Location = New System.Drawing.Point(3, 27)
        Me.LblSndLine.Name = "LblSndLine"
        Me.LblSndLine.Size = New System.Drawing.Size(328, 29)
        Me.LblSndLine.TabIndex = 7
        Me.LblSndLine.Text = "态度决定一切"
        Me.LblSndLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.设定时间ToolStripMenuItem, Me.重新载入文本ToolStripMenuItem, Me.自动更新开ToolStripMenuItem, Me.ToolStripSeparator1, Me.退出ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 120)
        '
        '设定时间ToolStripMenuItem
        '
        Me.设定时间ToolStripMenuItem.Name = "设定时间ToolStripMenuItem"
        Me.设定时间ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.设定时间ToolStripMenuItem.Text = "设定时间"
        '
        '重新载入文本ToolStripMenuItem
        '
        Me.重新载入文本ToolStripMenuItem.Name = "重新载入文本ToolStripMenuItem"
        Me.重新载入文本ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.重新载入文本ToolStripMenuItem.Text = "重新载入文本"
        '
        '自动更新开ToolStripMenuItem
        '
        Me.自动更新开ToolStripMenuItem.Name = "自动更新开ToolStripMenuItem"
        Me.自动更新开ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.自动更新开ToolStripMenuItem.Text = "自动更新：开"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(145, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(330, 169)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblEndString)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "倒计时器"
        Me.Panel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblEndString As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblSndLine As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 设定时间ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 重新载入文本ToolStripMenuItem As ToolStripMenuItem
    Private WithEvents LblFstLine As Label
    Friend WithEvents 自动更新开ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
End Class
