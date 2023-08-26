<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Texto
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Texto))
        PbWord = New PictureBox()
        TxtNota = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        PbExcel = New PictureBox()
        CType(PbWord, ComponentModel.ISupportInitialize).BeginInit()
        CType(PbExcel, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PbWord
        ' 
        PbWord.BorderStyle = BorderStyle.FixedSingle
        PbWord.Cursor = Cursors.Hand
        PbWord.Image = My.Resources.Resources.icons8_verificar_documento_64
        PbWord.Location = New Point(333, 31)
        PbWord.Name = "PbWord"
        PbWord.Size = New Size(46, 45)
        PbWord.SizeMode = PictureBoxSizeMode.StretchImage
        PbWord.TabIndex = 0
        PbWord.TabStop = False
        ' 
        ' TxtNota
        ' 
        TxtNota.AcceptsTab = True
        TxtNota.BackColor = SystemColors.Info
        TxtNota.BorderStyle = BorderStyle.None
        TxtNota.Location = New Point(16, 82)
        TxtNota.Multiline = True
        TxtNota.Name = "TxtNota"
        TxtNota.ScrollBars = ScrollBars.Vertical
        TxtNota.Size = New Size(368, 389)
        TxtNota.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(219, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 15)
        Label1.TabIndex = 2
        Label1.Text = "Exportar a:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Yu Gothic", 12F, FontStyle.Underline, GraphicsUnit.Point)
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 21)
        Label2.TabIndex = 3
        Label2.Text = "Archivo de texto"
        ' 
        ' PbExcel
        ' 
        PbExcel.BorderStyle = BorderStyle.FixedSingle
        PbExcel.Cursor = Cursors.Hand
        PbExcel.Image = My.Resources.Resources.excel
        PbExcel.Location = New Point(272, 31)
        PbExcel.Name = "PbExcel"
        PbExcel.Size = New Size(46, 45)
        PbExcel.SizeMode = PictureBoxSizeMode.StretchImage
        PbExcel.TabIndex = 4
        PbExcel.TabStop = False
        ' 
        ' Texto
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(391, 483)
        Controls.Add(PbExcel)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TxtNota)
        Controls.Add(PbWord)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Texto"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Texto"
        CType(PbWord, ComponentModel.ISupportInitialize).EndInit()
        CType(PbExcel, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PbWord As PictureBox
    Friend WithEvents TxtNota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PbExcel As PictureBox
End Class
