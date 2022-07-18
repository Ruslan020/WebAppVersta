# WebAppVersta
### Начало работы

1. В файле appsettings.json необходимо указать строку подключения к серверу SQL, указав имя самого сервера, имя и пароль учетной записи, которая может к нему подключиться.
2. Открыть командную строку в корне проекта. 
3. Если не установлен dotnet, то выполнить команду "dotnet tool install --global dotnet-ef"
4. Выполнить команду "dotnet ef migrations add <Название миграции>"
5. Выполнить команду "dotnet ef database update"
6. Запустить выполнение
