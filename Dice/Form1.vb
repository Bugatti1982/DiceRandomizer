Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim t As Integer
        t = 0
        Do

            MyPicBox.Refresh()

            Dim n As Integer
            Dim myPen As Pen

            myPen = New Pen(Drawing.Color.DarkTurquoise, 10)
            Dim myGraphics As Graphics = MyPicBox.CreateGraphics
            n = Int(6 * Rnd()) + 1

            Select Case n

                Case 1
                    myGraphics.DrawEllipse(myPen, 80, 80, 10, 10)

                Case 2
                    myGraphics.DrawEllipse(myPen, 40, 40, 10, 10)
                    myGraphics.DrawEllipse(myPen, 120, 120, 10, 10)

                Case 3
                    myGraphics.DrawEllipse(myPen, 40, 40, 10, 10)
                    myGraphics.DrawEllipse(myPen, 80, 80, 10, 10)
                    myGraphics.DrawEllipse(myPen, 120, 120, 10, 10)

                Case 4
                    myGraphics.DrawEllipse(myPen, 40, 40, 10, 10)
                    myGraphics.DrawEllipse(myPen, 120, 40, 10, 10)
                    myGraphics.DrawEllipse(myPen, 40, 120, 10, 10)
                    myGraphics.DrawEllipse(myPen, 120, 120, 10, 10)
                Case 5
                    myGraphics.DrawEllipse(myPen, 40, 40, 10, 10)
                    myGraphics.DrawEllipse(myPen, 120, 40, 10, 10)
                    myGraphics.DrawEllipse(myPen, 80, 80, 10, 10)
                    myGraphics.DrawEllipse(myPen, 40, 120, 10, 10)
                    myGraphics.DrawEllipse(myPen, 120, 120, 10, 10)

                Case 6
                    myGraphics.DrawEllipse(myPen, 40, 40, 10, 10)
                    myGraphics.DrawEllipse(myPen, 120, 40, 10, 10)
                    myGraphics.DrawEllipse(myPen, 40, 80, 10, 10)
                    myGraphics.DrawEllipse(myPen, 120, 80, 10, 10)
                    myGraphics.DrawEllipse(myPen, 40, 120, 10, 10)
                    myGraphics.DrawEllipse(myPen, 120, 120, 10, 10)
            End Select
            t = t + 1
        Loop Until t > 1000
        Timer1.Enabled = False
    End Sub

    Private Sub btnRoll_Click(sender As Object, e As EventArgs) Handles btnRoll.Click
        Timer1.Enabled = True
    End Sub
End Class
