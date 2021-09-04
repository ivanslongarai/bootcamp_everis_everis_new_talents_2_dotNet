using System;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace AccessControl.Dao
{
    public abstract class BaseDao : IDisposable
    {
        protected readonly SqlConnection con;

        protected BaseDao()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-VF2HIDE\SQLEXPRESS;Initial Catalog=DeathStar;Integrated Security=True;Connect Timeout=30");
        }

        protected async Task Insert(string command)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(command, con);
            await cmd.ExecuteNonQueryAsync();
            con.Close();
        }

        protected async Task Select(string command, Action<SqlDataReader> readerHandler)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(command, con);
            SqlDataReader dr = await cmd.ExecuteReaderAsync();
            readerHandler(dr);
            con.Close();
        }

        public void Dispose()
        {
            con?.Close();
            con?.Dispose();
        }
    }
}
