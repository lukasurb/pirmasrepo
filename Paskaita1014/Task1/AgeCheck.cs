using System;
namespace Task1
{
    public class AgeCheck
    {
        public int AmziausIvedimas()
        {
            Console.Write("Iveskite amziu: ");
            int amzius = Convert.ToInt32(Console.ReadLine());
            return amzius;
        }

        public Galimybes AmziausPatikrinimas(int amzius)
        {
            if (amzius < 18)
            {
                return Galimybes.Nieko;
            }
            else if (amzius < 20)
            {
                return Galimybes.Vairuoti;
            }
            else
            {
                return Galimybes.VairuotiirGerti;
            }
        }

    }
}
