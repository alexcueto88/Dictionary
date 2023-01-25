namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //           const myFamily = {
            //   'sister': {
            //               'name': 'Krista', 
            //	'age': 42

            //   }, 
            //'mother': {
            //               'name': 'Cathie', 
            //	'age': 70

            //   }
            //       }

            Dictionary<string, Dictionary<string, string>> family = new Dictionary<string, Dictionary<string, string>>();

            var family2 = new Dictionary<string, Dictionary<string, string>>();

            Dictionary<string, Dictionary<string, string>> family3 = new();

            //string name = "Alex"; 

            family.Add("sister", new Dictionary<string, string> { { "name", "Krista" }, {"age", "42" }, { "favorite food", "tacos"} });
            family.Add("mother", new Dictionary<string, string> { { "name", "Cathie" }, { "age", "70" }, { "favorite food", "pizza" } });
            string text = family["mother"]["name"];
            Console.WriteLine(text);

            foreach (var familyMember in family)
            {
                //var key = familyMember.Key;
                //var value = familyMember.Value;
                string sentance = $"{familyMember.Value["name"]} is my {familyMember.Key}";

                Console.WriteLine(familyMember.Key);
            }



            Dictionary<string, int> count = new Dictionary<string, int>();

            count["shirts"] = 15;
            // check if we already have shirts in dictionary. If not, add it; if so, increment it.

            int extraShirts = 10;
            if (count.ContainsKey("shirts"))
            {
                count["shirts"] += extraShirts;

            }
            else
            {
                count["shirts"] = extraShirts;
            }


            Console.WriteLine(count["shirts"]);

            Dictionary<int, string> players = new Dictionary<int, string>();

            players.Add(11, "Rodriguez");

            Console.WriteLine(players[11]);



        }
    }
}