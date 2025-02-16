using System;

namespace BiblioInheritance
{
  public class Book : Resource{

      public Book(string title, string author, string category, int pages) : base(title, category){
        PageCount = pages;
        Author = author;
      }

    

    public int PageCount
    {get; set;}
    public string Author
    {get; set;}
  
  public override string GetInfo(){
    return $"Title: {Title} \n Author: {Author} \nCategory: {Category} \nStatus: {Status}";
  }
  }
 
}
