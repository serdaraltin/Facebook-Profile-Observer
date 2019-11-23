
Public Class Form1
    Dim kaynak As String = ""
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
     
        tarayici.ScriptErrorsSuppressed = True
        tarayici.Navigate("https://tr-tr.facebook.com/")
        gb_tarayici.Enabled = False
    End Sub

    Private Sub tarayici_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles tarayici.DocumentCompleted
        gb_tarayici.Text = tarayici.Url.ToString
        gb_giris.Enabled = True
        If (tarayici.DocumentText.Contains("Giriş Yap")) Then
            lb_durum.Text = "Durum : "
        End If
        If (tarayici.Url.ToString() = ("https://www.facebook.com/") And tarayici.DocumentText.Contains("Messenger")) Then
            Dim doc As HtmlElementCollection = tarayici.Document.All
            For Each element As HtmlElement In doc
                If (element.GetAttribute("title") = "Profil") Then
                    element.InvokeMember("click")
                    lb_durum.Text = "Durum : " + "Yönlendiriliyor..."
                End If
            Next
        End If
        If (tarayici.DocumentText.Contains("Künye") And tarayici.DocumentText.Contains("_3-8_ img sp_cXMgT_8mDIg sx_b9ef8c")) Then
            kaynak = ""
            kaynak = tarayici.DocumentText
            lb_durum.Text = "Durum : " + "Kaynak toplanıyor..."
            If (kaynak.Contains("activeList:[")) Then
                tarayici.Stop()
                listele()
            End If

        End If

    End Sub

    Private Sub tarayici_Navigating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserNavigatingEventArgs) Handles tarayici.Navigating
        lb_durum.Text = "Durum : " + "Yükleniyor..."
        'gb_giris.Enabled = False
    End Sub

    Private Sub btn_giris_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_giris.Click
        Try
            tarayici.Document.GetElementById("email").InnerText = tx_mail.Text
            tarayici.Document.GetElementById("pass").InnerText = tx_sifre.Text
            tarayici.Document.GetElementById("loginbutton").InvokeMember("click")
        Catch ex As Exception

        End Try
       
    End Sub

    Private Sub listele()
        tarayici.Navigate("")
        If (kaynak.Contains("activeList:[")) Then
            kaynak = kaynak.Remove(0, kaynak.IndexOf("activeList:[") + 12)
            kaynak = kaynak.Substring(0, kaynak.IndexOf("}"))
            kaynak = kaynak.Remove(0, kaynak.IndexOf("{") + 1)
            kaynak = kaynak.Replace("""", "")

            ls_kisiler.Items.Clear()
            While (kaynak.Contains(":"))
                If (kaynak.Contains(",")) Then
                    Dim id As String = kaynak.Substring(0, kaynak.IndexOf(","))
                    kaynak = kaynak.Remove(0, kaynak.IndexOf(",") + 1)
                    id = id.Substring(0, id.IndexOf(":"))
                    ls_kisiler.Items.Add(id)
                Else
                    Dim id As String = kaynak
                    kaynak = ""
                    id = id.Substring(0, id.IndexOf(":"))
                    ls_kisiler.Items.Add(id)
                End If

            End While
            gb_kisiler.Text = "Id (" + (ls_kisiler.Items.Count - 1).ToString() + ")"
            gb_kisiler.Enabled = True
            lb_durum.Text = "Durum : " + "Tamamlandı."
        End If
    End Sub

    Private Sub ls_kisiler_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ls_kisiler.MouseClick
        Try
            tarayici.Navigate("https://www.facebook.com/" + ls_kisiler.SelectedItem.ToString())
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 8")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        System.Diagnostics.Process.Start("rundll32.exe", "InetCpl.cpl,ClearMyTracksByProcess 2")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            gb_tarayici.Enabled = True
        Else
            gb_tarayici.Enabled = False
        End If
    End Sub
End Class
