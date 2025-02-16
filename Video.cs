using System;

namespace BiblioInheritance
{
  public class Video : Resource
  {

        public Video(string title, string category, string director, int runtime, string mediaType) : base(title, category){
          Director = director;
          Runtime = runtime;
          MediaType = mediaType;

        }
    public string Director
    {get; set;}

    public int Runtime
    {get; set;}

    public string MediaType
    {get; set;}

  public override string GetInfo(){
    return $"Title: {Title} \n Category: {Category} \n Director: {Director} \n Runtime: {Runtime} \n MediaType:{MediaType}";
  }

  public override void UpdateStatus(){
    Status = "Wired In";
  }
  }
  

}
