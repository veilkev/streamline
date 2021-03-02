Public Class frmSites

    Private Sub Sites_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If frmStreamline.dM = True Then
            Me.BackColor = Color.Black
            Me.ForeColor = Color.White
            lbList.BackColor = Color.Black
            lbList.ForeColor = Color.LightGreen
        End If
    End Sub
End Class