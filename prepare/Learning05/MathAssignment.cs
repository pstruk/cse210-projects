using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // 4 parameters (2 from base class, 2 from this class)
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) 
        : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}