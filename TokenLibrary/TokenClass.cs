using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenLibrary
{
    public abstract class TokenClass
    {
        public int lines;
        public string tokens;
        public string lexemes;

        public void setTokens(string token)
        {
            this.tokens = token;
        }
        public string getTokens()
        {
            return this.tokens;
        }
        public void setLexemes(string lexeme)
        {
            this.lexemes = lexeme;
        }
        public string getLexemes()
        {
            return this.lexemes;
        }
        public void setLines(int line)
        {
            this.lines = line;
        }
        public int getLines()
        {
            return this.lines;
        }
    }
}
