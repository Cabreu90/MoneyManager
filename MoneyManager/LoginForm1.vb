Public Class LoginForm1

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Friend LoginBoolean As Boolean = False
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' Evaluate the the username and password.

        If UsernameTextBox.Text.ToUpper = "CESARIN" And PasswordTextBox.Text.ToUpper = "ABREU" Then
            ' If login is correct close this windows.
            LoginBoolean = True
            Me.Close()
        Else
            ' If login is not correct show a message.
            MessageBox.Show("Wrong username or password.", "Login Failed")
        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
