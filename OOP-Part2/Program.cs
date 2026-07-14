using System.Security.Authentication.ExtendedProtection;

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
                    case 6:
                        SearchAndFilterRooms(rooms);
                        break;
                    case 7:
                        GuestAndBookingStatistice(rooms, guests);
                        break;
                    case 8:
                        UpdateRoomPrice(rooms);
                        break;
                    case 9:
                        GuestLookupByName(guests);
                        break;
                    case 10:
                        RoomTypeBreackdownReport(rooms);
                        break;
                    case 11:
                        CheckOutGuest(rooms, guests);
                        break;
                    case 12:
                        RemoveUnavailableRooms(rooms, guests);
                        break;
                    case 13:
                        ExtendGuestStay(guests);
                        break;
                    case 14:
                        HighestRevenueBooking(guests);
                        break;
                    case 15:
                        GuestPaginationViewer(guests);
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

            var sorted = guests.OrderBy(g => g.GuestName);
            foreach (var guest in sorted)
            {
                guest.DisplayGuest();
            }
        }

        static void SearchAndFilterRooms(List<Room> rooms)
        {
            bool exitsub = true;
            while (exitsub)
            {
                Console.WriteLine("===== Search and Filter Rooms =====");
                Console.WriteLine("1. Show all available rooms");
                Console.WriteLine("2. Filter by room type");
                Console.WriteLine("3. Filter by max price");
                Console.WriteLine("4. Room price statistics");
                Console.WriteLine("0. Back");
                Console.Write("Enter your choice: ");

                int choicesub = int.Parse(Console.ReadLine());
                switch (choicesub)
                {
                    case 1:
                        var available = rooms.Where(r => r.IsAvailable).OrderBy(r => r.PricePerNight);
                        Console.WriteLine($"Available rooms: {available.Count()}");
                        if (!available.Any())
                        {
                            Console.WriteLine("No available rooms");
                        }
                        else
                        {
                            foreach (var r in available)
                            {
                                r.DisplayRoom();
                            }
                        }
                        break;
                    case 2:
                        Console.Write("Enter room type (Single / Double / Suite): ");
                        string type = Console.ReadLine();
                        var bytype = rooms.Where(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase)).OrderBy(r => r.RoomNumber);
                        Console.WriteLine($"Rooms of type {type}: {bytype.Count()}");
                        if (!bytype.Any())
                        {
                            Console.WriteLine("No rooms found of this type");
                        }
                        else
                        {
                            foreach (var r in bytype)
                            {
                                r.DisplayRoom();
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Enter maximum price per night: ");
                        double maxPrice = double.Parse(Console.ReadLine());
                        var byPrice = rooms.Where(r => r.IsAvailable && r.PricePerNight <= maxPrice).OrderBy(r => r.PricePerNight);
                        Console.WriteLine($"Available rooms under {maxPrice}: {byPrice.Count()}");
                        if (!byPrice.Any())
                        {
                            Console.WriteLine("No available rooms under this price");

                        }
                        else
                        {
                            foreach (var r in byPrice)
                            {
                                r.DisplayRoom();
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine($"Total rooms: {rooms.Count}");
                        Console.WriteLine($"Available rooms: {rooms.Count(r => r.IsAvailable)}");
                        Console.WriteLine($"Average price: {rooms.Average(r => r.PricePerNight):F2}");
                        Console.WriteLine($"Cheapest room: {rooms.Min(r => r.PricePerNight):F2}");
                        Console.WriteLine($"Most expensive room: {rooms.Max(r => r.PricePerNight):F2}");
                        break;
                    case 0:
                        exitsub = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void GuestAndBookingStatistice(List<Room> rooms, List<Guest> guests)
        {
            Console.WriteLine($"Total registered guests: {guests.Count}");
            Console.WriteLine($"Guest with active booking: {guests.Count(g => g.RoomNumber != "Not Assigned")}");
            Console.WriteLine($"Total rooms: {rooms.Count}");
            Console.WriteLine($"Currently booked rooms: {rooms.Count(r => !r.IsAvailable)}");

            var activeGuests = guests.Where(g => g.RoomNumber != "Not Assigned");
            if (!activeGuests.Any())
            {
                Console.WriteLine("No active bookings.");
                return;
            }

            Console.WriteLine($"Average nights (active booking): {activeGuests.Average(g => g.TotalNights):F1}");
            Console.WriteLine("Top 3 hightest spending guests");

            var top3 = activeGuests.OrderByDescending(g => g.CalculateTotalCost()).Take(3);
            foreach (var g in top3)
            {
                Console.WriteLine($"{g.GuestName}, Room: {g.RoomNumber}, Total: {g.CalculateTotalCost():F2}");
            }

            Console.WriteLine("Active booking summary");

            var summaries = activeGuests.Select(g => $"{g.GuestName} — Room {g.RoomNumber} — {g.TotalNights} nights — OMR {g.CalculateTotalCost():F2}");
            foreach (var summary in summaries)
            {
                Console.WriteLine(summary);
            }
        }

        static void UpdateRoomPrice(List<Room> rooms)
        {
            Console.Write("Enter room number: ");
            int roomNumber = int.Parse(Console.ReadLine());
            Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (room == null)
            {
                Console.WriteLine("Room not found.");
                return;
            }

            double oldPrice = room.PricePerNight;
            Console.Write("Enter new price per night: ");
            double newPrice = double.Parse(Console.ReadLine());
            if (newPrice <= 0)
            {
                Console.WriteLine("Price must be greater than 0.");
                return;
            }
            room.PricePerNight = newPrice;

            Console.WriteLine($"Price updated for room {roomNumber}");
            Console.WriteLine($"Old price: {oldPrice}, New price: {newPrice}");
        }

        static void GuestLookupByName(List<Guest> guests)
        {
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();

            var matches = guests.Where(g => g.GuestName.Contains(name, StringComparison.OrdinalIgnoreCase));
            if (!matches.Any())
            {
                Console.WriteLine("No guest matched that search.");
                return;
            }

            Console.WriteLine($"Found {matches.Count()} matches for '{name}';");
            foreach (var g in matches)
            {
                Console.WriteLine($"[{g.GuestId}] {g.GuestName}, Room: {g.RoomNumber}");
            }
        }

        static void RoomTypeBreackdownReport(List<Room> rooms)
        {
            string[] types = { "Single", "Double", "Suite" };
            foreach (var item in types)
            {
                int count = rooms.Count(r => r.RoomType.Equals(item, StringComparison.OrdinalIgnoreCase));
                string avg = count == 0 ? "N/A" : rooms.Where(r => r.RoomType.Equals(item, StringComparison.OrdinalIgnoreCase)).Average(r => r.PricePerNight).ToString("F2");

                Console.WriteLine($"{item}: Count = {count} | Avg Price = {avg}");
            }

            if (rooms.Any())
            {
                Console.WriteLine($"Overall average price: {rooms.Average(r => r.PricePerNight):F2}");
            }
            else
            {
                Console.WriteLine("No rooms in system");
            }
        }

        static void CheckOutGuest(List<Room> rooms, List<Guest> guests)
        {
            Console.Write("Enter guest ID to check out: ");
            string guestId = Console.ReadLine();

            Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);
            if (guest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }

            if (guest.RoomNumber == "Not Assigned")
            {
                Console.WriteLine("Guest has no active booking.");
                return;
            }

            int roomNumber = int.Parse(guest.RoomNumber);
            Room room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

            Console.WriteLine("---- Final Bill ----");
            Console.WriteLine($"Guest: {guest.GuestName}");
            Console.WriteLine($"Room number: {room.RoomNumber}");
            Console.WriteLine($"Room type: {room.RoomType}");
            Console.WriteLine($"Check-in date: {guest.CheckIndate}");
            Console.WriteLine($"Total nights: {guest.TotalNights}");
            Console.WriteLine($"Price per night: {guest.PricePerNight}");
            Console.WriteLine($"total cost: {guest.CalculateTotalCost():F2}");
            Console.WriteLine("--------------------");
            Console.Write("Confirm check-out? (y/n): ");

            string confirm = Console.ReadLine().ToUpper();
            if (confirm != "Y")
            {
                Console.WriteLine("Check-out cancelled.");
                return;
            }

            if (room != null)
            {
                room.IsAvailable = true;
            }

            guests.Remove(guest);

            Console.WriteLine($"Guest {guest.GuestName} checked out successfully.");
            Console.WriteLine($"Room {guest.RoomNumber} is now available: {rooms.Any(r => r.RoomNumber == roomNumber && r.IsAvailable)}");
            Console.WriteLine($"Remaining guests: {guests.Count}");
        }

        static void RemoveUnavailableRooms(List<Room> rooms, List<Guest> guests)
        {
            var removable = rooms.Where(r => !r.IsAvailable && !guests.Any(g => g.RoomNumber == r.RoomNumber.ToString())).OrderBy(r => r.RoomNumber).ToList();
            if (!removable.Any())
            {
                Console.WriteLine("All unavailable rooms are currently booked or no available rooms to remove.");
                return;
            }

            Console.WriteLine($"Safely removable rooms ({removable.Count})");
            foreach (var r in removable)
            {
                Console.WriteLine($"Room {r.RoomNumber}, {r.RoomType}, {r.PricePerNight:F2}");
            }

            Console.Write($"Remove these {removable.Count} rooms? (Y/N): ");
            string confirm = Console.ReadLine().ToUpper();
            if (confirm != "Y")
            {
                Console.WriteLine("Removal cancelled.");
                return;
            }

            rooms.RemoveAll(r => !r.IsAvailable && !guests.Any(g => g.RoomNumber == r.RoomNumber.ToString()));

            Console.WriteLine($"Room removed. Remaining rooms: {rooms.Count}");

            var summary = rooms.Select(r => $"Room {r.RoomNumber} ({r.RoomType})");
            foreach (var line in summary)
            {
                Console.WriteLine(line);
            }
        }

        static void ExtendGuestStay(List<Guest> guests)
        {
            Console.Write("Enter guest ID: ");
            string guestId = Console.ReadLine();
            Guest guest = guests.FirstOrDefault(g => g.GuestId == guestId);
            if (guest == null)
            {
                Console.WriteLine("Guest not found.");
                return;
            }

            if (guest.RoomNumber == "Not Assigned")
            {
                Console.WriteLine("Guest has no active booking.");
                return;
            }

            Console.Write("Enter additional nights: ");
            int extraNights = int.Parse(Console.ReadLine());
            if (extraNights <= 0)
            {
                Console.WriteLine("Additional nights must be greater than 0.");
                return;
            }

            int oldNights = guest.TotalNights;
            guest.TotalNights += extraNights;

            Console.WriteLine($"Stay extended for {guest.GuestName}");
            Console.WriteLine($"Previous nights: {oldNights}");
            Console.WriteLine($"Added nights: {extraNights}");
            Console.WriteLine($"New total nights: {guest.TotalNights}");
            Console.WriteLine($"New total cost: {guest.CalculateTotalCost():F2}");
        }

        static void HighestRevenueBooking(List<Guest> guests)
        {
            var activeGuests = guests.Where(g => g.RoomNumber != "Not Assigned");

            if (!activeGuests.Any())
            {
                Console.WriteLine("No active bookings.");
                return;
            }

            var top = activeGuests.Select(g => new { g.GuestName, g.RoomNumber, TotalCost = g.CalculateTotalCost() }).OrderByDescending(x => x.TotalCost).Take(1).First();

            Console.WriteLine("---- Highest Revenue Booking ----");
            Console.WriteLine($"Guest: {top.GuestName}");
            Console.WriteLine($"Room: {top.RoomNumber}");
            Console.WriteLine($"Total Cost: {top.TotalCost:F2}");
        }

        static void GuestPaginationViewer(List<Guest> guests)
        {
            if (!guests.Any())
            {
                Console.WriteLine("No guests registered.");
                return;
            }

            const int pageSize = 3;
            int totalPages = (int)Math.Ceiling(guests.Count / (double)pageSize);

            Console.WriteLine($"Total guests: {guests.Count}, Page size: {pageSize}, Total pages: {totalPages}");
            Console.Write($"Enter page number (1 - {totalPages}): ");
            int page = int.Parse(Console.ReadLine());
            if (page < 1 || page > totalPages)
            {
                Console.WriteLine("Invalid page number.");
                return;
            }

            var pageGuests = guests.Skip((page - 1) * pageSize).Take(pageSize);
            Console.WriteLine($"--- Page {page} of {totalPages} ---");
            foreach (var g in pageGuests)
            {
                g.DisplayGuest();
            }
        } 
    }
}
