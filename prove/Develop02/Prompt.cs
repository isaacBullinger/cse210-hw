// Class: Prompt
// Attributes:
// * _prompts = List<string>;
// * _prompt = string

// Behaviors:
// * GivePrompt : string

using System;
using System.Reflection.Metadata.Ecma335;

// This class contains a prompt list that populates itself.
// A random number is generated to select a random prompt.
// The prompt is then returned from the class.
public class Prompt
{
    public List<string> _prompts = new List<string>();
    public string _prompt;
    public string GivePrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, _prompts.Count);
        _prompt = _prompts[number];
        
        return _prompt;
    }
}