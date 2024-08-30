using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace SGC.Helppers
{
    public static class Session
    {
        public static string conn = "datasource=localhost;port=3306;username=root;password=;database=gestao_contratos";
        public static string UserName { get; set; }
        public static string Nomec { get; set; }
        public static string Nome { get; set; }
        public static string Nomerh { get; set; }
        public static string Emailrh { get; set; }
        public static string hoje { get; set; }
        public static string Emailc { get; set; }
        public static string Email { get; set; }
        public static string Error { get; set; }
        public static string s { get; set; }
        public static string curso { get; set; }
        public static string Sobrenomec { get; set; }
        public static string Sobrenome { get; set; }
        public static string Sobrenomerh { get; set; }
    }
    public static class conexao
    {
        public static string connectionString = "Server=localhost;Database=gestao_contratos;User=root;Password=;";

        public static string path = Directory.GetCurrentDirectory() + "\\banco-de-dados-SGC.sqlite";
        private static string sqliteconn;

    }

        internal class Helpper
    {

    }
}
