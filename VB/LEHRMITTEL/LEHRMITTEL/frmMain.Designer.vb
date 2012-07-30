<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cmbBits = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbBits
        '
        Me.cmbBits.Location = New System.Drawing.Point(12, 12)
        Me.cmbBits.Name = "cmbBits"
        Me.cmbBits.Size = New System.Drawing.Size(78, 28)
        Me.cmbBits.TabIndex = 0
        Me.cmbBits.Text = "Биты"
        Me.cmbBits.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(350, 165)
        Me.Controls.Add(Me.cmbBits)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Наглядное пособие"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbBits As System.Windows.Forms.Button

End Class
