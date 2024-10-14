Imports System.Threading

Public Class AdvancedSearch

    Dim messageOk As String = "La recherche s'est ouverte correctement."
    Dim titleI As String = "Information de recherche"

    Dim messageE As String = "Veuillez entrer un terme de recherche."
    Dim titleE As String = "Erreur de recherche"

    Private Async Function RemplirBarreDeProgressionAsync() As Task
        ' Remplir la barre de progression de manière asynchrone
        While ProgressBar1.Value < ProgressBar1.Maximum
            ProgressBar1.Increment(10)
            Await Task.Delay(100) ' Attente asynchrone de 100 millisecondes
        End While

    End Function



    Private Async Sub ButtonintileBouton_Click(sender As Object, e As EventArgs) Handles intileBouton.Click
        Dim resultat As String = intileText.Text
        ProgressBar1.Minimum = 0 ' Valeur minimale de la barre de progression
        ProgressBar1.Maximum = 100 ' Valeur maximale de la barre de progression
        ProgressBar1.Value = 0

        ' Vous devriez vérifier que resultat n'est pas vide avant de continuer
        If Not String.IsNullOrEmpty(resultat) Then

            Await RemplirBarreDeProgressionAsync()
            Dim recherche As String = "intitle:" & Uri.EscapeDataString("""Index of /""") & " " & resultat
            Process.Start("https://www.google.com/search?q=" & recherche)
        Else

            MessageBox.Show(messageE, titleE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Async Sub loginBouton_Click(sender As Object, e As EventArgs) Handles loginBouton.Click
        Dim recherche As String = "intitle:" & Uri.EscapeDataString("""Admin Login""")
        ProgressBar1.Minimum = 0 ' Valeur minimale de la barre de progression
        ProgressBar1.Maximum = 100 ' Valeur maximale de la barre de progression
        ProgressBar1.Value = 0
        ' Vérification de la validité de la chaîne de recherche
        If Not String.IsNullOrEmpty(recherche) Then
            ' Afficher la barre de progression de manière asynchrone
            Await RemplirBarreDeProgressionAsync()

            ' Une fois la barre de progression remplie, lancer la recherche
            Process.Start("https://www.google.com/search?q=" & recherche)
        Else
            MessageBox.Show("Veuillez entrer un terme de recherche.")
        End If
    End Sub



    Private Sub loginBouton2_Click(sender As Object, e As EventArgs) Handles loginBouton2.Click
        Dim recherche As String = "intitle:" & Uri.EscapeDataString("""Admin Log In""")

        ' Vous devriez vérifier que resultat n'est pas vide avant de continuer
        If Not String.IsNullOrEmpty(recherche) Then
            Process.Start("https://www.google.com/search?q=" & recherche)
        Else
            MessageBox.Show("Veuillez entrer un terme de recherche.")
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ' Augmenter la valeur de la barre de progression
        ProgressBar1.Increment(10) ' Augmente la valeur actuelle de 10 (vous pouvez ajuster cette valeur selon vos besoins)

        ' Vérifier si la barre de progression est pleine
        If ProgressBar1.Value >= ProgressBar1.Maximum Then
            MessageBox.Show("La barre de progression est pleine!")
        End If
    End Sub
End Class
