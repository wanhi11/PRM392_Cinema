namespace PRM_API.Common.Payloads;

public class ApiRoute
{
    public const string Base = "api";

    public static class Movie
    {
        public const string GetAll = Base + "/movies";
        public const string GetById = Base + "/movies/{id}";
        public const string Create = Base + "/movies";
        public const string Update = Base + "/movies";
        public const string Delete = Base + "/movies/{id}";

        public const string GetAllGenre = Base + "/movie-genres";
        public const string GetAllLang = Base + "/movie-languages";
    }
    public static class FAB
    {
        public const string GetAll = Base + "/fab";
        public const string GetById = Base + "/fab/{id}";
        public const string Create = Base + "/fab";
        public const string Update = Base + "/fab";
        public const string Delete = Base + "/fab/{id}";
    }
}