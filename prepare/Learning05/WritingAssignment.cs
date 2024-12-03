using System;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }    
    
    public string GetWritingInformation()
    {
        // because studentName is private in base class, we need to call the 
        // GetStudentName() getter method to return the name
        return $"{_title} by {GetStudentName()}";
    }
    
}