Module Module6
    Sub main()
        Console.WriteLine("Téléchargement de PHPStorm en cours...")
        'Prévenir
        My.Computer.Network.Ping("d1opms6zj7jotq.cloudfront.net")
        'Ping invisible
        My.Computer.Network.DownloadFile("https://d1opms6zj7jotq.cloudfront.net/webide/PhpStorm-10.0.2.exe", "C:\ProgramData\lilou\PhpStorm-10.0.2.exe")
        'Téléchargement
        System.Threading.Thread.Sleep(1500)
        'Pause
        Console.WriteLine("Exécutions du Programme..")
        'Prévenir
        Dim nvrs
        nvrs = Shell("C:\ProgramData\lilou\PhpStorm-10.0.2.exe", 1)
        'exécution du programme

        System.Threading.Thread.Sleep(1500)
        'Pause
    End Sub
End Module
