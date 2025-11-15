public class Forma
{
   public string? Nombre {get; set;} 

   public void Form ()
   {
     Nombre = "Forma";
   }
   public virtual double CalcularArea()
    {
        
        return 0.0;
    }

}

