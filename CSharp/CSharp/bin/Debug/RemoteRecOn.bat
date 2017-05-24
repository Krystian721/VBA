@echo off
echo StateStorageClassName=NamedPipe; > RevDeBug.setup
echo Application.Name=[Exec]; >> RevDeBug.setup
echo Repository.Path=C:\Users\Damian\Documents\RevDeBug\CSharp\Recordings\{appname}{timestamp}.tmox; >> RevDeBug.setup
@echo on
@echo RevDeBug Record is ON.
