namespace Labb_4___Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the restaurang class.
            Restaurant restaurant = new Restaurant();
            // Create dishes and store in MenuItem.
            var carbonara = new MenuItem(1, "Carbonara", 129m);
            var margherita = new MenuItem(2, "Margherita", 99m);
            var cheeseburgare = new MenuItem(1, "Cheeseburgare", 149m);
            var ceasarsallad = new MenuItem(1, "Ceasarsallad", 89m);
            // Add MenuItems to the restaurant menu.
            restaurant.AddToMenu(carbonara);
            restaurant.AddToMenu(margherita);
            restaurant.AddToMenu(cheeseburgare);
            restaurant.AddToMenu(ceasarsallad);
            // Show the restaurants menu
            restaurant.ShowMenu();
            // Create orders with the dishes from the menu, set table number.
            var foodItems1 = new List<MenuItem> { carbonara, cheeseburgare };
            var order1 = new Order(foodItems1, 25);
            restaurant.CreateOrder(order1);

            var foodItems2 = new List<MenuItem> { margherita, ceasarsallad };
            Order order2 = new Order(foodItems2, 20);
            restaurant.CreateOrder(order2);

            var foodItems3 = new List<MenuItem> { cheeseburgare, ceasarsallad };
            Order order3 = new Order(foodItems3, 30);
            restaurant.CreateOrder(order3);





            restaurant.ShowOrders(); // Show the current orders in queue.

            restaurant.ShowOrderCount(); //Show the total number of orders in the queue.

            restaurant.ShowNextOrder(); // Show the next order in the queue.

            restaurant.HandleOrder(); // Handle the next order in the queue.

            restaurant.ShowOrderCount(); // Show the total number of orders in the queue after one has been handled.

            var foodItems4 = new List<MenuItem> { cheeseburgare, cheeseburgare }; // Create another order.
            var order4 = new Order(foodItems4, 15);
            restaurant.CreateOrder(order4);

            restaurant.ShowOrderCount(); // Show the updated total orders in the queue.

            restaurant.HandleOrder(); // Handle the next order in queue.

            restaurant.HandleOrder(); // Handle the first order in queue.

            restaurant.ShowOrderCount(); // Handle the next order in queue.

            restaurant.ShowNextOrder(); // Show the next order in queue.

            restaurant.HandleOrder(); // Handle the next order in queue.

            restaurant.ShowOrderCount(); // Show the next order in queue, if there are no orders left in the queue this will be printed.

            // (Är helt snurrig i hövet efter detta kan jag lova.)




        }
    }
}
