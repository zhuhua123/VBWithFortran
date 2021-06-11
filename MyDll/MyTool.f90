module MyTool
contains
    double precision function Subtract(A,B)
    !DEC$ ATTRIBUTES DLLEXPORT :: Subtract
    !DEC$ ATTRIBUTES ALIAS: 'Subtract' :: Subtract
    !DEC$ ATTRIBUTES REFERENCE :: A, B
    implicit none
    double precision,intent(in) :: A,B
    Subtract=A-B
    return
    end function Subtract
end module MyTool