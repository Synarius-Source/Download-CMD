Module Module3
    Sub Main()

        Console.WriteLine("Téléchargement de Navicat en cours...")
        'Prévenir
        My.Computer.Network.Ping("download3.navicat.com")
        'Ping invisible
        System.Threading.Thread.Sleep(500)
        'Pause
        My.Computer.Network.DownloadFile("http://download3.navicat.com/download/navicat111_premium_fr_x86.exe", "C:\ProgramData\lilou\navicat111_premium_fr_x86.exe")
        'Téléchargement
        Console.WriteLine("Exécutions du Programme..")
        'Prévenir
        Dim nv
        nv = Shell("C:\ProgramData\lilou\navicat111_premium_fr_x86.exe", 1)
        MsgBox("Permet de se connecter à votre base MySQL")
        'exécution du programme
        System.Threading.Thread.Sleep(1500)
        'Pause

    End Sub

End Module
