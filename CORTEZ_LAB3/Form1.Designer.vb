<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        TxtUsername = New TextBox()
        TxtPassword = New TextBox()
        btnLogin = New Button()
        SuspendLayout()
        ' 
        ' TxtUsername
        ' 
        TxtUsername.Location = New Point(131, 103)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(191, 27)
        TxtUsername.TabIndex = 0
        ' 
        ' TxtPassword
        ' 
        TxtPassword.Location = New Point(131, 155)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "*"c
        TxtPassword.Size = New Size(191, 27)
        TxtPassword.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.AccessibleName = "LOGIN"
        btnLogin.Location = New Point(228, 203)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(94, 30)
        btnLogin.TabIndex = 2
        btnLogin.Text = "LOGIN"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnLogin)
        Controls.Add(TxtPassword)
        Controls.Add(TxtUsername)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents btnLogin As Button

End Class
