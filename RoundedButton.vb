Imports System.Drawing.Drawing2D

Public Class RoundedButton
    Inherits Button

    Protected Overrides Sub OnPaint(pevent As PaintEventArgs)
        MyBase.OnPaint(pevent)

        ' Set the button's border radius
        Dim borderRadius As Integer = 20

        ' Create a rounded rectangle path
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90)
        path.AddArc(Me.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90)
        path.AddArc(Me.Width - borderRadius, Me.Height - borderRadius, borderRadius, borderRadius, 0, 90)
        path.AddArc(0, Me.Height - borderRadius, borderRadius, borderRadius, 90, 90)
        path.CloseFigure()

        ' Set the region of the button to be the rounded rectangle path
        Me.Region = New Region(path)

        ' Draw the background
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        Using brush As New SolidBrush(Me.BackColor)
            pevent.Graphics.FillPath(brush, path)
        End Using

        ' Draw the text centered horizontally and vertically
        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        pevent.Graphics.DrawString(Me.Text, Me.Font, New SolidBrush(Me.ForeColor), Me.ClientRectangle, sf)
    End Sub
End Class
