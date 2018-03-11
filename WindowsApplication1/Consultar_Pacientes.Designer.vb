<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Consultar_Pacientes
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
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label20 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label15 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label14 = New MaterialSkin.Controls.MaterialLabel()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox6 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox9 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox7 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox5 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox4 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.TextBox2 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label9 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label8 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label7 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label6 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label5 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label4 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Label2 = New MaterialSkin.Controls.MaterialLabel()
        Me.TextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New MaterialSkin.Controls.MaterialLabel()
        Me.DataSet1 = New System.Data.DataSet()
        Me.Label12 = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox8 = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button5 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button6 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button3 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button9 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button7 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button4 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button8 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.ItemHeight = 13
        Me.ComboBox1.Items.AddRange(New Object() {"Estandar", "Tipo 1", "Tipo 2", "Tipo 3"})
        Me.ComboBox1.Location = New System.Drawing.Point(526, 140)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(144, 21)
        Me.ComboBox1.TabIndex = 44
        Me.ComboBox1.Text = "Estandar"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Depth = 0
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(395, 139)
        Me.Label20.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(122, 18)
        Me.Label20.TabIndex = 43
        Me.Label20.Text = "Tipo de Paciente:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Depth = 0
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(397, 114)
        Me.Label15.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(42, 18)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Años"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Depth = 0
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(79, 114)
        Me.Label14.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 18)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Fec. Nacimiento:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarMonthBackground = System.Drawing.Color.White
        Me.DateTimePicker2.CalendarTitleForeColor = System.Drawing.Color.White
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(208, 114)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(105, 20)
        Me.DateTimePicker2.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Depth = 0
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(375, 114)
        Me.Label13.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 18)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "0"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.Aquamarine
        Me.TextBox6.Depth = 0
        Me.TextBox6.Hint = ""
        Me.TextBox6.Location = New System.Drawing.Point(208, 22)
        Me.TextBox6.MaxLength = 32767
        Me.TextBox6.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox6.SelectedText = ""
        Me.TextBox6.SelectionLength = 0
        Me.TextBox6.SelectionStart = 0
        Me.TextBox6.Size = New System.Drawing.Size(79, 23)
        Me.TextBox6.TabIndex = 1
        Me.TextBox6.TabStop = False
        Me.TextBox6.UseSystemPasswordChar = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(563, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(107, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Depth = 0
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(648, 152)
        Me.Label10.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 18)
        Me.Label10.TabIndex = 18
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox9.Depth = 0
        Me.TextBox9.Hint = ""
        Me.TextBox9.Location = New System.Drawing.Point(208, 140)
        Me.TextBox9.MaxLength = 32767
        Me.TextBox9.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox9.SelectedText = ""
        Me.TextBox9.SelectionLength = 0
        Me.TextBox9.SelectionStart = 0
        Me.TextBox9.Size = New System.Drawing.Size(181, 23)
        Me.TextBox9.TabIndex = 7
        Me.TextBox9.TabStop = False
        Me.TextBox9.UseSystemPasswordChar = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox7.Depth = 0
        Me.TextBox7.Hint = ""
        Me.TextBox7.Location = New System.Drawing.Point(206, 302)
        Me.TextBox7.MaxLength = 32767
        Me.TextBox7.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox7.SelectedText = ""
        Me.TextBox7.SelectionLength = 0
        Me.TextBox7.SelectionStart = 0
        Me.TextBox7.Size = New System.Drawing.Size(464, 23)
        Me.TextBox7.TabIndex = 10
        Me.TextBox7.TabStop = False
        Me.TextBox7.UseSystemPasswordChar = False
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox5.Depth = 0
        Me.TextBox5.Hint = ""
        Me.TextBox5.Location = New System.Drawing.Point(206, 273)
        Me.TextBox5.MaxLength = 32767
        Me.TextBox5.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox5.SelectedText = ""
        Me.TextBox5.SelectionLength = 0
        Me.TextBox5.SelectionStart = 0
        Me.TextBox5.Size = New System.Drawing.Size(464, 23)
        Me.TextBox5.TabIndex = 9
        Me.TextBox5.TabStop = False
        Me.TextBox5.UseSystemPasswordChar = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox4.Depth = 0
        Me.TextBox4.Hint = ""
        Me.TextBox4.Location = New System.Drawing.Point(206, 244)
        Me.TextBox4.MaxLength = 32767
        Me.TextBox4.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox4.SelectedText = ""
        Me.TextBox4.SelectionLength = 0
        Me.TextBox4.SelectionStart = 0
        Me.TextBox4.Size = New System.Drawing.Size(464, 23)
        Me.TextBox4.TabIndex = 8
        Me.TextBox4.TabStop = False
        Me.TextBox4.UseSystemPasswordChar = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox2.Depth = 0
        Me.TextBox2.Hint = ""
        Me.TextBox2.Location = New System.Drawing.Point(208, 85)
        Me.TextBox2.MaxLength = 32767
        Me.TextBox2.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.SelectionLength = 0
        Me.TextBox2.SelectionStart = 0
        Me.TextBox2.Size = New System.Drawing.Size(462, 23)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TabStop = False
        Me.TextBox2.UseSystemPasswordChar = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Depth = 0
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(40, 280)
        Me.Label9.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(155, 18)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Motivo de la Consulta:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Depth = 0
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(127, 140)
        Me.Label8.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Telefono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Depth = 0
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(444, 26)
        Me.Label7.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Fecha Registro:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Depth = 0
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(319, 114)
        Me.Label6.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Edad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Depth = 0
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(41, 306)
        Me.Label5.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Historia Odontológica:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Depth = 0
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(117, 244)
        Me.Label4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alergico A:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Depth = 0
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(123, 170)
        Me.Label3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Depth = 0
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(93, 89)
        Me.Label2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Representante:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox1.Depth = 0
        Me.TextBox1.Hint = ""
        Me.TextBox1.Location = New System.Drawing.Point(208, 53)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.Size = New System.Drawing.Size(462, 23)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TabStop = False
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Depth = 0
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 58)
        Me.Label1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres y Apellidos:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Depth = 0
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(141, 26)
        Me.Label12.MouseState = MaterialSkin.MouseState.HOVER
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 18)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Cedula:"
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.Label11)
        Me.GroupPanel1.Controls.Add(Me.PictureBox1)
        Me.GroupPanel1.Controls.Add(Me.TextBox8)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Controls.Add(Me.ComboBox1)
        Me.GroupPanel1.Controls.Add(Me.TextBox9)
        Me.GroupPanel1.Controls.Add(Me.Label10)
        Me.GroupPanel1.Controls.Add(Me.Button1)
        Me.GroupPanel1.Controls.Add(Me.DateTimePicker1)
        Me.GroupPanel1.Controls.Add(Me.Button5)
        Me.GroupPanel1.Controls.Add(Me.Button6)
        Me.GroupPanel1.Controls.Add(Me.TextBox7)
        Me.GroupPanel1.Controls.Add(Me.Button3)
        Me.GroupPanel1.Controls.Add(Me.TextBox5)
        Me.GroupPanel1.Controls.Add(Me.Button2)
        Me.GroupPanel1.Controls.Add(Me.Label20)
        Me.GroupPanel1.Controls.Add(Me.TextBox6)
        Me.GroupPanel1.Controls.Add(Me.TextBox4)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.Controls.Add(Me.Label13)
        Me.GroupPanel1.Controls.Add(Me.TextBox1)
        Me.GroupPanel1.Controls.Add(Me.TextBox2)
        Me.GroupPanel1.Controls.Add(Me.DateTimePicker2)
        Me.GroupPanel1.Controls.Add(Me.Label2)
        Me.GroupPanel1.Controls.Add(Me.Label9)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.Label14)
        Me.GroupPanel1.Controls.Add(Me.Label15)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.Label4)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Label5)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(26, 50)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(836, 403)
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
        Me.GroupPanel1.TabIndex = 45
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(739, 131)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Imagen"
        '
        'TextBox8
        '
        '
        '
        '
        Me.TextBox8.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.TextBox8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(206, 170)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" &
    "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs23\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox8.Size = New System.Drawing.Size(464, 68)
        Me.TextBox8.TabIndex = 45
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialFlatButton1.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_add_a_photo_black_24dp_1x
        Me.MaterialFlatButton1.Image = Global.WindowsApplication1.My.Resources.Resources.cal
        Me.MaterialFlatButton1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(786, 9)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(44, 36)
        Me.MaterialFlatButton1.TabIndex = 46
        Me.MaterialFlatButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MaterialFlatButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.blanco
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(698, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 116)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button1.Depth = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_find_in_page_black_24dp_1x
        Me.Button1.Location = New System.Drawing.Point(290, 12)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button1.Name = "Button1"
        Me.Button1.Primary = False
        Me.Button1.Size = New System.Drawing.Size(44, 36)
        Me.Button1.TabIndex = 0
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.AutoSize = True
        Me.Button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button5.Depth = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_save_black_48dp_1x
        Me.Button5.Image = Global.WindowsApplication1.My.Resources.Resources.actualiser
        Me.Button5.Location = New System.Drawing.Point(418, 355)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button5.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button5.Name = "Button5"
        Me.Button5.Primary = False
        Me.Button5.Size = New System.Drawing.Size(112, 36)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Guardar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button6.AutoSize = True
        Me.Button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button6.Depth = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_close_black_24dp_1x
        Me.Button6.Image = Global.WindowsApplication1.My.Resources.Resources.CRISTAL_TRASH_FULL1
        Me.Button6.Location = New System.Drawing.Point(538, 355)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button6.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button6.Name = "Button6"
        Me.Button6.Primary = False
        Me.Button6.Size = New System.Drawing.Size(111, 36)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "Eliminar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.AutoSize = True
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.Depth = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_block_black_24dp_1x
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.button_cancel1
        Me.Button3.Location = New System.Drawing.Point(657, 355)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button3.Name = "Button3"
        Me.Button3.Primary = False
        Me.Button3.Size = New System.Drawing.Size(119, 36)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.AutoSize = True
        Me.Button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button2.Depth = 0
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_add_black_48dp_1x
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.Ccleaner_3D_v2_
        Me.Button2.Location = New System.Drawing.Point(32, 355)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button2.Name = "Button2"
        Me.Button2.Primary = False
        Me.Button2.Size = New System.Drawing.Size(94, 36)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Nuevo"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button9.AutoSize = True
        Me.Button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button9.Depth = 0
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button9.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_date_range_black_24dp_1x
        Me.Button9.Image = Global.WindowsApplication1.My.Resources.Resources.cal
        Me.Button9.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button9.Location = New System.Drawing.Point(734, 9)
        Me.Button9.Margin = New System.Windows.Forms.Padding(0)
        Me.Button9.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button9.Name = "Button9"
        Me.Button9.Primary = False
        Me.Button9.Size = New System.Drawing.Size(44, 36)
        Me.Button9.TabIndex = 0
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button7.AutoSize = True
        Me.Button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button7.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button7.Depth = 0
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button7.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_create_new_folder_black_24dp_1x
        Me.Button7.Image = Global.WindowsApplication1.My.Resources.Resources.editar1
        Me.Button7.Location = New System.Drawing.Point(681, 9)
        Me.Button7.Margin = New System.Windows.Forms.Padding(0)
        Me.Button7.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button7.Name = "Button7"
        Me.Button7.Primary = False
        Me.Button7.Size = New System.Drawing.Size(44, 36)
        Me.Button7.TabIndex = 0
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.AutoSize = True
        Me.Button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button4.Depth = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.Icon = Global.WindowsApplication1.My.Resources.Resources.Teeth_and_Gums1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(628, 9)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button4.Name = "Button4"
        Me.Button4.Primary = False
        Me.Button4.Size = New System.Drawing.Size(44, 36)
        Me.Button4.TabIndex = 0
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.AutoSize = True
        Me.Button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button8.Depth = 0
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button8.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_help_outline_black_24dp_1x
        Me.Button8.Location = New System.Drawing.Point(574, 9)
        Me.Button8.Margin = New System.Windows.Forms.Padding(0)
        Me.Button8.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button8.Name = "Button8"
        Me.Button8.Primary = False
        Me.Button8.Size = New System.Drawing.Size(44, 36)
        Me.Button8.TabIndex = 0
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Consultar_Pacientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(874, 479)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.GroupPanel1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button8)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Consultar_Pacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DianSoft Odontologia - Pacientes"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox6 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox9 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox7 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox5 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox4 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents TextBox2 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As System.Data.DataSet
    Friend WithEvents Button1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Label15 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Label12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Button3 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button5 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button6 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button7 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button8 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button4 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button9 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
    Friend WithEvents TextBox8 As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents Label11 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
End Class
