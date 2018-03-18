/*
 * SyntaxParser.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

using System.IO;

using Core.Library;

namespace Syntax_Analyzer {

    /**
     * <remarks>A token stream parser.</remarks>
     */
    public class SyntaxParser : RecursiveDescentParser {

        /**
         * <summary>An enumeration with the generated production node
         * identity constants.</summary>
         */
        private enum SynteticPatterns {
        }

        /**
         * <summary>Creates a new parser with a default analyzer.</summary>
         *
         * <param name='input'>the input stream to read from</param>
         *
         * <exception cref='ParserCreationException'>if the parser
         * couldn't be initialized correctly</exception>
         */
        public SyntaxParser(TextReader input)
            : base(input) {

            CreatePatterns();
        }

        /**
         * <summary>Creates a new parser.</summary>
         *
         * <param name='input'>the input stream to read from</param>
         *
         * <param name='analyzer'>the analyzer to parse with</param>
         *
         * <exception cref='ParserCreationException'>if the parser
         * couldn't be initialized correctly</exception>
         */
        public SyntaxParser(TextReader input, SyntaxAnalyzer analyzer)
            : base(input, analyzer) {

            CreatePatterns();
        }

        /**
         * <summary>Creates a new tokenizer for this parser. Can be overridden
         * by a subclass to provide a custom implementation.</summary>
         *
         * <param name='input'>the input stream to read from</param>
         *
         * <returns>the tokenizer created</returns>
         *
         * <exception cref='ParserCreationException'>if the tokenizer
         * couldn't be initialized correctly</exception>
         */
        protected override Tokenizer NewTokenizer(TextReader input) {
            return new SyntaxTokenizer(input);
        }

        /**
         * <summary>Initializes the parser by creating all the production
         * patterns.</summary>
         *
         * <exception cref='ParserCreationException'>if the parser
         * couldn't be initialized correctly</exception>
         */
        private void CreatePatterns() {
            ProductionPattern             pattern;
            ProductionPatternAlternative  alt;

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PROGRAM,
                                            "Prod_program");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_PREWAKE, 0, 1);
            alt.AddToken((int) SyntaxConstants.WAKE, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BODY, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.SLEEP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PREWAKE,
                                            "Prod_prewake");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_CONSTANT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PREWAKE, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_GLOBALVARDEC, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PREWAKE, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_RECORD, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PREWAKE, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCTION, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PREWAKE, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DTYPE,
                                            "Prod_dtype");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLE, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FRACTION, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SYMBOL, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASE, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICE, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VALUE,
                                            "Prod_value");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FRACTIONLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICELIT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VALUE_ID,
                                            "Prod_value_id");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FRACTIONLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICELIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDACCESS, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCFORID, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_EXTRAID,
                                            "Prod_extraid");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IDEXT,
                                            "Prod_idext");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDEXT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRAY,
                                            "Prod_array");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 0, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRSIZE,
                                            "Prod_arrsize");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRCONT,
                                            "Prod_arrcont");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRCONTINS, 1, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRCONTINS,
                                            "Prod_arrcontins");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRCONTINS1, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRCONTINS1,
                                            "Prod_arrcontins1");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRCONTINS1, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRVAL,
                                            "Prod_arrval");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INIT,
                                            "Prod_init");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_EXP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_STRING, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRCONT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONSTANT,
                                            "Prod_constant");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CONSTRUCT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RECORD,
                                            "Prod_record");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.GROUP, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDBODY, 1, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RECORDBODY,
                                            "Prod_recordbody");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRAY, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDEXT, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDBODY, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RECORDACCESS,
                                            "Prod_recordaccess");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_GLOBALVARDEC,
                                            "Prod_globalvardec");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VARDEC,
                                            "Prod_vardec");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VARDEC, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INCDEC,
                                            "Prod_incdec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_UNARY, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_UNARY, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_UNARY,
                                            "Prod_unary");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.INC, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DEC, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INCDECNOSEM,
                                            "Prod_incdecnosem");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_UNARY, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_UNARY, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_OP,
                                            "Prod_rel_op");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQUALS, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.LESS, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.GREAT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.LESSE, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.GREATE, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NOTE, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOGICAL_OP,
                                            "Prod_logical_op");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AND, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_NOT,
                                            "Prod_not");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.NOT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNCFORID,
                                            "Prod_funcforid");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNCH,
                                            "Prod_funch");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETER1, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNCTION,
                                            "Prod_function");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCTIONCONT, 1, 1);
            alt.AddToken((int) SyntaxConstants.RETURN, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RET, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EMPTY, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCTIONCONT, 1, 1);
            alt.AddToken((int) SyntaxConstants.END, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNCTIONCONT,
                                            "Prod_functioncont");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETER, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BODY, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAMETER,
                                            "Prod_parameter");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAMETER1,
                                            "Prod_parameter1");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAMCONT,
                                            "Prod_paramcont");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETER, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAMETERCALL,
                                            "Prod_parametercall");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALLMATH, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAMETERCALLMATH,
                                            "Prod_parametercallmath");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAMCONTCALL,
                                            "Prod_paramcontcall");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RET,
                                            "Prod_ret");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ALL_OPERATORS, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_BODY,
                                            "Prod_body");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_BODYLOOP,
                                            "Prod_bodyloop");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RECORDASSIGNVAR,
                                            "Prod_recordassignvar");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.GROUP, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDCONT, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RECORDCONT,
                                            "Prod_recordcont");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDCONT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STATEMENT,
                                            "Prod_statement");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VARDEC, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDASSIGNVAR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_IDSTATEMENT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_IO, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_IF, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_SWITCH, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FOR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_WHILE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DOWHILE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_INCDEC, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WIPE, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT2, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STATEMENT2,
                                            "Prod_statement2");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_BODY, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STATEMENTLOOP,
                                            "Prod_statementloop");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VARDEC, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDASSIGNVAR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_IDSTATEMENT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_IO, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_IF, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_SWITCH, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_FOR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_WHILE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DOWHILE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_INCDEC, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_BREAK, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_CONTINUE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WIPE, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BODYLOOP, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_STATEMENTLOOP2,
                                            "Prod_statementloop2");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_BODYLOOP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONTINUE,
                                            "Prod_continue");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CONTINUE, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IDSTATEMENT,
                                            "Prod_idstatement");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDSTATEMENT1, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IDSTATEMENT1,
                                            "Prod_idstatement1");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCH, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ADDE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SUBE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.MULE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DIVE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ASSIGN,
                                            "Prod_assign");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN1, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_INCDEC, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ASSIGN1,
                                            "Prod_assign1");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_REL_EXP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_STRING, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_EXP,
                                            "Prod_mathExp");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP_NEXT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_EXP_NEXT,
                                            "Prod_mathExp_next");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ALL_OPERATORS, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_NOT, 0, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_REL_LOGICAL, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ALL_OPERATORS, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATHOP,
                                            "Prod_mathop");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ADD, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SUB, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.MUL, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DIV, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.MOD, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_OP_CONT,
                                            "Prod_rel_op_cont");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP_CONT_NEXT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_OP_CONT_NEXT,
                                            "Prod_rel_op_cont_next");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ALL_OPERATORS, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_NOT, 0, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_REL_LOGICAL, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ALL_OPERATORS, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOGICAL_OP_CONT,
                                            "Prod_logical_op_cont");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_LOGICAL_OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGICAL_OP_CONT_NEXT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_LOGICAL_OP_CONT_NEXT,
                                            "Prod_logical_op_cont_next");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ALL_OPERATORS, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_NOT, 0, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_REL_LOGICAL, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ALL_OPERATORS, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_REL_LOGICAL,
                                            "Prod_math_rel_logical");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP_CONT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGICAL_OP_CONT, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_NOT, 0, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP_CONT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGICAL_OP_CONT, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP_CONT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGICAL_OP_CONT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ALL_OPERATORS,
                                            "Prod_all_operators");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP_CONT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_LOGICAL_OP_CONT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_STRING,
                                            "Prod_mathString");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AN, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_STRING, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IO,
                                            "Prod_IO");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SPEAK, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_NEXT, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.LOOK, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_SPEAK_NEXT,
                                            "Prod_speak_next");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ALL_OPERATORS, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_STR, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_EXP, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_STR, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_SPEAK_STR,
                                            "Prod_speak_str");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AN, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_NEXT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_SWITCH,
                                            "Prod_switch");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EXAMINE, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CASES, 1, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CASES,
                                            "Prod_cases");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PICK, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PICKSTATEMENT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CASES, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DEFAULT, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PICK, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BREAK, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CASES, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DEFAULT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PICKSTATEMENT,
                                            "Prod_pickstatement");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BREAK, 1, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_BREAK,
                                            "Prod_break");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.BREAK, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DEFAULT,
                                            "Prod_default");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DECIDE, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BREAK, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FOR,
                                            "Prod_for");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EXECUTE, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INITIALIZATION, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONDITION, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INCDECNOSEM, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INITIALIZATION,
                                            "Prod_initialization");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONDITION,
                                            "Prod_condition");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_REL_EXP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IF,
                                            "Prod_if");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.TEST, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_EXP, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ELSE, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_EXP,
                                            "Prod_rel_exp");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_REL_COMP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_COMP,
                                            "Prod_rel_comp");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE_ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP_CONT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGICAL_OP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_NOT, 0, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_COMP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_D_OP_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_D_OP_TAIL,
                                            "Prod_d_opTail");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP_CONT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGICAL_OP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_COMP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP_CONT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_LOGICAL_OP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_COMP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_LOGICAL_OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP_CONT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_COMP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_REL_COMP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ELSE,
                                            "Prod_else");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.THEN, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.TESTIF, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_EXP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ELSE, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_WHILE,
                                            "Prod_while");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.UNTIL, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_EXP, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DOWHILE,
                                            "Prod_dowhile");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WORK, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.UNTIL, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_COMP, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);
        }
    }
}
