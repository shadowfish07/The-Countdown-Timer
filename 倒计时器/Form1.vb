Imports System.IO
Public Class Form1
    Public words(,) As String, wordnum As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Location = New Point(Me.Location.X + 695, Me.Location.Y)
        LblTime.Text = DateDiff(DateInterval.Day, Today, DateSerial(2018, 7, 10))
        LblEndString.Text = "暑假"
        Label2.Left = LblEndString.Location.X + LblEndString.Width - 10
        Label4.Left = LblTime.Location.X + LblTime.Width - 10
        ReadWords("WordsAndSettings.txt")
        Dim rand As New Random
        Dim randi As Integer = rand.Next(wordnum)
        If Len(words(0, randi)) > 36 Then
            LblFstLine.Font = New Font(LblFstLine.Font.FontFamily, 10)
        Else
            LblFstLine.Font = New Font(LblFstLine.Font.FontFamily, 14.25)
        End If
        LblFstLine.Text = words(0, randi)
        LblSndLine.Text = words(1, randi)
    End Sub

    Private Sub ReadWords(ref As String)
        ReDim words(1, 0)
        wordnum = 0
        Dim fs As New FileStream(ref, FileMode.OpenOrCreate)
        Dim sr As New StreamReader(fs, System.Text.Encoding.Unicode)
        PutInWords(sr.ReadToEnd)
        sr.Close()
        fs.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Static time As Integer = 0
        time += 1
        If time = 60 * 30 Then
            Dim rand As New Random
            Dim randi As Integer = rand.Next(wordnum)
            time = 0
            If Len(words(0, randi)) > 36 Then
                LblFstLine.Font = New Font(LblFstLine.Font.FontFamily, 10)
            Else
                LblFstLine.Font = New Font(LblFstLine.Font.FontFamily, 14.25)
            End If
            LblFstLine.Text = words(0, randi)
            LblSndLine.Text = words(1, randi)
        End If
        LblTime.Text = DateDiff(DateInterval.Day, Today, DateSerial(2018, 7, 10))
        Label4.Left = LblTime.Location.X + LblTime.Width - 10
    End Sub



    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Dim temp As String = LblTime.Text
        LblTime.Text = InputBox("新日期",, LblTime.Text)
        If LblTime.Text = "" Then LblTime.Text = temp
        Label4.Left = LblTime.Location.X + LblTime.Width - 10
    End Sub

    Private Sub 设定时间ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 设定时间ToolStripMenuItem.Click
        Form1_DoubleClick(Nothing, Nothing)
    End Sub

    Private Sub 重新载入文本ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重新载入文本ToolStripMenuItem.Click
        ReadWords("WordsAndSettings.txt")
    End Sub

    Private Sub 自动更新开ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 自动更新开ToolStripMenuItem.Click
        If Timer1.Enabled = True Then
            自动更新开ToolStripMenuItem.Text = "自动更新：关"
            Timer1.Enabled = False
        Else
            自动更新开ToolStripMenuItem.Text = "自动更新：开"
            Timer1.Enabled = True
        End If
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub PutInWords(s As String)
        Dim prev_str As Integer = 0, behd_str As Integer = -2, split_str As Integer = 0
        Do Until s.IndexOf("/@", behd_str + 2) = -1
            prev_str = s.IndexOf("/@", behd_str + 2) + 2
            If s.IndexOf("@/", prev_str) = -1 Then
                MsgBox("格式错误")
            Else
                behd_str = s.IndexOf("@/", prev_str - 1)
            End If
            If s.IndexOf("##", prev_str, behd_str - prev_str) = -1 Then
                ReDim Preserve words(1, wordnum)
                words(0, wordnum) = s.Substring(prev_str, behd_str - prev_str)
                wordnum += 1
            Else
                split_str = s.IndexOf("##", prev_str, behd_str - prev_str)
                ReDim Preserve words(1, wordnum)
                words(0, wordnum) = s.Substring(prev_str, split_str - prev_str)
                words(1, wordnum) = s.Substring(split_str + 2, behd_str - split_str - 2)
                wordnum += 1
            End If
        Loop
    End Sub
End Class
