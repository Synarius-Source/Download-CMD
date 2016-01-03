Public Class Form1

    Private Property objFSO As Object


    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Show()

        Module1.Main()


    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs)
    End Sub

    Private Sub Label1_Click_1(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As System.Object, e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
       
        MsgBox("Téléchargement de UWAMP")
        Module2.Main()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("Téléchargement de Navicat")
        Module3.Main()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Me.Close()



    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        MsgBox("Téléchargement de Notepad")


        Module4.main()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click

        MsgBox("Téléchargement de Filezilla")
        ConsoleApplication1.Module5.main()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        MsgBox("Téléchargement de PHPStorm")
        ConsoleApplication1.Module6.main()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        MsgBox("Suppression des fichiers temporaires")
        objFSO = CreateObject("Scripting.FileSystemObject")
        objFSO.DeleteFolder("C:\ProgramData\lilou")
        System.Threading.Thread.Sleep(1500)
        MsgBox("Celà peut mettre du temps")
        ' My.Computer.FileSystem.RenameDirectory("C:\ProgramData\lilou",
        '"lilou2")

        'sUPP tous les fichiers
        
    End Sub

    






    Public Sub Button8_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class


