Public Class frmhu

    Dim tai As Integer

    Private Sub frmhu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = System.Windows.Forms.Application.ProductName + " v" + System.Windows.Forms.Application.ProductVersion + " - 胡"
    End Sub

    Private Sub btnthrow1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthrow1.Click
        frmMain.pay(txtTai.Text, 1, chkBao.Checked)
        Me.Close()
        frmDice.Show()
    End Sub


    Private Sub btnthrow2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthrow2.Click
        frmMain.pay(txtTai.Text, 2, chkBao.Checked)
        Me.Close()
        frmDice.Show()
    End Sub

    Private Sub btnthrow3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthrow3.Click
        frmMain.pay(txtTai.Text, 3, chkBao.Checked)
        Me.Close()
        frmDice.Show()
    End Sub

    Private Sub btnthrow4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnthrow4.Click
        frmMain.pay(txtTai.Text, 4, chkBao.Checked)
        Me.Close()
        frmDice.Show()
    End Sub

    Private Sub btnZaHu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnZaHu.Click
        frmMain.pay(txtTai.Text, 5, False)
        Me.Close()
        frmDice.Show()
    End Sub

    Private Sub chkBao_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBao.CheckedChanged

        If chkBao.Checked = True Then
            If btnthrow1.Text = "自摸" Then
                btnthrow1.Enabled = False
            End If
            If btnthrow2.Text = "自摸" Then
                btnthrow2.Enabled = False
            End If
            If btnthrow3.Text = "自摸" Then
                btnthrow3.Enabled = False
            End If
            If btnthrow4.Text = "自摸" Then
                btnthrow4.Enabled = False
            End If
            btnZaHu.Enabled = False
        Else
            btnthrow1.Enabled = True
            btnthrow2.Enabled = True
            btnthrow3.Enabled = True
            btnthrow4.Enabled = True
            btnZaHu.Enabled = True
        End If

    End Sub
End Class