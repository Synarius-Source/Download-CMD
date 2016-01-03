Module Module2
    Sub Main()
        My.Computer.FileSystem.CreateDirectory("C:\ProgramData\lilou\")
        'Création
        'Console.WriteLine("Je vais te crée un répertoire Logiciel dans ton disque C:\...")
        'Prévenir
        System.Threading.Thread.Sleep(500)
        'Pause
        Console.WriteLine("Téléchargement de UwAmp en cours...")
        'Prévenir
        My.Computer.Network.Ping("uwamp.com")
        'Ping invisible
        System.Threading.Thread.Sleep(500)
        'Pause
        My.Computer.Network.DownloadFile("http://www.uwamp.com/file/UwAmp.exe", "C:\ProgramData\lilou\UwAmp_3.0.1.exe")
        'Téléchargement
        Console.WriteLine("Exécutions du Programme..")
        'Prévenir
        Dim RetVal
        RetVal = Shell("C:\ProgramData\lilou\\UwAmp_3.0.1.exe", 1)
        'exécution du programme
        MsgBox("Uwamp vous permet d'accèder à vos site en local")
        System.Threading.Thread.Sleep(1500)
        Console.WriteLine("Lancement de UwAmp...")
        'Prévenir
        Dim nvss
        nvss = Shell("C:\UwAmp\UwAmp.exe", 1)
        'exécution du programme
        Try
            System.Threading.Thread.Sleep(1500)
            System.Diagnostics.Process.Start("http://127.0.0.1/")
        Catch
            MsgBox("Bienvenu sur votre Website")
            'Localhost
        End Try
        'Pause
    End Sub
End Module
