<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnViewSubmissions = New RoundedButton()
        btnCreateSubmission = New RoundedButton()
        lblTitle = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Khaki
        btnViewSubmissions.Location = New Point(79, 107)
        btnViewSubmissions.Margin = New Padding(0)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(415, 37)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions (CTRL + V)" & vbCrLf
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.LightSkyBlue
        btnCreateSubmission.Location = New Point(79, 188)
        btnCreateSubmission.Margin = New Padding(0)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(415, 37)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "Create New Submission (CTRL + N)" & vbCrLf
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(144, 52)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(38, 20)
        lblTitle.TabIndex = 2
        lblTitle.Text = "Title"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(600, 300)
        Controls.Add(lblTitle)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        KeyPreview = True
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Submission App"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents btnViewSubmissions As RoundedButton
    Friend WithEvents btnCreateSubmission As RoundedButton
    Friend WithEvents lblTitle As Label

End Class
