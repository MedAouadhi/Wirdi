Public Class LoginForm1

    ' TODO: ins�rez le code pour effectuer une authentification personnalis�e � l'aide du nom d'utilisateur et du mot de passe fournis 
    ' (Consultez https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' L'objet Principal personnalis� peut ensuite �tre associ� � l'objet Principal du thread actuel comme suit : 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' CustomPrincipal est l'impl�mentation IPrincipal utilis�e pour effectuer l'authentification. 
    ' Par la suite, My.User retournera les informations d'identit� encapsul�es dans l'objet CustomPrincipal
    ' telles que le nom d'utilisateur, le nom complet, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
