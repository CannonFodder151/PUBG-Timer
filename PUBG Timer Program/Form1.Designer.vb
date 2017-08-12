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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdomute = New System.Windows.Forms.RadioButton()
        Me.rdotrain = New System.Windows.Forms.RadioButton()
        Me.rdoship = New System.Windows.Forms.RadioButton()
        Me.rdoindustrial = New System.Windows.Forms.RadioButton()
        Me.rdoair = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.prbtime = New System.Windows.Forms.ProgressBar()
        Me.lblstat = New System.Windows.Forms.Label()
        Me.lblround = New System.Windows.Forms.Label()
        Me.lbltimemin = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbltimesec = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnstop = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer11 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer12 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer13 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer14 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer15 = New System.Windows.Forms.Timer(Me.components)
        Me.hsbvolume = New System.Windows.Forms.TrackBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnwebsite = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.hsbvolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdomute)
        Me.GroupBox1.Controls.Add(Me.rdotrain)
        Me.GroupBox1.Controls.Add(Me.rdoship)
        Me.GroupBox1.Controls.Add(Me.rdoindustrial)
        Me.GroupBox1.Controls.Add(Me.rdoair)
        Me.GroupBox1.Location = New System.Drawing.Point(538, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(114, 144)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sound"
        '
        'rdomute
        '
        Me.rdomute.AutoSize = True
        Me.rdomute.Location = New System.Drawing.Point(7, 115)
        Me.rdomute.Name = "rdomute"
        Me.rdomute.Size = New System.Drawing.Size(49, 17)
        Me.rdomute.TabIndex = 4
        Me.rdomute.TabStop = True
        Me.rdomute.Text = "Mute"
        Me.rdomute.UseVisualStyleBackColor = True
        '
        'rdotrain
        '
        Me.rdotrain.AutoSize = True
        Me.rdotrain.Location = New System.Drawing.Point(7, 91)
        Me.rdotrain.Name = "rdotrain"
        Me.rdotrain.Size = New System.Drawing.Size(75, 17)
        Me.rdotrain.TabIndex = 3
        Me.rdotrain.TabStop = True
        Me.rdotrain.Text = "Train Horn"
        Me.rdotrain.UseVisualStyleBackColor = True
        '
        'rdoship
        '
        Me.rdoship.AutoSize = True
        Me.rdoship.Location = New System.Drawing.Point(7, 67)
        Me.rdoship.Name = "rdoship"
        Me.rdoship.Size = New System.Drawing.Size(66, 17)
        Me.rdoship.TabIndex = 2
        Me.rdoship.TabStop = True
        Me.rdoship.Text = "Ship Bell"
        Me.rdoship.UseVisualStyleBackColor = True
        '
        'rdoindustrial
        '
        Me.rdoindustrial.AutoSize = True
        Me.rdoindustrial.Location = New System.Drawing.Point(7, 44)
        Me.rdoindustrial.Name = "rdoindustrial"
        Me.rdoindustrial.Size = New System.Drawing.Size(96, 17)
        Me.rdoindustrial.TabIndex = 1
        Me.rdoindustrial.TabStop = True
        Me.rdoindustrial.Text = "Industrial Alarm"
        Me.rdoindustrial.UseVisualStyleBackColor = True
        '
        'rdoair
        '
        Me.rdoair.AutoSize = True
        Me.rdoair.Location = New System.Drawing.Point(7, 20)
        Me.rdoair.Name = "rdoair"
        Me.rdoair.Size = New System.Drawing.Size(63, 17)
        Me.rdoair.TabIndex = 0
        Me.rdoair.TabStop = True
        Me.rdoair.Text = "Air Horn"
        Me.rdoair.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 266)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Start Timer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(12, 296)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 23)
        Me.btnreset.TabIndex = 3
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 326)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "End"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'prbtime
        '
        Me.prbtime.ForeColor = System.Drawing.Color.Honeydew
        Me.prbtime.Location = New System.Drawing.Point(209, 89)
        Me.prbtime.Name = "prbtime"
        Me.prbtime.Size = New System.Drawing.Size(215, 14)
        Me.prbtime.TabIndex = 5
        Me.prbtime.Value = 100
        '
        'lblstat
        '
        Me.lblstat.AutoSize = True
        Me.lblstat.BackColor = System.Drawing.Color.Transparent
        Me.lblstat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstat.Location = New System.Drawing.Point(240, 70)
        Me.lblstat.Name = "lblstat"
        Me.lblstat.Size = New System.Drawing.Size(159, 16)
        Me.lblstat.TabIndex = 6
        Me.lblstat.Text = "Time Untill Field Appears"
        '
        'lblround
        '
        Me.lblround.AutoSize = True
        Me.lblround.BackColor = System.Drawing.Color.Transparent
        Me.lblround.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblround.Location = New System.Drawing.Point(275, 13)
        Me.lblround.Name = "lblround"
        Me.lblround.Size = New System.Drawing.Size(82, 20)
        Me.lblround.TabIndex = 7
        Me.lblround.Text = "Dropping"
        '
        'lbltimemin
        '
        Me.lbltimemin.AutoSize = True
        Me.lbltimemin.BackColor = System.Drawing.Color.Transparent
        Me.lbltimemin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimemin.Location = New System.Drawing.Point(273, 106)
        Me.lbltimemin.Name = "lbltimemin"
        Me.lbltimemin.Size = New System.Drawing.Size(29, 31)
        Me.lbltimemin.TabIndex = 8
        Me.lbltimemin.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 31)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = ":"
        '
        'lbltimesec
        '
        Me.lbltimesec.AutoSize = True
        Me.lbltimesec.BackColor = System.Drawing.Color.Transparent
        Me.lbltimesec.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltimesec.Location = New System.Drawing.Point(308, 106)
        Me.lbltimesec.Name = "lbltimesec"
        Me.lbltimesec.Size = New System.Drawing.Size(44, 31)
        Me.lbltimesec.TabIndex = 10
        Me.lbltimesec.Text = "00"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'btnstop
        '
        Me.btnstop.Location = New System.Drawing.Point(93, 326)
        Me.btnstop.Name = "btnstop"
        Me.btnstop.Size = New System.Drawing.Size(75, 23)
        Me.btnstop.TabIndex = 11
        Me.btnstop.Text = "Stop"
        Me.btnstop.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 1000
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'Timer6
        '
        Me.Timer6.Interval = 1000
        '
        'Timer7
        '
        Me.Timer7.Interval = 1000
        '
        'Timer8
        '
        Me.Timer8.Interval = 1000
        '
        'Timer9
        '
        Me.Timer9.Interval = 1000
        '
        'Timer10
        '
        Me.Timer10.Interval = 1000
        '
        'Timer11
        '
        Me.Timer11.Interval = 1000
        '
        'Timer12
        '
        Me.Timer12.Interval = 1000
        '
        'Timer13
        '
        Me.Timer13.Interval = 1000
        '
        'Timer14
        '
        Me.Timer14.Interval = 1000
        '
        'Timer15
        '
        Me.Timer15.Interval = 1000
        '
        'hsbvolume
        '
        Me.hsbvolume.Location = New System.Drawing.Point(416, 304)
        Me.hsbvolume.Maximum = 1000
        Me.hsbvolume.Minimum = 100
        Me.hsbvolume.Name = "hsbvolume"
        Me.hsbvolume.Size = New System.Drawing.Size(236, 45)
        Me.hsbvolume.TabIndex = 15
        Me.hsbvolume.TickFrequency = 100
        Me.hsbvolume.Value = 500
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(418, 334)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Volume"
        '
        'btnhelp
        '
        Me.btnhelp.Location = New System.Drawing.Point(93, 296)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(75, 23)
        Me.btnhelp.TabIndex = 17
        Me.btnhelp.Text = "Help"
        Me.btnhelp.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(11, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(202, 26)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Please report all crashes and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "time errors to www.pubgtimer.weebly.com"
        '
        'btnwebsite
        '
        Me.btnwebsite.Location = New System.Drawing.Point(93, 266)
        Me.btnwebsite.Name = "btnwebsite"
        Me.btnwebsite.Size = New System.Drawing.Size(75, 23)
        Me.btnwebsite.TabIndex = 20
        Me.btnwebsite.Text = "Bug Report"
        Me.btnwebsite.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(664, 361)
        Me.Controls.Add(Me.btnwebsite)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.hsbvolume)
        Me.Controls.Add(Me.btnstop)
        Me.Controls.Add(Me.lbltimesec)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltimemin)
        Me.Controls.Add(Me.lblround)
        Me.Controls.Add(Me.lblstat)
        Me.Controls.Add(Me.prbtime)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Playerzone Timer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.hsbvolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents prbtime As ProgressBar
    Friend WithEvents lblstat As Label
    Friend WithEvents lblround As Label
    Friend WithEvents lbltimemin As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbltimesec As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnstop As Button
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Timer10 As Timer
    Friend WithEvents Timer11 As Timer
    Friend WithEvents Timer12 As Timer
    Friend WithEvents Timer13 As Timer
    Friend WithEvents Timer14 As Timer
    Friend WithEvents Timer15 As Timer
    Friend WithEvents rdomute As RadioButton
    Friend WithEvents rdotrain As RadioButton
    Friend WithEvents rdoship As RadioButton
    Friend WithEvents rdoindustrial As RadioButton
    Friend WithEvents rdoair As RadioButton
    Friend WithEvents hsbvolume As TrackBar
    Friend WithEvents Label2 As Label
    Friend WithEvents btnhelp As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnwebsite As Button
End Class
