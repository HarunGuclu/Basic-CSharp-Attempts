using Encapsulation_8._2_;

class Program
{
    static void Main(string[] args)
    {
        HotelRoom room = new HotelRoom();
        room.RoomNumber_ = 405;
        room.RoomType_ = "Single";
        room.SetReserved(true);

        Console.WriteLine("Room number:" + room.RoomNumber_);
        Console.WriteLine("Room Type:" + room.RoomType_);
        Console.WriteLine("Is reserved:" + room.IsReserved());

        Console.WriteLine("-------------------");

        room.RoomNumber_ = 721;
        room.RoomType_ = "Suit";
        room.SetReserved(false);

        Console.WriteLine("Room number:" + room.RoomNumber_);
        Console.WriteLine("Room Type:" + room.RoomType_);
        Console.WriteLine("Is reserved:" + room.IsReserved());


    }
}















