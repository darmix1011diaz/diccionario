<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Agregar
    Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbx_agregar = New System.Windows.Forms.GroupBox()
        Me.pbx_imagen = New System.Windows.Forms.PictureBox()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_imagen = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.txt_definicion = New System.Windows.Forms.TextBox()
        Me.txt_palabra = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbx_agregar.SuspendLayout()
        CType(Me.pbx_imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PALABRA:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(24, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DEFINICION:"
        '
        'gbx_agregar
        '
        Me.gbx_agregar.BackColor = System.Drawing.Color.Transparent
        Me.gbx_agregar.Controls.Add(Me.pbx_imagen)
        Me.gbx_agregar.Controls.Add(Me.btn_menu)
        Me.gbx_agregar.Controls.Add(Me.btn_imagen)
        Me.gbx_agregar.Controls.Add(Me.btn_agregar)
        Me.gbx_agregar.Controls.Add(Me.txt_definicion)
        Me.gbx_agregar.Controls.Add(Me.txt_palabra)
        Me.gbx_agregar.Controls.Add(Me.Label1)
        Me.gbx_agregar.Controls.Add(Me.Label2)
        Me.gbx_agregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_agregar.ForeColor = System.Drawing.Color.White
        Me.gbx_agregar.Location = New System.Drawing.Point(12, 46)
        Me.gbx_agregar.Name = "gbx_agregar"
        Me.gbx_agregar.Size = New System.Drawing.Size(501, 298)
        Me.gbx_agregar.TabIndex = 2
        Me.gbx_agregar.TabStop = False
        '
        'pbx_imagen
        '
        Me.pbx_imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbx_imagen.Location = New System.Drawing.Point(28, 125)
        Me.pbx_imagen.Name = "pbx_imagen"
        Me.pbx_imagen.Size = New System.Drawing.Size(311, 158)
        Me.pbx_imagen.TabIndex = 7
        Me.pbx_imagen.TabStop = False
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.Black
        Me.btn_menu.Location = New System.Drawing.Point(354, 91)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(121, 38)
        Me.btn_menu.TabIndex = 6
        Me.btn_menu.Text = "MENU"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'btn_imagen
        '
        Me.btn_imagen.BackColor = System.Drawing.Color.Black
        Me.btn_imagen.Location = New System.Drawing.Point(354, 218)
        Me.btn_imagen.Name = "btn_imagen"
        Me.btn_imagen.Size = New System.Drawing.Size(121, 38)
        Me.btn_imagen.TabIndex = 5
        Me.btn_imagen.Text = "IMAGEN"
        Me.btn_imagen.UseVisualStyleBackColor = False
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Black
        Me.btn_agregar.Location = New System.Drawing.Point(354, 152)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(121, 38)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'txt_definicion
        '
        Me.txt_definicion.Location = New System.Drawing.Point(151, 88)
        Me.txt_definicion.Name = "txt_definicion"
        Me.txt_definicion.Size = New System.Drawing.Size(188, 31)
        Me.txt_definicion.TabIndex = 3
        '
        'txt_palabra
        '
        Me.txt_palabra.Location = New System.Drawing.Point(151, 50)
        Me.txt_palabra.Name = "txt_palabra"
        Me.txt_palabra.Size = New System.Drawing.Size(188, 31)
        Me.txt_palabra.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(121, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 33)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "AGREGAR PALABRA"
        '
        'frm_Agregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(538, 356)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbx_agregar)
        Me.Name = "frm_Agregar"
        Me.Text = "Diccionario"
        Me.gbx_agregar.ResumeLayout(False)
        Me.gbx_agregar.PerformLayout()
        CType(Me.pbx_imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents gbx_agregar As GroupBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents txt_definicion As TextBox
    Friend WithEvents txt_palabra As TextBox
    Friend WithEvents btn_menu As Button
    Friend WithEvents btn_imagen As Button
    Friend WithEvents pbx_imagen As PictureBox
    Friend WithEvents Label3 As Label
End Class
