Module Module5
    Sub main()
        Console.WriteLine("Téléchargement de FileZilla en cours...")
        'Prévenir
        My.Computer.Network.Ping("skylink.dl.sourceforge.net")
        'Ping invisible
        My.Computer.Network.DownloadFile("http://skylink.dl.sourceforge.net/project/filezilla/FileZilla_Client/3.14.1/FileZilla_3.14.1_win64-setup.exe", "C:\ProgramData\lilou\FileZilla_3.14.1_win64-setup.exe")
        'Téléchargement
        System.Threading.Thread.Sleep(1500)
        'Pause
        Console.WriteLine("Exécutions du Programme..")
        'Prévenir
        Dim nvr
        nvr = Shell("C:\ProgramData\lilou\FileZilla_3.14.1_win64-setup.exe", 1)
        MsgBox("Permet de transfèrer vos site sur un hébergeur Web en FTP")
        'exécution du programme
        System.Threading.Thread.Sleep(1500)
    End Sub
End Module
