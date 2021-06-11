Imports System.Runtime.InteropServices

Module Module1

    Sub Main()
        Dim ValueA As Double = 2.0
        Dim ValueB As Double = 1.0
        Dim res As Double
        res = Subtract(ValueA, ValueB)
        Console.WriteLine($"ValueA({ValueA})-ValueB({ValueB})={res}")
        Console.ReadLine()
    End Sub

    <DllImport("MyDll.dll", EntryPoint:="Subtract", CallingConvention:=CallingConvention.Cdecl)>
    Public Function Subtract(ByRef A As Double, ByRef B As Double) As Double
    End Function

End Module
