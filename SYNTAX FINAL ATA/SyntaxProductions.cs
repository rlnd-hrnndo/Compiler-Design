using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Analyzer
{
    public class SyntaxProductions
    {
        public string GetProductionName(string prod)
        {
            string production = prod;
            if (production.Contains("prod_"))
            {
                switch (prod)
                {
                    
                }
            }
            else
            {
                switch (prod)
                {

                    // Tokens
                    case "":
                        production = "<program>"; break;
                }
            }

            return production;
        }
    }
}