Public Class Form2

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim Npp
        Npp = Shell("C:\Program Files (x86)\Notepad++\notepad++.exe", 1)
        'exécution du programme
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Dim myProcesses() As Process
        Dim myProcess As Process
        ' Returns array containing all instances of "Notepad".
        myProcesses = Process.GetProcessesByName("notepad++.exe*32")
        For Each myProcess In myProcesses
            myProcess.CloseMainWindow()
        Next
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim Npp
        Npp = Shell("C:\UwAmp\bin\apache\bin\httpd.exe", 1)
        'exécution du programme
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim myProcesses() As Process
        Dim myProcess As Process
        ' Returns array containing all instances of "Notepad".
        myProcesses = Process.GetProcessesByName("httpd.exe*32")
        myProcesses = Process.GetProcessesByName("httpd.exe*32")
        For Each myProcess In myProcesses
            myProcess.CloseMainWindow()
        Next
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Dim myProcesses() As Process
        Dim myProcess As Process
        ' Returns array containing all instances of "Notepad".
        myProcesses = Process.GetProcessesByName("mysqld.exe*32")
        For Each myProcess In myProcesses
            myProcess.CloseMainWindow()
        Next
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Dim Npp
        Npp = Shell("C:\UwAmp\bin\database\mysql-5.6.20\bin\mysqld.exe", 1)
        'exécution du programme
    End Sub
End Class