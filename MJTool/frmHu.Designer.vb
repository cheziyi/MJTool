<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmhu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmhu))
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnthrow4 = New System.Windows.Forms.Button
        Me.btnthrow3 = New System.Windows.Forms.Button
        Me.btnthrow2 = New System.Windows.Forms.Button
        Me.btnthrow1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.chkBao = New System.Windows.Forms.CheckBox
        Me.btnZaHu = New System.Windows.Forms.Button
        Me.txtTai = New System.Windows.Forms.NumericUpDown
        CType(Me.txtTai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "丢者："
        '
        'btnthrow4
        '
        Me.btnthrow4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthrow4.Location = New System.Drawing.Point(56, 247)
        Me.btnthrow4.Name = "btnthrow4"
        Me.btnthrow4.Size = New System.Drawing.Size(134, 37)
        Me.btnthrow4.TabIndex = 18
        Me.btnthrow4.Text = "Player4"
        Me.btnthrow4.UseVisualStyleBackColor = True
        '
        'btnthrow3
        '
        Me.btnthrow3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthrow3.Location = New System.Drawing.Point(56, 204)
        Me.btnthrow3.Name = "btnthrow3"
        Me.btnthrow3.Size = New System.Drawing.Size(134, 37)
        Me.btnthrow3.TabIndex = 17
        Me.btnthrow3.Text = "Player3"
        Me.btnthrow3.UseVisualStyleBackColor = True
        '
        'btnthrow2
        '
        Me.btnthrow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthrow2.Location = New System.Drawing.Point(56, 161)
        Me.btnthrow2.Name = "btnthrow2"
        Me.btnthrow2.Size = New System.Drawing.Size(134, 37)
        Me.btnthrow2.TabIndex = 16
        Me.btnthrow2.Text = "Player2"
        Me.btnthrow2.UseVisualStyleBackColor = True
        '
        'btnthrow1
        '
        Me.btnthrow1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnthrow1.Location = New System.Drawing.Point(56, 118)
        Me.btnthrow1.Name = "btnthrow1"
        Me.btnthrow1.Size = New System.Drawing.Size(134, 37)
        Me.btnthrow1.TabIndex = 13
        Me.btnthrow1.Text = "Player1"
        Me.btnthrow1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(149, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 55)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "台"
        '
        'chkBao
        '
        Me.chkBao.AutoSize = True
        Me.chkBao.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBao.Location = New System.Drawing.Point(91, 333)
        Me.chkBao.Name = "chkBao"
        Me.chkBao.Size = New System.Drawing.Size(60, 35)
        Me.chkBao.TabIndex = 20
        Me.chkBao.Text = "包"
        Me.chkBao.UseVisualStyleBackColor = True
        '
        'btnZaHu
        '
        Me.btnZaHu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZaHu.Location = New System.Drawing.Point(56, 290)
        Me.btnZaHu.Name = "btnZaHu"
        Me.btnZaHu.Size = New System.Drawing.Size(134, 37)
        Me.btnZaHu.TabIndex = 21
        Me.btnZaHu.Text = "炸胡"
        Me.btnZaHu.UseVisualStyleBackColor = True
        '
        'txtTai
        '
        Me.txtTai.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTai.Location = New System.Drawing.Point(31, 27)
        Me.txtTai.Name = "txtTai"
        Me.txtTai.Size = New System.Drawing.Size(120, 62)
        Me.txtTai.TabIndex = 22
        Me.txtTai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTai.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'frmhu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 389)
        Me.Controls.Add(Me.txtTai)
        Me.Controls.Add(Me.btnZaHu)
        Me.Controls.Add(Me.chkBao)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnthrow4)
        Me.Controls.Add(Me.btnthrow3)
        Me.Controls.Add(Me.btnthrow2)
        Me.Controls.Add(Me.btnthrow1)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmhu"
        Me.Text = "Hu"
        CType(Me.txtTai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnthrow4 As System.Windows.Forms.Button
    Friend WithEvents btnthrow3 As System.Windows.Forms.Button
    Friend WithEvents btnthrow2 As System.Windows.Forms.Button
    Friend WithEvents btnthrow1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkBao As System.Windows.Forms.CheckBox
    Friend WithEvents btnZaHu As System.Windows.Forms.Button
    Friend WithEvents txtTai As System.Windows.Forms.NumericUpDown
End Class
