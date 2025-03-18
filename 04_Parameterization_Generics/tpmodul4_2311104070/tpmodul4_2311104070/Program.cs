using System;

class Program
{
    static void Main()
    {
        KodePos.TampilkanSemuaKodePos();

        Console.WriteLine("\n===== PROGRAM DOOR MACHINE =====");
        DoorMachine pintu = new DoorMachine();

        pintu.CurrentState();
        pintu.ToggleLock();
        pintu.OpenDoor();
        pintu.CloseDoor();
        pintu.ToggleLock();

        Console.WriteLine("\nProgram selesai. Tekan Enter untuk keluar.");
        Console.ReadLine();
    }
}