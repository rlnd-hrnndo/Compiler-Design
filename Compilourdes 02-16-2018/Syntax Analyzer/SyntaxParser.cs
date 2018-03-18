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

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONSTANT,
                                            "Prod_constant");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CONSTRUCT, 1, 1);
            alt.AddToken((int) SyntaxConstants.WHOLE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONSTANTINIT1, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID1, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CONSTRUCT, 1, 1);
            alt.AddToken((int) SyntaxConstants.FRACTION, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONSTANTINIT2, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID2, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CONSTRUCT, 1, 1);
            alt.AddToken((int) SyntaxConstants.SYMBOL, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONSTANTINIT3, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID3, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CONSTRUCT, 1, 1);
            alt.AddToken((int) SyntaxConstants.PHRASE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONSTANTINIT4, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID4, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CONSTRUCT, 1, 1);
            alt.AddToken((int) SyntaxConstants.CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONSTANTINIT5, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID5, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONSTANTINIT1,
                                            "Prod_constantinit1");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONSTANTINIT2,
                                            "Prod_constantinit2");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FRACTIONLIT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONSTANTINIT3,
                                            "Prod_constantinit3");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONSTANTINIT4,
                                            "Prod_constantinit4");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONSTANTINIT5,
                                            "Prod_constantinit5");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICELIT, 1, 1);
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

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RECORD,
                                            "Prod_record");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.GROUP, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDBODY, 1, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_RECORDBODY,
                                            "Prod_recordbody");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDEXT, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDBODY, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FRACTION, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDEXT, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDBODY, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SYMBOL, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDEXT, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDBODY, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDEXT, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDBODY, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDEXT, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_RECORDBODY, 0, 1);
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

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IDEXT,
                                            "Prod_idext");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDEXT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_GLOBALVARDEC,
                                            "Prod_globalvardec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT1, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID1, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FRACTION, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT2, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID2, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SYMBOL, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT3, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID3, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT4, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID4, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT5, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID5, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_VARDEC,
                                            "Prod_vardec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT1, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID1, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VARDEC, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FRACTION, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT2, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID2, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VARDEC, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SYMBOL, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT3, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID3, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VARDEC, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT4, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID4, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VARDEC, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICE, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT5, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID5, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_VARDEC, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INIT1,
                                            "Prod_init1");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRCONT1, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INIT2,
                                            "Prod_init2");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.FRACTIONLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRCONT2, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INIT3,
                                            "Prod_init3");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRCONT3, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INIT4,
                                            "Prod_init4");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_STRING, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_STRING, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRCONT4, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INIT5,
                                            "Prod_init5");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.CHOICELIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRCONT5, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
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

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRCONT1,
                                            "Prod_arrcont1");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL1, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRCONT2,
                                            "Prod_arrcont2");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.FRACTIONLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL2, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRCONT3,
                                            "Prod_arrcont3");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL3, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRCONT4,
                                            "Prod_arrcont4");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL4, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRCONT5,
                                            "Prod_arrcont5");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddToken((int) SyntaxConstants.CHOICELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL5, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRVAL1,
                                            "Prod_arrval1");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL1, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRVAL2,
                                            "Prod_arrval2");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.FRACTIONLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL2, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRVAL3,
                                            "Prod_arrval3");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL3, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRVAL4,
                                            "Prod_arrval4");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL4, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ARRVAL5,
                                            "Prod_arrval5");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.CHOICELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRVAL5, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_EXTRAID1,
                                            "Prod_extraid1");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT1, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID1, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_EXTRAID2,
                                            "Prod_extraid2");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT2, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID2, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_EXTRAID3,
                                            "Prod_extraid3");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT3, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID3, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_EXTRAID4,
                                            "Prod_extraid4");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT4, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID4, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_EXTRAID5,
                                            "Prod_extraid5");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.COMMA, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INIT5, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_EXTRAID5, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FUNCH,
                                            "Prod_funch");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DTYPE, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETER1, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
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
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_PARAMETER1,
                                            "Prod_parameter1");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
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
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMCONTCALL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICELIT, 1, 1);
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
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE, 1, 1);
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
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_IDSTATEMENT1, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IDSTATEMENT1,
                                            "Prod_idstatement1");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AT, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AT, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FUNCH, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PARAMETERCALL, 0, 1);
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
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ASSIGN,
                                            "Prod_assign");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN1, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ASSIGN1, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_ASSIGN1,
                                            "Prod_assign1");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FRACTIONLIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_STRING, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.CHOICELIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INCDEC,
                                            "Prod_incdec");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.INC, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.DEC, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.INC, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DEC, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_EXP,
                                            "Prod_mathExp");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGITMATH_EXP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGITMATH_EXP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
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

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DIGITMATH_EXP,
                                            "Prod_digitmathExp");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FRACTIONLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_DIGIT,
                                            "Prod_digit");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.FRACTIONLIT, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_MATH_STRING,
                                            "Prod_mathString");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AN, 1, 1);
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_STRING, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AN, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_STRING, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_IO,
                                            "Prod_IO");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.SPEAK, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_NEXT, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.LOOK, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.LOOK, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_SPEAK_NEXT,
                                            "Prod_speak_next");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_ID, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_STR, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_ID, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_STR, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_ID, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_SPEAK_STR,
                                            "Prod_speak_str");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AN, 1, 1);
            alt.AddToken((int) SyntaxConstants.PHRASELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_ID, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_SPEAK_ID,
                                            "Prod_speak_id");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AN, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_ID, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_STR, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AN, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_ID, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_SPEAK_STR, 0, 1);
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
            alt.AddProduction((int) SyntaxConstants.PROD_CASE_WHOLE, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_CASE_SYMBOL, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CASE_WHOLE,
                                            "Prod_case_whole");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PICK, 1, 1);
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PICKSTATEMENT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CASE_WHOLE, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DEFAULT, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PICK, 1, 1);
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BREAK, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CASE_WHOLE, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DEFAULT, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CASE_SYMBOL,
                                            "Prod_case_symbol");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PICK, 1, 1);
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_PICKSTATEMENT, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CASE_SYMBOL, 0, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DEFAULT, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.PICK, 1, 1);
            alt.AddToken((int) SyntaxConstants.SYMBOLLIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.COL, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_BREAK, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CASE_SYMBOL, 0, 1);
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
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FOR,
                                            "Prod_for");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.EXECUTE, 1, 1);
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_INITIALIZATION, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_CONDITION, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_COUNT_EXP, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.OBR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_STATEMENTLOOP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CBR, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_INITIALIZATION,
                                            "Prod_initialization");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.EQ, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_CONDITION,
                                            "Prod_condition");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FOR_REL_OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FOR_REL_OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FOR_REL_OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_FOR_REL_OP, 1, 1);
            alt.AddToken((int) SyntaxConstants.WHOLELIT, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_COUNT_EXP,
                                            "Prod_count_exp");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.INC, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.DEC, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.INC, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.DEC, 1, 1);
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_FOR_REL_OP,
                                            "Prod_for_rel_op");
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
            alt.AddProduction((int) SyntaxConstants.PROD_REL_OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_COMP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_OPT_COND, 0, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_REL_COMP,
                                            "Prod_rel_comp");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_VALUE, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_D_OP, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_D_OP,
                                            "Prod_d_op");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_MATH_EXP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_D_OP, 0, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_D_OP_TAIL, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.ID, 1, 1);
            alt.AddToken((int) SyntaxConstants.OB, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_ARRSIZE, 1, 1);
            alt.AddToken((int) SyntaxConstants.CB, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_D_OP_TAIL,
                                            "Prod_d_opTail");
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_MATHOP, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_D_OP, 0, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddProduction((int) SyntaxConstants.PROD_DIGIT, 1, 1);
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

            pattern = new ProductionPattern((int) SyntaxConstants.PROD_OPT_COND,
                                            "Prod_opt_cond");
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.AND, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_EXP, 1, 1);
            pattern.AddAlternative(alt);
            alt = new ProductionPatternAlternative();
            alt.AddToken((int) SyntaxConstants.OR, 1, 1);
            alt.AddProduction((int) SyntaxConstants.PROD_REL_EXP, 1, 1);
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
            alt.AddProduction((int) SyntaxConstants.PROD_REL_EXP, 1, 1);
            alt.AddToken((int) SyntaxConstants.CP, 1, 1);
            alt.AddToken((int) SyntaxConstants.SEM, 1, 1);
            pattern.AddAlternative(alt);
            AddPattern(pattern);
        }
    }
}
