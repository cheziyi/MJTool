<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStats
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStats))
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblGang = New System.Windows.Forms.Label
        Me.lblZaHu = New System.Windows.Forms.Label
        Me.lblDiao = New System.Windows.Forms.Label
        Me.lblHu = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SimHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "咬到 / 杠:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SimHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(128, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "炸胡:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "钓莊:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("SimHei", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(156, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "胡:"
        '
        'lblGang
        '
        Me.lblGang.AutoSize = True
        Me.lblGang.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGang.Location = New System.Drawing.Point(216, 31)
        Me.lblGang.Name = "lblGang"
        Me.lblGang.Size = New System.Drawing.Size(29, 31)
        Me.lblGang.TabIndex = 5
        Me.lblGang.Text = "0"
        '
        'lblZaHu
        '
        Me.lblZaHu.AutoSize = True
        Me.lblZaHu.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZaHu.Location = New System.Drawing.Point(216, 156)
        Me.lblZaHu.Name = "lblZaHu"
        Me.lblZaHu.Size = New System.Drawing.Size(29, 31)
        Me.lblZaHu.TabIndex = 6
        Me.lblZaHu.Text = "0"
        '
        'lblDiao
        '
        Me.lblDiao.AutoSize = True
        Me.lblDiao.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiao.Location = New System.Drawing.Point(216, 118)
        Me.lblDiao.Name = "lblDiao"
        Me.lblDiao.Size = New System.Drawing.Size(29, 31)
        Me.lblDiao.TabIndex = 7
        Me.lblDiao.Text = "0"
        '
        'lblHu
        '
        Me.lblHu.AutoSize = True
        Me.lblHu.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHu.Location = New System.Drawing.Point(216, 82)
        Me.lblHu.Name = "lblHu"
        Me.lblHu.Size = New System.Drawing.Size(29, 31)
        Me.lblHu.TabIndex = 8
        Me.lblHu.Text = "0"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(87, 228)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(167, 53)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "关"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 329)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblHu)
        Me.Controls.Add(Me.lblDiao)
        Me.Controls.Add(Me.lblZaHu)
        Me.Controls.Add(Me.lblGang)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStats"
        Me.Text = "frmStats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblGang As System.Windows.Forms.Label
    Friend WithEvents lblZaHu As System.Windows.Forms.Label
    Friend WithEvents lblDiao As System.Windows.Forms.Label
    Friend WithEvents lblHu As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
