namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            string userInput;
            bool correctInput;
            do {
                Console.Clear();
                correctInput = true;

                Console.WriteLine("Would you like to use List, SQL, or Mongo?");
                Console.WriteLine("(sql, mongo, list)");





                userInput = Console.ReadLine();

                if(userInput != "sql" && userInput != "mongo" && userInput != "list")
                {
                    correctInput= false;
                    Console.WriteLine("Input doesnt match information we have, please try again");
                    Thread.Sleep(1000);
                }
            } while (!correctInput); ; 

            Console.Clear();

            IDataAccess db = DataAccessFactory.GetDataAccessType(userInput);

            var products = db.LoadData();
            db.SaveData();

            foreach(var item in products )
            {
                Console.WriteLine($"Name: {item.Name} Price: {item.Price}");
            }
        }
    }
}
