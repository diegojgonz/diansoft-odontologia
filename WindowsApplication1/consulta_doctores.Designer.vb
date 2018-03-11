<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class consulta_doctores
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
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox6 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox9 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button3 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button6 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button5 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox8 = New DevComponents.DotNetBar.Controls.RichTextBoxEx()
        Me.GroupPanel1 = New DevComponents.DotNetBar.Controls.GroupPanel()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(259, 103)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(14, 16)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(333, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 43
        Me.Label15.Text = "Años"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(80, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 13)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Fec. Nacimiento:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(173, 101)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePicker2.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(314, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(279, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Edad:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(370, 76)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(14, 16)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(262, 51)
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
        Me.TextBox6.Location = New System.Drawing.Point(173, 50)
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
        Me.Label12.Location = New System.Drawing.Point(124, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Cedula:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(173, 25)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(83, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.PaleTurquoise
        Me.TextBox9.Depth = 0
        Me.TextBox9.Hint = ""
        Me.TextBox9.Location = New System.Drawing.Point(173, 127)
        Me.TextBox9.MaxLength = 32767
        Me.TextBox9.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox9.SelectedText = ""
        Me.TextBox9.SelectionLength = 0
        Me.TextBox9.SelectionStart = 0
        Me.TextBox9.Size = New System.Drawing.Size(87, 23)
        Me.TextBox9.TabIndex = 7
        Me.TextBox9.TabStop = False
        Me.TextBox9.UseSystemPasswordChar = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(115, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Telefono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(127, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Fecha:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 156)
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
        Me.TextBox1.Location = New System.Drawing.Point(173, 75)
        Me.TextBox1.MaxLength = 32767
        Me.TextBox1.MouseState = MaterialSkin.MouseState.HOVER
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox1.SelectedText = ""
        Me.TextBox1.SelectionLength = 0
        Me.TextBox1.SelectionStart = 0
        Me.TextBox1.Size = New System.Drawing.Size(191, 23)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.TabStop = False
        Me.TextBox1.UseSystemPasswordChar = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombres y Apellidos:"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialFlatButton1.Icon = Global.WindowsApplication1.My.Resources.Resources.Dentist_Search
        Me.MaterialFlatButton1.Image = Global.WindowsApplication1.My.Resources.Resources.Search
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(282, 37)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(44, 36)
        Me.MaterialFlatButton1.TabIndex = 51
        Me.MaterialFlatButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MaterialFlatButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
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
        Me.Button2.Location = New System.Drawing.Point(4, 272)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button2.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button2.Name = "Button2"
        Me.Button2.Primary = False
        Me.Button2.Size = New System.Drawing.Size(94, 36)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Nuevo"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.AutoSize = True
        Me.Button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button3.Depth = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_close_black_24dp_1x
        Me.Button3.Image = Global.WindowsApplication1.My.Resources.Resources.button_cancel1
        Me.Button3.Location = New System.Drawing.Point(382, 272)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button3.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button3.Name = "Button3"
        Me.Button3.Primary = False
        Me.Button3.Size = New System.Drawing.Size(119, 36)
        Me.Button3.TabIndex = 47
        Me.Button3.Text = "Cancelar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button6.AutoSize = True
        Me.Button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button6.Depth = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button6.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_remove_black_24dp_1x
        Me.Button6.Image = Global.WindowsApplication1.My.Resources.Resources.CRISTAL_TRASH_FULL1
        Me.Button6.Location = New System.Drawing.Point(263, 272)
        Me.Button6.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button6.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button6.Name = "Button6"
        Me.Button6.Primary = False
        Me.Button6.Size = New System.Drawing.Size(111, 36)
        Me.Button6.TabIndex = 50
        Me.Button6.Text = "Eliminar"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.AutoSize = True
        Me.Button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button5.BackColor = System.Drawing.Color.White
        Me.Button5.Depth = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_save_black_48dp_1x
        Me.Button5.Location = New System.Drawing.Point(143, 272)
        Me.Button5.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button5.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button5.Name = "Button5"
        Me.Button5.Primary = False
        Me.Button5.Size = New System.Drawing.Size(112, 36)
        Me.Button5.TabIndex = 49
        Me.Button5.Text = "Guardar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button5.UseVisualStyleBackColor = False
        '
        'TextBox8
        '
        '
        '
        '
        Me.TextBox8.BackgroundStyle.Class = "RichTextBoxBorder"
        Me.TextBox8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBox8.Location = New System.Drawing.Point(173, 156)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Rtf = "{\rtf1\ansi\ansicpg1252\deff0\deflang3082{\fonttbl{\f0\fnil\fcharset0 Microsoft S" &
    "ans Serif;}}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "\viewkind4\uc1\pard\f0\fs17\par" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "}" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.TextBox8.Size = New System.Drawing.Size(211, 83)
        Me.TextBox8.TabIndex = 52
        '
        'GroupPanel1
        '
        Me.GroupPanel1.BackColor = System.Drawing.Color.White
        Me.GroupPanel1.CanvasColor = System.Drawing.SystemColors.Control
        Me.GroupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007
        Me.GroupPanel1.Controls.Add(Me.TextBox8)
        Me.GroupPanel1.Controls.Add(Me.Button3)
        Me.GroupPanel1.Controls.Add(Me.Button2)
        Me.GroupPanel1.Controls.Add(Me.Button6)
        Me.GroupPanel1.Controls.Add(Me.TextBox9)
        Me.GroupPanel1.Controls.Add(Me.Button5)
        Me.GroupPanel1.Controls.Add(Me.MaterialFlatButton1)
        Me.GroupPanel1.Controls.Add(Me.DateTimePicker1)
        Me.GroupPanel1.Controls.Add(Me.Label12)
        Me.GroupPanel1.Controls.Add(Me.Label8)
        Me.GroupPanel1.Controls.Add(Me.Label18)
        Me.GroupPanel1.Controls.Add(Me.TextBox6)
        Me.GroupPanel1.Controls.Add(Me.Label7)
        Me.GroupPanel1.Controls.Add(Me.Label15)
        Me.GroupPanel1.Controls.Add(Me.Label16)
        Me.GroupPanel1.Controls.Add(Me.Label14)
        Me.GroupPanel1.Controls.Add(Me.Label3)
        Me.GroupPanel1.Controls.Add(Me.DateTimePicker2)
        Me.GroupPanel1.Controls.Add(Me.Label17)
        Me.GroupPanel1.Controls.Add(Me.TextBox1)
        Me.GroupPanel1.Controls.Add(Me.Label13)
        Me.GroupPanel1.Controls.Add(Me.Label6)
        Me.GroupPanel1.Controls.Add(Me.Label1)
        Me.GroupPanel1.DisabledBackColor = System.Drawing.Color.Empty
        Me.GroupPanel1.Location = New System.Drawing.Point(12, 12)
        Me.GroupPanel1.Name = "GroupPanel1"
        Me.GroupPanel1.Size = New System.Drawing.Size(511, 320)
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
        Me.GroupPanel1.TabIndex = 53
        '
        'consulta_doctores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 344)
        Me.Controls.Add(Me.GroupPanel1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "consulta_doctores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Medicos"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupPanel1.ResumeLayout(False)
        Me.GroupPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox9 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button6 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button5 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button3 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents Button2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TextBox8 As DevComponents.DotNetBar.Controls.RichTextBoxEx
    Friend WithEvents GroupPanel1 As DevComponents.DotNetBar.Controls.GroupPanel
End Class
