namespace VinterProjekt
{
    public class Item
    {
        protected string name;

        public virtual string GetInfo()
        {
            return "";
        }

        public virtual void Use(Character target)
        {

        }

    }
}