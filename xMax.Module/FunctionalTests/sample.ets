;#DropDB xMaxEasyTest

#Application xMaxWin
#Application xMaxWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef xMaxWin

*Action About...
 
*Action OK

#EndIf

#IfDef xMaxWeb
*Action Navigation(My Details)
#EndIf
