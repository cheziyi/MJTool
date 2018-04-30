Public Class frmDice

    Dim dice1 As Integer
    Dim dice2 As Integer
    Dim dice3 As Integer

    Dim round As Integer


    Private Sub frmDice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Text = System.Windows.Forms.Application.ProductName + " v" + System.Windows.Forms.Application.ProductVersion + " - 骰子"
        Panel1.Show()
        Panel2.Hide()
        If round = 17 Then
            Me.Close()
        End If
    End Sub

    Private Sub btnRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoll.Click
        rolldice()
    End Sub

    Private Function RandomNumber(ByVal rUpper As Integer, ByVal rLower As Integer) As Integer

        Randomize()
        RandomNumber = Int((rUpper - rLower + 1) * Rnd() + rLower)
    End Function

    Public Sub roundsub(ByVal roundd As Integer)
        round = roundd
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReRoll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReRoll.Click
        rolldice()
    End Sub

    Private Sub rolldice()
        Panel1.Hide()
        Panel2.Show()
        Dim totaldice As Integer
        Dim wall As Integer
        Dim image(6) As Image

        image(1) = My.Resources.dice1
        image(2) = My.Resources.dice2
        image(3) = My.Resources.dice3
        image(4) = My.Resources.dice4
        image(5) = My.Resources.dice5
        image(6) = My.Resources.dice6

        dice1 = RandomNumber(6, 1)
        dice2 = RandomNumber(6, 1)
        dice3 = RandomNumber(6, 1)

        picDice1.Image = image(dice1)
        picDice2.Image = image(dice2)
        picDice3.Image = image(dice3)

        totaldice = dice1 + dice2 + dice3
        lblTotal.Text = totaldice
        wall = round + totaldice - 1

        If wall Mod 4 = 1 Then
            lblPlayer.Text = "(" + frmMain.lblP1.Text + ")"
            lblWall.Text = frmMain.lblWind1.Text + "墙"
        ElseIf wall Mod 4 = 2 Then
            lblPlayer.Text = "(" + frmMain.lblP2.Text + ")"
            lblWall.Text = frmMain.lblWind2.Text + "墙"
        ElseIf wall Mod 4 = 3 Then
            lblPlayer.Text = "(" + frmMain.lblP3.Text + ")"
            lblWall.Text = frmMain.lblWind3.Text + "墙"
        Else
            lblPlayer.Text = "(" + frmMain.lblP4.Text + ")"
            lblWall.Text = frmMain.lblWind4.Text + "墙"
        End If
        If totaldice Mod 2 = 0 Then
            lblRemain.Text = 18 - totaldice
        Else
            lblRemain.Text = 19 - totaldice
        End If

        btnExit.Select()
    End Sub
End Class