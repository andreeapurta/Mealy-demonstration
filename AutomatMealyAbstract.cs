using System;

namespace AutomatMealy
{
    public abstract class AutomatMealyAbstract
    {
        public Function gg;
        public Function ff;

        public abstract String F(String state, String input);

        public abstract String G(String state, String input);

        public abstract String Evolutie(String initialState, String stringinput);

        public AutomatMealyAbstract(Function fi, Function gi)
        {
            gg = gi;
            ff = fi;
        }
    }
}