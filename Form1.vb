Imports Newtonsoft.Json
Imports System.Net.Http

Public Class Form1

    Private currentIndex As Integer = 0
    Private baseURL As String = "http://localhost:3000"
    Private httpClient As New HttpClient()
    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex)
        ' Ensure KeyPreview is set to True to capture key events
        Me.KeyPreview = True
    End Sub
    Private Async Function LoadSubmission(index As Integer) As Task
        Try
            Dim response = Await HttpClient.GetAsync($"{baseURL}/read?index={index}")

            If response.IsSuccessStatusCode Then
                Dim content = Await response.Content.ReadAsStringAsync()
                Debug.WriteLine("API Response: " & content)
                Dim submissionData = JsonConvert.DeserializeObject(Of Submission)(content)

                lblTitle.Text = $"{submissionData.name}, Slidely Task 2 - Create Submissions"
                If submissionData IsNot Nothing AndAlso Not String.IsNullOrEmpty(submissionData.name) Then
                    lblTitle.Text = $"{submissionData.name}, Slidely Task 2 - Create Submissions"
                Else
                    MessageBox.Show("Submission data is empty or name is missing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Submission not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure KeyPreview is set to True to capture key events
        Me.KeyPreview = True
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createSubmissionForm As New CreateSubmissionForm()
        createSubmissionForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateSubmission.PerformClick()
        End If
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class
