<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.lbl_seg = New System.Windows.Forms.Label()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoraYMinutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegundosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FechaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.HoraYMinutosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegundosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PararToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncenderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lbl_hora
        '
        Me.lbl_hora.AutoSize = True
        Me.lbl_hora.Font = New System.Drawing.Font("Arial Black", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_hora.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_hora.Location = New System.Drawing.Point(41, 24)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(115, 45)
        Me.lbl_hora.TabIndex = 0
        Me.lbl_hora.Text = "00:00"
        '
        'lbl_seg
        '
        Me.lbl_seg.AutoSize = True
        Me.lbl_seg.BackColor = System.Drawing.Color.Transparent
        Me.lbl_seg.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_seg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_seg.Location = New System.Drawing.Point(151, 42)
        Me.lbl_seg.Name = "lbl_seg"
        Me.lbl_seg.Size = New System.Drawing.Size(28, 21)
        Me.lbl_seg.TabIndex = 1
        Me.lbl_seg.Text = "00"
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lbl_fecha.Location = New System.Drawing.Point(53, 69)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(115, 15)
        Me.lbl_fecha.TabIndex = 2
        Me.lbl_fecha.Text = "Jueves, 13 junio 2019"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(221, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuenteToolStripMenuItem, Me.ColorToolStripMenuItem, Me.PararToolStripMenuItem, Me.EncenderToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 20)
        Me.ToolStripMenuItem1.Text = "..."
        '
        'FuenteToolStripMenuItem
        '
        Me.FuenteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FuenteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FechaToolStripMenuItem, Me.HoraYMinutosToolStripMenuItem, Me.SegundosToolStripMenuItem})
        Me.FuenteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        Me.FuenteToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FuenteToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.FuenteToolStripMenuItem.Text = "Fuente"
        '
        'FechaToolStripMenuItem
        '
        Me.FechaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FechaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FechaToolStripMenuItem.Name = "FechaToolStripMenuItem"
        Me.FechaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.FechaToolStripMenuItem.Text = "Fecha"
        '
        'HoraYMinutosToolStripMenuItem
        '
        Me.HoraYMinutosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HoraYMinutosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HoraYMinutosToolStripMenuItem.Name = "HoraYMinutosToolStripMenuItem"
        Me.HoraYMinutosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.HoraYMinutosToolStripMenuItem.Text = "Hora y Minutos"
        '
        'SegundosToolStripMenuItem
        '
        Me.SegundosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SegundosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SegundosToolStripMenuItem.Name = "SegundosToolStripMenuItem"
        Me.SegundosToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SegundosToolStripMenuItem.Text = "Segundos"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ColorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FondoToolStripMenuItem, Me.FechaToolStripMenuItem1, Me.HoraYMinutosToolStripMenuItem1, Me.SegundosToolStripMenuItem1})
        Me.ColorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'FondoToolStripMenuItem
        '
        Me.FondoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FondoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FondoToolStripMenuItem.Name = "FondoToolStripMenuItem"
        Me.FondoToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.FondoToolStripMenuItem.Text = "Fondo"
        '
        'FechaToolStripMenuItem1
        '
        Me.FechaToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FechaToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FechaToolStripMenuItem1.Name = "FechaToolStripMenuItem1"
        Me.FechaToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.FechaToolStripMenuItem1.Text = "Fecha"
        '
        'HoraYMinutosToolStripMenuItem1
        '
        Me.HoraYMinutosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HoraYMinutosToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.HoraYMinutosToolStripMenuItem1.Name = "HoraYMinutosToolStripMenuItem1"
        Me.HoraYMinutosToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.HoraYMinutosToolStripMenuItem1.Text = "Hora y Minutos"
        '
        'SegundosToolStripMenuItem1
        '
        Me.SegundosToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SegundosToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SegundosToolStripMenuItem1.Name = "SegundosToolStripMenuItem1"
        Me.SegundosToolStripMenuItem1.Size = New System.Drawing.Size(156, 22)
        Me.SegundosToolStripMenuItem1.Text = "Segundos"
        '
        'PararToolStripMenuItem
        '
        Me.PararToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PararToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.PararToolStripMenuItem.Name = "PararToolStripMenuItem"
        Me.PararToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.PararToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.PararToolStripMenuItem.Text = "Parar"
        '
        'EncenderToolStripMenuItem
        '
        Me.EncenderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EncenderToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.EncenderToolStripMenuItem.Name = "EncenderToolStripMenuItem"
        Me.EncenderToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EncenderToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.EncenderToolStripMenuItem.Text = "Encender"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 98)
        Me.ProgressBar1.Maximum = 60
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(220, 3)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(221, 99)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.lbl_seg)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents lbl_hora As Label
    Friend WithEvents lbl_seg As Label
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FechaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoraYMinutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SegundosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FondoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FechaToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HoraYMinutosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SegundosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PararToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EncenderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
