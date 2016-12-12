using ICities;

namespace DanishFlag
{
    public class DanishFlag : IUserMod
    {
        public string Name
        {
            get { return "Danish flag replacer"; }
        }

        public string Description
        {
            get { return "Replaces the stock flags with the danish flag Dannebrog"; }
        }

        public string[][] CustomFlags()
        {
            return new[]
            {
                new[] {"denmark", "Denmark"},
            };
        }
    }
}
