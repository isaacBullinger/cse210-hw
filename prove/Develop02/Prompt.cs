// Class: Prompt
// Attributes:
// * _prompts = List<string>;

// Behaviors:
// * DisplayPrompt(string)

using System;
using System.Reflection.Metadata.Ecma335;

// This class contains a prompt list that populates itself.
// A random number is generated to select a random prompt.
// The prompt is then returned from the class.
public class Prompt
{
    public List<string> _prompts = new List<string>();
    public string _prompt;
    string _prompt1 = "Who was the most interesting person I interacted with today?";
    string _prompt2 = "What was the best part of my day?";
    string _prompt3 = "How did I see the hand of the Lord in my life today?";
    string _prompt4 = "What was the strongest emotion I felt today?";
    string _prompt5 = "If I had one thing I could do over today, what would it be?";
    public string GivePrompt()
    {
        _prompts.Add(_prompt1);
        _prompts.Add(_prompt2);
        _prompts.Add(_prompt3);
        _prompts.Add(_prompt4);
        _prompts.Add(_prompt5);

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, _prompts.Count);
        _prompt = _prompts[number];
        
        return _prompt;
    }
}