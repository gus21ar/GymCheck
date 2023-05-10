// Sqlbackup.bat
 sqlcmd -U <sa> -P <2016> -S .\SQLEXPRESS -Q "EXEC sp_BackupDatabases @backupLocation='F:\Archivos\GymCheck\BuckUp\Sql', @databaseName='GymDB', @backupType='F'"