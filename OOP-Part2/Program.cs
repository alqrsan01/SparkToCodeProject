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
        }
    }
}
