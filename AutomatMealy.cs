namespace AutomatMealy
{
    public class AutomatMealy : AutomatMealyAbstract
    {
        public AutomatMealy(Function fi, Function gi) : base(fi, gi)
        {
        }

        public override string Evolutie(string initialState, string input)
        {
            string finalString = "";
            string currentState = (string)initialState.Clone();
            foreach (var element in input)
            {
                finalString += "(" + currentState + ", " + element + ", ";
                currentState = F(currentState, element.ToString());
                string upperCaseElement = G(currentState, element.ToString());
                finalString += currentState + ", " + upperCaseElement + ") " + " ";
                finalString += "\n";
            }

            return finalString;
        }

        public override string F(string state, string input)
        {
            return ff.Calcul(state, input);
        }

        public override string G(string state, string input)
        {
            return gg.Calcul(state, input);
        }
    }
}