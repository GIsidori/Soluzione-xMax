;#DropDB xMaxEasyTest

#Application xMaxWin
#Application xMaxWeb
#IfDef xMaxWin

*Action About...
 
*Action OK

#EndIf

#IfDef xMaxWeb
!Action Navigation(My Details)
#EndIf
