<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        btnPrevious = New RoundedButton()
        btnNext = New RoundedButton()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGithubLink = New Label()
        lblStopwatchTime = New Label()
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.LightGray
        TextBox1.Location = New Point(149, 80)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(339, 27)
        TextBox1.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.LightGray
        TextBox2.Location = New Point(149, 176)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(339, 27)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.LightGray
        TextBox3.Location = New Point(149, 126)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(339, 27)
        TextBox3.TabIndex = 2
        ' 
        ' TextBox4
        ' 
        TextBox4.BackColor = Color.LightGray
        TextBox4.Location = New Point(149, 276)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(339, 27)
        TextBox4.TabIndex = 3
        ' 
        ' TextBox5
        ' 
        TextBox5.BackColor = Color.LightGray
        TextBox5.Location = New Point(149, 226)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(339, 27)
        TextBox5.TabIndex = 4
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Khaki
        btnPrevious.Location = New Point(22, 343)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(219, 29)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.SkyBlue
        btnNext.Location = New Point(264, 343)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(232, 29)
        btnNext.TabIndex = 6
        btnNext.Text = "NEXT (CTRL + N)" & vbCrLf
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(64, 87)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 7
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(64, 129)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(38, 176)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(86, 20)
        lblPhone.TabIndex = 9
        lblPhone.Text = "Phone Num"
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Location = New Point(45, 213)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(87, 40)
        lblGithubLink.TabIndex = 11
        lblGithubLink.Text = "Github Link " & vbCrLf & "For Task 2"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(53, 263)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(79, 40)
        lblStopwatchTime.TabIndex = 10
        lblStopwatchTime.Text = "Stopwatch" & vbCrLf & "    time"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(94, 22)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(38, 20)
        lblTitle.TabIndex = 13
        lblTitle.Text = "Title"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(500, 450)
        Controls.Add(lblTitle)
        Controls.Add(lblGithubLink)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "View Submissions"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents btnPrevious As RoundedButton
    Friend WithEvents btnNext As RoundedButton
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents lblTitle As Label
End Class
