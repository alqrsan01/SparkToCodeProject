namespace OOP_Part2
{
    public class Room
    {
        public int RoomNumber;
        public string RoomType;
        public double PricePerNight;
        public bool IsAvailable;

        public Room(int roomNumber, string roomType, double pricePerNight)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = true;
        }
        public void DisplayRoom()
        {

        }
    }

    public class Guest
    {
        public int GuestId;
        public string GuestName;
        public int RoomNumber;
        public string CheckIndate;
        public int TotalNights;

        public Guest(string guestId, string guestName, string checkInDate, int totalNights)
        {

        }
        public void DisplayGuest()
        {

        }
        public void CalculateTotalCost()
        {

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();
            List<Guest> guests = new List<Guest>();

            rooms.Add(new Room(101, "Single", 100.0));
            rooms.Add(new Room(102, "Double", 150.0));
            rooms.Add(new Room(103, "Suite", 250.0));
            rooms.Add(new Room(104, "Single", 100.0));
            rooms.Add(new Room(105, "Double", 150.0));
            rooms.Add(new Room(106, "Suite", 250.0));
            rooms.Add(new Room(107, "Single", 100.0));

            bool exit = true;
            while (exit)
            {
                Console.WriteLine("\n===== Hotel management system =====");
                Console.WriteLine("1. Add new room");
                Console.WriteLine("2. Register new guest");
                Console.WriteLine("3. Book a room for a guest");
                Console.WriteLine("4. View all rooms");
                Console.WriteLine("5. View all guests");
                Console.WriteLine("6. Search and filter rooms");
                Console.WriteLine("7. Guest and booking statistics");
                Console.WriteLine("8. Update room price");
                Console.WriteLine("9. Guest lookup by name");
                Console.WriteLine("10. Room type breakdown report");
                Console.WriteLine("11. Check out a guest");
                Console.WriteLine("12. Remove unavailable rooms");
                Console.WriteLine("13. Extend guest stay");
                Console.WriteLine("14. Highest revenue booking");
                Console.WriteLine("15. Guest pagination viewer");
                Console.WriteLine("16. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        AddNewRoom();
                        break;
                    case 16:
                        exit = false;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                
            }
        }

        static void AddNewRoom()
        {

        }
    }
}
