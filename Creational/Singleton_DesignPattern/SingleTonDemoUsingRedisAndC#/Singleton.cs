using StackExchange.Redis; // Importing the StackExchange.Redis library for Redis operations

namespace SingleTonDemo
{
    public class Singleton
    {
        // Private static instance of the Singleton class
        private static Singleton instance;

        // ConnectionMultiplexer to manage connections to the Redis server
        private ConnectionMultiplexer conn;

        // Private constructor to prevent instantiation from outside
        private Singleton()
        {
            // Establish a connection to the Redis server running on localhost
            conn = ConnectionMultiplexer.Connect("localhost");
        }

        // Public method to get the singleton instance
        public static Singleton getSingletonInstance()
        {
            // Check if an instance already exists
            if (instance == null)
            {
                // If not, create a new instance
                instance = new Singleton();
            }
            // Return the existing or newly created instance
            return instance;
        }

        // Method to retrieve the IDatabase interface for performing Redis operations
        public IDatabase someLogic()
        {
            // Get a database instance from the connection multiplexer
            return conn.GetDatabase();
        }
    }
}