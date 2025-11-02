!define /date MyTIMESTAMP "%Y-%m-%d@%H-%M"
Name "Kairos"
OutFile "Kairos_Setup-${MyTIMESTAMP}.exe"
InstallDir "$DESKTOP\Kairos"

RequestExecutionLevel user

Page Directory
Page Instfiles
;--------------------------------
Section "Files" 
  CreateDirectory "$INSTDIR"
  SetOutPath "$INSTDIR"
  
  ; Put files there
  File /r ".\Release\net9.0-windows\*.dll"
  File /r ".\Release\net9.0-windows\*.exe"
  File /r ".\Release\net9.0-windows\*.json"
  ;File /r ".\Release\net9.0-windows\*.ico"
  ;File "..\*.toml"
SectionEnd ; end the section
