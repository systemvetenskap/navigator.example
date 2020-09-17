using PageNavigation.Example.Models;

namespace PageNavigation.Example
{
   /// <summary>
   /// Spelartyp CPU. Implementerar <see cref="IFullname"/>
   /// </summary>
    public class Cpu : IFullname
    {
        public string Fullname { get; set; }
    }
}
