Public Class frmBit




    Private Sub cmbConvert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConvert.Click



    End Sub


    Private Sub numValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numValue.ValueChanged

        UcBit1.IntValue = sender.value

    End Sub

    Private Sub frmBit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        numValue.Value = 5

    End Sub

    Private Sub chNumBit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chNumBit.CheckedChanged

        updateBit()

    End Sub

    Private Sub numBit_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numBit.ValueChanged

        updateBit()

    End Sub

    Private Sub updateBit()

        If chNumBit.Checked Then
            '   ВЫСТАВИМ numBit.Value БИТ В 1
            Me.Text = UcBit1.setBit(Me.numBit.Value)

        Else
            '   ОЧИСТИТЬ numBit.Value БИТ В 1
            Me.Text = UcBit1.clearBit(Me.numBit.Value)

        End If

    End Sub

End Class