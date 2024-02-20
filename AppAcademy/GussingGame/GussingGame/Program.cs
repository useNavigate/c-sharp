using System;

namespace GuessingGame
{
    class Program
    {
        /// <summary>
        /// Note, we based this solution on the image in 01e-class-modeling
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            GuessingGameWorkflow wf = new GuessingGameWorkflow();

            wf.Run();



            Console.ReadKey();
        }
    }
}
