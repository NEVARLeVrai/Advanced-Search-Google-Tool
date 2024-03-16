Public Class AdvancedSearch
    Dim messageOk As String = "La recherche s'est ouverte correctement."
    Dim titleI As String = "Information de recherche"

    Dim messageE As String = "Veuillez entrer un terme de recherche."
    Dim titleE As String = "Erreur de recherche"

    Private Sub ButtonintileBouton_Click(sender As Object, e As EventArgs) Handles intileBouton.Click
        Dim resultat As String = intileText.Text

        ' Vous devriez vérifier que resultat n'est pas vide avant de continuer
        If Not String.IsNullOrEmpty(resultat) Then
            Dim recherche As String = "intitle:" & Uri.EscapeDataString("""Index of /""") & " " & resultat
            Process.Start("https://www.google.com/search?q=" & recherche)

            MessageBox.Show(messageOk, titleI, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            MessageBox.Show(messageE, titleE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub loginBouton_Click(sender As Object, e As EventArgs) Handles loginBouton.Click
        Dim recherche As String = "intitle:" & Uri.EscapeDataString("""Admin Login""")

        ' Vous devriez vérifier que resultat n'est pas vide avant de continuer
        If Not String.IsNullOrEmpty(recherche) Then
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

End Class
