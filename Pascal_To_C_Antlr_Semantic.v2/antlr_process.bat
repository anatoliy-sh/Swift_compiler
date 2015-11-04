@echo off

%~d0
cd "%~dp0"

set JAVA_HOME=C:\Program Files\Java\jdk1.6.0_11
set NET_HOME=C:\WINDOWS\Microsoft.NET\Framework\v3.5

set ANTLR_JAR=.\lib\java\antlr-3.2.jar


set JAVA="%JAVA_HOME%\bin\java"
set JAVAC="%JAVA_HOME%\bin\javac"
set NATIVE2ASCII="%JAVA_HOME%\bin\native2ascii"
set CSC="%NET_HOME%\csc"
set MSBUILD="%NET_HOME%\msbuild"

set ANTLR=%JAVA% -classpath .;%CLASSPATH%;%ANTLR_JAR% org.antlr.Tool



mkdir antlr_temp_dir
%NATIVE2ASCII% -encoding Windows-1251 MathExpr.g antlr_temp_dir\MathExpr.g
%ANTLR% antlr_temp_dir\MathExpr.g
%NATIVE2ASCII% -encoding Windows-1251 -reverse antlr_temp_dir\MathExprLexer.cs MathExprLexer.cs
%NATIVE2ASCII% -encoding Windows-1251 -reverse antlr_temp_dir\MathExprParser.cs MathExprParser.cs
rmdir /s /q antlr_temp_dir
