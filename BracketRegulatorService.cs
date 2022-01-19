using System;
using System.Collections.Generic;
using System.Text;

namespace JobNimbusAssigmnment
{
    public class BracketRegulatorService
    {
        public BracketRegulatorService() { }

        public Boolean isMatching(char char1,
                              char char2)
        {
            if (char1 == '(' && char2 == ')')
                return true;
            else if (char1 == '{' && char2 == '}')
                return true;
            else if (char1 == '[' && char2 == ']')
                return true;
            else
                return false;
        }


        public Boolean areBracketsEqual(char[] key)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < key.Length; i++)
            {

                if (key[i] == '{' || key[i] == '('
                    || key[i] == '[')
                    stack.Push(key[i]);


                if (key[i] == '}' || key[i] == ')'
                    || key[i] == ']')
                {


                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    else if (!isMatching(stack.Pop(),
                                             key[i]))
                    {
                        return false;
                    }
                }
            }

            if (stack.Count == 0)
                return true;
            else
            {

                return false;
            }
        }

    }
}
