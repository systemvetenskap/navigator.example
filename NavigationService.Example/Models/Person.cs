using Navigering.Example.Models;

namespace Navigering.Example
{
    /// <summary>
    /// En person som implementerar ett interface som styr Fullname, men som inte kräver för- och efternamn
    /// </summary>
    public class Person : IFullname
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string Fullname => $"{Firstname} {Lastname}";

    }
}
