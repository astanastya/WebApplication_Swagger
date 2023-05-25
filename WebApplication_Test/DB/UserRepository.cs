using Newtonsoft.Json;

namespace WebApplication_Test.DB;

public static class UserRepository
{
    public static string _jsonPath = "C:\\Users\\aastafieva\\source\\repos\\WebApplication_Swagger\\WebApplication_Test\\DB\\Users.json";
    public static List<User> Get()
    {
        string jsonContent = File.ReadAllText(_jsonPath);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonContent);
        return users;
    }

    public static void Save(List<User> users)
    {
        string jsonContent = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText(_jsonPath, jsonContent);
    }
}