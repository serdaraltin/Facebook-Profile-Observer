<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gb_giris = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_giris = New System.Windows.Forms.Button()
        Me.tx_sifre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tx_mail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lb_durum = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tarayici = New System.Windows.Forms.WebBrowser()
        Me.gb_tarayici = New System.Windows.Forms.GroupBox()
        Me.ls_kisiler = New System.Windows.Forms.ListBox()
        Me.gb_kisiler = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.gb_giris.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.gb_tarayici.SuspendLayout()
        Me.gb_kisiler.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_giris
        '
        Me.gb_giris.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_giris.Controls.Add(Me.Button2)
        Me.gb_giris.Controls.Add(Me.Button1)
        Me.gb_giris.Controls.Add(Me.btn_giris)
        Me.gb_giris.Controls.Add(Me.tx_sifre)
        Me.gb_giris.Controls.Add(Me.Label2)
        Me.gb_giris.Controls.Add(Me.tx_mail)
        Me.gb_giris.Controls.Add(Me.Label1)
        Me.gb_giris.Location = New System.Drawing.Point(314, 2)
        Me.gb_giris.Name = "gb_giris"
        Me.gb_giris.Size = New System.Drawing.Size(807, 62)
        Me.gb_giris.TabIndex = 0
        Me.gb_giris.TabStop = False
        Me.gb_giris.Text = "Giriş"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(140, 27)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Önbelleği Temizle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 27)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Çerezleri Temizle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_giris
        '
        Me.btn_giris.Location = New System.Drawing.Point(722, 29)
        Me.btn_giris.Name = "btn_giris"
        Me.btn_giris.Size = New System.Drawing.Size(75, 23)
        Me.btn_giris.TabIndex = 4
        Me.btn_giris.Text = "Giriş Yap"
        Me.btn_giris.UseVisualStyleBackColor = True
        '
        'tx_sifre
        '
        Me.tx_sifre.Location = New System.Drawing.Point(518, 32)
        Me.tx_sifre.Name = "tx_sifre"
        Me.tx_sifre.Size = New System.Drawing.Size(188, 20)
        Me.tx_sifre.TabIndex = 3
        Me.tx_sifre.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(515, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Şifre"
        '
        'tx_mail
        '
        Me.tx_mail.Location = New System.Drawing.Point(307, 32)
        Me.tx_mail.Name = "tx_mail"
        Me.tx_mail.Size = New System.Drawing.Size(188, 20)
        Me.tx_mail.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(304, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eposta veya Telefon"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lb_durum})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 640)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1130, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lb_durum
        '
        Me.lb_durum.Name = "lb_durum"
        Me.lb_durum.Size = New System.Drawing.Size(53, 17)
        Me.lb_durum.Text = "Durum : "
        '
        'tarayici
        '
        Me.tarayici.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tarayici.Location = New System.Drawing.Point(3, 16)
        Me.tarayici.MinimumSize = New System.Drawing.Size(20, 20)
        Me.tarayici.Name = "tarayici"
        Me.tarayici.Size = New System.Drawing.Size(921, 544)
        Me.tarayici.TabIndex = 2
        '
        'gb_tarayici
        '
        Me.gb_tarayici.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gb_tarayici.Controls.Add(Me.tarayici)
        Me.gb_tarayici.Location = New System.Drawing.Point(194, 70)
        Me.gb_tarayici.Name = "gb_tarayici"
        Me.gb_tarayici.Size = New System.Drawing.Size(927, 563)
        Me.gb_tarayici.TabIndex = 3
        Me.gb_tarayici.TabStop = False
        '
        'ls_kisiler
        '
        Me.ls_kisiler.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ls_kisiler.FormattingEnabled = True
        Me.ls_kisiler.Location = New System.Drawing.Point(6, 19)
        Me.ls_kisiler.Name = "ls_kisiler"
        Me.ls_kisiler.Size = New System.Drawing.Size(172, 537)
        Me.ls_kisiler.TabIndex = 4
        '
        'gb_kisiler
        '
        Me.gb_kisiler.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gb_kisiler.Controls.Add(Me.ls_kisiler)
        Me.gb_kisiler.Enabled = False
        Me.gb_kisiler.Location = New System.Drawing.Point(7, 70)
        Me.gb_kisiler.Name = "gb_kisiler"
        Me.gb_kisiler.Size = New System.Drawing.Size(184, 563)
        Me.gb_kisiler.TabIndex = 5
        Me.gb_kisiler.TabStop = False
        Me.gb_kisiler.Text = "Id"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(207, 37)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "By DeadSound"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(301, 62)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(1100, 69)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 662)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gb_kisiler)
        Me.Controls.Add(Me.gb_tarayici)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.gb_giris)
        Me.Name = "Form1"
        Me.Text = "FB-Profil Gözlemcisi"
        Me.gb_giris.ResumeLayout(False)
        Me.gb_giris.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.gb_tarayici.ResumeLayout(False)
        Me.gb_kisiler.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gb_giris As System.Windows.Forms.GroupBox
    Friend WithEvents btn_giris As System.Windows.Forms.Button
    Friend WithEvents tx_sifre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tx_mail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lb_durum As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tarayici As System.Windows.Forms.WebBrowser
    Friend WithEvents gb_tarayici As System.Windows.Forms.GroupBox
    Friend WithEvents ls_kisiler As System.Windows.Forms.ListBox
    Friend WithEvents gb_kisiler As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
