Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private baseURL As String = "http://localhost:3000"
    Private httpClient As New HttpClient()
    Private currentIndex As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmission(currentIndex)
        ' Ensure KeyPreview is set to True to capture key events
        Me.KeyPreview = True
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Try
            Dim response = Await httpClient.GetAsync($"{baseURL}/read?index={index}")

            If response.IsSuccessStatusCode Then
                Dim content = Await response.Content.ReadAsStringAsync()

                Dim submissionData = JsonConvert.DeserializeObject(Of Submission)(content)

                TextBox1.Text = submissionData.name
                TextBox2.Text = submissionData.email
                TextBox3.Text = submissionData.phone
                TextBox4.Text = submissionData.github_link
                TextBox5.Text = submissionData.stopwatch_time
                lblTitle.Text = $"{submissionData.name}, Slidely Task 2 - View Submissions"
            Else
                MessageBox.Show("Submission not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        Else
            MessageBox.Show("This is the first submission", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        Await LoadSubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        End If
    End Sub
    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim response = Await httpClient.DeleteAsync($"{baseURL}/delete?index={currentIndex}")

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                If currentIndex > 0 Then
                    currentIndex -= 1
                End If
                Await LoadSubmission(currentIndex)
            Else
                MessageBox.Show("Failed to delete submission", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




End Class
