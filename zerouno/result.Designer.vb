<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class result
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(result))
        Me.imglst = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.picbox = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imglst
        '
        Me.imglst.ImageStream = CType(resources.GetObject("imglst.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imglst.TransparentColor = System.Drawing.Color.Transparent
        Me.imglst.Images.SetKeyName(0, "ok.png")
        Me.imglst.Images.SetKeyName(1, "error.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.zerouno.My.Resources.Resources.btnAceptar
        Me.PictureBox1.Location = New System.Drawing.Point(771, 228)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 34)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'lblDesc
        '
        Me.lblDesc.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.ForeColor = System.Drawing.Color.DimGray
        Me.lblDesc.Location = New System.Drawing.Point(171, 50)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(706, 175)
        Me.lblDesc.TabIndex = 5
        Me.lblDesc.Text = "La configuración se ha guardado correctamente. Recomendamos que almacene el archi" & _
    "vo en un pendrive, mail u otro almacenamiento externo para que no pueda ser modi" & _
    "ficado."
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Black
        Me.lblTitulo.Location = New System.Drawing.Point(169, 11)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(131, 29)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.Text = "Resultado"
        '
        'picbox
        '
        Me.picbox.ErrorImage = CType(resources.GetObject("picbox.ErrorImage"), System.Drawing.Image)
        Me.picbox.Image = Global.zerouno.My.Resources.Resources.ok
        Me.picbox.InitialImage = CType(resources.GetObject("picbox.InitialImage"), System.Drawing.Image)
        Me.picbox.Location = New System.Drawing.Point(27, 68)
        Me.picbox.Name = "picbox"
        Me.picbox.Size = New System.Drawing.Size(138, 147)
        Me.picbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox.TabIndex = 6
        Me.picbox.TabStop = False
        '
        'result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Snow
        Me.ClientSize = New System.Drawing.Size(900, 283)
        Me.Controls.Add(Me.picbox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "result"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "result"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imglst As System.Windows.Forms.ImageList
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDesc As System.Windows.Forms.Label
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents picbox As System.Windows.Forms.PictureBox
End Class
