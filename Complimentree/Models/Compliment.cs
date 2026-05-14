namespace Complimentree.Models
{
    public class Compliment
    {
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;


        public static Compliment GetCompliment()
        {
            List<string> ComplimentsAsStrings = new List<string>{
                "You may not be evergreen, but you are to me.",
                "I bet squirrels consider you prime real estate.",
                "You're so down to earth.",
                "You're very grounded.",
                "Your leaves are soothing.",
                "You sway nicely in the wind.",
                "You're blooming brilliant.",
                "You're really good at standing still and doing nothing.",
                "Let's get to the root of your beauty.",
                "I will never leaf you.",
                "You've really branched out lately.",
                "You provide the perfect amount of shade on a hot day.",
                "I'm really pine-ing for you." };

            Random rnd = new Random();
            int complimentIndex = rnd.Next(0, ComplimentsAsStrings.Count);
            Compliment complimnetToReturn = new Compliment() { Id = complimentIndex, Text = ComplimentsAsStrings[complimentIndex] };
            return complimnetToReturn;
        }
    }

  
}
