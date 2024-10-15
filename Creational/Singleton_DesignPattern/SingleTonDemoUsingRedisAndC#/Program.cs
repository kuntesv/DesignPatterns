namespace SingleTonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Retrieve the singleton instance of the Singleton class
            Singleton s1 = Singleton.getSingletonInstance();

            // Retrieve another reference to the same singleton instance
            Singleton s2 = Singleton.getSingletonInstance();

            // Check if both references point to the same instance
            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance. One is trying to SET value in Redis and another is trying to GET value.");

                // Set a value in Redis using the singleton instance
                s1.someLogic().StringSet("key", "value");

                // Get the value from Redis using another reference to the same singleton instance
                Console.WriteLine(s2.someLogic().StringGet("key"));
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}