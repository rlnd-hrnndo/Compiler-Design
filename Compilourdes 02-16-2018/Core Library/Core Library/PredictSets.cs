﻿namespace Core.Library
{
    public class PredictSets
    {
        string program = "CONSTRUCT, GROUP, WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, EMPTY, WAKE";
        string prewake = "CONSTRUCT, WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, GROUP, EMPTY, WAKE";
        string constant = "CONSTRUCT";
        string constantinit1 = "WHOLElit";
        string constantinit2 = "FRACTIONlit";
        string constantinit3 = "SYMBOLlit";
        string constantinit4 = "WHOLElit";
        string constantinit5 = "CHOICElit";
        string value = "WHOLElit, FRACTIONlit, SYMBOLlit, PHRASElit, CHOICElit";
        string record = "GROUP";
        string recordbody = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE";
        string dtype = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE";
        string idext = ",, ;";
        string globalvardec = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE";
        string vardec = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE";
        string init1 = ",, =, , +, -, *, /, %, ;, id";
        string init2 = ",, =, , +, -, *, /, %, ;, id";
        string init3 = ",, =, , ;, id";
        string init4 = ",, =, , ;, id";
        string init5 = ",, =, , ;, id";
        string arrsize = "WHOLElit, id";
        string arrcont1 = ",, =, , +, -, *, /, %, ;, id";
        string arrcont2 = ",, =, , +, -, *, /, %, ;, id";
        string arrcont3 = ",, =, , ;, id";
        string arrcont4 = ",, =, , ;, id";
        string arrcont5 = ",, =, , ;, id";
        string arrval1 = ",, }";
        string arrval2 = ",, }";
        string arrval3 = ",, }";
        string arrval4 = ",, }";
        string arrval5 = ",, }";
        string extraid1 = ",, ;";
        string extraid2 = ",, ;";
        string extraid3 = ",, ;";
        string extraid4 = ",, ;";
        string extraid5 = ",, ;";
        string funch = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, WHOLElit, FRACTIONlit, SYMBOLlit, PHRASElit, CHOICElit, id";
        string function = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, EMPTY";
        string functioncont = "id, RETURN, END";
        string parameter = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, )";
        string parameter1 = "id";
        string paramcont = ",, )";
        string parametercall = "WHOLElit, FRACTIONlit, id, ), ,";
        string paramcontcall = ", )";
        string ret = "id, WHOLElit, FRACTIONlit, SYMBOLlit, PHRASElit, CHOICElit";
        string body = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, id, TEST, EXECUTE, WORK, GROUP, EXAMINE, ++, --, SPEAK, LOOK, UNTIL, WIPE";
        string bodyloop = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, id, TEST, EXECUTE, WORK, BREAK, GROUP, EXAMINE, ++, --, SPEAK, LOOK, CONTINUE, UNTIL, WIPE";
        string recordassignvar = "GROUP";
        string recordcont = ",";
        string statement = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, GROUP, id, SPEAK, LOOK, TEST, EXAMINE, EXECUTE, UNTIL, WORK, id, ++, --, WIPE";
        string statement2 = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, id, TEST, EXECUTE, WORK, GROUP, EXAMINE, ++, --, SPEAK, LOOK, UNTIL, BREAK, }, RETURN, END, DECIDE, WIPE";
        string statementloop = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, GROUP, id, SPEAK, LOOK, TEST, EXAMINE, EXECUTE, UNTIL, WORK, id, ++, --, BREAK, CONTINUE, WIPE";
        string statementloop2 = "WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, id, TEST, EXECUTE, WORK, BREAK, GROUP, EXAMINE, ++, --, SPEAK, LOOK, CONTINUE, UNTIL, }, WIPE";
        string strcontinue = "CONTINUE";
        string idstatement = "id";
        string idstatement1 = "@, =, (";
        string assign = "WHOLElit, FRACTIONlit, SYMBOLlit, PHRASElit, CHOICElit, id, (";
        string assign1 = "WHOLElit, FRACTIONlit, SYMBOLlit, PHRASElit, CHOICElit, id";
        string incdec = "id, ++, --";
        string mathExp = "), WHOLElit, FRACTIONlit, id, SYMBOLlit, PHRASElit, CHOICElit, =, , ,, ;, +, -, *, /, %, ==, <, >, <=, >=, !=, &&, \\";
        string mathop = "+, -, *, /, %";
        string digitmathExp = "WHOLElit, FRACTIONlit, id";
        string digit = "WHOLElit, FRACTIONlit, id";
        string mathStr = "&";
        string IO = "SPEAK, LOOK";
        string speak_next = "PHRASElit, id, )";
        string speak_str = "&, )";
        string speak_id = "&, )";
        string strswitch = "EXAMINE";
        string cases = "WHOLElit, SYMBOLlit";
        string case_whole = "WHOLElit, DECIDE, }";
        string case_symbol = "SYMBOLlit, DECIDE, }";
        string pickstatement = "{";
        string strbreak = "BREAK";
        string strdefault = "DECIDE";
        string strfor = "EXECUTE";
        string initialization = "id, WHOLElit";
        string condition = "id, WHOLElit";
        string count_exp = "id, ++, --";
        string for_rel_op = "<, >, <=, >=, !=";
        string strif = "TEST";
        string rel_exp = "WHOLElit, FRACTIONlit, SYMBOLlit, PHRASElit, CHOICElit, (, id, ==, <, >, <=, >=, !=";
        string rel_comp = "(, id, WHOLElit, FRACTIONlit, SYMBOLlit, PHRASElit, CHOICElit";
        string d_op = "WHOLElit, FRACTIONlit, id, (, ), ==, <, >, <=, >=, !=, &&, \\";
        string d_opTail = "+, -, *, /, %, ), ==, <, >, <=, >=, !=, &&, \\, WHOLElit, FRACTIONlit, id";
        string rel_op = "==, <, >, <=, >=, !=";
        string opt_cond = "&&, \\, )";
        string strelse = "THEN, TESTIF, WHOLE, FRACTION, SYMBOL, PHRASE, CHOICE, id, TEST, EXECUTE, WORK, BREAK, GROUP, EXAMINE, ++, --, SPEAK, LOOK, CONTINUE, UNTIL, }, RETURN, DECIDE, END, WIPE";
        string strwhile = "UNTIL";
        string dowhile = "WORK";
        

        public string GetPredictSet(int code)
        {
            switch (code)
            {
                case 2001: return program;
                case 2002: return prewake;
                case 2003: return constant;
                case 2004: return constantinit1;
                case 2005: return constantinit2;
                case 2006: return constantinit3;
                case 2007: return constantinit4;
                case 2008: return constantinit5;
                case 2009: return value;
                case 2010: return record;
                case 2011: return recordbody;
                case 2012: return dtype;
                case 2013: return idext;
                case 2014: return globalvardec;
                case 2015: return vardec;
                case 2016: return init1;
                case 2017: return init2;
                case 2018: return init3;
                case 2019: return init4;
                case 2020: return init5;
                case 2021: return arrsize;
                case 2022: return arrcont1;
                case 2023: return arrcont2;
                case 2024: return arrcont3;
                case 2025: return arrcont4;
                case 2026: return arrcont5;
                case 2027: return arrval1;
                case 2028: return arrval2;
                case 2029: return arrval3;
                case 2030: return arrval4;
                case 2031: return arrval5;
                case 2032: return extraid1;
                case 2033: return extraid2;
                case 2034: return extraid3;
                case 2035: return extraid4;
                case 2036: return extraid5;
                case 2037: return funch;
                case 2038: return function;
                case 2039: return functioncont;
                case 2040: return parameter;
                case 2041: return parameter1;
                case 2042: return paramcont;
                case 2043: return parametercall;
                case 2044: return paramcontcall;
                case 2045: return ret;
                case 2046: return body;
                case 2047: return bodyloop;
                case 2048: return recordassignvar;
                case 2049: return recordcont;
                case 2050: return statement;
                case 2051: return statement2;
                case 2052: return statementloop;
                case 2053: return statementloop2;
                case 2054: return strcontinue;
                case 2055: return idstatement;
                case 2056: return idstatement1;
                case 2057: return assign;
                case 2058: return assign1;
                case 2059: return incdec;
                case 2060: return mathExp;
                case 2061: return mathop;
                case 2062: return digitmathExp;
                case 2063: return digit;
                case 2064: return mathStr;
                case 2065: return IO;
                case 2066: return speak_next;
                case 2067: return speak_str;
                case 2068: return speak_id;
                case 2069: return strswitch;
                case 2070: return cases;
                case 2071: return case_whole;
                case 2072: return case_symbol;
                case 2073: return pickstatement;
                case 2074: return strbreak;
                case 2075: return strdefault;
                case 2076: return strfor;
                case 2077: return initialization;
                case 2078: return condition;
                case 2079: return count_exp;
                case 2080: return for_rel_op;
                case 2081: return strif;
                case 2082: return rel_exp;
                case 2083: return rel_comp;
                case 2084: return d_op;
                case 2085: return d_opTail;
                case 2086: return rel_op;
                case 2087: return opt_cond;
                case 2088: return strelse;
                case 2089: return strwhile;
                case 2090: return dowhile;
                default:
                    return "";
            }
        }
    }
    
}
