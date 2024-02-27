using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int time = 30;

        Breathing breathing = new Breathing(time, "Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        breathing.StartBreathing(time);
        breathing.EndMessage();
    }
}