using System;

namespace BiblioInheritance
{
  public class Resource{

        public Resource(string title, string category){
          Title = title;
          Category = category;
          
          Status = "Available";
        }

        public string Title
          {get; private set;}
          
        
       public string Category
          {get; private set;}
          
        
       public string Status
          
          {get; protected set;}
        

   public virtual void UpdateStatus(){
      if(Status == "Out"){
        Status = "Available";
      }
      else{
        Status = "Out";
      }
    }

  public virtual string GetInfo(){
    return $"Title: {Title} \nCategory: {Category} \nStatus: {Status}";
  }

  }
  

}
