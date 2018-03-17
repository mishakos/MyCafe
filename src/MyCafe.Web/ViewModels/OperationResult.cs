namespace MyCafe.Web.ViewModels
{
    public class OperationResult
    {
        public OperationResult(bool isSucceeded)
        {
            IsSucceeded = isSucceeded;
        }
        public OperationResult(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
        public bool IsSucceeded { get; set; }
        public string ErrorMessage { get; set; }
    }
}
