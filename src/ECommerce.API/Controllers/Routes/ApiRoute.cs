namespace ECommerce.API.Controllers.ApiRoute
{
    public  static class ApiRoute
    {
        public static class Category
        {
            public const string BaseUrl = "api/categories";
            public const string List = "";
            public const string Create = "";
            public const string Update = "{id}";
            public const string Delete = "{id}";
            public const string GetById = "{id}";
        }
        public static class Product
        {
            public const string BaseUrl = "api/products";
            public const string List = "";
            public const string Create = "";
            public const string Update = "{id}";
            public const string Delete = "{id}";
            public const string GetById = "{id}";
        }
    }
}
