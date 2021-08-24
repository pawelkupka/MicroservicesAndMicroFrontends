namespace Common.Application.Authorization
{
    public record AuthorizationResult
    {
        public AuthorizationResult(bool isAuthorized, string errorMessage)
        {
            IsAuthorized = isAuthorized;
            ErrorMessage = errorMessage;
        }

        public bool IsAuthorized { get; init; }
        public string ErrorMessage { get; init; }

        public static AuthorizationResult Success() => new AuthorizationResult(true, null);
        public static AuthorizationResult Fail(string errorMessage) => new AuthorizationResult(false, errorMessage);
    }
}
