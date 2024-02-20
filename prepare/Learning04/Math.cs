using System;
using System.Diagnostics.CodeAnalysis;

public class Math : Assignment
{
    private string _textBookSection;
    private string _problems;

    public Math(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }
}