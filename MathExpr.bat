@echo off

set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v2.0.50727

set CSC="%NET_HOME%\csc.exe"
set ILASM="%NET_HOME%\ilasm.exe"



if "%1"=="" (
  echo Usage:
  echo   %~nx0 ^<source_file^>
  exit
)



del "%~n1.exe" "%~n1.ilasm" >nul 2>nul

setlocal enabledelayedexpansion
set START=
(
  for /f "delims=" %%s in ('"%~dp0bin\Debug\MathExpr.exe" %1') do (
    set STR=%%s
    if "!STR!"==".assembly extern mscorlib" (
      set START=true
    )
    if "!START!"=="true" (
      echo !STR!
    )
  )
) >"%~n1.ilasm"
setlocal disabledelayedexpansion

%ILASM% "/output=%~n1.exe" "%~n1.ilasm"

rem for java byte code(*.j)
rem %JASMIN% "%~n1.j"
