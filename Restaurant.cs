using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Generic_Collections
{
    internal class Restaurant // Class that represent a resturang with a menue and queue for orders.
    {
        private List<MenuItem> _menu;   // List that represents the menu.
        private Queue<Order> _orders;   // Queue for orders.

        // Constructor that creates a new instance of the restaurant
        public Restaurant()
        {
            _menu = new List<MenuItem>(); // Creates an empty list for the menu.
            _orders = new Queue<Order>(); // Creates an empty queue for the orders.
        }

        // A method to add a dish in the menu.
        public void AddToMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem); // Add a menuItem in the menu.
            Console.WriteLine($"{menuItem.Name} har lagts till i menyn."); // output that confirmes that the dish have been added.
            Console.WriteLine("");

        }


        // Method to print menu.
        public void ShowMenu()
        {
            Console.WriteLine("Meny:");
            for (int i = 0; i < _menu.Count; i++) // Loop through all obejct in the menu.
            {
                Console.WriteLine($"{i + 1}. {_menu[i]}"); // output all objects in the menu with its index.
            }

            Console.WriteLine("__________");
            Console.WriteLine("");

        }

        // Create an order in queue.
        public void CreateOrder(Order order)
        {
            _orders.Enqueue(order); // Add an order in the queue.
            Console.WriteLine("");
            Console.WriteLine($"Beställning nummer {order.GetOrderId()} har lagts till."); // Confirm order.
            Console.WriteLine("");

        }

        // Show current order.
        public void ShowOrders()
        {
            if (_orders.Count > 0) // If there are any orders in the queue.
            {
                Console.WriteLine("Aktuella beställningar:");

                foreach (var order in _orders) // Loops through all orders in the queue.
                {

                    order.ShowOrder(); // Show details about every order.

                }
            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu."); // If queue is empty, this will be printed.
            }
            
        }

        // Show next order without removing it.
        public void ShowNextOrder()
        {
            Console.WriteLine("Nästa order i kön: "); // Output next order in queue.
            if (_orders.Count > 0) // If there is orders in the queue.
            {
                var nextOrder = _orders.Peek(); // Get next order without removing it.
                nextOrder.ShowOrder(); // Show details about next order.

            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu."); // If queue is empty, this will be printed.
            }
        }

        // Handle an order, delete it from the queue.
        public void HandleOrder()
        {
            if (_orders.Count > 0) // If there are any orders in queue.
            {
                var order = _orders.Dequeue(); // Delete the first order in the queue.
                Console.WriteLine($"Order {order.GetOrderId()} färdig."); // Output that the order is handled.
            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu."); // If there is no orders in queue, this will be printed.
            }
            Console.WriteLine("");

        }


        // Show numbers of orders in the queue.
        public void ShowOrderCount()
        {
            if (_orders.Count > 0) // If there are any orders.
            {
                Console.WriteLine($"Det är {_orders.Count} ordrar i kön."); // Output the amount of orders in the queue.

            }
            else
            {
                Console.WriteLine("Det finns inga väntande ordrar i kön just nu."); // If there is no order in queue, output this.
            }
           

        }

    }
}
