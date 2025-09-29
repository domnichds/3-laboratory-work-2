using System;

namespace lab02_01
{
    class ClassRoom
    {
        private Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils )
        {
            this.pupils = new Pupil[4];

            for (int i = 0; i < pupils.Length && i < 4; i++)
            {
                this.pupils[i] = pupils[i];
            }
            for (int i = pupils.Length; i < 4; i++)
            {
                this.pupils[i] = new GoodPupil();
            }
        }

        public void PrintInfo()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ученик №{i + 1}:");
                pupils[i].Study();
                pupils[i].Write();
                pupils[i].Read();
                pupils[i].Relax();
            }
        }


    }
    public class Pupil
    {
        public virtual void Study() 
        {
            Console.WriteLine("Ученик учится");
        }
        public virtual void Read() 
        {
            Console.WriteLine("Ученик читает");
        }
        public virtual void Write()
        {
            Console.WriteLine("Ученик пишет");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Ученик отдыхает");
        }
    }
    public class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Отличник учится");
        }

        public override void Read()
        {
            Console.WriteLine("Отличник читает");
        }

        public override void Write()
        {
            Console.WriteLine("Отличник пишет");
        }

        public override void Relax()
        {
            Console.WriteLine("Отличник отдыхает");
        }
    }

    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Хорошист учится");
        }

        public override void Read()
        {
            Console.WriteLine("Хорошист читает");
        }

        public override void Write()
        {
            Console.WriteLine("Хорошист пишет");
        }

        public override void Relax()
        {
            Console.WriteLine("Хорошист отдыхает");
        }
    }
    public class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Двоечник учится");
        }

        public override void Read()
        {
            Console.WriteLine("Двоечник читает");
        }

        public override void Write()
        {
            Console.WriteLine("Двоечник пишет");
        }

        public override void Relax()
        {
            Console.WriteLine("Двоечник отдыхает");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassRoom new_class1 = new ClassRoom(
                new BadPupil(),
                new ExcelentPupil(),
                new GoodPupil(),
                new BadPupil());
            new_class1.PrintInfo();
            ClassRoom new_class2 = new ClassRoom(new BadPupil());
            new_class2.PrintInfo();
        }
    }
}