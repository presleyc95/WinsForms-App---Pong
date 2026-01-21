<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btnStart = New Button()
        btnReset = New Button()
        lblP2Score = New Label()
        lblP1Score = New Label()
        lblP2 = New Label()
        lblP1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(btnStart)
        Panel1.Controls.Add(btnReset)
        Panel1.Controls.Add(lblP2Score)
        Panel1.Controls.Add(lblP1Score)
        Panel1.Controls.Add(lblP2)
        Panel1.Controls.Add(lblP1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(685, 100)
        Panel1.TabIndex = 0
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(263, 10)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(60, 28)
        btnStart.TabIndex = 5
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(362, 10)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(60, 28)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' lblP2Score
        ' 
        lblP2Score.Font = New Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblP2Score.Location = New Point(573, 42)
        lblP2Score.Name = "lblP2Score"
        lblP2Score.Size = New Size(37, 46)
        lblP2Score.TabIndex = 3
        lblP2Score.Text = "0"
        ' 
        ' lblP1Score
        ' 
        lblP1Score.Font = New Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblP1Score.Location = New Point(78, 42)
        lblP1Score.Name = "lblP1Score"
        lblP1Score.Size = New Size(38, 46)
        lblP1Score.TabIndex = 2
        lblP1Score.Text = "0"
        ' 
        ' lblP2
        ' 
        lblP2.AutoSize = True
        lblP2.Font = New Font("Showcard Gothic", 14F)
        lblP2.Location = New Point(545, 9)
        lblP2.Name = "lblP2"
        lblP2.Size = New Size(95, 23)
        lblP2.TabIndex = 1
        lblP2.Text = "Player 2"
        ' 
        ' lblP1
        ' 
        lblP1.AutoSize = True
        lblP1.Font = New Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblP1.Location = New Point(52, 9)
        lblP1.Name = "lblP1"
        lblP1.Size = New Size(94, 23)
        lblP1.TabIndex = 0
        lblP1.Text = "Player 1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(684, 661)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblP2 As Label
    Friend WithEvents lblP1 As Label
    Friend WithEvents lblP1Score As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblP2Score As Label

End Class
