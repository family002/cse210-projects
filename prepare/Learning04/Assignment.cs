public class Assignment
{
    private string _studentname;
    private string _topic;
    
    public Assignment(string studentname, string topic)
    {
            _studentname = studentname;
            _topic = topic;
    }

    public string GetStudentName()
    {
        return _studentname;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public string GetSummary()
    {
        return _studentname + " - " + _topic;
    }
}