using Microsoft.Extensions.Configuration;

namespace Dal
{
    public static class DalAccess
    {
        public static string GetConnectionString(string name)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("dbDrinkAndCollect.json")
                .Build();
            return configuration.GetConnectionString("DefaultConnection");
        }
    }
}
