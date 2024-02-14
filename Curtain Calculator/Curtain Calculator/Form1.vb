Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This sub-routine reads in the width, height and floor drop of a window to calculate the size of the curtain required
        ' Variable Declarations and INPUT
        Dim fltWinWidth As Decimal = Val(txtWinWidth.Text)
        Dim fltWinHeight As Decimal = Val(txtWinHeight.Text)
        Dim fltFloorDropHeight As Decimal = Val(txtFloorDropHeight.Text)

        ' Variable Declarations and OUTPUT
        Dim fltCurtainLength As Decimal = fltWinHeight + fltFloorDropHeight + 20
        Dim fltCurtainWidth As Decimal = 1.3 * fltWinWidth

        ' Data OUTPUT to screen
        lblCurtainLength.Text = fltCurtainLength.ToString
        lblCurtainWidth.Text = fltCurtainWidth.ToString

        If fltCurtainWidth >= 200 Then
            MsgBox("Your curtain will require an extra wide fitting over 2 metres and may require extra fees.")
        Else
            MsgBox("Your curtain is a standard size.")
        End If
    End Sub
End Class
