using System;

namespace BiblioInheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Resource test = new Resource("spaceship","Out-of-world");
      test.GetInfo();
      test.UpdateStatus();
      Console.WriteLine(test.Status);
      Book mybook = new Book("Code: The Hidden Language of Computer Hardware and Software", "Charles Petzold", "Non-Fiction", 396);
      Console.WriteLine(mybook.GetInfo());
      Periodical p = new Periodical("Wired", "Adam","Technology", "Monthly");
      p.UpdateStatus();
      Console.WriteLine(p.GetInfo());
      Video v = new Video("Wired In", "Adam", "Space", 0, "On-Demand");
      Console.WriteLine(v.GetInfo());
    }
  }
}
