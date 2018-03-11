<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Dim MetroTileFrame1 As DevComponents.DotNetBar.Metro.MetroTileFrame
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DockContainerItem1 = New DevComponents.DotNetBar.DockContainerItem()
        Me.ItemPanel1 = New DevComponents.DotNetBar.ItemPanel()
        Me.ItemContainer1 = New DevComponents.DotNetBar.ItemContainer()
        Me.labelX2 = New DevComponents.DotNetBar.LabelX()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Button8 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroTileItem1 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem11 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem12 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem3 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem4 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem13 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem9 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem10 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem5 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem2 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem8 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem6 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        Me.MetroTileItem7 = New DevComponents.DotNetBar.Metro.MetroTileItem()
        MetroTileFrame1 = New DevComponents.DotNetBar.Metro.MetroTileFrame()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.LightSlateGray
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(881, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(134, 32)
        Me.TextBox1.TabIndex = 13
        '
        'DockContainerItem1
        '
        Me.DockContainerItem1.Name = "DockContainerItem1"
        Me.DockContainerItem1.Text = "DockContainerItem1"
        '
        'ItemPanel1
        '
        Me.ItemPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.ItemPanel1.BackgroundStyle.Class = "ItemPanel"
        Me.ItemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemPanel1.ContainerControlProcessDialogKey = True
        Me.ItemPanel1.DragDropSupport = True
        Me.ItemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ItemContainer1})
        Me.ItemPanel1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical
        Me.ItemPanel1.Location = New System.Drawing.Point(6, 71)
        Me.ItemPanel1.Name = "ItemPanel1"
        Me.ItemPanel1.Size = New System.Drawing.Size(1009, 337)
        Me.ItemPanel1.TabIndex = 20
        Me.ItemPanel1.Text = "ItemPanel1"
        '
        'ItemContainer1
        '
        '
        '
        '
        Me.ItemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ItemContainer1.MultiLine = True
        Me.ItemContainer1.Name = "ItemContainer1"
        Me.ItemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.MetroTileItem1, Me.MetroTileItem11, Me.MetroTileItem12, Me.MetroTileItem3, Me.MetroTileItem4, Me.MetroTileItem13, Me.MetroTileItem9, Me.MetroTileItem10, Me.MetroTileItem5, Me.MetroTileItem2, Me.MetroTileItem8, Me.MetroTileItem6, Me.MetroTileItem7})
        '
        '
        '
        Me.ItemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        'labelX2
        '
        Me.labelX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.labelX2.Location = New System.Drawing.Point(12, 5)
        Me.labelX2.Name = "labelX2"
        Me.labelX2.Size = New System.Drawing.Size(98, 47)
        Me.labelX2.TabIndex = 21
        Me.labelX2.Text = "<div align=""right""><font size=""+4"">Wile</font><br/>E. Coyote</div>"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MaterialFlatButton1.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_power_settings_new_black_24dp_1x
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(834, 10)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(44, 36)
        Me.MaterialFlatButton1.TabIndex = 24
        Me.MaterialFlatButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MaterialFlatButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button8.AutoSize = True
        Me.Button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Button8.Depth = 0
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button8.Icon = Global.WindowsApplication1.My.Resources.Resources.ic_lock_black_24dp_1x
        Me.Button8.Location = New System.Drawing.Point(163, 12)
        Me.Button8.Margin = New System.Windows.Forms.Padding(0)
        Me.Button8.MouseState = MaterialSkin.MouseState.HOVER
        Me.Button8.Name = "Button8"
        Me.Button8.Primary = False
        Me.Button8.Size = New System.Drawing.Size(44, 36)
        Me.Button8.TabIndex = 23
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button8.UseVisualStyleBackColor = True
        '
        'pictureBox1
        '
        Me.pictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pictureBox1.Location = New System.Drawing.Point(116, 10)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(44, 40)
        Me.pictureBox1.TabIndex = 22
        Me.pictureBox1.TabStop = False
        '
        'MetroTileItem1
        '
        Me.MetroTileItem1.Image = Global.WindowsApplication1.My.Resources.Resources.ic_perm_identity_white_48dp_2x
        Me.MetroTileItem1.Name = "MetroTileItem1"
        Me.MetroTileItem1.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem1.Text = "<h4>Modulo de Pacientes</h4>"
        Me.MetroTileItem1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Olive
        Me.MetroTileItem1.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem1.TitleText = "Crear, Modificar, Eliminar Pacientes"
        Me.MetroTileItem1.Tooltip = "Pacientes"
        '
        'MetroTileItem11
        '
        Me.MetroTileItem11.Image = Global.WindowsApplication1.My.Resources.Resources.ic_content_paste_white_48dp_2x
        Me.MetroTileItem11.Name = "MetroTileItem11"
        Me.MetroTileItem11.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem11.Text = "<h4>Historia Clinica</h4>"
        Me.MetroTileItem11.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Gray
        Me.MetroTileItem11.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem11.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem11.TitleText = "Historia Clinica del Paciente"
        '
        'MetroTileItem12
        '
        Me.MetroTileItem12.Image = Global.WindowsApplication1.My.Resources.Resources.ic_help_outline_white_48dp_2x
        Me.MetroTileItem12.Name = "MetroTileItem12"
        Me.MetroTileItem12.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem12.Text = "<h4>Anamnesis Médica</h4>"
        Me.MetroTileItem12.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellowish
        Me.MetroTileItem12.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem12.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem12.TitleText = "Preguntas para complementar historial"
        '
        'MetroTileItem3
        '
        Me.MetroTileItem3.Image = Global.WindowsApplication1.My.Resources.Resources.diente
        Me.MetroTileItem3.Name = "MetroTileItem3"
        Me.MetroTileItem3.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem3.Text = "<h4>Odontograma</h4>"
        Me.MetroTileItem3.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedViolet
        Me.MetroTileItem3.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem3.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem3.TitleText = "Crear, Presupuestos, Trabajos"
        Me.MetroTileItem3.TitleTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTileItem4
        '
        Me.MetroTileItem4.Image = Global.WindowsApplication1.My.Resources.Resources.ic_add_a_photo_white_48dp_2x
        Me.MetroTileItem4.Name = "MetroTileItem4"
        Me.MetroTileItem4.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem4.Text = "<h4>Modulo de Imagen</h4>"
        Me.MetroTileItem4.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkGreen
        Me.MetroTileItem4.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem4.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem4.TitleText = "Agregar, Modificar, Eliminar Imagenes"
        '
        'MetroTileItem13
        '
        Me.MetroTileItem13.Image = Global.WindowsApplication1.My.Resources.Resources.ic_description_white_48dp_2x
        Me.MetroTileItem13.Name = "MetroTileItem13"
        Me.MetroTileItem13.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem13.Text = "<h5>Presupuestos</h5>"
        Me.MetroTileItem13.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.PlumWashed
        Me.MetroTileItem13.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem13.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem13.TitleText = "ver e Imprimir Presupuestos"
        '
        'MetroTileItem9
        '
        Me.MetroTileItem9.Image = Global.WindowsApplication1.My.Resources.Resources.ic_attach_money_white_48dp_2x
        Me.MetroTileItem9.Name = "MetroTileItem9"
        Me.MetroTileItem9.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem9.Text = "<h4>Modulo de Caja</h4>"
        Me.MetroTileItem9.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Teal
        Me.MetroTileItem9.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem9.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem9.TitleText = "Saldos, Abonos"
        '
        'MetroTileItem10
        '
        Me.MetroTileItem10.Image = Global.WindowsApplication1.My.Resources.Resources.ic_event_note_white_48dp_2x
        Me.MetroTileItem10.Name = "MetroTileItem10"
        Me.MetroTileItem10.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem10.Text = "<h4>Citas</h4>"
        Me.MetroTileItem10.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.DarkBlue
        Me.MetroTileItem10.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem10.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem10.TitleText = "Asignar cita a Paciente"
        '
        'MetroTileItem5
        '
        Me.MetroTileItem5.Frames.Add(MetroTileFrame1)
        Me.MetroTileItem5.Image = Global.WindowsApplication1.My.Resources.Resources.ic_insert_chart_white_48dp_2x
        Me.MetroTileItem5.Name = "MetroTileItem5"
        Me.MetroTileItem5.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem5.Text = "<h4>Reportes</h4>"
        Me.MetroTileItem5.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee
        Me.MetroTileItem5.TileSize = New System.Drawing.Size(200, 110)
        Me.MetroTileItem5.TitleText = "Reportes varios del sistema"
        '
        'MetroTileFrame1
        '
        MetroTileFrame1.Image = Global.WindowsApplication1.My.Resources.Resources.ic_insert_chart_white_48dp_2x
        MetroTileFrame1.Text = "<h4>Reportes</h4>"
        MetroTileFrame1.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Coffee
        '
        '
        '
        MetroTileFrame1.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        MetroTileFrame1.TitleText = "Reportes varios del sistema"
        '
        'MetroTileItem2
        '
        Me.MetroTileItem2.Image = Global.WindowsApplication1.My.Resources.Resources.shutterstock_1949512794
        Me.MetroTileItem2.Name = "MetroTileItem2"
        Me.MetroTileItem2.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem2.Text = "<h4>Modulo de Doctores</h4>"
        Me.MetroTileItem2.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Azure
        Me.MetroTileItem2.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem2.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem2.TitleText = "Crear, Modificar, Eliminar Doctores"
        Me.MetroTileItem2.TitleTextFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroTileItem8
        '
        Me.MetroTileItem8.Image = Global.WindowsApplication1.My.Resources.Resources.ic_account_circle_white_48dp_2x
        Me.MetroTileItem8.Name = "MetroTileItem8"
        Me.MetroTileItem8.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem8.Text = "<h4>Modulo de Usuarios</h4>"
        Me.MetroTileItem8.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.[Default]
        Me.MetroTileItem8.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem8.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem8.TitleText = "Crear, Modificar, Eliminar Usuarios"
        '
        'MetroTileItem6
        '
        Me.MetroTileItem6.Image = Global.WindowsApplication1.My.Resources.Resources.ic_build_white_48dp_2x
        Me.MetroTileItem6.Name = "MetroTileItem6"
        Me.MetroTileItem6.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem6.Text = "<h4>Parametros</h4>"
        Me.MetroTileItem6.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Plum
        Me.MetroTileItem6.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem6.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem6.TitleText = "Configuracion del Sistema"
        '
        'MetroTileItem7
        '
        Me.MetroTileItem7.Image = Global.WindowsApplication1.My.Resources.Resources.ic_error_white_48dp_2x
        Me.MetroTileItem7.Name = "MetroTileItem7"
        Me.MetroTileItem7.SymbolColor = System.Drawing.Color.Empty
        Me.MetroTileItem7.Text = "<h4>Acerca de Diansoft Odontologia</h4>"
        Me.MetroTileItem7.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange
        Me.MetroTileItem7.TileSize = New System.Drawing.Size(200, 110)
        '
        '
        '
        Me.MetroTileItem7.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.MetroTileItem7.TitleText = "Informacion del Sistema"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1019, 433)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.labelX2)
        Me.Controls.Add(Me.ItemPanel1)
        Me.Controls.Add(Me.TextBox1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "Principal"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DianSoft Odontologia - Menú Principal"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DockContainerItem1 As DevComponents.DotNetBar.DockContainerItem
    Friend WithEvents ItemPanel1 As DevComponents.DotNetBar.ItemPanel
    Friend WithEvents ItemContainer1 As DevComponents.DotNetBar.ItemContainer
    Friend WithEvents MetroTileItem1 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem2 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem3 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem4 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem5 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem6 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem7 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem8 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem9 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem10 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem11 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents MetroTileItem12 As DevComponents.DotNetBar.Metro.MetroTileItem
    Private WithEvents labelX2 As DevComponents.DotNetBar.LabelX
    Private WithEvents pictureBox1 As PictureBox
    Friend WithEvents MetroTileItem13 As DevComponents.DotNetBar.Metro.MetroTileItem
    Friend WithEvents Button8 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
End Class
