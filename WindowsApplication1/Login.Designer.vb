<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PasswordTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.UsernameTextBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.OK = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.Cancel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Depth = 0
        Me.PasswordTextBox.Hint = "Contraseña"
        Me.PasswordTextBox.Location = New System.Drawing.Point(216, 77)
        Me.PasswordTextBox.MaxLength = 32767
        Me.PasswordTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.SelectedText = ""
        Me.PasswordTextBox.SelectionLength = 0
        Me.PasswordTextBox.SelectionStart = 0
        Me.PasswordTextBox.Size = New System.Drawing.Size(199, 23)
        Me.PasswordTextBox.TabIndex = 7
        Me.PasswordTextBox.TabStop = False
        Me.PasswordTextBox.UseSystemPasswordChar = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Depth = 0
        Me.UsernameTextBox.Hint = "Usuario"
        Me.UsernameTextBox.Location = New System.Drawing.Point(216, 30)
        Me.UsernameTextBox.MaxLength = 32767
        Me.UsernameTextBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox.SelectedText = ""
        Me.UsernameTextBox.SelectionLength = 0
        Me.UsernameTextBox.SelectionStart = 0
        Me.UsernameTextBox.Size = New System.Drawing.Size(199, 23)
        Me.UsernameTextBox.TabIndex = 5
        Me.UsernameTextBox.TabStop = False
        Me.UsernameTextBox.UseSystemPasswordChar = False
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.OK)
        Me.GroupPanel1.Controls.Add(Me.PictureBox1)
        Me.GroupPanel1.Controls.Add(Me.PictureBox3)
        Me.GroupPanel1.Controls.Add(Me.Cancel)
        Me.GroupPanel1.Controls.Add(Me.PictureBox2)
        Me.GroupPanel1.Controls.Add(Me.UsernameTextBox)
        Me.GroupPanel1.Controls.Add(Me.PasswordTextBox)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(430, 202)
        '
        '
        '
        Me.GroupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.GroupPanel1.Style.BackColorGradientAngle = 90
        Me.GroupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.GroupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderBottomWidth = 1
        Me.GroupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.GroupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderLeftWidth = 1
        Me.GroupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderRightWidth = 1
        Me.GroupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.GroupPanel1.Style.BorderTopWidth = 1
        Me.GroupPanel1.Style.CornerDiameter = 4
        Me.GroupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded
        Me.GroupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center
        Me.GroupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.GroupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near
        '
        '
        '
        Me.GroupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.GroupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.GroupPanel1.TabIndex = 14
        '
        'OK
        '
        Me.OK.AutoSize = True
        Me.OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OK.BackColor = System.Drawing.Color.White
        Me.OK.Depth = 0
        Me.OK.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_done_black_24dp_1x
        Me.OK.Location = New System.Drawing.Point(184, 143)
        Me.OK.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.OK.MouseState = MaterialSkin.MouseState.HOVER
        Me.OK.Name = "OK"
        Me.OK.Primary = True
        Me.OK.Size = New System.Drawing.Size(110, 36)
        Me.OK.TabIndex = 8
        Me.OK.Text = "Aceptar"
        Me.OK.UseVisualStyleBackColor = False
        '
        'Cancel
        '
        Me.Cancel.AutoSize = True
        Me.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Cancel.BackColor = System.Drawing.Color.White
        Me.Cancel.Depth = 0
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_close_black_24dp_1x
        Me.Cancel.Location = New System.Drawing.Point(301, 143)
        Me.Cancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Cancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Primary = False
        Me.Cancel.Size = New System.Drawing.Size(119, 36)
        Me.Cancel.TabIndex = 9
        Me.Cancel.Text = "Cancelar"
        Me.Cancel.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WindowsApplication1.My.Resources.Resources.ic_vpn_key_black_48dp_1x
        Me.PictureBox3.Location = New System.Drawing.Point(181, 77)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 13
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.ic_person_black_48dp_1x
        Me.PictureBox2.Location = New System.Drawing.Point(181, 30)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(29, 23)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.icon_doc
        Me.PictureBox1.Location = New System.Drawing.Point(3, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(166, 170)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(430, 202)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diansoft Odontologia - Iniciar Sesión"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PasswordTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents UsernameTextBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Cancel As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents OK As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents PictureBox1 As PictureBox
End Class
