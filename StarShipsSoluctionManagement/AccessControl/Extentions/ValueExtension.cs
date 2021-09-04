using System.Data.SqlClient;

namespace AccessControl.Extensions
{
    public static class ValueExtension
    {

        public static T GetValueOrDefault<T>(this SqlDataReader reader, string field)
        {
            try
            {
                return (T)reader[field];
            }
            catch
            {
                return default(T);
            }
        }

    }
}
