using System;
using System.Collections.Generic;

namespace PokeGotchi.Models
{
    public class Pikachu
    {
        public int Fullness {get;set;}
        public int Happiness {get;set;}
        public int Meals {get;set;}
        public int Energy {get;set;}
        public bool isConscious {get;set;}
        public string Emotion {get;set;}
        public List<string> ActivityLog {get;set;}

        public Pikachu()
        {
            Fullness = 20;
            Happiness = 20;
            Meals = 3;
            Energy = 50;
            isConscious = true;
            ActivityLog = new List<string>();
            Emotion = "~/images/pika_neutral.png";
        }
        public void Feed()
        {
            if(Meals > 0)
            {
                Random rand = new Random();
                Meals--;
                int chance = rand.Next(1,5);
                if(chance == 1)
                {
                    Happiness-=3;
                    ActivityLog.Insert(0, "Pikachu thinks your cooking sucks");
                    Emotion = "~/images/pika_angry.png";
                    if(Happiness <= 0)
                    {
                        isConscious = false;
                        ActivityLog.Insert(0, "Pikachu thinks your cooking sucks so much he lost consciousness");
                        Emotion = "~/images/pika_ko.png";
                    }
                } else{
                    Fullness+=rand.Next(5,11);
                    ActivityLog.Insert(0, "Pikachu loved your meal!");
                    Emotion = "~/images/pika_happy.png";
                    if(Energy >= 100 && Happiness >= 100 && Fullness >= 100)
                    {
                        isConscious = false;
                        ActivityLog.Insert(0, "Pikachu is as fat and happy as can be!");
                        Emotion = "~/images/pika_superhappy.png";
                    }
                }
            }
        }

        public void Play()
        {
            Energy-=5;
            Random rand = new Random();
            int chance = rand.Next(1,5);
            if(chance == 1)
            {
                Happiness-=2;
                ActivityLog.Insert(0, "Pikachu doesn't find you amusing right now...");
                Emotion = "~/images/pika_unamused.png";
                if(Happiness <= 0)
                {
                    isConscious = false;
                    ActivityLog.Insert(0, "Pikachu fainted! Trainer whited out!");
                    Emotion = "~/images/pika_ko.png";
                }
            } else{
                Happiness+=rand.Next(5,11);
                ActivityLog.Insert(0, "Pikachu had lots of fun playing with you!");
                Emotion = "~/images/pika_happy.png";
                if(Energy >= 100 && Happiness >= 100 && Fullness >= 100)
                {
                    isConscious = false;
                    ActivityLog.Insert(0, "Pikachu got heat stroke and fainted!");
                    Emotion = "~/images/pika_ko.png";
                }
            }
        }

        public void Work()
        {
            Energy-=5;
            Random rand = new Random();
            Meals+=rand.Next(1,4);
            ActivityLog.Insert(0, "Pikachu worked hard for the money!");
            Emotion = "~/images/pika_neutral.png";
        }

        public void Sleep()
        {
            if(Energy<100)
            {
                Energy+=15;
            }
            Happiness-=5;
            Fullness-=5;
            ActivityLog.Insert(0, "Pikachu took a nap");
            Emotion = "~/images/pika_sleeping.png";
            if(Happiness <= 0 || Fullness <= 0)
            {
                isConscious = false;
                ActivityLog.Insert(0, "Pikachu took the big sleep");
                Emotion = "~/images/pika_ko.png";
            }
            if(Energy >= 100 && Happiness >= 100 && Fullness >= 100)
            {
                isConscious = false;
                ActivityLog.Insert(0, "Pikachu woke up happier than ever. The end.");
                Emotion = "~/images/pika_superhappy.png";
            }
        }
    }
}