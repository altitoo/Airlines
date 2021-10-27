namespace Airlines.MVC.App_Start
{
    public class ActionResult<T>
    {
        public ActionResult(string msg)
        {
            message = msg;
            success = false;
        }

        public ActionResult(T resultData)
        {
            data = resultData;
            success = true;
        }

        public string message;
        public bool success;
        public T data;
    }
}