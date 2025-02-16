using System;

namespace BiblioInheritance
{
    public class Periodical : Resource{

            public Periodical(string title,string author, string category, string period) : base(title, category){
                Period = period;
            }

      public string Period
         {get; set;}
         public string Author
         {get; set;}
    
    public override void UpdateStatus(){
      Status = "In Use.";
    }
    }
 
}
