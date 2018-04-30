Public Class frmMain

    Dim basepay As Decimal
    Dim round As Integer
    Dim game As Integer
    Dim roundprev As Integer
    Dim gameprev As Integer

    Dim playerhu As Integer

    Dim player1 As String
    Dim player2 As String
    Dim player3 As String
    Dim player4 As String

    Dim gangtai As Integer
    Dim angangtai As Integer

    Dim hucounter(4) As Integer
    Dim zahucounter(4) As Integer
    Dim gangcount(4) As Integer
    Dim diaozengcount(4) As Integer
    Dim hucounterprev(4) As Integer
    Dim zahucounterprev(4) As Integer
    Dim gangcountprev(4) As Integer
    Dim diaozengcountprev(4) As Integer

    Dim money(4) As Decimal
    Dim moneyprev(4) As Decimal

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlStart.Show()
        pnlMain.Hide()
        pnlEnd.Hide()
        btnPlay.Select()
        lblName.Text = System.Windows.Forms.Application.ProductName
        lblVersion.Text = "Version: " + System.Windows.Forms.Application.ProductVersion
        Me.Text = System.Windows.Forms.Application.ProductName + " v" + System.Windows.Forms.Application.ProductVersion
        lblCopy.Text = "Produced by: " + System.Windows.Forms.Application.CompanyName
    End Sub

    Private Sub btnPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlay.Click
        player1 = txtPlayer1.Text
        player2 = txtPlayer2.Text
        player3 = txtPlayer3.Text
        player4 = txtPlayer4.Text

        basepay = txtBasePay.Text
        gangtai = txtGangTai.Text
        angangtai = txtAnGangTai.Text

        lblP1.Text = player1
        lblP2.Text = player2
        lblP3.Text = player3
        lblP4.Text = player4

        money(1) = 0
        money(2) = 0
        money(3) = 0
        money(4) = 0

        round = 1
        game = 1



        history()

        wind(round)



        pnlStart.Hide()
        pnlMain.Show()
        pnlEnd.Hide()



    End Sub

    Private Sub btnHu1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHu1.Click
        history()
        If round Mod 4 = 1 Then
            round = round
            diaozengcount(1) = diaozengcount(1) + 1
        Else
            round = round + 1
        End If
        game = game + 1
        hu(1)


    End Sub

    Private Sub btnHu2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHu2.Click
        history()
        If round Mod 4 = 2 Then
            round = round
            diaozengcount(2) = diaozengcount(2) + 1
        Else
            round = round + 1
        End If
        game = game + 1
        hu(2)

    End Sub

    Private Sub btnHu3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHu3.Click

        history()
        If round Mod 4 = 3 Then
            round = round
            diaozengcount(3) = diaozengcount(3) + 1
        Else
            round = round + 1
        End If
        game = game + 1
        hu(3)

    End Sub

    Private Sub btnHu4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHu4.Click


        history()
        If round Mod 4 = 0 Then
            round = round
            diaozengcount(4) = diaozengcount(4) + 1
        Else
            round = round + 1
        End If
        game = game + 1
        hu(4)

    End Sub



    Private Sub hu(ByVal player As Integer)

        hucounter(player) = hucounter(player) + 1
        If player = 1 Then
            frmhu.btnthrow1.Text = "自摸"
            frmhu.btnthrow2.Text = player2
            frmhu.btnthrow3.Text = player3
            frmhu.btnthrow4.Text = player4
            playerhu = 1
            frmhu.Show()
        End If

        If player = 2 Then
            frmhu.btnthrow1.Text = player1
            frmhu.btnthrow2.Text = "自摸"
            frmhu.btnthrow3.Text = player3
            frmhu.btnthrow4.Text = player4
            playerhu = 2
            frmhu.Show()
        End If

        If player = 3 Then
            frmhu.btnthrow1.Text = player1
            frmhu.btnthrow2.Text = player2
            frmhu.btnthrow3.Text = "自摸"
            frmhu.btnthrow4.Text = player4
            playerhu = 3
            frmhu.Show()
        End If

        If player = 4 Then
            frmhu.btnthrow1.Text = player1
            frmhu.btnthrow2.Text = player2
            frmhu.btnthrow3.Text = player3
            frmhu.btnthrow4.Text = "自摸"
            playerhu = 4
            frmhu.Show()
        End If

        frmDice.roundsub(round)


    End Sub


    Public Sub pay(ByVal tai As Decimal, ByVal playerthrow As Integer, ByVal bao As Boolean)

        Dim intCount As Integer
        Dim payout As Decimal = basepay

        For intCount = 1 To tai - 1
            payout = payout * 2
        Next intCount


        If playerthrow = 0 Then
            history()
            gangcount(playerhu) = gangcount(playerhu) + 1
            money(1) = money(1) - payout
            money(2) = money(2) - payout
            money(3) = money(3) - payout
            money(4) = money(4) - payout
            money(playerhu) = money(playerhu) + (payout * 4)

        ElseIf playerthrow = 5 Then
            zahucounter(playerhu) = zahucounter(playerhu) + 1
            money(playerhu) = money(playerhu) - (payout * 8)
            money(1) = money(1) + (payout * 2)
            money(2) = money(2) + (payout * 2)
            money(3) = money(3) + (payout * 2)
            money(4) = money(4) + (payout * 2)

        ElseIf playerthrow = playerhu Then
            money(1) = money(1) - (payout * 2)
            money(2) = money(2) - (payout * 2)
            money(3) = money(3) - (payout * 2)
            money(4) = money(4) - (payout * 2)
            money(playerhu) = money(playerhu) + (payout * 8)

        ElseIf bao = True Then
            money(playerhu) = money(playerhu) + (payout * 4)
            money(playerthrow) = money(playerthrow) - (payout * 4)

        Else
            money(1) = money(1) - payout
            money(2) = money(2) - payout
            money(3) = money(3) - payout
            money(4) = money(4) - payout
            money(playerhu) = money(playerhu) + (payout * 5)
            money(playerthrow) = money(playerthrow) - payout
        End If

        wind(round)

    End Sub



    Private Sub wind(ByVal round As Integer)

        txtMoney1.Text = money(1)
        txtMoney2.Text = money(2)
        txtMoney3.Text = money(3)
        txtMoney4.Text = money(4)

        If round < 5 Then
            lblWind.Text = "东"
        ElseIf round < 9 Then
            lblWind.Text = "南"
        ElseIf round < 13 Then
            lblWind.Text = "西"
        Else
            lblWind.Text = "北"
        End If


        If round Mod 4 = 1 Then
            lblWind1.Text = "东"
            lblWind2.Text = "南"
            lblWind3.Text = "西"
            lblWind4.Text = "北"
            lblWind1.ForeColor = Color.Red
            lblWind2.ForeColor = Color.Blue
            lblWind3.ForeColor = Color.Blue
            lblWind4.ForeColor = Color.Blue
        ElseIf round Mod 4 = 2 Then
            lblWind1.Text = "北"
            lblWind2.Text = "东"
            lblWind3.Text = "南"
            lblWind4.Text = "西"
            lblWind1.ForeColor = Color.Blue
            lblWind2.ForeColor = Color.Red
            lblWind3.ForeColor = Color.Blue
            lblWind4.ForeColor = Color.Blue
        ElseIf round Mod 4 = 3 Then
            lblWind1.Text = "西"
            lblWind2.Text = "北"
            lblWind3.Text = "东"
            lblWind4.Text = "南"
            lblWind1.ForeColor = Color.Blue
            lblWind2.ForeColor = Color.Blue
            lblWind3.ForeColor = Color.Red
            lblWind4.ForeColor = Color.Blue
        Else
            lblWind1.Text = "南"
            lblWind2.Text = "西"
            lblWind3.Text = "北"
            lblWind4.Text = "东"
            lblWind1.ForeColor = Color.Blue
            lblWind2.ForeColor = Color.Blue
            lblWind3.ForeColor = Color.Blue
            lblWind4.ForeColor = Color.Red
        End If

        Dim roundtxt As String = round
        Dim gametxt As String = game
        lblRound.Text = "第 " + roundtxt + " 局"
        lblGame.Text = "第 " + gametxt + " 盘"

        Dim roundprevtxt As String = roundprev
        Dim gameprevtxt As String = gameprev
        Dim moneyprevtxt(4) As String


        moneyprevtxt(1) = moneyprev(1)
        moneyprevtxt(2) = moneyprev(2)
        moneyprevtxt(3) = moneyprev(3)
        moneyprevtxt(4) = moneyprev(4)



        lblhistory.Text = "上一局: " + roundprevtxt & vbNewLine & _
        "上一盘: " + gameprevtxt & vbNewLine & _
