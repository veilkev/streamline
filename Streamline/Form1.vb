Imports System.IO

Public Class frmStreamline

    Public user As String = Environment.UserName.ToString               'Gets the username
    Dim loc As String = "C:\Users\" + user + "\Desktop"                 'Default location used to download files
    Dim path As String = "C:\Users\Public"                              'Location used to store files
    Public dM As Boolean = False                                        'Dark Mode
    Public cName As Boolean = False                                     'Custom naming of videos
    Dim appDir As String = "C:\Users\" + user + "\" + "AppData\Local"   'Appdata storage

    ' Extracting file mechanism
    Private Sub Patch(ByVal FilePath As String, ByVal File As Object)
        ' Extracts the needed file.
        Dim FByte() As Byte = File
        My.Computer.FileSystem.WriteAllBytes(FilePath, FByte, True)
    End Sub

    ' Used if user does not want to automatically paste from clipboard
    Private Sub txtbxURL_ClickOnce(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbxURL.Click
        'clears the textbox for input
        If optPaste.Checked = True Then
            txtbxURL.Clear()
        End If
    End Sub

    ' Double click to copy from clipboard
    Private Sub txtbxURL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbxURL.DoubleClick
        ' Stores whatever is on the clipboard

        If optPaste.Checked = True Then
            Dim url As String = My.Computer.Clipboard.GetText
            txtbxURL.Text = url
        End If
       
    End Sub

    ' Creates directory in AppData
    Private Sub appData()
        ' Creates directory for the program
        If Not My.Computer.FileSystem.DirectoryExists(appDir + "\Streamline") Then
            My.Computer.FileSystem.CreateDirectory(appDir + "\Streamline")
        End If
    End Sub

    Private Sub frmStreamline_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Sets app data requirements
        appData()

        ' Determines if dark mode is enabled.
        If My.Computer.FileSystem.FileExists(appDir + "\Streamline\dM.txt") Then
            dM = True
            LMTS.Enabled = True
            DarkMode()
        Else
            dMTS.Enabled = True
        End If


        ' Determines custom name option
        If My.Computer.FileSystem.FileExists(appDir + "\Streamline\cName.txt") Then
            cName = True
            nameTSON.Enabled = False
            nameTSOFF.Enabled = True
        End If

        ' Hide progressbar until ready
        pbStream.Hide()

        ' Sets location to textbox
        txtbxSave.Text = loc

        ' Updates youtube-dl program
        Try
            Shell("cmd /c " + loc + "\youtube-dl.exe --update")
        Catch ex As Exception
            MsgBox("Possible network issue when updating program.", MsgBoxStyle.Exclamation)
        End Try

        ' Checks if file exists
        If My.Computer.FileSystem.FileExists(path + "\youtube-dl.exe") Then
            Try
                My.Computer.FileSystem.DeleteFile(path + "\youtube-dl.exe")
                ' Wait half a second
                System.Threading.Thread.Sleep(500)
            Catch ex As Exception
                ' ignore warning
            End Try
        End If

        ' Extracts the file needed for downloading
        youtubeDl()

        ' Sets version of program
        lblVersion.Text = "Version: " + FileVersionInfo.GetVersionInfo(path + "\youtube-dl.exe").FileVersion.ToString()

    End Sub

    Private Sub DarkMode()
        Me.BackColor = Color.Black
        lblStatus.ForeColor = Color.White
        lblVersion.ForeColor = Color.White
        lblTitle.ForeColor = Color.White
        optPaste.ForeColor = Color.White
        optAudio.ForeColor = Color.White
        btnDown.ForeColor = Color.White
        btnDown.BackColor = Color.Black
        btnDown.FlatAppearance.BorderColor = Color.LightGreen
        msLine.BackColor = Color.Black
        msLine.ForeColor = Color.White
        msFile.BackColor = Color.Black
        msFile.ForeColor = Color.White
        msSaveTo.BackColor = Color.Black
        msSaveTo.ForeColor = Color.White
        msSettings.BackColor = Color.Black
        msSettings.ForeColor = Color.White
        msAbout.BackColor = Color.Black
        msAbout.ForeColor = Color.White
        txtbxURL.BackColor = Color.Black
        txtbxURL.ForeColor = Color.White
        txtbxSave.BackColor = Color.Black
        txtbxSave.ForeColor = Color.White
        sitesTS.BackColor = Color.Black
        sitesTS.ForeColor = Color.White
        themeTS.BackColor = Color.Black
        themeTS.ForeColor = Color.White
        dMTS.BackColor = Color.Black
        dMTS.ForeColor = Color.White
        LMTS.BackColor = Color.Black
        LMTS.ForeColor = Color.White
        nameTS.BackColor = Color.Black
        nameTS.ForeColor = Color.White
        nameTSON.BackColor = Color.Black
        nameTSON.ForeColor = Color.White
        nameTSOFF.BackColor = Color.Black
        nameTSOFF.ForeColor = Color.White

        ' Disables the option
        dMTS.Enabled = False
        LMTS.Enabled = True
    End Sub

    Private Sub LightMode()
        Me.BackColor = Color.White
        lblStatus.ForeColor = Color.Black
        lblVersion.ForeColor = Color.Black
        lblTitle.ForeColor = Color.Black
        optPaste.ForeColor = Color.Black
        optAudio.ForeColor = Color.Black
        btnDown.ForeColor = Color.Black
        btnDown.BackColor = Color.White
        btnDown.FlatAppearance.BorderColor = Color.LightGreen
        msLine.BackColor = Color.White
        msLine.ForeColor = Color.Black
        msFile.BackColor = Color.White
        msFile.ForeColor = Color.Black
        msSaveTo.BackColor = Color.White
        msSaveTo.ForeColor = Color.Black
        msSettings.BackColor = Color.White
        msSettings.ForeColor = Color.Black
        msAbout.BackColor = Color.White
        msAbout.ForeColor = Color.Black
        txtbxURL.BackColor = Color.White
        txtbxURL.ForeColor = Color.Black
        txtbxSave.BackColor = Color.White
        txtbxSave.ForeColor = Color.Black
        sitesTS.BackColor = Color.White
        sitesTS.ForeColor = Color.Black
        themeTS.BackColor = Color.White
        themeTS.ForeColor = Color.Black
        dMTS.BackColor = Color.White
        dMTS.ForeColor = Color.Black
        LMTS.BackColor = Color.White
        LMTS.ForeColor = Color.Black
        nameTS.BackColor = Color.White
        nameTS.ForeColor = Color.Black
        nameTSON.BackColor = Color.White
        nameTSON.ForeColor = Color.Black
        nameTSOFF.BackColor = Color.White
        nameTSOFF.ForeColor = Color.Black

        ' Disables the option
        LMTS.Enabled = False
        dMTS.Enabled = True
    End Sub


    Private Sub youtubeDl()
        Patch(path + "\youtube-dl.exe", My.Resources.youtube_dl)
    End Sub

    Private Sub txtbxSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtbxSave.Click
        ' Prevents unwanted pseudo-locations
        MsgBox("If you wish to change the default location of the downloaded file, please click the 'save to' button")
    End Sub

   


   
    Private Sub TypeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sitesTS.Click
        ' In case the file has been previously downloaded, 
        ' or has been marked only and is unable to write to it.
        'If My.Computer.FileSystem.FileExists(path + "\sites.txt") Then
        'Shell("cmd /c attrib -r " + path + "\sites.txt")
        'My.Computer.FileSystem.DeleteFile(path + "\sites.txt")
        ' End If

        'Try
        'Patch(path + "\sites.txt", My.Resources.sites)
        'Shell("cmd /c attrib +r " + path + "\sites.txt")
        'Process.Start(path + "\sites.txt")
        'Catch ex As Exception
        'MsgBox("Something went wrong", MsgBoxStyle.Exclamation)
        'End Try

        frmSites.Show()




    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msAbout.Click
        frmAbout.Show()
    End Sub

    Private Sub SaveToToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msSaveTo.Click
        If (saveTo.ShowDialog() = DialogResult.OK) Then
            txtbxSave.Text = saveTo.SelectedPath
        End If
    End Sub



    Public Function randomString() As String
        ' Creates a random string
        Dim fileName As String = ""
        Dim number As Integer = 0
        Dim counter As Integer = 10

        While (counter > 0)
            ' Generates a random between 1 and 9
            number = Int((9 * Rnd()) + 1)

            ' Adds number to string
            fileName += number.ToString

            counter = counter - 1
        End While

        ' Converts the 10 digit number to hex format
        fileName = Hex(fileName).ToString

        ' Makes sure the file doesn't already exist
        If My.Computer.FileSystem.FileExists("C:\Users\Public\" + fileName + ".txt") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Public\" + fileName + ".txt")
            randomString()
        ElseIf My.Computer.FileSystem.FileExists("C:\Users\Public\" + fileName + ".bat") Then
            My.Computer.FileSystem.DeleteFile("C:\Users\Public\" + fileName + ".bat")
            randomString()
        End If

        Return fileName
    End Function

    Private Sub txtbxURL_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbxURL.TextChanged

        If txtbxURL.Text.StartsWith("http:") Or txtbxURL.Text.StartsWith("https:") Then
            lblStatus.Text = "Status: Ready"
        End If

        If txtbxURL.Text = "" Then
            lblStatus.Text = "Status: "
        End If
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        ' Will be used to determine if it is time to download a file
        Dim ready As Boolean = False
        Dim running As Boolean = True
        Dim loc As String = txtbxSave.Text + "\"
        Dim link As String = txtbxURL.Text
        Dim fileName As String = ""
        lblStatus.Text = "Status:"

        ' Deletes log file before starting new download
        'Try
        'My.Computer.FileSystem.DeleteFile(path + "\log.txt")
        'Catch ex As Exception
        'End Try

        If txtbxURL.Text.StartsWith("http") Or txtbxURL.Text.StartsWith("https") Then
            ready = True
            'lblStatus.Text = "Status: Ready."
        Else
            MsgBox("Invalid URL! Try Again", MsgBoxStyle.Critical)
            lblStatus.Text = "Status: Download failed."
        End If

        If ready = True Then

            pbStream.Show()
            pbStream.Value = 10 'progressbar loads

            Try

                ' -----------------------------------------------
                'Shell("cmd /c " + path + "\youtube-dl.exe -o " + """" + loc + "%(title)s-%(id)s.%(ext)s" + """" + " " + """" + link + """" +
                '" > " + path + "\log.txt")
                ' -----------------------------------------------

                ' Generates a random string
                fileName = randomString()
                pbStream.Value = 20

                ' Creates a text file 
                File.Create(path + "\" + fileName + ".txt").Dispose()
                pbStream.Value = 30

                If cName = True Then
                    Dim name As String = ""
                    name = InputBox("What would you like to name the file?", name)

                    If name = "" Or String.IsNullOrWhiteSpace(name) Then
                        MsgBox("Please enter a valid name!", MsgBoxStyle.OkOnly)
                    Else
                        ' Adds audio feature
                        If optAudio.Checked = True Then
                            ' Writes for the audio file
                            File.AppendAllText(path + "\" + fileName + ".txt", "cmd /c " + path + "\youtube-dl.exe --extract-audio --audio-format mp3 -o " + """" + loc + "\" +
                                              name + ".%%(ext)s" + """" + " " + """" + link + """")
                        Else
                            ' Writes for the video file
                            File.AppendAllText(path + "\" + fileName + ".txt", "cmd /c " + path + "\youtube-dl.exe -o " + """" + loc + "\" +
                                              name + ".%%(ext)s" + """" + " " + """" + link + """")
                        End If

                    End If

                Else

                    If optAudio.Checked = True Then
                        ' Writes for the audio file
                        File.AppendAllText(path + "\" + fileName + ".txt", "cmd /c " + path + "\youtube-dl.exe --extract-audio --audio-format mp3 -o " + """" + loc + "\" +
                                           "%%(title)s.%%(ext)s" + """" + " " + """" + link + """")
                    Else
                        ' Writes for the video file
                        File.AppendAllText(path + "\" + fileName + ".txt", "cmd /c " + path + "\youtube-dl.exe -o " + """" + loc + "\" +
                                           "%%(title)s.%%(ext)s" + """" + " " + """" + link + """")
                    End If
                    
                End If
                pbStream.Value = 40


                ' Converts the text file to a batch file
                My.Computer.FileSystem.RenameFile("C:\Users\Public\" + fileName + ".txt", fileName + ".bat")
                pbStream.Value = 50

                ' Executes batch file
                Process.Start(path + "\" + fileName + ".bat")
                pbStream.Value = 70

                ' Checks if the file still exists
                While (running)
                    If My.Computer.FileSystem.FileExists(path + "\" + fileName) Then
                        System.Threading.Thread.Sleep(3000)
                    Else
                        running = False
                        pbStream.Value = 100
                    End If
                End While



            Catch ex As Exception
                pbStream.Value = 0
                lblStatus.Text = "Status: "
            End Try
        End If
    End Sub

    
    Private Sub btnDown_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.MouseEnter
        If dM = True Then
            btnDown.BackColor = Color.Aquamarine
            btnDown.ForeColor = Color.Black
            btnDown.FlatAppearance.BorderColor = Color.White
        End If
    End Sub

    Private Sub btnDown_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDown.MouseLeave
        If dM = True Then
            btnDown.BackColor = Color.Black
            btnDown.ForeColor = Color.White
            btnDown.FlatAppearance.BorderColor = Color.LightSeaGreen
        End If
    End Sub

    
    Private Sub pbArt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbArt.Click
        txtbxURL.Text = "Enter a supported URL"
    End Sub

    Private Sub DarkModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dMTS.Click
        ' Creates the directory if not already created
        appData()
        File.Create(appDir + "\Streamline\dM.txt").Dispose()

        ' Launches dark mode
        dM = True
        DarkMode()
    End Sub

    Private Sub LMTS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LMTS.Click
        Try
            If dM = True Then
                My.Computer.FileSystem.DeleteFile(appDir + "\Streamline\dM.txt")
            End If

            dM = False

            LightMode()
        Catch ex As Exception
            MsgBox("An exception occurred!", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub nameTSON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nameTSON.Click
        ' Creates the directory if not already created
        appData()
        File.Create(appDir + "\Streamline\cName.txt").Dispose()

        ' Enables custom name option
        cName = True
        nameTSON.Enabled = False
        nameTSOFF.Enabled = True
    End Sub

    Private Sub nameTSOFF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nameTSOFF.Click
        If cName = True Then
            My.Computer.FileSystem.DeleteFile(appDir + "\Streamline\cName.txt")
        End If

        ' Disables custom name option
        cName = False
        nameTSON.Enabled = True
        nameTSOFF.Enabled = False
    End Sub


End Class
