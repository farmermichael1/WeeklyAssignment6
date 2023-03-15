<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbTitle = New System.Windows.Forms.Label()
        Me.lsbInternet = New System.Windows.Forms.ListBox()
        Me.btnSpeed = New System.Windows.Forms.Button()
        Me.lbSpeed = New System.Windows.Forms.Label()
        Me.lbAverage = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitle.Location = New System.Drawing.Point(304, 47)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(345, 31)
        Me.lbTitle.TabIndex = 0
        Me.lbTitle.Text = "Internet Speed Test Survey"
        '
        'lsbInternet
        '
        Me.lsbInternet.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsbInternet.FormattingEnabled = True
        Me.lsbInternet.ItemHeight = 25
        Me.lsbInternet.Location = New System.Drawing.Point(632, 99)
        Me.lsbInternet.Name = "lsbInternet"
        Me.lsbInternet.Size = New System.Drawing.Size(132, 154)
        Me.lsbInternet.TabIndex = 1
        '
        'btnSpeed
        '
        Me.btnSpeed.Location = New System.Drawing.Point(376, 99)
        Me.btnSpeed.Name = "btnSpeed"
        Me.btnSpeed.Size = New System.Drawing.Size(192, 47)
        Me.btnSpeed.TabIndex = 2
        Me.btnSpeed.Text = "Enter Internet Speed"
        Me.btnSpeed.UseVisualStyleBackColor = True
        '
        'lbSpeed
        '
        Me.lbSpeed.AutoSize = True
        Me.lbSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSpeed.Location = New System.Drawing.Point(448, 379)
        Me.lbSpeed.Name = "lbSpeed"
        Me.lbSpeed.Size = New System.Drawing.Size(179, 20)
        Me.lbSpeed.TabIndex = 3
        Me.lbSpeed.Text = "Average Internet Speed"
        '
        'lbAverage
        '
        Me.lbAverage.AutoSize = True
        Me.lbAverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAverage.Location = New System.Drawing.Point(664, 379)
        Me.lbAverage.Name = "lbAverage"
        Me.lbAverage.Size = New System.Drawing.Size(57, 20)
        Me.lbAverage.TabIndex = 4
        Me.lbAverage.Text = "Label3"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WeeklyAssignment6.My.Resources.Resources.speed
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(766, 451)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbAverage)
        Me.Controls.Add(Me.lbSpeed)
        Me.Controls.Add(Me.btnSpeed)
        Me.Controls.Add(Me.lsbInternet)
        Me.Controls.Add(Me.lbTitle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Internet Speed Test Survey for Home Users"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbTitle As Label
    Friend WithEvents lsbInternet As ListBox
    Friend WithEvents btnSpeed As Button
    Friend WithEvents lbSpeed As Label
    Friend WithEvents lbAverage As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
