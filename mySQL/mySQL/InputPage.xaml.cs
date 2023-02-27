using MySql.Data.MySqlClient;
using System.Windows;

namespace mySQL;

public partial class InputPage : ContentPage
{
	public InputPage()
	{
		InitializeComponent();
	}

	void OnButtonClicked(object sender, EventArgs args)
	{
        // get connection
        string connectionString = "server=192.169.144.133;database=sr_team_6;uid=mcctc6;pwd=mcctcrocks;";
        MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        // publish data
        string query = $"INSERT INTO PLAYERS (PLAYER_ID, FIRST_NAME, LAST_NAME, PHONE_NUMBER, DISCORD_ID, ESPORT_GAME) VALUES ('{xPid.Text}', '{xFirstN.Text}', '{xLastN.Text}', '{xPhone.Text}', '{xDiscord.Text}', '{xEsportsGame.Text}')";
        MySqlCommand command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();

        // close
        connection.Close();
    }
}