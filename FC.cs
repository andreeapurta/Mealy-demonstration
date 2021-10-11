using System;

namespace AutomatMealy
{
    public class FC : Function
    {
        public string Calcul(string state, string input)
        {
            switch (state)
            {
                case "1":
                    if (input.Equals("a"))
                    {
                        return "2";
                    }
                    else
                    {
                        throw new InvalidProgramException("Input not supported for current state");
                    }
                case "2":
                    if (input.Equals("a"))
                    {
                        return "3";
                    }
                    else if (input.Equals("b"))
                    {
                        return "4";
                    }
                    else if (input.Equals("c"))
                    {
                        return "5";
                    }
                    else
                    {
                        throw new InvalidProgramException("Input not supported for current state");
                    }
                case "3":
                    if (input.Equals("a"))
                    {
                        return "3";
                    }
                    else if (input.Equals("b"))
                    {
                        return "4";
                    }
                    else if (input.Equals("c"))
                    {
                        return "5";
                    }
                    else
                    {
                        throw new InvalidProgramException("Input not supported for current state");
                    }
                case "4":
                    if (input.Equals("a"))
                    {
                        return "3";
                    }
                    else if (input.Equals("b"))
                    {
                        return "4";
                    }
                    else if (input.Equals("c"))
                    {
                        return "5";
                    }
                    else
                    {
                        throw new InvalidProgramException("the input doesn't have an accepted value.");
                    }
                default:
                    throw new InvalidProgramException("the input doesn't have an accepted value."); ;
            };
        }
    }
}