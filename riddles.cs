using System;


class Sphinx 
{
   
    static void Main()
    {
      
        Console.WriteLine("What get wetter the more it dries?");  
        string answerOne = Console.ReadLine();
        string finalAnswerOne = answerOne.ToLower();
        bool ansOneBool = finalAnswerOne == "towel";
        if(ansOneBool){
            Console.WriteLine("Good Job... How about another");
        } else {
            Console.WriteLine("you lose");
        }
       
        Console.WriteLine("You measure my life in hours, I serve you by expiring. I am fast when I'm thin, and slow when I'm fat. The wind is my enemy. What am I");
        string answerTwo = Console.ReadLine();
        string finalAnswerTwo = answerTwo.ToLower();
        bool ansTwoBool = finalAnswerTwo == "candle";
        if(ansTwoBool){
            Console.WriteLine("Good Work, you're very good at this. Another One");
        } else {
            Console.WriteLine("idiot");
        }

        Console.WriteLine("I have a mouth but do not speek, I have a bed but do not sleep, I run everywhere but go nowhere, what am I?");
        string answerThree = Console.ReadLine();
        string finalAnswerThree = answerThree.ToLower();
        bool ansThreeBool = finalAnswerThree == "river";
        if (ansThreeBool){
            Console.WriteLine("Nice! You gotem");
        }else{
            Console.WriteLine("No");
        }
    }
}