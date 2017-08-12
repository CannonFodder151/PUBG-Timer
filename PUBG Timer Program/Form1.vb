Public Class Form1

    'This program assists you in PUBG by providing a countdown for the player zone


    Dim totaltime, timemin, timesec, volume As Integer
    Dim sound As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("This program is not fully complete and the does volume not work at this point in time, however all other functions of this program are working, in this version mute does work.")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        lblround.Text = "Dropping"
        lblstat.Text = "Time Untill Field Appears"
        lbltimemin.Text = "0"
        lbltimesec.Text = "00"


        totaltime = 120

        Timer1.Enabled = True


        If sound = 1 Then
            My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
        ElseIf sound = 2 Then
            My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
        ElseIf sound = 3 Then
            My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
        ElseIf sound = 4 Then
            My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
        Else

        End If



    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click

        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        Timer5.Enabled = False
        Timer6.Enabled = False
        Timer7.Enabled = False
        Timer8.Enabled = False
        Timer9.Enabled = False
        Timer10.Enabled = False
        Timer11.Enabled = False
        Timer12.Enabled = False
        Timer13.Enabled = False
        Timer14.Enabled = False
        Timer15.Enabled = False

        lblround.Text = "Dropping"
        lblstat.Text = "Time Untill Field Appears"
        lbltimemin.Text = "0"
        lbltimesec.Text = "00"

        totaltime = 120
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'This handels the countdown for the zones

        If totaltime > 0 Then
            prbtime.Maximum = 120
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer1.Enabled = False
            totaltime = 300
            Timer2.Enabled = True
            lblround.Text = "Round 1"
            lblstat.Text = "Time untill the circle starts closing"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If


        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        If totaltime > 0 Then
            prbtime.Maximum = 300
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer2.Enabled = False
            totaltime = 300
            Timer3.Enabled = True
            lblround.Text = "Round 1"
            lblstat.Text = "Time untill the circle is closed"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 300
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer3.Enabled = False
            totaltime = 200
            Timer4.Enabled = True
            lblround.Text = "Round 2"
            lblstat.Text = "Time untill the circle starts closing"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 200
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer4.Enabled = False
            totaltime = 140
            Timer5.Enabled = True
            lblround.Text = "Round 2"
            lblstat.Text = "Time untill the circle is closed"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 140
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer5.Enabled = False
            totaltime = 150
            Timer6.Enabled = True
            lblround.Text = "Round 3"
            lblstat.Text = "Time untill the circle starts closing"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 150
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer6.Enabled = False
            totaltime = 90
            Timer7.Enabled = True
            lblround.Text = "Round 3"
            lblstat.Text = "Time untill the circle is closed"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 90
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer7.Enabled = False
            totaltime = 120
            Timer8.Enabled = True
            lblround.Text = "Round 4"
            lblstat.Text = "Time untill the circle starts closing"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 120
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer8.Enabled = False
            totaltime = 60
            Timer9.Enabled = True
            lblround.Text = "Round 4"
            lblstat.Text = "Time untill the circle is closed"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 60
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer9.Enabled = False
            totaltime = 120
            Timer10.Enabled = True
            lblround.Text = "Round 5"
            lblstat.Text = "Time untill the circle starts closing"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 120
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer10.Enabled = False
            totaltime = 40
            Timer11.Enabled = True
            lblround.Text = "Round 5"
            lblstat.Text = "Time untill the circle is closed"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 40
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer11.Enabled = False
            totaltime = 90
            Timer12.Enabled = True
            lblround.Text = "Round 6"
            lblstat.Text = "Time untill the circle starts closing"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 90
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer12.Enabled = False
            totaltime = 30
            Timer13.Enabled = True
            lblround.Text = "Round 6"
            lblstat.Text = "Time untill the circle is closed"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 30
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer13.Enabled = False
            totaltime = 90
            Timer14.Enabled = True
            lblround.Text = "Round 7"
            lblstat.Text = "Time untill the circle starts closing"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 90
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer14.Enabled = False
            totaltime = 20
            Timer15.Enabled = True
            lblround.Text = "Round 7"
            lblstat.Text = "Time untill the circle is closed"
        End If

        If totaltime = 0 Then
            If sound = 1 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 2 Then
                My.Computer.Audio.Play(My.Resources.air_horn, AudioPlayMode.Background)
            ElseIf sound = 3 Then
                My.Computer.Audio.Play(My.Resources.ship_bell, AudioPlayMode.Background)
            ElseIf sound = 4 Then
                My.Computer.Audio.Play(My.Resources.train_horn, AudioPlayMode.Background)
            Else
            End If
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub

    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        If totaltime > 0 Then
            prbtime.Maximum = 20
            totaltime -= 1
            prbtime.Value = totaltime
        Else
            Timer15.Enabled = False
            lblround.Text = "End Game"
            lblstat.Text = "Good Luck"
        End If

        If totaltime > 60 Then
            timemin = (totaltime Mod 3600) \ 60
        Else
            timemin = 0
        End If

        timesec = totaltime - (timemin * 60)

        lbltimemin.Text = timemin
        lbltimesec.Text = timesec
    End Sub


    Private Sub rdoair_CheckedChanged(sender As Object, e As EventArgs) Handles rdoair.CheckedChanged
        hsbvolume.Enabled = True
        sound = 1
    End Sub

    Private Sub rdoindustrial_CheckedChanged(sender As Object, e As EventArgs) Handles rdoindustrial.CheckedChanged
        hsbvolume.Enabled = True
        sound = 2
    End Sub

    Private Sub rdoship_CheckedChanged(sender As Object, e As EventArgs) Handles rdoship.CheckedChanged
        hsbvolume.Enabled = True
        sound = 3
    End Sub

    Private Sub hsbvolume_Scroll(sender As Object, e As EventArgs) Handles hsbvolume.Scroll

    End Sub

    Private Sub btnhelp_Click(sender As Object, e As EventArgs) Handles btnhelp.Click
        MsgBox("To use this program simply press 'start timer' as soon as the aircraft appears on screen, you may change the sound anytime during the program running.")
    End Sub

    Private Sub rdomute_CheckedChanged(sender As Object, e As EventArgs) Handles rdomute.CheckedChanged
        hsbvolume.Enabled = False
        sound = 5
    End Sub

    Private Sub btnwebsite_Click(sender As Object, e As EventArgs) Handles btnwebsite.Click
        Try
            System.Diagnostics.Process.Start("http://pubgtimer.weebly.com/bug-repoting.html")
        Catch
            'Code to handle the error.
        End Try
    End Sub

    Private Sub rdotrain_CheckedChanged(sender As Object, e As EventArgs) Handles rdotrain.CheckedChanged
        hsbvolume.Enabled = True
        sound = 4
    End Sub

    Private Sub btnstop_Click(sender As Object, e As EventArgs) Handles btnstop.Click
        Timer1.Enabled = False
        Timer2.Enabled = False
        Timer3.Enabled = False
        Timer4.Enabled = False
        Timer5.Enabled = False
        Timer6.Enabled = False
        Timer7.Enabled = False
        Timer8.Enabled = False
        Timer9.Enabled = False
        Timer10.Enabled = False
        Timer11.Enabled = False
        Timer12.Enabled = False
        Timer13.Enabled = False
        Timer14.Enabled = False
        Timer15.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
