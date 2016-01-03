Module Module4
    Sub main()
        Console.WriteLine("Téléchargement de Notepead ++ en cours...")
        'Prévenir
        My.Computer.Network.Ping("notepad-plus-plus.org")
        'Ping invisible
        System.Threading.Thread.Sleep(500)
        'Pause
        My.Computer.Network.DownloadFile("https://notepad-plus-plus.org/repository/6.x/6.8.8/npp.6.8.8.Installer.exe", "C:\ProgramData\lilou\npp.6.8.8.Installer.exe")
        'Téléchargement
        Console.WriteLine("Exécutions du Programme..")
        'Prévenir
        Dim Npp
        Npp = Shell("C:\ProgramData\lilou\npp.6.8.8.Installer.exe", 1)
        'exécution du programme
        MsgBox("Permet d'éditer vos fichier html php etc...")
        System.Threading.Thread.Sleep(1500)
        'Pause
    End Sub

    

End Module
