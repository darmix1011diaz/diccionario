<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Listar
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
        Me.gbx_agregar = New System.Windows.Forms.GroupBox()
        Me.btn_menu = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.lv_palabras = New System.Windows.Forms.ListView()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbx_agregar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_agregar
        '
        Me.gbx_agregar.BackColor = System.Drawing.Color.Transparent
        Me.gbx_agregar.Controls.Add(Me.btn_menu)
        Me.gbx_agregar.Controls.Add(Me.btn_guardar)
        Me.gbx_agregar.Controls.Add(Me.lv_palabras)
        Me.gbx_agregar.Controls.Add(Me.btn_agregar)
        Me.gbx_agregar.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_agregar.ForeColor = System.Drawing.Color.White
        Me.gbx_agregar.Location = New System.Drawing.Point(7, 58)
        Me.gbx_agregar.Name = "gbx_agregar"
        Me.gbx_agregar.Size = New System.Drawing.Size(501, 277)
        Me.gbx_agregar.TabIndex = 3
        Me.gbx_agregar.TabStop = False
        '
        'btn_menu
        '
        Me.btn_menu.BackColor = System.Drawing.Color.Black
        Me.btn_menu.Location = New System.Drawing.Point(251, 199)
        Me.btn_menu.Name = "btn_menu"
        Me.btn_menu.Size = New System.Drawing.Size(228, 38)
        Me.btn_menu.TabIndex = 7
        Me.btn_menu.Text = "MENU DICCIONARIO"
        Me.btn_menu.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.BackColor = System.Drawing.Color.Black
        Me.btn_guardar.Location = New System.Drawing.Point(251, 132)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(228, 38)
        Me.btn_guardar.TabIndex = 6
        Me.btn_guardar.Text = "GUARDAR PALABRA"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'lv_palabras
        '
        Me.lv_palabras.FullRowSelect = True
        Me.lv_palabras.GridLines = True
        Me.lv_palabras.HideSelection = False
        Me.lv_palabras.Location = New System.Drawing.Point(5, 30)
        Me.lv_palabras.Name = "lv_palabras"
        Me.lv_palabras.Size = New System.Drawing.Size(240, 241)
        Me.lv_palabras.TabIndex = 5
        Me.lv_palabras.UseCompatibleStateImageBehavior = False
        Me.lv_palabras.View = System.Windows.Forms.View.List
        '
        'btn_agregar
        '
        Me.btn_agregar.BackColor = System.Drawing.Color.Black
        Me.btn_agregar.Location = New System.Drawing.Point(251, 68)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(228, 38)
        Me.btn_agregar.TabIndex = 4
        Me.btn_agregar.Text = "AGREGAR PALABRA"
        Me.btn_agregar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(129, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "LISTAR PALABRA"
        '
        'frm_Listar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(515, 359)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gbx_agregar)
        Me.Name = "frm_Listar"
        Me.Text = "frm_Listar"
        Me.gbx_agregar.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbx_agregar As GroupBox
    Friend WithEvents lv_palabras As ListView
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_menu As Button
    Friend WithEvents Label1 As Label
End Class
