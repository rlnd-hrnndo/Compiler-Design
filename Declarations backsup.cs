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
        public static string[] symbols;
        public static string[] huma;
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

        public static void Init()
        {
            mathop = new string[]
            {

            };

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
                "*", "/", "%", "<", ">", "!", "|"
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

            list2 = new string[] { //huma4 delim
                "YES", "NO", "SLEEP", "EXIT", "BREAK"
            };

            list3 = new string[] { //huma delim
                "CHOICE", "WHOLE", "SYMBOL", "PHRASE", "FRACTION", "EMPTY", "RETURN", "GROUP",
                "PICK", "CONSTRUCT"
            };

            list4 = new string[] { // huma10
                "THEN", "WORK"
            };

            list5 = new string[] {// huma3
                "DECIDE"
            };

            huma = new string[]
            {
                " "
            };

            huma1 = new string[]
            {
                " ", "("
            };

            huma2 = new string[]
            {
                " ", ";"
            };

            huma3 = new string[]
            {
                " ", ":"
            };

            huma4 = new string[]
            {
                " ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            huma5 = new string[]
            {
                " ", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0",
                "(", ")", "\"", "!", "|", "&"
            };

            huma6 = new string[]
            {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i",
                "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", ";",
                ")"
            };

            huma7 = new string[]
            {
                " ", ",", ";", "&", "<", ">", "|", "=", "!", ")", ":", "}"
            };

            huma8 = new string[]
            {
                " ", "'", "\"", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o",
                "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "1", "2", "3", "4", "5", "6",
                "7", "8", "9", "0"
            };

            huma9 = new string[]
            {
                " ", "\n", ";", "{", "+", "-", "*", "/", "%", "^", "<", ">", "!", "&", "|", "=", ")"
            };

            huma10 = new string[]
            {
                " ", "{"
            };

            huma11 = new string[]
            {
                ";"
            };

            huma12 = new string[]
            {
                " ", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "\n", "<", ">", "=", "!",
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z",
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
                "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
            };

            huma13 = new string[]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            huma14 = new string[]
            {
                " ", ",", "+", "-", "*", "/", "%", "^", "<", ">", "!", "&", "|", "=", ";", "]", ")", ":", "}"
            };

            huma15 = new string[]
            {
                " ", ",", "=", "(", "+", "-", "*", "/", "%", "^", "<", ">", "!", "&", "|", "=", "[",
                "@", ";", ")", "{"
            };

            huma16 = new string[]
            {
                " ", ",", ";", "+", "-", "*", "/", "%", "^", "<", ">", "!", "&", "|", "=", ")", ":", "}"
            };

            huma17 = new string[]
            {
                " ", ",", "=", ")", ";", "&", "|", "!"
            };

            huma18 = new string[]
            {
                " ", "\"", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o",
                "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };

            huma19 = new string[]
            {
                " ", "\n", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q",
                "r", "s", "t", "u", "v", "w", "x", "y", "z",
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
                "R", "S", "T", "U", "V", "W", "X", "Y", "Z",
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
            };

            huma20 = new string[]
            {
                " ", "\n", ";"
            };

            huma21 = new string[]
            {
                " ", ",", ";", "+", "-", "*", "/", "%", "^", "<", ">", "!", "&", "|", "="
            };
        }
    }
}
