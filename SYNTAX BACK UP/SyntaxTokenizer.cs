/*
 * SyntaxTokenizer.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

using System.IO;

using Core.Library;

namespace Syntax_Analyzer {

    /**
     * <remarks>A character stream tokenizer.</remarks>
     */
    public class SyntaxTokenizer : Tokenizer {

        /**
         * <summary>Creates a new tokenizer for the specified input
         * stream.</summary>
         *
         * <param name='input'>the input stream to read</param>
         *
         * <exception cref='ParserCreationException'>if the tokenizer
         * couldn't be initialized correctly</exception>
         */
        public SyntaxTokenizer(TextReader input)
            : base(input, false) {

            CreatePatterns();
        }

        /**
         * <summary>Initializes the tokenizer by creating all the token
         * patterns.</summary>
         *
         * <exception cref='ParserCreationException'>if the tokenizer
         * couldn't be initialized correctly</exception>
         */
        private void CreatePatterns() {
            TokenPattern  pattern;

            pattern = new TokenPattern((int) SyntaxConstants.SPEAK,
                                       "speak",
                                       TokenPattern.PatternType.STRING,
                                       "SPEAK");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.LOOK,
                                       "look",
                                       TokenPattern.PatternType.STRING,
                                       "LOOK");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.TEST,
                                       "test",
                                       TokenPattern.PatternType.STRING,
                                       "TEST");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.THEN,
                                       "then",
                                       TokenPattern.PatternType.STRING,
                                       "THEN");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.TESTIF,
                                       "testif",
                                       TokenPattern.PatternType.STRING,
                                       "TESTIF");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.EXAMINE,
                                       "examine",
                                       TokenPattern.PatternType.STRING,
                                       "EXAMINE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.PICK,
                                       "pick",
                                       TokenPattern.PatternType.STRING,
                                       "PICK");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DECIDE,
                                       "decide",
                                       TokenPattern.PatternType.STRING,
                                       "DECIDE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.EXECUTE,
                                       "execute",
                                       TokenPattern.PatternType.STRING,
                                       "EXECUTE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.UNTIL,
                                       "until",
                                       TokenPattern.PatternType.STRING,
                                       "UNTIL");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.WORK,
                                       "work",
                                       TokenPattern.PatternType.STRING,
                                       "WORK");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.WAKE,
                                       "wake",
                                       TokenPattern.PatternType.STRING,
                                       "WAKE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.SLEEP,
                                       "sleep",
                                       TokenPattern.PatternType.STRING,
                                       "SLEEP");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.YES,
                                       "yes",
                                       TokenPattern.PatternType.STRING,
                                       "YES");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.NO,
                                       "no",
                                       TokenPattern.PatternType.STRING,
                                       "NO");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CONSTRUCT,
                                       "construct",
                                       TokenPattern.PatternType.STRING,
                                       "CONSTRUCT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.EXIT,
                                       "exit",
                                       TokenPattern.PatternType.STRING,
                                       "EXIT");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.RETURN,
                                       "return",
                                       TokenPattern.PatternType.STRING,
                                       "RETURN");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.ID,
                                       "id",
                                       TokenPattern.PatternType.STRING,
                                       "id");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.GROUP,
                                       "group",
                                       TokenPattern.PatternType.STRING,
                                       "GROUP");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.BREAK,
                                       "break",
                                       TokenPattern.PatternType.STRING,
                                       "BREAK");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CONTINUE,
                                       "continue",
                                       TokenPattern.PatternType.STRING,
                                       "CONTINUE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.END,
                                       "end",
                                       TokenPattern.PatternType.STRING,
                                       "END");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.WIPE,
                                       "wipe",
                                       TokenPattern.PatternType.STRING,
                                       "WIPE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CHOICE,
                                       "choice",
                                       TokenPattern.PatternType.STRING,
                                       "CHOICE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.WHOLE,
                                       "whole",
                                       TokenPattern.PatternType.STRING,
                                       "WHOLE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.SYMBOL,
                                       "symbol",
                                       TokenPattern.PatternType.STRING,
                                       "SYMBOL");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.PHRASE,
                                       "phrase",
                                       TokenPattern.PatternType.STRING,
                                       "PHRASE");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.FRACTION,
                                       "fraction",
                                       TokenPattern.PatternType.STRING,
                                       "FRACTION");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.EMPTY,
                                       "empty",
                                       TokenPattern.PatternType.STRING,
                                       "EMPTY");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CHOICELIT,
                                       "choicelit",
                                       TokenPattern.PatternType.STRING,
                                       "CHOICElit");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.WHOLELIT,
                                       "wholelit",
                                       TokenPattern.PatternType.STRING,
                                       "WHOLElit");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.SYMBOLLIT,
                                       "symbollit",
                                       TokenPattern.PatternType.STRING,
                                       "SYMBOLlit");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.PHRASELIT,
                                       "phraselit",
                                       TokenPattern.PatternType.STRING,
                                       "PHRASElit");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.FRACTIONLIT,
                                       "fractionlit",
                                       TokenPattern.PatternType.STRING,
                                       "FRACTIONlit");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.COMMA,
                                       "COMMA",
                                       TokenPattern.PatternType.STRING,
                                       ",");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.OBR,
                                       "OBR",
                                       TokenPattern.PatternType.STRING,
                                       "{");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CBR,
                                       "CBR",
                                       TokenPattern.PatternType.STRING,
                                       "}");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.OP,
                                       "OP",
                                       TokenPattern.PatternType.STRING,
                                       "(");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CP,
                                       "CP",
                                       TokenPattern.PatternType.STRING,
                                       ")");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.OB,
                                       "OB",
                                       TokenPattern.PatternType.STRING,
                                       "[");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.CB,
                                       "CB",
                                       TokenPattern.PatternType.STRING,
                                       "]");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.COL,
                                       "COL",
                                       TokenPattern.PatternType.STRING,
                                       ":");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.SEM,
                                       "SEM",
                                       TokenPattern.PatternType.STRING,
                                       ";");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.NEG,
                                       "NEG",
                                       TokenPattern.PatternType.STRING,
                                       "~");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.EQ,
                                       "EQ",
                                       TokenPattern.PatternType.STRING,
                                       "=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.AN,
                                       "AN",
                                       TokenPattern.PatternType.STRING,
                                       "&");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.AT,
                                       "AT",
                                       TokenPattern.PatternType.STRING,
                                       "@");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.ADD,
                                       "ADD",
                                       TokenPattern.PatternType.STRING,
                                       "+");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.SUB,
                                       "SUB",
                                       TokenPattern.PatternType.STRING,
                                       "-");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.MUL,
                                       "MUL",
                                       TokenPattern.PatternType.STRING,
                                       "*");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DIV,
                                       "DIV",
                                       TokenPattern.PatternType.STRING,
                                       "/");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.MOD,
                                       "MOD",
                                       TokenPattern.PatternType.STRING,
                                       "%");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.INC,
                                       "INC",
                                       TokenPattern.PatternType.STRING,
                                       "++");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DEC,
                                       "DEC",
                                       TokenPattern.PatternType.STRING,
                                       "--");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.LESS,
                                       "LESS",
                                       TokenPattern.PatternType.STRING,
                                       "<");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.GREAT,
                                       "GREAT",
                                       TokenPattern.PatternType.STRING,
                                       ">");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.LESSE,
                                       "LESSE",
                                       TokenPattern.PatternType.STRING,
                                       "<=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.GREATE,
                                       "GREATE",
                                       TokenPattern.PatternType.STRING,
                                       ">=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.EQUALS,
                                       "EQUALS",
                                       TokenPattern.PatternType.STRING,
                                       "==");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.NOTE,
                                       "NOTE",
                                       TokenPattern.PatternType.STRING,
                                       "!=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.NOT,
                                       "NOT",
                                       TokenPattern.PatternType.STRING,
                                       "!!");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.AND,
                                       "AND",
                                       TokenPattern.PatternType.STRING,
                                       "&&");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.OR,
                                       "OR",
                                       TokenPattern.PatternType.STRING,
                                       "\\\\");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.ADDE,
                                       "ADDE",
                                       TokenPattern.PatternType.STRING,
                                       "+=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.SUBE,
                                       "SUBE",
                                       TokenPattern.PatternType.STRING,
                                       "-=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.MULE,
                                       "MULE",
                                       TokenPattern.PatternType.STRING,
                                       "*=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.DIVE,
                                       "DIVE",
                                       TokenPattern.PatternType.STRING,
                                       "/=");
            AddPattern(pattern);

            pattern = new TokenPattern((int) SyntaxConstants.WHITESPACE,
                                       "WHITESPACE",
                                       TokenPattern.PatternType.REGEXP,
                                       "[ \\t\\n\\r]+");
            pattern.Ignore = true;
            AddPattern(pattern);
        }
    }
}
