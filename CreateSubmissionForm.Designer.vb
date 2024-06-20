<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGithubLink = New TextBox()
        btnStartStop = New Button()
        btnSubmit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        lblStopwatch = New Label()
        Timer1 = New Timer(components)
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(104, 80)
        txtName.Name = "txtName"
        txtName.Size = New Size(384, 27)
        txtName.TabIndex = 0
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(104, 129)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(384, 27)
        txtEmail.TabIndex = 1
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(104, 179)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(384, 27)
        txtPhone.TabIndex = 2
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(104, 241)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(384, 27)
        txtGithubLink.TabIndex = 3
        ' 
        ' btnStartStop
        ' 
        btnStartStop.BackColor = Color.Khaki
        btnStartStop.Location = New Point(12, 296)
        btnStartStop.Name = "btnStartStop"
        btnStartStop.Size = New Size(264, 29)
        btnStartStop.TabIndex = 4
        btnStartStop.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnStartStop.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SkyBlue
        btnSubmit.Location = New Point(27, 362)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(439, 29)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 83)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 6
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AllowDrop = True
        Label2.AutoSize = True
        Label2.Location = New Point(12, 228)
        Label2.Name = "Label2"
        Label2.Size = New Size(83, 40)
        Label2.TabIndex = 7
        Label2.Text = "Github Link" & vbCrLf & "For Task 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 20)
        Label3.TabIndex = 8
        Label3.Text = "Phone Num"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 136)
        Label4.Name = "Label4"
        Label4.Size = New Size(46, 20)
        Label4.TabIndex = 9
        Label4.Text = "Email"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(430, 305)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(0, 20)
        lblStopwatch.TabIndex = 10
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' Label5
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(66, 33)
        lblTitle.Name = "Label5"
        lblTitle.Size = New Size(38, 20)
        lblTitle.TabIndex = 11
        lblTitle.Text = "Title"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(500, 450)
        Controls.Add(lblTitle)
        Controls.Add(lblStopwatch)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartStop)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "Create Submission"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents btnStartStop As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTitle As Label
End Class
