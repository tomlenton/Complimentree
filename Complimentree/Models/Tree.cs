using System.Drawing;

namespace Complimentree.Models
{
    public class Tree
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Location? Location { get; set; }

        public double Size = double.NaN;
        public string Species { get; set; } = string.Empty;
        public List<Compliment> Compliments { get; set; } = new List<Compliment>();
    

      //public static string ComplimentsAsString()
      //  {
      //      string listToReturn = string.Empty;
      //      foreach (var compliment in Compliments)
      //      {
      //          listToReturn += $"{compliment.Text}, ";
      //      }

      //      return listToReturn = listToReturn.Substring(0, listToReturn.Length - 2);

      //  }
    }
}
