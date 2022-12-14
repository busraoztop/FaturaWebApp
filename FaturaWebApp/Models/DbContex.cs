using Microsoft.Data.Sqlite;

namespace FaturaWebApp.Models
{
    public static class DbContex
    {
        /// <summary>
        /// Veritabanından fatura listesi getirilir
        /// </summary>
        /// <returns></returns>
        public static List<Fatura> FaturaListesi()
        {


            using (var connection = new SqliteConnection("Data Source=./FaturaDB.db"))
            {
                List<Fatura> faturalar = new List<Fatura>();


                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText =
                @" SELECT FaturaNo, FaturaTarihi, FaturaDurumu FROM Faturalar ";
                

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var faturaNo = reader.GetString(0);
                        var faturaTarihi = reader.GetString(1);
                        var faturaDurumu = reader.GetString(2);
                        
                        faturalar.Add(new Fatura {FaturaNo= faturaNo,FaturaTarihi= faturaTarihi,FaturaDurumu=faturaDurumu});
                    }

                    connection.Close();

                    return faturalar;
                }
            }
        }
    }
}
