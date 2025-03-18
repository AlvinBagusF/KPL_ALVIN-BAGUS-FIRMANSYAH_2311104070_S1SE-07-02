using System;

class DoorMachine
{
    private bool isLocked;
    private bool isOpen;

    public DoorMachine(bool awalTerkunci = true, bool awalTerbuka = false)
    {
        isLocked = awalTerkunci;
        isOpen = awalTerbuka;
    }

    public void CurrentState()
    {
        Console.WriteLine($"Pintu terkunci: {isLocked}, Pintu terbuka: {isOpen}");
    }

    public void ToggleLock()
    {
        if (isOpen)
        {
            Console.WriteLine("Tidak bisa mengunci pintu saat pintu terbuka.");
        }
        else
        {
            isLocked = !isLocked;
            Console.WriteLine(isLocked ? "Pintu dikunci." : "Pintu tidak terkunci.");
        }
    }

    public void OpenDoor()
    {
        if (isOpen)
        {
            Console.WriteLine("Pintu sudah terbuka.");
        }
        else if (isLocked)
        {
            Console.WriteLine("Pintu terkunci, tidak bisa dibuka.");
        }
        else
        {
            isOpen = true;
            Console.WriteLine("Pintu terbuka.");
        }
    }

    public void CloseDoor()
    {
        if (!isOpen)
        {
            Console.WriteLine("Pintu sudah tertutup.");
        }
        else
        {
            isOpen = false;
            Console.WriteLine("Pintu tertutup.");
        }
    }
}
