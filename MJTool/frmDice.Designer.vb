<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDice
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDice))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnRoll = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblRemain = New System.Windows.Forms.Label
        Me.lblPlayer = New System.Windows.Forms.Label
        Me.lblWall = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.picDice3 = New System.Windows.Forms.PictureBox
        Me.picDice2 = New System.Windows.Forms.PictureBox
        Me.picDice1 = New System.Windows.Forms.PictureBox
        Me.btnReRoll = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picDice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDice1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnRoll)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-7, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 526)
        Me.Panel1.TabIndex = 0
        '
        'btnRoll
        '
        Me.btnRoll.Font = New System.Drawing.Font("SimHei", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoll.Location = New System.Drawing.Point(273, 366)
        Me.btnRoll.Name = "btnRoll"
        Me.btnRoll.Size = New System.Drawing.Size(234, 68)
        Me.btnRoll.TabIndex = 1
        Me.btnRoll.Text = "掷骰子"
        Me.btnRoll.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(234, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(312, 242)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.btnReRoll)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblRemain)
        Me.Panel2.Controls.Add(Me.lblPlayer)
        Me.Panel2.Controls.Add(Me.lblWall)
        Me.Panel2.Controls.Add(Me.lblTotal)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.picDice3)
        Me.Panel2.Controls.Add(Me.picDice2)
        Me.Panel2.Controls.Add(Me.picDice1)
        Me.Panel2.Location = New System.Drawing.Point(-7, -4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(780, 526)
        Me.Panel2.TabIndex = 1
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("SimHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(396, 416)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(167, 53)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "关"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SimHei", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(321, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 37)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "剩"
        '
        'lblRemain
        '
        Me.lblRemain.AutoSize = True
        Me.lblRemain.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemain.Location = New System.Drawing.Point(383, 328)
        Me.lblRemain.Name = "lblRemain"
        Me.lblRemain.Size = New System.Drawing.Size(80, 55)
        Me.lblRemain.TabIndex = 8
        Me.lblRemain.Text = "10"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = True
        Me.lblPlayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer.Location = New System.Drawing.Point(383, 258)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(157, 55)
        Me.lblPlayer.TabIndex = 7
        Me.lblPlayer.Text = "(XXX)"
        '
        'lblWall
        '
        Me.lblWall.AutoSize = True
        Me.lblWall.Font = New System.Drawing.Font("SimHei", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWall.Location = New System.Drawing.Point(282, 270)
        Me.lblWall.Name = "lblWall"
        Me.lblWall.Size = New System.Drawing.Size(95, 37)
        Me.lblWall.TabIndex = 6
        Me.lblWall.Text = "墙墙"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(383, 194)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(80, 55)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "16"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimHei", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(282, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "总共"
        '
        'picDice3
        '
        Me.picDice3.BackColor = System.Drawing.Color.DarkGray
        Me.picDice3.Location = New System.Drawing.Point(452, 52)
        Me.picDice3.Name = "picDice3"
        Me.picDice3.Size = New System.Drawing.Size(111, 111)
        Me.picDice3.TabIndex = 3
        Me.picDice3.TabStop = False
        '
        'picDice2
        '
        Me.picDice2.BackColor = System.Drawing.Color.DarkGray
        Me.picDice2.Location = New System.Drawing.Point(335, 52)
        Me.picDice2.Name = "picDice2"
        Me.picDice2.Size = New System.Drawing.Size(111, 111)
        Me.picDice2.TabIndex = 2
        Me.picDice2.TabStop = False
        '
        'picDice1
        '
        Me.picDice1.BackColor = System.Drawing.Color.DarkGray
        Me.picDice1.Location = New System.Drawing.Point(218, 52)
        Me.picDice1.Name = "picDice1"
        Me.picDice1.Size = New System.Drawing.Size(111, 111)
        Me.picDice1.TabIndex = 1
        Me.picDice1.TabStop = False
        '
        'btnReRoll
        '
        Me.btnReRoll.Font = New System.Drawing.Font("SimHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReRoll.Location = New System.Drawing.Point(218, 416)
        Me.btnReRoll.Name = "btnReRoll"
        Me.btnReRoll.Size = New System.Drawing.Size(167, 53)
        Me.btnReRoll.TabIndex = 17
        Me.btnReRoll.Text = "重掷"
        Me.btnReRoll.UseVisualStyleBackColor = True
        '
        'frmDice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDice"
        Me.Text = "Dice"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.picDice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDice1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRoll As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents picDice3 As System.Windows.Forms.PictureBox
    Friend WithEvents picDice2 As System.Windows.Forms.PictureBox
    Friend WithEvents picDice1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblPlayer As System.Windows.Forms.Label
    Friend WithEvents lblWall As System.Windows.Forms.Label
    Friend WithEvents lblRemain As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReRoll As System.Windows.Forms.Button
End Class
