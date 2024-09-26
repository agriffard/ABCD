namespace ABCD.Controllers;

public class BaseController : Controller
{
    protected void AddMessage(string message, string messageType = "alert-primary")
    {
        base.TempData.Clear();
        base.TempData.Add("Message", message);
        base.TempData.Add("MessageType", messageType);
    }

    protected void AddErrorMessage(string message) => AddMessage(message, "alert-danger");
    protected void AddInformationMessage(string message) => AddMessage(message, "alert-info");
    protected void AddSuccessMessage(string message) => AddMessage(message, "alert-success");
    protected void AddWarningMessage(string message) => AddMessage(message, "alert-warning");
}
