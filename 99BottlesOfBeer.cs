using System;


static class _99BottlesOfBeer
{
    public static void Main()
    {
        for (int i = 99; i > -1; i--) Console.WriteLine($"{(i > 0 ? i.ToString() : "No more")} {(i > 1 || i == 0 ? "bottles" : "bottle")} of beer on the wall, {(i == 0 ? "no more" : i.ToString())} {(i > 1 || i == 0 ? "bottles" : "bottle")} of beer.\n{(i == 0 ? "Go to the store and buy some more, 99 bottles of beer on the wall." : $"Take one down and pass it around, {(i > 1 ? (i - 1).ToString() : "no more")} {(i > 1 || i == 1 ? "bottles" : "bottle")} of beer on the wall.\n")}");
    }
}
