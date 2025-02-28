namespace Leave_Management_System_WorkFlow_API.Routes;

public static class Routes
{
    private const string ApiBaseUrl = "api/v1";

    public static class Login
    {
        private const string Base = $"{ApiBaseUrl}/auth";
        
        public const string LoginUser = $"{Base}/login";
        public const string LogoutUser = $"{Base}/logout";
        public const string RegisterUser = $"{Base}/register";
    }

    public static class LeaveRequest
    {
        private const string Base = $"{ApiBaseUrl}/leave";

        public const string Create = Base;
        public const string Get = $"{Base}/{{id:guid}}";
        public const string GetAll = $"{Base}/all";
        public const string Update = $"{Base}/{{id:guid}}";
        public const string Delete = $"{Base}/{{id:guid}}";
    }

    public static class Employee
    {
        private const string Base = $"{ApiBaseUrl}/employee";

        public const string Create = Base;
        public const string Get = $"{Base}/{{id:guid}}";
        public const string GetAll = $"{Base}/all";
        public const string Update = $"{Base}/{{id:guid}}";
        public const string Delete = $"{Base}/{{id:guid}}";
    }
}