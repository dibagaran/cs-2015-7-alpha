using System;

class Program
{
    public static void Main ()
    {
    }
}

class OperatingSystem{
}

class MobileOperatingSystem : OperatingSystem{ // A MobileOperatingSystem IS an OperatingSystem
}

class Linux : OperatingSystem{ // Linux IS an OperatingSystem
}

class Windows : OperatingSystem{ // Windows IS an OperatingSystem
}

class Android : MobileOperatingSystem{ // Android IS a MobileOperatingSystem
}