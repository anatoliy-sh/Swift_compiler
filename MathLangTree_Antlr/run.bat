@echo off

%~d0
cd "%~dp0"


rem set JAVA_HOME=C:\Program Files\Java\jdk1.6.0_11
rem set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v4.0.30319

rem if exist .\_props.bat call .\_props.bat

rem set ANTLR_JAR=.\antlr\java\antlr-3.3-complete.jar


rem set JAVA="%JAVA_HOME%\bin\java"
rem set JAVAC="%JAVA_HOME%\bin\javac"
rem set CSC="%NET_HOME%\csc"
rem set MSBUILD="%NET_HOME%\msbuild"

rem set ANTLR=%JAVA% -classpath .;%CLASSPATH%;%ANTLR_JAR% org.antlr.Tool



.\bin\Debug\MathLang.exe .\Input.txt
