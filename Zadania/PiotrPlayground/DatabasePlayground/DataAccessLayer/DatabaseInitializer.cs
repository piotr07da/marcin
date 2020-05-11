using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Text;

namespace PiotrPlayground.DatabasePlayground.DataAccessLayer
{
    public class DatabaseInitializer
    {
        public void InitializeIfNotExist(string databaseFilePath)
        {
            if (File.Exists(databaseFilePath))
            {
                // jak baza danych istnieje to nie ma nic do roboty więc od razu kończymy metodę:
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection($"URI=file:{databaseFilePath}")) // tworzymy nowe połączenie do bazy danych, jako connection string przekazujemy ścieżkę pliku, w którym utworzy się nowa baza danych
                {
                    connection.Open(); // połączenie do bazy trzeba otworzyć

                    CreateNodesTable(connection);
                    CreateDepartmentsTable(connection);
                    CreateEmployeesTable(connection);
                    //CreateSupervisorTable(connection);
                }
            }
            catch
            {
                // Jeżeli plik bazy danych się utworzyło ale podczas tworzenia tabel poleciał wyjątek to taką bazę danych usuwamy jako uszkodzoną.
                if (File.Exists(databaseFilePath))
                {
                    File.Delete(databaseFilePath);
                }
                throw; // i rzucamy wyjątek dalej w górę
            }
        }

        private void CreateNodesTable(SQLiteConnection connection)
        {
            using (var command = new SQLiteCommand(connection)) // tworzymy nowe polecenie bazodanowe (w tym przypadku słowo kluczowe using pełni zupełnie inną funkcję niż znana do tej pory)
            {
                // budujemy treść polecenia bazodanowego tworzącego tabelę Nodes z kolumnami Id, ParentId, Value, gdzie kluczem głównym tabeli będzie kolumna Id

                var commandTextBuilder = new StringBuilder();
                commandTextBuilder.Append("create table Nodes (");
                commandTextBuilder.Append("Id blob not null,");
                commandTextBuilder.Append("ParentId blob null,");
                commandTextBuilder.Append("Value text,");
                commandTextBuilder.Append("primary key (Id))");
                var commandText = commandTextBuilder.ToString();

                command.CommandText = commandText; // przypisujemy treść polecenia do polecenia

                // wywołujemy polecenie na bazie danych

                command.ExecuteNonQuery();

                // budujemy treść polecenia bazodanowego tworzącego tabelę Employee (pracownik) z kolumnami Id, FirstName, LastName, Department, SupervisorId
            }
        }

        private void CreateDepartmentsTable(SQLiteConnection connection)
        {
            using (var command = new SQLiteCommand(connection))
            {
                // budujemy treść polecenia bazodanowego tworzącego tabelę Departments (działy w firmie) z kolumnami Id, Name

                var commandTextBuilder = new StringBuilder();
                commandTextBuilder.Append("create table Departments (");
                commandTextBuilder.Append("Id blob not null,");
                commandTextBuilder.Append("Name text,");
                commandTextBuilder.Append("primary key (Id))");
                var commandText = commandTextBuilder.ToString();

                command.CommandText = commandText; // przypisujemy treść polecenia do polecenia

                // wywołujemy polecenie na bazie danych

                command.ExecuteNonQuery();
            }
        }

        private void CreateEmployeesTable(SQLiteConnection connection)
        {
            using (var command = new SQLiteCommand(connection))
            {
                // budujemy treść polecenia bazodanowego tworzącego tabelę Employee (pracownik) z kolumnami Id, FirstName, LastName, SupervisorId, DepartmentId

                var commandTextBuilder = new StringBuilder();
                commandTextBuilder.Append("create table Employees (");
                commandTextBuilder.Append("Id blob not null,");
                commandTextBuilder.Append("FirstName text,");
                commandTextBuilder.Append("LastName text,");
                commandTextBuilder.Append("SupervisorId blob null,");
                commandTextBuilder.Append("DepartmentId blob null,");
                commandTextBuilder.Append("primary key (Id))");
                var commandText = commandTextBuilder.ToString();

                command.CommandText = commandText; // przypisujemy treść polecenia do polecenia

                // wywołujemy polecenie na bazie danych

                command.ExecuteNonQuery();
            }
        }
        //private void CreateSupervisorTable(SQLiteConnection connection)
        //{
        //    using (var command = new SQLiteCommand(connection))
        //    {
        //        var commandTextBuilder = new StringBuilder();

        //        commandTextBuilder.Append("create table Supervisors (");
        //        commandTextBuilder.Append("Id blob not null,");
        //        commandTextBuilder.Append("FirstName text,");
        //        commandTextBuilder.Append("LastName text,");
        //        commandTextBuilder.Append("DepartmentId blob null,");
        //        commandTextBuilder.Append("primary key (Id))");

        //        var commandText = commandTextBuilder.ToString();

        //        command.CommandText = commandTextBuilder;

        //        command.ExecuteNonQuery();
        //    }
        //}
    }
}
