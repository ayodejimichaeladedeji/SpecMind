namespace SpecMind.Application.Common
{
    public class Result<T>
    {
        public T? Data { get; set; }
        public string? ErrorMessage { get; set; }
        public bool IsSuccess => string.IsNullOrEmpty(ErrorMessage);
    }
}