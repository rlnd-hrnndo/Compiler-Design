using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TokenLibrary;
using Syntax_Analyzer;

namespace Compilourdes
{
    public class LexicalAnalyzer
    {
        public string txtCode1;

        public LexicalAnalyzer(string txtCode)
        {
            this.txtCode1 = txtCode;
        }

        public void StartLex(Compilourdes_GUI cmp)
        {
            Checker chk1 = new Checker();
            //checks each word for each delimiter
            chk1.checkMain(cmp,txtCode1);
            MessageBox.Show("Lexical Analysis Finished");

            if(cmp.CheckTable() == 1)
            {
                SyntaxInitializer Syntax_Analyzer = new SyntaxInitializer();
                string syntax_result = Syntax_Analyzer.Start(tokenDump(chk1.tokens)) + "\n";
                int c = 0;

                foreach (var item in Syntax_Analyzer.SET)
                {
                    string a = (c + 1).ToString();
                    string b = Syntax_Analyzer.PRODUCTION[c].ToString();
                    string d = "->";
                    string e = Syntax_Analyzer.SET[c].ToString();
                    cmp.Syntax1(a, b, d, e);
                    c++;
                }

                if (syntax_result == "Syntax Analyzer Succeeded...\n")
                    MessageBox.Show("Syntax Analysis Finished");

                else if (syntax_result != "Syntax Analyzer Succeeded...\n")
                {

                    if (Syntax_Analyzer.errors.getColumn() == 1)
                    {
                        Syntax_Analyzer.errors.setLines(Syntax_Analyzer.errors.getLines() - 1);
                    }

                    string a = "SYN-Error";
                    int errorline = Syntax_Analyzer.errors.getLines();
                    string b = Syntax_Analyzer.errors.getErrorMessage().ToString();
                    string cc = errorline.ToString();
                    string e = Syntax_Analyzer.errors.getErrorMessage().ToString();
                    cmp.Syntax2(a, b, cc);
                    //errornum++;
                }
            }
        }

        public List<TokenLibrary.TokenClass> tokenDump(List<Tokens> tokens)
        {
            List<TokenLibrary.TokenClass> token = new List<TokenLibrary.TokenClass>();
            Tokens t = new Tokens();
            foreach (var item in tokens)
            {
                t = new Tokens();
                t.setLexemes(item.getLexemes());
                t.setLines(item.getLines());
                t.setTokens(item.getTokens());
                token.Add(t);
            }
            return token;
        }
    }
}