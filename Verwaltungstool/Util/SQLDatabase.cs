using MySqlConnector;
using System;
using System.Threading.Tasks;

namespace MySQL_Datenbanken
{
    /// <copyright>(c) Nic Markfort 2021</copyright>
    /// <summary>
    /// Die Klasse vereinfacht die Nutzung des MySqlConnector
    /// </summary>
    public class SQLDatabase
    {
        #region Felder
        private readonly MySqlConnectionStringBuilder _mySqlConnectionStringBuilder;
        #endregion

        #region Eigenschaften
        public MySqlConnection Verbindung { get; private set; }
        #endregion

        public SQLDatabase(string hostname, string benutzername, string passwort, string datenbank, uint port = 3306)
        {

            this._mySqlConnectionStringBuilder = new MySqlConnectionStringBuilder
            {
                Server = hostname,
                UserID = benutzername,
                Password = passwort,
                Database = datenbank,
                Port = port
            };
        }
        
        public bool IstVerbunden()
        {
            if (this.Verbindung == null) return false;

            switch (this.Verbindung.State)
            {
                case System.Data.ConnectionState.Connecting:
                case System.Data.ConnectionState.Closed:
                case System.Data.ConnectionState.Broken:
                case System.Data.ConnectionState.Executing:
                case System.Data.ConnectionState.Fetching:
                    return false;
                case System.Data.ConnectionState.Open:
                    return true;
            }

            return false;
        }

        public void Verbinden()
        {
            this.Verbindung = new MySqlConnection(this._mySqlConnectionStringBuilder.ConnectionString);
                this.Verbindung.Open();
        }

        public async Task<bool> AsyncWartenVerbinden()
        {
            this.Verbindung = new MySqlConnection(this._mySqlConnectionStringBuilder.ConnectionString);
            await this.Verbindung.OpenAsync();
            return true;
        }

        public void AsyncVerbinden()
        {
            this.Verbindung = new MySqlConnection(this._mySqlConnectionStringBuilder.ConnectionString);
            this.Verbindung.OpenAsync();
        }

        public void Schreiben(string abfrage)
        {
            if (!this.IstVerbunden())
                this.Verbinden();

            new MySqlCommand(abfrage, this.Verbindung).ExecuteNonQuery();
        }

        public async void AsyncWrite(string abfrage)
        {
            if (!this.IstVerbunden())
                await this.AsyncWartenVerbinden();

            new MySqlCommand(abfrage, this.Verbindung).ExecuteNonQuery();
        }

        public MySqlDataReader Lesen(string abfrage)
        {
            if (!this.IstVerbunden())
                this.Verbinden();

            return new MySqlCommand(abfrage, this.Verbindung).ExecuteReader();
        }

        public void AsyncLesen(string abfrage, Action<MySqlDataReader> callback)
        {
            if (!this.IstVerbunden())
                this.Verbinden();

            Task.Run(() => {

                MySqlDataReader mySqlDataReader = new MySqlCommand(abfrage, this.Verbindung).ExecuteReader();
                callback.Invoke(mySqlDataReader);

                mySqlDataReader.Close();
            });
        }

        public async Task<MySqlDataReader> AsyncLesen(string abfrage)
        {
            if (!this.IstVerbunden())
                await this.AsyncWartenVerbinden();

            return await new MySqlCommand(abfrage, this.Verbindung).ExecuteReaderAsync();
        }

    }
}
