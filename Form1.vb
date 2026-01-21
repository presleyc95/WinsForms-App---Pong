Imports System.Drawing.Imaging
Imports System.Numerics

Public Class Form1


    Private WithEvents gameTimer As New Timer()
    Private player1 As Character
    Private player2 As Character
    Private pong As Ball
    Private moveUpP1, moveDownP1, moveUpP2, moveDownP2 As Boolean


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeGame()

    End Sub

    Private Sub InitializeGame()
        player1 = New Character With {.X = 20, .Y = Me.ClientSize.Height / 2}
        player2 = New Character With {.X = Me.ClientSize.Width - 35, .Y = Me.ClientSize.Height / 2}

        pong = New Ball With {.X = Me.ClientSize.Width \ 2, .Y = Me.ClientSize.Height \ 2 + 15}

        lblP1Score.Text = "0"
        lblP2Score.Text = "0"

        gameTimer.Interval = 16
    End Sub


    Private Sub gameTimer_Tick(sender As Object, e As EventArgs) Handles gameTimer.Tick
        If moveUpP1 And player1.Y > 100 Then player1.Move(-player1.Speed)
        If moveDownP1 And player1.Y + player1.Height < 660 Then player1.Move(player1.Speed)
        If moveUpP2 And player2.Y > 100 Then player2.Move(-player2.Speed)
        If moveDownP2 And player2.Y + player2.Height < 660 Then player2.Move(player2.Speed)
        pong.Move()
        ' checking screen bound and updating score accordingly
        If pong.X <= 0 Then
            pong.Dx *= -1
            lblP2Score.Text += 1
        End If

        If pong.X + pong.Width > Me.ClientSize.Width Then
            pong.Dx *= -1
            lblP1Score.Text += 1
        End If

        If pong.Y < 100 OrElse pong.Y + pong.Height > Me.ClientSize.Height Then
            pong.Dy *= -1
        End If

        ' --- Paddle collisions ---
        If pong.Bounds.IntersectsWith(player1.Bounds) AndAlso pong.Dx < 0 Then
            pong.Dx *= -1

            ' push ball outside paddle to prevent "sticking"
            pong.X = player1.X + player1.Width + 1

            ' optional: add "english" based on where it hit the paddle
            Dim ballCenter = pong.Y + (pong.Height \ 2)
            Dim paddleCenter = player1.Y + (player1.Height \ 2)
            Dim offset = ballCenter - paddleCenter
            pong.Dy = Math.Sign(offset) * Math.Min(6, Math.Max(1, Math.Abs(offset) \ 10))
        End If

        If pong.Bounds.IntersectsWith(player2.Bounds) AndAlso pong.Dx > 0 Then
            pong.Dx *= -1

            ' push ball outside paddle to prevent "sticking"
            pong.X = player2.X - pong.Width - 1

            ' optional: add "english"
            Dim ballCenter = pong.Y + (pong.Height \ 2)
            Dim paddleCenter = player2.Y + (player2.Height \ 2)
            Dim offset = ballCenter - paddleCenter
            pong.Dy = Math.Sign(offset) * Math.Min(6, Math.Max(1, Math.Abs(offset) \ 10))
        End If

        If lblP1Score.Text = 5 Then
            gameTimer.Stop()
            MessageBox.Show("Player 1 Wins!!")
        End If

        If lblP2Score.Text = 5 Then
            gameTimer.Stop()
            MessageBox.Show("Player 2 Wins!!")
        End If


        Me.Invalidate()
    End Sub

    'Enables Mouse Movements for Character
    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.W : moveUpP1 = True
            Case Keys.S : moveDownP1 = True
            Case Keys.NumPad8 : moveUpP2 = True
            Case Keys.NumPad5 : moveDownP2 = True
        End Select
    End Sub

    Protected Overrides Sub OnKeyUp(e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.W : moveUpP1 = False
            Case Keys.S : moveDownP1 = False
            Case Keys.NumPad8 : moveUpP2 = False
            Case Keys.NumPad5 : moveDownP2 = False
        End Select
    End Sub


    'Draws the object on screen
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.FillRectangle(
        Brushes.White,
        player1.X,
        player1.Y,
        player1.Width,
        player1.Height
    )
        e.Graphics.FillRectangle(
        Brushes.White,
        player2.X,
        player2.Y,
        player2.Width,
        player2.Height
    )
        e.Graphics.FillEllipse(
        Brushes.White,
        pong.X,
        pong.Y,
        pong.Width,
        pong.Height
    )
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        gameTimer.Stop()
        InitializeGame()
        Me.Invalidate()

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        gameTimer.Start()
    End Sub
End Class
