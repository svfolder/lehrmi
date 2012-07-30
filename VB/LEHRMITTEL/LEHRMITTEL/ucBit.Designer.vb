<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucBit
    Inherits System.Windows.Forms.UserControl

    'Пользовательский элемент управления (UserControl) переопределяет метод Dispose для очистки списка компонентов.
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
        Me.txtNumBit = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtNumBit
        '
        Me.txtNumBit.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtNumBit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNumBit.Enabled = False
        Me.txtNumBit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.txtNumBit.Location = New System.Drawing.Point(3, 3)
        Me.txtNumBit.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNumBit.Name = "txtNumBit"
        Me.txtNumBit.Size = New System.Drawing.Size(100, 23)
        Me.txtNumBit.TabIndex = 0
        Me.txtNumBit.Text = "0"
        Me.txtNumBit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ucBit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtNumBit)
        Me.MaximumSize = New System.Drawing.Size(106, 28)
        Me.MinimumSize = New System.Drawing.Size(106, 28)
        Me.Name = "ucBit"
        Me.Size = New System.Drawing.Size(106, 28)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNumBit As System.Windows.Forms.TextBox

End Class
