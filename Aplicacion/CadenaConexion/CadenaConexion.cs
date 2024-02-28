namespace Aplicacion.CadenaConexion
{
    public static class CadenaConexion
    {
        //atributos
        private const string Server = "LAPTOP-00ETFL4J\\SQLEXPRESS";
        private const string DataBase = "XCommerce";
        private const string User = "sa";
        private const string Password = "12345";

        //propiedad
        public static string ObtenerCadenaSql => $"Data Source={Server}; " +
                                                $"Initial Catalog={DataBase}; " +
                                                $"User Id={User}; " +
                                                $"Password={Password};";
    }
}
