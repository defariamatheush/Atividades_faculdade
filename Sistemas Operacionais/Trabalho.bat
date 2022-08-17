@echo off


:inicio
cls

echo Informe uma opcao:
echo [1] Abrir "Bloco de notas"
echo [2] Excluir arquivo
echo [3] Versao do programa
echo [4] Help
echo [5] Fechar o programa

set /p numero=Informe uma opcao:
if %numero% == 1 (goto :opcao1) 
if %numero% == 2 (goto :opcao2) 
if %numero% == 3 (goto :opcao3) 
if %numero% == 4 (goto :opcao4) 
if %numero% == 5 (goto :opcao5) 

:opcao1
echo Abrindo o BLOCO DE NOTAS
timeout 3 > NUL
start notepad.exe
goto :inicio

:opcao2
echo Informe o diretorio com o nome do arquivo:
set /p diretorio=Diretorio(Colocar aspas duplas no inicio e final do diretorio): 
echo deletando...
echo %diretorio% 
del %diretorio%
timeout 2 > nul
echo Arquivo deletado
goto :inicio

:opcao3
echo --version 0.1.0
echo [1] Finalizar programa
echo [2] Voltar para o menu
set /p opc=Opcao:
if %opc% == 1 (goto :opcao5)
if %opc% == 2 (goto :inicio)


:opcao4
echo Help:
echo Opcao 1: Fara abrir o bloco de notas
echo Opcao 2: Informar o diretorio do arquivo com o nome do arquivo e extensao
echo Opcao 3: Sera mostrado a versao do programa
echo Opcao 4: Ira mostrar como funciona o programa
echo Opcao 5: Sera finalizado o programa
echo [1] Finalizar programa
echo [2] Voltar para o menu
set /p opc1=Opcao:
if %opc1% == 1 (goto :opcao5)
if %opc1% == 2 (goto :inicio)


:opcao5
echo Finalizando Programa
timeout 3 > nul
goto :fim



:fim

