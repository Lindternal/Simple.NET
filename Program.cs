using Microsoft.Data.Sqlite;

File.Create(Constants.DatabaseFile).Close();

using (SqliteConnection databaseConnection = new SqliteConnection(Constants.DatabaseConnectionString))
{
    databaseConnection.Open();

    using (var command = databaseConnection.CreateCommand())
    {
        command.CommandType = System.Data.CommandType.Text;

        command.CommandText = "CREATE TABLE Investors (investor_id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, surname TEXT, address TEXT, email TEXT, phone TEXT, registration_date DATE);";
        command.ExecuteNonQuery();

        command.CommandText = "CREATE TABLE Funds (fund_id INTEGER PRIMARY KEY AUTOINCREMENT, fund_name TEXT, description TEXT, creation_date DATE, fund_size REAL, current_assets REAL);";
        command.ExecuteNonQuery();

        command.CommandText = "CREATE TABLE Transactions (transaction_id INTEGER PRIMARY KEY AUTOINCREMENT, investor_id INTEGER REFERENCES Investors(investor_id), fund_id INTEGER REFERENCES Funds(fund_id), transaction_type TEXT, transaction_amount REAL, transaction_date DATE);";
        command.ExecuteNonQuery();
    }
    
    databaseConnection.Close();
}