<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lst = New System.Windows.Forms.ListView()
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox()
        Me.lblComponente = New System.Windows.Forms.Label()
        Me.odiag = New System.Windows.Forms.OpenFileDialog()
        Me.sdiag = New System.Windows.Forms.SaveFileDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lst
        '
        Me.lst.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lst.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.lst.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.lst, "lst")
        Me.lst.ForeColor = System.Drawing.Color.White
        Me.lst.Name = "lst"
        Me.lst.UseCompatibleStateImageBehavior = False
        Me.lst.View = System.Windows.Forms.View.List
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.txtDescripcion, "txtDescripcion")
        Me.txtDescripcion.ForeColor = System.Drawing.Color.LightGray
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ReadOnly = True
        '
        'lblComponente
        '
        resources.ApplyResources(Me.lblComponente, "lblComponente")
        Me.lblComponente.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblComponente.Name = "lblComponente"
        '
        'odiag
        '
        resources.ApplyResources(Me.odiag, "odiag")
        '
        'sdiag
        '
        resources.ApplyResources(Me.sdiag, "sdiag")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.AliceBlue
        resources.ApplyResources(Me.LinkLabel1, "LinkLabel1")
        Me.LinkLabel1.BackColor = System.Drawing.Color.Black
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.SteelBlue
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.TabStop = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Name = "Label1"
        '
        'PictureBox7
        '
        Me.PictureBox7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox7.Image = Global.zerouno.My.Resources.Resources.comparar_off
        resources.ApplyResources(Me.PictureBox7, "PictureBox7")
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox7, resources.GetString("PictureBox7.ToolTip"))
        '
        'PictureBox6
        '
        Me.PictureBox6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox6.Image = Global.zerouno.My.Resources.Resources.guardar_off
        resources.ApplyResources(Me.PictureBox6, "PictureBox6")
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox6, resources.GetString("PictureBox6.ToolTip"))
        '
        'PictureBox5
        '
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = Global.zerouno.My.Resources.Resources.options_off
        resources.ApplyResources(Me.PictureBox5, "PictureBox5")
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox5, resources.GetString("PictureBox5.ToolTip"))
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Gray
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.zerouno.My.Resources.Resources.programa
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.lblComponente)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lst)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lst As System.Windows.Forms.ListView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents lblComponente As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents odiag As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sdiag As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
