using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    class _0_PrefixPostfixInfix_Theory
    {
        // Infix :
        //          1. <operand> <operator> <operand>. Example : a*b, a+b, 2-3, 4/2 etc
        //          2. operands doesn't have to be constant or variable. can be expression also : (a*b)+(c/d), (2+3)*4
        //          3. Infix expressions are evaluated according : 
        //              a) Parantheses () {} []
        //              b) Exponents (Right to Left. Exm : 2^3^2 = 2^9. NOT 8^2 WHICH IS WRONG.        
        //              c) Multiplication and division (Same preference. Left to Right. Exm : 3*6/2 = 18/2 = 9. NOT 3*3 = 9 WHICH IS WRONG.
        //              d) Addition and Subtraction (Same preference. Left to Right. Exm : 4-2+1 = 3. NOT 4-(2+1) = 1 WHICH IS WRONG.
        //          4.   2 * 6 / 2 - 3 + 7
        //              = (2*6/2) - 3 + 7 [ multiplication and division is higher than add/sub ]
        //              = (12/2) - 3 + 7  [ (2*6/2) evaluate from left to right ]
        //              = 6 - 3 + 7       [ evaluate from left to right ]
        //              = 3 + 7
        //              = 10
        //          5. Left to right is called : Left associativity
        //          6. Right to Left is called : Right associativity

        // Problem with Infix : Operator associativity, parantheses, order of expression evaluation etc 
        // So, mathematicians came with two approaches where expressions can be evaluated without considering the aboves
        // These are : 1) Postfix 2) Prefix

        // Prefix / Polish :
        //          1. Format : <operator> <operand> <operand>
        //          2. Infix : 2 + 3. Prefix : +23
        //          3. Infix : a+b*c. Prefix : +a*bc or +a(*bc)

        // Postfix / Reverse Polish
        //          1. <operand> <operand> <operator>
        //          2. Programatically, postfix are easy to parse and least costly in terms of time and memory
        //          3. Infix : 2+3. Postfix : 23+
        //          4. Infix : a+b*c. Postfix : abc*+

        // A*B+C*D-E

        // Postfix  : (A*B)+(C*D)-E [ by order of preference and associativity rules ]
        //          : (AB*)+(CD*)-E
        //          : (AB*)(CD*)+E-
        //          : AB*CD*+E-
        // If A = 2, B = 3, C = 5, D = 4, E = 9, then Postfix expression will be
        //          = 2 3 * 5 4 * + 9 -
        //          = 6 5 4 * + 9 -  [ from left to right ]
        //          = 6 20 + 9 -
        //          = 26 9 -
        //          = 17
        // Code Algorithm for Postfix expression evaluator
        //      1. Create Stack
        //      2. for i -> 0 to length(postfix expression) - 1
        //          {
        //              if(exp[i] is operand)
        //                  Push(exp[i])
        //              else if(exp[i] is operator)
        //              {
        //                  OP2 <- POP()
        //                  OP1 <- POP()
        //                  RES <- Perform(exp[i], OP1, OP2)
        //                  Push(RES)
        //              }
        //          }
        //      3. RESULT <- POP()

        // Prefix   : (*AB)+(*CD)-E
        //          : +(*AB)(*CD)-E
        //          : -+*AB*CD
        // Code Algorithm for prefix expression evaluator [ same as postfix. But this time start from end of expression to first elemnt of expression]


        // Infix to postfix pseudocode : A*B+C*D-E
        // InfixToPostfix(exp)
        // {
        //      Create a Stack S
        //      rest <- string.Empty
        //      for i <- 0 to length(exp)-1
        //      {
        //          if exp[i] is operand
        //             rest <- rest + exp[i]
        //          else if exp[i] is operator
        //          {
        //              while (!Stack.Empty() && HasHigherPrec(Stack.Top(), exp[i]))
        //              {
        //                  rest <- rest + Stack.Top()
        //                  Stack.Pop()
        //              }
        //              Stack.Push(exp[i])
        //          }
        //      }
        //      while(!Stack.Empty())
        //      {
        //          rest <- rest + Stack.Top()
        //      }
        //      return result
        //  }


        // Infix : ((A+B)*C-D)*E to Postfix [ same algo with stack ]

        // infix : A*(B+C) = ABC+*

    }
}
