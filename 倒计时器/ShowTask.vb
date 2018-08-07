Public Class ShowTask
    Private _EndString As String
    Private _EndTime As Date
    Private _Level As Integer
    Private _Words() As Integer

    Property EndString As String
        Get
            Return _EndString
        End Get
        Set
            _EndString = Value
        End Set
    End Property
    Property EndTime As Date
        Get
            Return _EndTime
        End Get
        Set
            _EndTime = Value
        End Set
    End Property
    Property Level As Integer
        Get
            Return _Level
        End Get
        Set
            _Level = Value
        End Set
    End Property
    Property Words(i As Integer) As Integer
        Get
            Return _Words(i)
        End Get
        Set
            _Words(i) = Value
        End Set
    End Property
End Class
