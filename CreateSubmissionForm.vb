﻿Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Imports System.Diagnostics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class CreateSubmissionForm
    Private baseURL As String = "http://localhost:3000"
    Private stopwatch As New Stopwatch()
    Private httpClient As New HttpClient()
    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' Update every second
        lblStopwatch.Text = "00:00:00"
        Me.KeyPreview = True
    End Sub
    Private Async Function LoadSubmission(index As Integer) As Task
        Try
            Dim response = Await httpClient.GetAsync($"{baseURL}/read?index={index}")

            If response.IsSuccessStatusCode Then
                Dim content = Await response.Content.ReadAsStringAsync()
                Dim submissionData = JsonConvert.DeserializeObject(Of Submission)(content)

                lblTitle.Text = $"{submissionData.name}, Slidely Task 2 - Create Submissions"

            Else
                MessageBox.Show("Submission not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
    Private Sub btnStartStop_Click(sender As Object, e As EventArgs) Handles btnStartStop.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            Timer1.Stop()
            btnStartStop.Text = "Resume"
        Else
            stopwatch.Start()
            Timer1.Start()
            btnStartStop.Text = "Pause"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubLink.Text,
            .stopwatch_time = lblStopwatch.Text
        }

        Try
            Await SubmitFormToAPI(submission)
        Catch ex As Exception
            MessageBox.Show($"Submission failed. Please try again. Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Function SubmitFormToAPI(submission As Submission) As Task
        Using client As New HttpClient()
            client.BaseAddress = New Uri("http://localhost:3000/")
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await client.PostAsync("submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Dim errorContent As String = Await response.Content.ReadAsStringAsync()
                Throw New Exception($"Server returned status code {response.StatusCode}. Error: {errorContent}")
            End If
        End Using
    End Function

    Protected Overrides Sub OnKeyDown(e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then ' Handle Ctrl+T for Start/Pause
            btnStartStop.PerformClick()
        End If
        MyBase.OnKeyDown(e)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnStartStop.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnSubmit.PerformClick()
        End If
    End Sub



End Class

Public Class Submission
    Public Property name As String
    Public Property email As String
    Public Property phone As String
    Public Property github_link As String
    Public Property stopwatch_time As String
End Class
