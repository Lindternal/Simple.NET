using System.Data.SqlClient;
public class Constants
{
    public const string DatabaseFile = "db.sqlite";
}

public static class MyConnectionString
{
    public static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
    public static string ConnectionString => builder.ConnectionString;

    static MyConnectionString()
    {
        builder.DataSource = Constants.DatabaseFile;
    }
}