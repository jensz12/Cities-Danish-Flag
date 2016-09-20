using ICities;

namespace DanishFlag
{
    public class DanishFlag : IUserMod
    {
        public string Name
        {
            get { return "Danish flag"; }
        }

        public string Description
        {
            get { return "Danish flag"; }
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
