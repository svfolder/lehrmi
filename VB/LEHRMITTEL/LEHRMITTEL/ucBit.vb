

Public Class ucBit

    Dim m_value As Byte

    Dim m_stringbit As String


    Property IntValue()
        Get
            Return m_value
        End Get
        Set(ByVal value)
            m_value = value
            SetupValue()
        End Set
    End Property

    Property StrValue() As String
        Get
            Return m_stringbit
        End Get
        Set(ByVal value As String)
            m_stringbit = value
        End Set
    End Property







    '   ПЕРЕСЧИТАЕМ ЧИСЛО В БИТЫ
    Private Sub SetupValue()

        Dim strTmp As String = ""

        '   ЦИКЛ ПО 8ми БИТАМ
        For bit As Integer = 7 To 0 Step -1

            '   ПОЛУЧИТЬ ЗНАЧЕНИЕ БИТА И СЛОЖИТЬ СО СТРОКОЙ
            strTmp &= Me.getBit(m_value, bit)

        Next

        m_stringbit = strTmp
        txtNumBit.Text = m_stringbit

    End Sub

    '   ПОЛУЧИТЬ ЗНАЧЕНИЕ БИТА 0 ИЛИ 1
    Private Function getBit(ByVal Num As Byte, ByVal i As Byte) As Byte


        '   СОБИРАЕМ МАСКУ (1 << i), ЕСЛИ i = 3 МАСКА ПОЛУЧИТСЯ 00000100
        '   ОБЪЕДИНЯЕМ С ЧИСЛОМ, В РЕЗУЛЬТАТЕ ПОЛУЧИМ СБРОС ВСЕХ БИТ КРОМЕ БИТА i,
        '   ТО ЕСТЬ 3тий БИТ НЕ БУДЕТ ЗАТРОНУТ ОПЕРАЦИЕЙ AND
        '   ДАЛЕЕ СРАВНИВАЕМ С 0, ЕСЛИ НЕ НОЛЬ, ЗНАЧИТ ВЕРНЕМ 1, В ПРОТИВНОМ СЛУЧАЕ )))
        If (Num And (1 << i)) <> 0 Then
            Return 1
        Else
            Return 0
        End If


    End Function

    '   УСТАНОВКА БИТА С НОМЕРОМ i
    Public Function setBit(ByVal i As Byte) As Integer

        '   МАСКА АНАЛОГИЧНА ДЛЯ ПОЛУЧЕНИЯ БИТА 00000100
        '   ОПЕРАЦИЯ OR УСТАНАВЛИВАЕТ ТОЛЬКО ВЫСТАВЛЕННЫЙ БИТ В МАСКЕ,
        '   ВСЕ ОСТАЛЬНЫЕ БИТЫ ОСТАНУТСЯ НЕТРОНУТЫ
        IntValue = (m_value Or (1 << i))

        Return IntValue

    End Function

    '   ОЧИСТКА БИТА С ПОД НОМЕРОМ i
    Public Function clearBit(ByVal i As Byte) As Integer

        '   СОБИРАЕМ МАСКУ С ИНВЕРСИЕЙ БИТОВ, ЕСЛИ i = 3
        '   МАСКА ПОЛУЧИТСЯ 11111011

        Dim mask As Integer = Not (1 << i)

        '   ОБЪЕДИНЯЕМ МАСКУ СО ЗНАЧЕНИЕМ
        IntValue = (m_value And mask)

        Return IntValue

    End Function


    Private Sub ucBit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub


End Class
