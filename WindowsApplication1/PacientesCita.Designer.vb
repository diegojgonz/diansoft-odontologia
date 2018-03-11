<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PacientesCita
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora_atencion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.atendido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.hora_atencion, Me.atendido, Me.observacion})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 192)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(665, 196)
        Me.DataGridView1.TabIndex = 12
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.ReadOnly = True
        Me.nombre.Width = 124
        '
        'hora_atencion
        '
        Me.hora_atencion.HeaderText = "Hora Atencion"
        Me.hora_atencion.Name = "hora_atencion"
        Me.hora_atencion.ReadOnly = True
        Me.hora_atencion.Width = 123
        '
        'atendido
        '
        Me.atendido.HeaderText = "Atendido"
        Me.atendido.Name = "atendido"
        Me.atendido.ReadOnly = True
        Me.atendido.Width = 124
        '
        'observacion
        '
        Me.observacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.observacion.HeaderText = "Observacion"
        Me.observacion.Name = "observacion"
        Me.observacion.ReadOnly = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(3, 1)
        Me.MonthCalendar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MonthCalendar1.Location = New System.Drawing.Point(1, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 13
        '
        'PacientesCita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 400)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Name = "PacientesCita"
        Me.Text = "Diansoft Odontologia - Pacientes por Atender"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents hora_atencion As DataGridViewTextBoxColumn
    Friend WithEvents atendido As DataGridViewTextBoxColumn
    Friend WithEvents observacion As DataGridViewTextBoxColumn
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
