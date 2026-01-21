Public Class Character
    Public Property X As Integer
    Public Property Y As Integer
    Public Property Width As Integer = 15
    Public Property Height As Integer = 60
    Public Property Speed As Integer = 4

    Public ReadOnly Property Bounds As Rectangle
        Get
            Return New Rectangle(X, Y, Width, Height)
        End Get
    End Property

    Public Sub Move(dY As Integer)
        Y += dY
    End Sub
End Class


Public Class Ball
    Public Property X As Integer
    Public Property Y As Integer
    Public Property Width As Integer = 15
    Public Property Height As Integer = 15
    Public Property Dx As Integer = 5
    Public Property Dy As Integer = 5

    Public ReadOnly Property Bounds As Rectangle
        Get
            Return New Rectangle(X, Y, Width, Height)
        End Get
    End Property

    Public Sub Move()
        X += Dx
        Y += Dy
    End Sub
End Class


