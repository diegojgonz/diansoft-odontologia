<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultar_Usuarios
    Inherits DevComponents.DotNetBar.Metro.MetroForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox5 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox3 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox6 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox9 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.TextBox8 = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.Button6 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button5 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button7 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button8 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(124, 279)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Nivel:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(361, 250)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(14, 16)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(361, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 16)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(361, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 16)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Repita la Contraseña:"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox5.Depth = 0
        Me.TextBox5.Hint = ""
        Me.TextBox5.Location = New System.Drawing.Point(164, 250)
        Me.TextBox5.MaxLength = 32767
        Me.TextBox5.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox5.SelectedText = ""
        Me.TextBox5.SelectionLength = 0
        Me.TextBox5.SelectionStart = 0
        Me.TextBox5.Size = New System.Drawing.Size(191, 23)
        Me.TextBox5.TabIndex = 8
        Me.TextBox5.TabStop = False
        Me.TextBox5.UseSystemPasswordChar = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Administrador", "Usuario"})
        Me.ComboBox1.Location = New System.Drawing.Point(164, 276)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(94, 227)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Contraseña:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Nombre de Usuario:"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox4.Depth = 0
        Me.TextBox4.Hint = ""
        Me.TextBox4.Location = New System.Drawing.Point(164, 224)
        Me.TextBox4.MaxLength = 32767
        Me.TextBox4.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox4.SelectedText = ""
        Me.TextBox4.SelectionLength = 0
        Me.TextBox4.SelectionStart = 0
        Me.TextBox4.Size = New System.Drawing.Size(191, 23)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.TabStop = False
        Me.TextBox4.UseSystemPasswordChar = False
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox3.Depth = 0
        Me.TextBox3.Hint = ""
        Me.TextBox3.Location = New System.Drawing.Point(164, 198)
        Me.TextBox3.MaxLength = 32767
        Me.TextBox3.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox3.SelectedText = ""
        Me.TextBox3.SelectionLength = 0
        Me.TextBox3.SelectionStart = 0
        Me.TextBox3.Size = New System.Drawing.Size(191, 23)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.TabStop = False
        Me.TextBox3.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(106, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Apellidos:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox2.Depth = 0
        Me.TextBox2.Hint = ""
        Me.TextBox2.Location = New System.Drawing.Point(164, 70)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.SelectionLength = 0
        Me.TextBox2.SelectionStart = 0
        Me.TextBox2.Size = New System.Drawing.Size(211, 23)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.TabStop = False
        Me.TextBox2.UseSystemPasswordChar = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(253, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 16)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "*"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox6.Depth = 0
        Me.TextBox6.Hint = ""
        Me.TextBox6.Location = New System.Drawing.Point(164, 18)
        Me.TextBox6.MaxLength = 32767
        Me.TextBox6.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox6.SelectedText = ""
        Me.TextBox6.SelectionLength = 0
        Me.TextBox6.SelectionStart = 0
        Me.TextBox6.Size = New System.Drawing.Size(83, 23)
        Me.TextBox6.TabIndex = 1
        Me.TextBox6.TabStop = False
        Me.TextBox6.UseSystemPasswordChar = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(115, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Cedula:"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox9.Depth = 0
        Me.TextBox9.Hint = ""
        Me.TextBox9.Location = New System.Drawing.Point(164, 172)
        Me.TextBox9.MaxLength = 32767
        Me.TextBox9.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox9.SelectedText = ""
        Me.TextBox9.SelectionLength = 0
        Me.TextBox9.SelectionStart = 0
        Me.TextBox9.Size = New System.Drawing.Size(87, 23)
        Me.TextBox9.TabIndex = 5
        Me.TextBox9.TabStop = False
        Me.TextBox9.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(106, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(103, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dirección:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox1.Depth = 0
        Me.TextBox1.Hint = ""
        Me.TextBox1.Location = New System.Drawing.Point(164, 44)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.Size = New System.Drawing.Size(211, 23)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TabStop = False
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(106, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Label10)
        Me.GroupPanel1.Controls.Add(Me.PictureBox1)
        Me.GroupPanel1.Controls.Add(Me.TextBox8)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Controls.Add(Me.Button6)
        Me.GroupPanel1.Controls.Add(Me.TextBox4)
        Me.GroupPanel1.Controls.Add(Me.Button5)
        Me.GroupPanel1.Controls.Add(Me.TextBox3)
        Me.GroupPanel1.Controls.Add(Me.Button4)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Button7)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.TextBox1)
        Me.GroupPanel1.Controls.Add(Me.TextBox2)
        Me.GroupPanel1.Controls.Add(Me.Button8)
        Me.GroupPanel1.Controls.Add(Me.ComboBox1)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label16)
        Me.GroupPanel1.Controls.Add(Me.Label14)
        Me.GroupPanel1.Controls.Add(Me.TextBox5)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.TextBox6)
        Me.GroupPanel1.Controls.Add(Me.Label11)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.TextBox9)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 22)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(554, 379)
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
        Me.GroupPanel1.TabIndex = 64
        '
        'TextBox8
        '
        '
        '
        '
        Me.TextBox8.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.TextBox8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(164, 99)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" &
    "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs23\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox8.Size = New System.Drawing.Size(211, 67)
        Me.TextBox8.TabIndex = 64
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button6.Depth = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_remove_black_24dp_1x
        Me.Button6.Location = New System.Drawing.Point(306, 325)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button6.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button6.Name = "Button6"
        Me.Button6.Primary = False
        Me.Button6.Size = New System.Drawing.Size(111, 36)
        Me.Button6.TabIndex = 63
        Me.Button6.Text = "Eliminar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.AutoSize = True
        Me.Button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button5.Depth = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_save_black_48dp_1x
        Me.Button5.Location = New System.Drawing.Point(186, 324)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button5.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button5.Name = "Button5"
        Me.Button5.Primary = False
        Me.Button5.Size = New System.Drawing.Size(112, 36)
        Me.Button5.TabIndex = 62
        Me.Button5.Text = "Guardar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button4.Depth = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_close_black_24dp_1x
        Me.Button4.Image = Global.WindowsApplication1.My.Resources.Resources.button_cancel1
        Me.Button4.Location = New System.Drawing.Point(425, 325)
        Me.Button4.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button4.Name = "Button4"
        Me.Button4.Primary = False
        Me.Button4.Size = New System.Drawing.Size(119, 36)
        Me.Button4.TabIndex = 61
        Me.Button4.Text = "Cancelar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.AutoSize = True
        Me.Button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button7.Depth = 0
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button7.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_add_black_48dp_1x
        Me.Button7.Location = New System.Drawing.Point(4, 325)
        Me.Button7.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button7.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button7.Name = "Button7"
        Me.Button7.Primary = False
        Me.Button7.Size = New System.Drawing.Size(94, 36)
        Me.Button7.TabIndex = 60
        Me.Button7.Text = "Nuevo"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.AutoSize = True
        Me.Button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button8.Depth = 0
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button8.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_find_in_page_black_24dp_1x
        Me.Button8.Location = New System.Drawing.Point(274, 5)
        Me.Button8.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button8.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button8.Name = "Button8"
        Me.Button8.Primary = False
        Me.Button8.Size = New System.Drawing.Size(44, 36)
        Me.Button8.TabIndex = 59
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(422, 137)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 13)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Imagen de Perfil"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blanco
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(405, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 116)
        Me.PictureBox1.TabIndex = 65
        Me.PictureBox1.TabStop = False
        '
        'Consultar_Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 413)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.Name = "Consultar_Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DianSoft Odontologia - Usuarios"
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox3 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button5 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button4 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button7 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button8 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextBox8 As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents Label10 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
