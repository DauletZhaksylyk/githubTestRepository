using OpenQA.Selenium.Remote;

namespace PreparingForQualificationProject
{
    public class Pizza
    {
        private int size { get; }
        private bool cheese { get; }
        private bool mushroom { get; }
        private bool olives { get; }
        public Pizza(int size, bool cheese, bool mushroom, bool olives)
        {
            this.size = size;
            this.cheese = cheese;
            this.mushroom = mushroom;
            this.olives = olives;
        }

        public int Size { get { return size; } }
        public bool Cheese { get { return cheese; } }
        public bool Mushroom { get { return mushroom; } }
        public bool Olives { get { return olives; } }

        public override string ToString()
        {
            string text = "";

            text += size;
            text += cheese ? ",with cheese" : ",no cheese";
            text += mushroom ? ",with mushroom" : ",no mushhroom";
            text += olives ? ",with olives" : ",no olives";

            return text;
        }
    }
}
