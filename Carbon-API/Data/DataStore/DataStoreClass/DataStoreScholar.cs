using Carbon_API.Data.DataStore;

namespace Carbon_API.Data
{
    public class DataStoreScholar : DataStoreClass
    {
        private readonly string NAME = "Scholar";
        private readonly string[] PARENT_CLASS = null;
        private readonly string[] SUB_CLASS = { "Arcanist", "Acolyte" };
        public string GetName()
        {
            return NAME;
        }

        public string[] GetParentClasses()
        {
            return PARENT_CLASS;
        }

        public string[] GetSubClasses()
        {
            return SUB_CLASS;
        }
    }
}