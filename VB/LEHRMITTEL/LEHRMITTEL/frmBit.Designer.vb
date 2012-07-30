<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBit
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.numValue = New System.Windows.Forms.NumericUpDown
        Me.cmbConvert = New System.Windows.Forms.Button
        Me.chNumBit = New System.Windows.Forms.CheckBox
        Me.numBit = New System.Windows.Forms.NumericUpDown
        Me.UcBit1 = New LEHRMITTEL.ucBit
        Me.GroupBox1.SuspendLayout()
        CType(Me.numValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.numBit)
        Me.GroupBox1.Controls.Add(Me.chNumBit)
        Me.GroupBox1.Controls.Add(Me.numValue)
        Me.GroupBox1.Controls.Add(Me.cmbConvert)
        Me.GroupBox1.Controls.Add(Me.UcBit1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 170)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Оперируем битами"
        '
        'numValue
        '
        Me.numValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.numValue.Location = New System.Drawing.Point(120, 23)
        Me.numValue.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numValue.Name = "numValue"
        Me.numValue.Size = New System.Drawing.Size(65, 22)
        Me.numValue.TabIndex = 3
        '
        'cmbConvert
        '
        Me.cmbConvert.Enabled = False
        Me.cmbConvert.Location = New System.Drawing.Point(380, 136)
        Me.cmbConvert.Name = "cmbConvert"
        Me.cmbConvert.Size = New System.Drawing.Size(107, 28)
        Me.cmbConvert.TabIndex = 2
        Me.cmbConvert.Text = "Конвертировать"
        Me.cmbConvert.UseVisualStyleBackColor = True
        '
        'chNumBit
        '
        Me.chNumBit.AutoSize = True
        Me.chNumBit.Location = New System.Drawing.Point(6, 80)
        Me.chNumBit.Name = "chNumBit"
        Me.chNumBit.Size = New System.Drawing.Size(164, 17)
        Me.chNumBit.TabIndex = 4
        Me.chNumBit.Text = "Установить бит с номером"
        Me.chNumBit.UseVisualStyleBackColor = True
        '
        'numBit
        '
        Me.numBit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numBit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.numBit.Location = New System.Drawing.Point(6, 103)
        Me.numBit.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.numBit.Name = "numBit"
        Me.numBit.Size = New System.Drawing.Size(65, 22)
        Me.numBit.TabIndex = 5
        '
        'UcBit1
        '
        Me.UcBit1.IntValue = CType(0, Byte)
        Me.UcBit1.Location = New System.Drawing.Point(6, 19)
        Me.UcBit1.MaximumSize = New System.Drawing.Size(197, 28)
        Me.UcBit1.MinimumSize = New System.Drawing.Size(197, 28)
        Me.UcBit1.Name = "UcBit1"
        Me.UcBit1.Size = New System.Drawing.Size(197, 28)
        Me.UcBit1.StrValue = Nothing
        Me.UcBit1.TabIndex = 1
        '
        'frmBit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 194)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmBit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmBit"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UcBit1 As LEHRMITTEL.ucBit
    Friend WithEvents cmbConvert As System.Windows.Forms.Button
    Friend WithEvents numValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents chNumBit As System.Windows.Forms.CheckBox
    Friend WithEvents numBit As System.Windows.Forms.NumericUpDown
End Class