"第一脚: $" + moneyprevtxt(1) & vbNewLine & _
"第二脚: $" + moneyprevtxt(2) & vbNewLine & _
"第三脚: $" + moneyprevtxt(3) & vbNewLine & _
"第四脚: $" + moneyprevtxt(4)



        If round = 17 Then

            txtEnd1.Text = money(1)
            txtEnd2.Text = money(2)
            txtEnd3.Text = money(3)
            txtEnd4.Text = money(4)

            lblEnd1.Text = player1 + ": $"
            lblEnd2.Text = player2 + ": $"
            lblEnd3.Text = player3 + ": $"
            lblEnd4.Text = player4 + ": $"


            game = game - 1
            Dim gametxt2 As String
            gametxt2 = game

            lblTotalGame.Text = "总共 " + gametxt2 + " 盘"

            pnlStart.Hide()
            pnlMain.Hide()
            pnlEnd.Show()

            btnExit.Select()

        End If

    End Sub

    Private Sub btnPay11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay11.Click
        playerhu = 1
        pay(gangtai, 0, False)
    End Sub

    Private Sub btnPay12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay12.Click
        playerhu = 1
        pay(angangtai, 0, False)
    End Sub

    Private Sub btnPay21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay21.Click
        playerhu = 2
        pay(gangtai, 0, False)
    End Sub

    Private Sub btnPay22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay22.Click
        playerhu = 2
        pay(angangtai, 0, False)
    End Sub

    Private Sub btnPay31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay31.Click
        playerhu = 3
        pay(gangtai, 0, False)
    End Sub

    Private Sub btnPay32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay32.Click
        playerhu = 3
        pay(angangtai, 0, False)
    End Sub

    Private Sub btnPay41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay41.Click
        playerhu = 4
        pay(gangtai, 0, False)
    End Sub

    Private Sub btnPay42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPay42.Click
        playerhu = 4
        pay(angangtai, 0, False)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        End

    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        history()
        round = round + 1
        game = game + 1
        wind(round)

        frmDice.roundsub(round)
        frmDice.Show()

    End Sub


    Private Sub btnStay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStay.Click

        history()
        round = round
        game = game + 1
        wind(round)

        frmDice.roundsub(round)
        frmDice.Show()

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        game = gameprev
        round = roundprev

        Dim i As Integer = 1

        For i = 1 To 4
            money(i) = moneyprev(i)
            hucounter(i) = hucounterprev(i)
            zahucounter(i) = zahucounterprev(i)
            gangcount(i) = gangcountprev(i)
            diaozengcount(i) = diaozengcountprev(i)
        Next i

        wind(round)

    End Sub

    Private Sub history()
        gameprev = game
        roundprev = round

        Dim i As Integer = 1

        For i = 1 To 4
            moneyprev(i) = money(i)
            hucounterprev(i) = hucounter(i)
            zahucounterprev(i) = zahucounter(i)
            gangcountprev(i) = gangcount(i)
            diaozengcountprev(i) = diaozengcount(i)
        Next i




    End Sub


    Private Sub btnStats1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStats1.Click
        statsout(1)
    End Sub


    Private Sub btnStats2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStats2.Click
        statsout(2)
    End Sub

    Private Sub btnStats3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStats3.Click
        statsout(3)
    End Sub

    Private Sub btnStats4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStats4.Click
        statsout(4)
    End Sub

    Private Sub statsout(ByVal player As Integer)
        frmStats.lblHu.Text = hucounter(player)
        frmStats.lblZaHu.Text = zahucounter(player)
        frmStats.lblGang.Text = gangcount(player)
        frmStats.lblDiao.Text = diaozengcount(player)
        If player = 1 Then
            frmStats.Text = System.Windows.Forms.Application.ProductName + " v" + System.Windows.Forms.Application.ProductVersion + " - " + player1 + " 详细质料"
        ElseIf player = 2 Then
            frmStats.Text = System.Windows.Forms.Application.ProductName + " v" + System.Windows.Forms.Application.ProductVersion + " - " + player2 + " 详细质料"
        ElseIf player = 3 Then
            frmStats.Text = System.Windows.Forms.Application.ProductName + " v" + System.Windows.Forms.Application.ProductVersion + " - " + player3 + " 详细质料"
        ElseIf player = 4 Then
            frmStats.Text = System.Windows.Forms.Application.ProductName + " v" + System.Windows.Forms.Application.ProductVersion + " - " + player4 + " 详细质料"
        End If

        frmStats.Show()

    End Sub

    Private Sub btnGStats1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGStats1.Click
        statsout(1)
    End Sub

    Private Sub btnGStats2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGStats2.Click
        statsout(2)
    End Sub

    Private Sub btnGStats3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGStats3.Click
        statsout(3)
    End Sub

    Private Sub btnGStats4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGStats4.Click
        statsout(4)
    End Sub

    Private Sub btnRollDice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollDice.Click
        frmDice.roundsub(round)
        frmDice.Show()
    End Sub
End Class
