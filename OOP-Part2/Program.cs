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
            string status = IsAvailable ? "Available" : "Booked";
            Console.WriteLine($"Room: {RoomNumber}, Type: {RoomType}, Price: {PricePerNight}, Status: {status}");
        }
    }

    public class Guest
    {
        public string GuestId;
        public string GuestName;
        public string RoomNumber;
        public string CheckIndate;
        public int TotalNights;
        public double PricePerNight;

        public Guest(string guestId, string guestName, string checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            CheckIndate = checkInDate;
            TotalNights = totalNights;
            RoomNumber = "Not Assigned";
            PricePerNight = 0;
        }
        public void DisplayGuest()
        {
            Console.WriteLine($"ID: {GuestId} | Name: {GuestName} | Room: {RoomNumber} | Check-in: {CheckIndate} | Nights: {TotalNights}");
        }
        public double CalculateTotalCost()
        {
            return PricePerNight * TotalNights;
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
                Console.WriteLine("0. Exit");
                Console.WriteLine("===================================");
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
                        AddNewRoom(rooms);
                        break;
                    case 2:
                        RegisterNewGuest(guests);
                        break;
                    case 3:
                        BookRoomForGuest(rooms, guests);
                        break;
                    case 4:
                        ViewAllRooms(rooms);
                        break;
                    case 5:
                        ViewAllGuests(guests);
                        break;
                    case 0:
                        exit = false;
                        Console.WriteLine("Exiting the program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                
            }
        }

        static void AddNewRoom(List<Room> rooms)
        {
            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            bool exists = rooms.Any(r => r.RoomNumber == roomNumber);
            if (exists)
            {
                Console.WriteLine("Room number already exists. Please try again.");
                return;
            }

            Console.Write("Enter room type: ");
            string roomType = Console.ReadLine();
            Console.Write("Enter price per night: ");
            double pricePerNight = double.Parse(Console.ReadLine());

            rooms.Add(new Room(roomNumber, roomType, pricePerNight));
            Console.WriteLine($"Room {roomNumber} added! Total rooms: {rooms.Count}");
        }

        static void RegisterNewGuest(List<Guest> guests)
        {
            Console.Write("Enter guest name: ");
            string guestName = Console.ReadLine();
            Console.Write("Enter check-in date: ");
            string checkInDate = Console.ReadLine();
            Console.Write("Enter number of nights: ");
            int totalNights = int.Parse(Console.ReadLine());

            string guestId = $"G{(guests.Count + 1):D3}";
            guests.Add(new Guest(guestId, guestName, checkInDate, totalNights));
            Console.WriteLine($"Guest registered! ID: {guestId}, Name: {guestName}, Nights: {totalNights}");
        }

        static void BookRoomForGuest(List<Room> rooms, List<Guest> guests)
        {
            Console.Write("Enter guest ID (e.g. G001): ");
            string guestId = Console.ReadLine();
            Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);
            if (guest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }

            Console.Write("Enter room number to book: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (room == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }

            if (!room.IsAvailable)
            {
                Console.WriteLine("Room is not available.");
                return;
            }

            guest.RoomNumber = roomNumber.ToString();
            guest.PricePerNight = room.PricePerNight;
            room.IsAvailable = false;

            Console.WriteLine($"Booking confirmed!");
            Console.WriteLine($"Guest: {guest.GuestName}, Room: {room.RoomNumber}, Type: {room.RoomType}");
            Console.WriteLine($"Price: {room.PricePerNight}, Nights: {guest.TotalNights}, Total: {guest.CalculateTotalCost()}");
        }

        static void ViewAllRooms(List<Room> rooms)
        {
            if (!rooms.Any())
            {
                Console.WriteLine("No rooms available.");
                return;
            }

            Console.WriteLine($"Total rooms: {rooms.Count}");
            
            var sorted = rooms.OrderBy(r => r.RoomNumber);
            foreach (var room in sorted)
            {
                room.DisplayRoom();
            }
        }

        static void ViewAllGuests(List<Guest> guests)
        {
            if (!guests.Any())
            {
                Console.WriteLine("No guests registered.");
                return;
            }

            Console.WriteLine($"Total guests: {guests.Count}");
            
            var sorted = guests.OrderBy(g => g.GuestId);
            foreach (var guest in sorted)
            {
                guest.DisplayGuest();
            }
        }
    }
}
