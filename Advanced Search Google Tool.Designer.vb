<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedSearch
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvancedSearch))
        Me.loginBouton2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loginBouton = New System.Windows.Forms.Button()
        Me.intileText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.intileBouton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'loginBouton2
        '
        Me.loginBouton2.Location = New System.Drawing.Point(131, 184)
        Me.loginBouton2.Name = "loginBouton2"
        Me.loginBouton2.Size = New System.Drawing.Size(86, 28)
        Me.loginBouton2.TabIndex = 11
        Me.loginBouton2.Text = "Log In"
        Me.loginBouton2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Search for login pages"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'loginBouton
        '
        Me.loginBouton.Location = New System.Drawing.Point(39, 184)
        Me.loginBouton.Name = "loginBouton"
        Me.loginBouton.Size = New System.Drawing.Size(86, 28)
        Me.loginBouton.TabIndex = 9
        Me.loginBouton.Text = "Login"
        Me.loginBouton.UseVisualStyleBackColor = True
        '
        'intileText
        '
        Me.intileText.Location = New System.Drawing.Point(39, 69)
        Me.intileText.Name = "intileText"
        Me.intileText.Size = New System.Drawing.Size(177, 20)
        Me.intileText.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 26)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "intitle:""Index of /""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Find open directories on web servers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'intileBouton
        '
        Me.intileBouton.Location = New System.Drawing.Point(88, 95)
        Me.intileBouton.Name = "intileBouton"
        Me.intileBouton.Size = New System.Drawing.Size(86, 28)
        Me.intileBouton.TabIndex = 6
        Me.intileBouton.Text = "Envoyer"
        Me.intileBouton.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(730, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "V1.0 alpha"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'AdvancedSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.loginBouton2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.loginBouton)
        Me.Controls.Add(Me.intileText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.intileBouton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "AdvancedSearch"
        Me.Text = "Advanced Search Google Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginBouton2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents loginBouton As Button
    Friend WithEvents intileText As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents intileBouton As Button
    Friend WithEvents Label3 As Label
End Class
