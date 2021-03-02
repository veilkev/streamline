Public Class frmAbout



    Private Sub frmAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If frmStreamline.dM = True Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            lblUser.ForeColor = Color.White
        End If

        lblUser.Text = "Licensed to user: " + frmStreamline.user

    End Sub
End Class