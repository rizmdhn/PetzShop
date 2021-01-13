Imports MySql.Data.MySqlClient
Module Aritmatika
    Public Total As Integer
    Function Calculate(ByRef Harga, ByRef qty)
        Dim Jumlah As Integer
        Jumlah = Harga * qty
        Total = Total + Jumlah
        Return Total
    End Function

End Module
