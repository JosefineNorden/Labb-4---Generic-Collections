using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_4___Generic_Collections
{
    // This class is for the orders at the restaurant.
    public class Order
    {
        static int orderIdCounter = 1;  // Static counter to generate the orders ID.
        private int _orderId;           // Private field to store order ID.
        private List<MenuItem> _orderItems; // List of MenuItems representing the items in the order.
        private int _tableNumber; // The table number with the order.

        // Constructor that assigns a order ID, order items and the table number.
        public Order(List<MenuItem> orderItems,int tableNumber)
        {
            _orderId = orderIdCounter;  // Assign the current orders ID.
            orderIdCounter++;           // Counter for the next order ID.
            _orderItems = orderItems; // Set the list of menu items in the order.
            _tableNumber = tableNumber; // Table number for the order.
        }

        // Method to output the details about the order.
        public void ShowOrder()
        {
            
            Console.WriteLine($"Order {_orderId}:"); // Print the order ID.
            foreach (var item in _orderItems) // Loop through all items in the order.
            {
                Console.WriteLine($"1st {item.Name}"); // Print each items name.

            }
            

            decimal total = 0;
            foreach (var item in _orderItems) // Loop through all items to calculate the price.
            {
                total += item.Price;  // Calculator total price.
            }
            Console.WriteLine($"Summa: {total:C}");  // Print total price.
            Console.WriteLine($"Till bord nummer {_tableNumber}");  // Print out table number.
            Console.WriteLine("__________");
        }

        
        public int GetOrderId()
        {
            return _orderId;  // Return the order ID.
        }
    }
}
