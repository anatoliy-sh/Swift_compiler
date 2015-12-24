@echo off

%~d0
cd "%~dp0"

rem set JAVA_HOME=C:\Program Files\Java\jdk1.6.0_11
set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v3.5

rem set ANTLR_JAR=.\lib\java\antlr-3.2.jar


rem set JAVA="%JAVA_HOME%\bin\java"
rem set JAVAC="%JAVA_HOME%\bin\javac"
rem set CSC="%NET_HOME%\csc"
set MSBUILD="%NET_HOME%\msbuild"

rem set ANTLR=%JAVA% -classpath .;%CLASSPATH%;%ANTLR_JAR% org.antlr.Tool



%MSBUILD% /target:rebuild .\MathExpr.csproj
