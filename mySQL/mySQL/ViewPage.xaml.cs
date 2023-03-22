using MySql.Data.MySqlClient;

namespace mySQL;

public partial class ViewPage : ContentPage

{

	public ViewPage()
	{
        InitializeComponent();
    }

    private void LookupStudentInfo_Clicked(object sender, EventArgs e)
    {
        //get connection
        string connectionString = "server=192.169.144.133;database=sr_team_6;uid=mcctc6;pwd=mcctcrocks;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();
        string query = $@"SELECT * FROM PLAYERS WHERE PLAYER_ID = '{LookupID.Text}';";
        using var cmd = new MySqlCommand(query, connection);
        using MySqlDataReader reader = cmd.ExecuteReader();
        while (reader.Read())
        {
            FirstNameLookup.Text = reader.GetString(1);
            LastNameLookup.Text = reader.GetString(2);
            PhoneNumberLookup.Text = reader.GetString(3);
            DiscordIDLookup.Text = reader.GetString(4);
            GameLookup.Text = reader.GetString(5);
        }
        connection.Close();
    }
}

public class Monkey
{
    public string Name { get; set; }
    public string Location { get; set; }
    public string Details { get; set; }
    public string ImageUrl { get; set; }
}