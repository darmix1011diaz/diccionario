<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Ver
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
        Me.gbx_ver = New System.Windows.Forms.GroupBox()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.txt_definicion = New System.Windows.Forms.TextBox()
        Me.txt_palabra = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbx_ver.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_ver
        '
        Me.gbx_ver.BackColor = System.Drawing.Color.Transparent
        Me.gbx_ver.Controls.Add(Me.btn_actualizar)
        Me.gbx_ver.Controls.Add(Me.txt_definicion)
        Me.gbx_ver.Controls.Add(Me.txt_palabra)
        Me.gbx_ver.Controls.Add(Me.Label1)
        Me.gbx_ver.Controls.Add(Me.Label2)
        Me.gbx_ver.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_ver.ForeColor = System.Drawing.Color.White
        Me.gbx_ver.Location = New System.Drawing.Point(12, 55)
        Me.gbx_ver.Name = "gbx_ver"
        Me.gbx_ver.Size = New System.Drawing.Size(501, 244)
        Me.gbx_ver.TabIndex = 3
        Me.gbx_ver.TabStop = False
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackColor = System.Drawing.Color.Black
        Me.btn_actualizar.Location = New System.Drawing.Point(349, 88)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(136, 75)
        Me.btn_actualizar.TabIndex = 4
        Me.btn_actualizar.Text = "ACTUALIZAR PALABRA"
        Me.btn_actualizar.UseVisualStyleBackColor = False
        '
        'txt_definicion
        '
        Me.txt_definicion.Location = New System.Drawing.Point(139, 132)
        Me.txt_definicion.Name = "txt_definicion"
        Me.txt_definicion.Size = New System.Drawing.Size(195, 31)
        Me.txt_definicion.TabIndex = 3
        '
        'txt_palabra
        '
        Me.txt_palabra.Location = New System.Drawing.Point(139, 70)
        Me.txt_palabra.Name = "txt_palabra"
        Me.txt_palabra.Size = New System.Drawing.Size(195, 31)
        Me.txt_palabra.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(6, 79)
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
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(6, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DEFINICION:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(145, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(275, 33)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "EDITAR PALABRA"
        '
        'frm_Ver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(532, 327)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbx_ver)
        Me.Name = "frm_Ver"
        Me.Text = "frm_Ver"
        Me.gbx_ver.ResumeLayout(False)
        Me.gbx_ver.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbx_ver As GroupBox
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents txt_definicion As TextBox
    Friend WithEvents txt_palabra As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
