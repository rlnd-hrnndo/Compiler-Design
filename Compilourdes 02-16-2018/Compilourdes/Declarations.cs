using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compilourdes
{
    public class Declarations
    {
        public static string[] logop;
        public static string[] relop;
        public static string[] mathop;
        public static string[] ASCII;
        public static string[] nonzero;
        public static string[] digit;
        public static string[] sletter;
        public static string[] bletter;
        public static string[] letter;
        public static string[] ident;
        public static string[] list1;
        public static string[] list2;
        public static string[] list3;
        public static string[] list4;
        public static string[] list5;
        public static string[] list6;
        public static string[] symbols;
        public static string[] huma1;
        public static string[] huma2;
        public static string[] huma3;
        public static string[] huma4;
        public static string[] huma5;
        public static string[] huma6;
        public static string[] huma7;
        public static string[] huma8;
        public static string[] huma9;
        public static string[] huma10;
        public static string[] huma11;
        public static string[] huma12;
        public static string[] huma13;
        public static string[] huma14;
        public static string[] huma15;
        public static string[] huma16;
        public static string[] huma17;
        public static string[] huma18;
        public static string[] huma19;
        public static string[] huma20;
        public static string[] huma21;
        public static string[] huma22;
        public static string[] huma23;
        public static string[] huma24;
        public static string[] huma25;
        public static string[] huma26;
        public static int isrun = 0;

        public static void Init()
        {

            ASCII = new string[] {
                "`", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "-", "=",
                "~", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "_", "+",
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z",
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
                "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                "[", "]", "\\", ";", "'", ",", ".", "/",
                "{", "}", "|", ":", "\"", "<", ">", "?", " ", "\t", "\n"
            };

            nonzero = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            digit = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

            symbols = new string[] {
                ".", ",", "{", "}", "(", ")", "[", "]", ":", ";", "~", "^", "&", "=", "@", "+", "-",
                "*", "/", "%", "<", ">", "!", "\\"
            };

            sletter = new string[] {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            bletter = new string[]
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
                "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };

            letter = new string[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z",
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
                "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };

            ident = new string[] {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z",
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
                "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
            };

            list1 = new string[] { //huma1 delim
                "SPEAK", "LOOK", "TEST", "TESTIF", "EXAMINE", "EXECUTE", "UNTIL", "WAKE", "WIPE"
            };

            list2 = new string[] { //huma2 delim
                "SLEEP", "EXIT", "BREAK", "END"
            };

            list3 = new string[] { //huma3 delim
                "CHOICE", "WHOLE", "SYMBOL", "PHRASE", "FRACTION", "EMPTY", "RETURN", "GROUP",
                "PICK", "CONSTRUCT"
            };

            list4 = new string[] { // huma4 delim
                "THEN", "WORK"
            };

            list5 = new string[] {// huma5 delim
                "DECIDE"
            };

            list6 = new string[] {// huma26 delim
                "YES", "NO"
            };

            huma1 = new string[]
            {
                " ", "("
            };

            huma2 = new string[]
            {
                ";", " "
            };

            huma3 = new string[]
            {
                " "
            };

            huma4 = new string[]
            {
                " ", "{", "\n"
            };

            huma5 = new string[]
            {
                " ", ":"
            };

            huma6 = new string[]
            {
                " ", ",", "=", "(", "+", "-", "*", "/", "%", "^", "<", ">", "!", "&", "\\", "=", "[",
                "@", ";", ")", "{", "]"
            };

            huma7 = new string[]
            {
                " ", ",", "+", "-", "*", "/", "%", "^", "<", ">", "!", "&", "\\", "=", ";", "]", ")",
                ":", "}"
            };

            huma8 = new string[]
            {
                " ", ",", ";", "+", "-", "*", "/", "%", "^", "<", ">", "!", "&", "\\", "=", ")", ":",
                "}"
            };

            huma9 = new string[]
            {
                " ", ",", ";", "&", "<", ">", "\\", "=", "!", ")", ":", "}"
            };

            huma10 = new string[]
            {
                " ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7",
                "8", "9", "0", "(", "Y", "N"
            };

            huma11 = new string[]
            {
				"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7",
                "8", "9", "0", ";", ")", " "
            };

            huma12 = new string[]
            {
                " ", "'", "\"", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n",
                "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "0", "Y", "N"
            };

            huma13 = new string[]
            {
                " ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7",
                "8", "9", "0", "(", "\"", "'", "Y", "N"
            };

            huma14 = new string[]
            {
                " ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "("
            };

            huma15 = new string[]
            {
                " ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "C", "W", "S", "F", "P", "1", "2",
                "3", "4", "5", "6", "7", "8", "9", "0"
            };

            huma16 = new string[]
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
            };

            huma17 = new string[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7",
                "8", "9", "0", "~", "C", "W", "S", "F", "P", "\n", "(", ")", "\"", "]", " "
            };

            huma18 = new string[]
            {
                " ", "\n", ";", "{", "+", "-", "*", "/", "%", "^", "<", ">", "!", "&", "\\", "=", "(",
                ")"
            };

            huma19 = new string[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8",
                "9", "0", "S", "L", "T", "E", "U", "W", "Y", "N", "B", "C", "P", "F", "R", "G", "D",
                "(", "\n", "\t", " ", "'", "\""
            };

            huma20 = new string[]
            {
                ";", " ", "\n", "\t", ","
            };

            huma21 = new string[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8",
                "9", "0", " "
            };

            huma22 = new string[]
            {
                ";", "+", "-", "*", "/", "%", ")", " ", "=", ",", "<", ">", "!", "!", "&", "\\", "(",
                ")"
            };

            huma23 = new string[]
            {
                " ", "\n", "\t", "{", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "S", "L", "T", "E",
                "U", "W", "Y", "N", "B", "C", "P", "F", "R", "G", "D"
            };

            huma24 = new string[]
            {
                " ", "\"", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
                "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            huma25 = new string[]
            {
                "\n", " ", "\t", "}"
            };

            huma26 = new string[]
            {
                ";", " ", "(", ")", ",", "&", "\\", "!", "="
            };
        }
    }
}
