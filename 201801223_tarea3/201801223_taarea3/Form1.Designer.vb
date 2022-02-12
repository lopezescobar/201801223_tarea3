<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbventa = New System.Windows.Forms.CheckBox()
        Me.cbcompra = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtventa = New System.Windows.Forms.TextBox()
        Me.txtcompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.compraCCR = New System.Windows.Forms.RadioButton()
        Me.compraEuro = New System.Windows.Forms.RadioButton()
        Me.compraPM = New System.Windows.Forms.RadioButton()
        Me.compraDolar = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.ventaCCR = New System.Windows.Forms.RadioButton()
        Me.ventaEuro = New System.Windows.Forms.RadioButton()
        Me.ventaPM = New System.Windows.Forms.RadioButton()
        Me.ventaDolar = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbventa)
        Me.GroupBox1.Controls.Add(Me.cbcompra)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 162)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "transacciones"
        '
        'cbventa
        '
        Me.cbventa.AutoSize = True
        Me.cbventa.Location = New System.Drawing.Point(40, 88)
        Me.cbventa.Name = "cbventa"
        Me.cbventa.Size = New System.Drawing.Size(55, 19)
        Me.cbventa.TabIndex = 1
        Me.cbventa.Text = "venta"
        Me.cbventa.UseVisualStyleBackColor = True
        '
        'cbcompra
        '
        Me.cbcompra.AutoSize = True
        Me.cbcompra.Location = New System.Drawing.Point(43, 37)
        Me.cbcompra.Name = "cbcompra"
        Me.cbcompra.Size = New System.Drawing.Size(67, 19)
        Me.cbcompra.TabIndex = 0
        Me.cbcompra.Text = "compra"
        Me.cbcompra.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtventa)
        Me.GroupBox2.Controls.Add(Me.txtcompra)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(229, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(221, 155)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ingresar cantidad"
        '
        'txtventa
        '
        Me.txtventa.Location = New System.Drawing.Point(103, 101)
        Me.txtventa.Name = "txtventa"
        Me.txtventa.Size = New System.Drawing.Size(100, 23)
        Me.txtventa.TabIndex = 3
        '
        'txtcompra
        '
        Me.txtcompra.Enabled = False
        Me.txtcompra.Location = New System.Drawing.Point(97, 38)
        Me.txtcompra.Name = "txtcompra"
        Me.txtcompra.Size = New System.Drawing.Size(100, 23)
        Me.txtcompra.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "compra"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.compraCCR)
        Me.GroupBox3.Controls.Add(Me.compraEuro)
        Me.GroupBox3.Controls.Add(Me.compraPM)
        Me.GroupBox3.Controls.Add(Me.compraDolar)
        Me.GroupBox3.Location = New System.Drawing.Point(81, 239)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 168)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "compra"
        '
        'compraCCR
        '
        Me.compraCCR.AutoSize = True
        Me.compraCCR.Location = New System.Drawing.Point(32, 143)
        Me.compraCCR.Name = "compraCCR"
        Me.compraCCR.Size = New System.Drawing.Size(84, 19)
        Me.compraCCR.TabIndex = 3
        Me.compraCCR.TabStop = True
        Me.compraCCR.Text = "Colonos Cr"
        Me.compraCCR.UseVisualStyleBackColor = True
        '
        'compraEuro
        '
        Me.compraEuro.AutoSize = True
        Me.compraEuro.Location = New System.Drawing.Point(30, 106)
        Me.compraEuro.Name = "compraEuro"
        Me.compraEuro.Size = New System.Drawing.Size(54, 19)
        Me.compraEuro.TabIndex = 2
        Me.compraEuro.TabStop = True
        Me.compraEuro.Text = "Euros"
        Me.compraEuro.UseVisualStyleBackColor = True
        '
        'compraPM
        '
        Me.compraPM.AutoSize = True
        Me.compraPM.Location = New System.Drawing.Point(30, 68)
        Me.compraPM.Name = "compraPM"
        Me.compraPM.Size = New System.Drawing.Size(115, 19)
        Me.compraPM.TabIndex = 1
        Me.compraPM.TabStop = True
        Me.compraPM.Text = "Pesos Mexicanos"
        Me.compraPM.UseVisualStyleBackColor = True
        '
        'compraDolar
        '
        Me.compraDolar.AutoSize = True
        Me.compraDolar.Location = New System.Drawing.Point(32, 30)
        Me.compraDolar.Name = "compraDolar"
        Me.compraDolar.Size = New System.Drawing.Size(53, 19)
        Me.compraDolar.TabIndex = 0
        Me.compraDolar.TabStop = True
        Me.compraDolar.Text = "Dolar"
        Me.compraDolar.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.ventaCCR)
        Me.GroupBox4.Controls.Add(Me.ventaEuro)
        Me.GroupBox4.Controls.Add(Me.ventaPM)
        Me.GroupBox4.Controls.Add(Me.ventaDolar)
        Me.GroupBox4.Location = New System.Drawing.Point(355, 243)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 158)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "venta"
        '
        'ventaCCR
        '
        Me.ventaCCR.AutoSize = True
        Me.ventaCCR.Location = New System.Drawing.Point(15, 126)
        Me.ventaCCR.Name = "ventaCCR"
        Me.ventaCCR.Size = New System.Drawing.Size(84, 19)
        Me.ventaCCR.TabIndex = 3
        Me.ventaCCR.TabStop = True
        Me.ventaCCR.Text = "Colonos Cr"
        Me.ventaCCR.UseVisualStyleBackColor = True
        '
        'ventaEuro
        '
        Me.ventaEuro.AutoSize = True
        Me.ventaEuro.Location = New System.Drawing.Point(14, 97)
        Me.ventaEuro.Name = "ventaEuro"
        Me.ventaEuro.Size = New System.Drawing.Size(54, 19)
        Me.ventaEuro.TabIndex = 2
        Me.ventaEuro.TabStop = True
        Me.ventaEuro.Text = "Euros"
        Me.ventaEuro.UseVisualStyleBackColor = True
        '
        'ventaPM
        '
        Me.ventaPM.AutoSize = True
        Me.ventaPM.Location = New System.Drawing.Point(16, 63)
        Me.ventaPM.Name = "ventaPM"
        Me.ventaPM.Size = New System.Drawing.Size(115, 19)
        Me.ventaPM.TabIndex = 1
        Me.ventaPM.TabStop = True
        Me.ventaPM.Text = "Pesos Mexicanos"
        Me.ventaPM.UseVisualStyleBackColor = True
        '
        'ventaDolar
        '
        Me.ventaDolar.AutoSize = True
        Me.ventaDolar.Location = New System.Drawing.Point(14, 26)
        Me.ventaDolar.Name = "ventaDolar"
        Me.ventaDolar.Size = New System.Drawing.Size(53, 19)
        Me.ventaDolar.TabIndex = 0
        Me.ventaDolar.TabStop = True
        Me.ventaDolar.Text = "Dolar"
        Me.ventaDolar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(656, 255)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(656, 308)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(656, 365)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbventa As CheckBox
    Friend WithEvents cbcompra As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtventa As TextBox
    Friend WithEvents txtcompra As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents compraCCR As RadioButton
    Friend WithEvents compraEuro As RadioButton
    Friend WithEvents compraPM As RadioButton
    Friend WithEvents compraDolar As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents ventaCCR As RadioButton
    Friend WithEvents ventaEuro As RadioButton
    Friend WithEvents ventaPM As RadioButton
    Friend WithEvents ventaDolar As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
