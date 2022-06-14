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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.jjk = New System.Windows.Forms.TextBox()
        Me.jl = New System.Windows.Forms.TextBox()
        Me.jth = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gaji = New System.Windows.Forms.Label()
        Me.makan = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perhitungan Gaji Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Jml jam kerja :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Jml lembur : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jml tidak hadir : "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 182)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Hitung"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'jjk
        '
        Me.jjk.Location = New System.Drawing.Point(113, 64)
        Me.jjk.Name = "jjk"
        Me.jjk.Size = New System.Drawing.Size(100, 20)
        Me.jjk.TabIndex = 5
        '
        'jl
        '
        Me.jl.Location = New System.Drawing.Point(113, 107)
        Me.jl.Name = "jl"
        Me.jl.Size = New System.Drawing.Size(100, 20)
        Me.jl.TabIndex = 6
        '
        'jth
        '
        Me.jth.Location = New System.Drawing.Point(113, 144)
        Me.jth.Name = "jth"
        Me.jth.Size = New System.Drawing.Size(100, 20)
        Me.jth.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(231, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total gaji :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(231, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Uang makan :"
        '
        'gaji
        '
        Me.gaji.AutoSize = True
        Me.gaji.Location = New System.Drawing.Point(305, 64)
        Me.gaji.Name = "gaji"
        Me.gaji.Size = New System.Drawing.Size(10, 13)
        Me.gaji.TabIndex = 10
        Me.gaji.Text = "-"
        '
        'makan
        '
        Me.makan.AutoSize = True
        Me.makan.Location = New System.Drawing.Point(305, 95)
        Me.makan.Name = "makan"
        Me.makan.Size = New System.Drawing.Size(10, 13)
        Me.makan.TabIndex = 11
        Me.makan.Text = "-"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 261)
        Me.Controls.Add(Me.makan)
        Me.Controls.Add(Me.gaji)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.jth)
        Me.Controls.Add(Me.jl)
        Me.Controls.Add(Me.jjk)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents jjk As System.Windows.Forms.TextBox
    Friend WithEvents jl As System.Windows.Forms.TextBox
    Friend WithEvents jth As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gaji As System.Windows.Forms.Label
    Friend WithEvents makan As System.Windows.Forms.Label

End Class
