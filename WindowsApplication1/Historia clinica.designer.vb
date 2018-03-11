<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class historia_clinica
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
        Me.Texmamografia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Texcedulaallternativo = New System.Windows.Forms.MaskedTextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lbledad = New System.Windows.Forms.Label()
        Me.lblpaciente = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lbledadtitulo = New System.Windows.Forms.Label()
        Me.lblcedulatitulo = New System.Windows.Forms.Label()
        Me.lblpacientetitulo = New System.Windows.Forms.Label()
        Me.lblfechatitulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btnguardar = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Texmamografia
        '
        Me.Texmamografia.BackColor = System.Drawing.SystemColors.Control
        Me.Texmamografia.Location = New System.Drawing.Point(14, 91)
        Me.Texmamografia.Multiline = True
        Me.Texmamografia.Name = "Texmamografia"
        Me.Texmamografia.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Texmamografia.Size = New System.Drawing.Size(690, 352)
        Me.Texmamografia.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(269, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Historia Clinica"
        '
        'Texcedulaallternativo
        '
        Me.Texcedulaallternativo.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Texcedulaallternativo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Texcedulaallternativo.Location = New System.Drawing.Point(72, 11)
        Me.Texcedulaallternativo.Mask = "99999999"
        Me.Texcedulaallternativo.Name = "Texcedulaallternativo"
        Me.Texcedulaallternativo.Size = New System.Drawing.Size(86, 21)
        Me.Texcedulaallternativo.TabIndex = 79
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(164, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(54, 23)
        Me.Button3.TabIndex = 74
        Me.Button3.Text = "Ok"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lbledad
        '
        Me.lbledad.AutoSize = True
        Me.lbledad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbledad.Location = New System.Drawing.Point(56, 66)
        Me.lbledad.Name = "lbledad"
        Me.lbledad.Size = New System.Drawing.Size(49, 15)
        Me.lbledad.TabIndex = 66
        Me.lbledad.Text = "              "
        '
        'lblpaciente
        '
        Me.lblpaciente.AutoSize = True
        Me.lblpaciente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaciente.Location = New System.Drawing.Point(305, 14)
        Me.lblpaciente.Name = "lblpaciente"
        Me.lblpaciente.Size = New System.Drawing.Size(85, 15)
        Me.lblpaciente.TabIndex = 65
        Me.lblpaciente.Text = "                          "
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(87, 40)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(58, 15)
        Me.lblfecha.TabIndex = 64
        Me.lblfecha.Text = "                 "
        '
        'lbledadtitulo
        '
        Me.lbledadtitulo.AutoSize = True
        Me.lbledadtitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbledadtitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbledadtitulo.Location = New System.Drawing.Point(11, 66)
        Me.lbledadtitulo.Name = "lbledadtitulo"
        Me.lbledadtitulo.Size = New System.Drawing.Size(39, 15)
        Me.lbledadtitulo.TabIndex = 63
        Me.lbledadtitulo.Text = "Edad:"
        '
        'lblcedulatitulo
        '
        Me.lblcedulatitulo.AutoSize = True
        Me.lblcedulatitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcedulatitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblcedulatitulo.Location = New System.Drawing.Point(11, 11)
        Me.lblcedulatitulo.Name = "lblcedulatitulo"
        Me.lblcedulatitulo.Size = New System.Drawing.Size(49, 15)
        Me.lblcedulatitulo.TabIndex = 62
        Me.lblcedulatitulo.Text = "Cédula:"
        '
        'lblpacientetitulo
        '
        Me.lblpacientetitulo.AutoSize = True
        Me.lblpacientetitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpacientetitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblpacientetitulo.Location = New System.Drawing.Point(241, 14)
        Me.lblpacientetitulo.Name = "lblpacientetitulo"
        Me.lblpacientetitulo.Size = New System.Drawing.Size(58, 15)
        Me.lblpacientetitulo.TabIndex = 61
        Me.lblpacientetitulo.Text = "Paciente:"
        '
        'lblfechatitulo
        '
        Me.lblfechatitulo.AutoSize = True
        Me.lblfechatitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfechatitulo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblfechatitulo.Location = New System.Drawing.Point(9, 40)
        Me.lblfechatitulo.Name = "lblfechatitulo"
        Me.lblfechatitulo.Size = New System.Drawing.Size(72, 15)
        Me.lblfechatitulo.TabIndex = 60
        Me.lblfechatitulo.Text = "Fecha Nac.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(87, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Años           "
        Me.Label2.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button1.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WindowsApplication1.My.Resources.Resources.scanner1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(292, 461)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 65)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Button2.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.WindowsApplication1.My.Resources.Resources.cancelar
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(372, 461)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(74, 65)
        Me.Button2.TabIndex = 70
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Btnguardar
        '
        Me.Btnguardar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Btnguardar.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnguardar.Image = Global.WindowsApplication1.My.Resources.Resources.guardar1
        Me.Btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btnguardar.Location = New System.Drawing.Point(212, 461)
        Me.Btnguardar.Name = "Btnguardar"
        Me.Btnguardar.Size = New System.Drawing.Size(74, 65)
        Me.Btnguardar.TabIndex = 69
        Me.Btnguardar.Text = "Guardar"
        Me.Btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btnguardar.UseVisualStyleBackColor = False
        '
        'historia_clinica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(719, 535)
        Me.Controls.Add(Me.Texmamografia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Texcedulaallternativo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Btnguardar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lbledad)
        Me.Controls.Add(Me.lblpaciente)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.lbledadtitulo)
        Me.Controls.Add(Me.lblcedulatitulo)
        Me.Controls.Add(Me.lblpacientetitulo)
        Me.Controls.Add(Me.lblfechatitulo)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "historia_clinica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diansoft Odontologia - Historia Clinica"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Texmamografia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Texcedulaallternativo As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Btnguardar As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lbledad As System.Windows.Forms.Label
    Friend WithEvents lblpaciente As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents lbledadtitulo As System.Windows.Forms.Label
    Friend WithEvents lblcedulatitulo As System.Windows.Forms.Label
    Friend WithEvents lblpacientetitulo As System.Windows.Forms.Label
    Friend WithEvents lblfechatitulo As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
