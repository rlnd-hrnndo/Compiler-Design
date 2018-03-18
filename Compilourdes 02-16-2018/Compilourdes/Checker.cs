using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

using TokenLibrary;

namespace Compilourdes
{
    public class Tokens : TokenClass
    {

    }
    public class Checker
    {
        public List<Tokens> tokens = new List<Tokens>();
        string txtCode1;
        int intLineNo = 1;
        int intDelete = 0;

        public void checkMain(Compilourdes_GUI cmp, string code)
        {
            Tokens token = new Tokens();
            Declarations.Init();
            bool blFlag = false;

            txtCode1 = code;

            while (txtCode1.Length != 0) //loops until the end of the string
            {
                intDelete = 0;
                if (txtCode1.ElementAt(0).Equals(' ') || (txtCode1.ElementAt(0).Equals('\n')) || (txtCode1.ElementAt(0).Equals('\t')))
                {
                    if (txtCode1.ElementAt(0).Equals('\n'))
                        intLineNo++;
                    txtCode1 = txtCode1.Remove(0, 1); //remove spaces from the string
                    continue; //loop the process
                }
                blFlag = AnalyzeSymbols(cmp); // if reserved word is found at the function, loop immediately
                if (blFlag == true)
                    continue;
                blFlag = Analyze1(cmp);
                if (blFlag == true) // if reserved word is found at the function, loop immediately
                    continue;
                blFlag = Analyze2(cmp); // another set of reserved words
                if (blFlag == true)
                    continue;
                blFlag = Analyze3(cmp);
                if (blFlag == true)
                    continue;
                blFlag = Analyze4(cmp);
                if (blFlag == true)
                    continue;
                blFlag = Analyze5(cmp);
                if (blFlag == true)
                    continue;
                blFlag = Analyze6(cmp);
                if (blFlag == true)
                    continue;
                blFlag = ChkLiterals(cmp);
                if (blFlag == true)
                    continue;
                blFlag = DeclareId(cmp); //identifiers
                if (blFlag == true)
                    continue;
                if (blFlag == false)
                {
                    string strSub = txtCode1.Substring(0, intDelete);
                    // MessageBox.Show("No Reserved Word like: "+strSub);
                    cmp.AddtotblError("Error", "Invalid Input: "+strSub, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intDelete); //remove error word
                    continue;
                }
            }
        }
        
        public bool Analyze1(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intCtr = 0, intTemp = 0;
            foreach (char val1 in txtCode1)
            {
                if (Declarations.huma1.Contains(val1.ToString()) || val1.Equals('n')) // if the character is a delimiter
                {
                    if (intTemp > intDelete)
                        intDelete = intTemp; //length of wrong reserved word (if the word is incorrect)
                    goto label1; // goto label1 to check for reserved word
                }
                string strCompare1 = txtCode1.Substring(0, intCtr); //to compare for wrong delimiter
                if (txtCode1.ElementAt(intCtr).Equals('I')) //if equals 'I' for TESTIF
                    goto iter;
                else if (Declarations.list1.Contains(strCompare1)) //if the words are equal without encountering a delimiter
                {
                    //MessageBox.Show("Wrong expected delimiter on input");
                    cmp.AddtotblError("LEX-Error", "Wrong expected delimiter on " + strCompare1, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                iter:;
                intCtr++;
                intTemp++;
            }
            label1:;
            string strCompare = txtCode1.Substring(0, intCtr); // to check for correct reserved word
            if (Declarations.list1.Contains(strCompare))
            {
                if (intCtr == txtCode1.Length) //if there is no delimiter execute this block
                {
                    //MessageBox.Show("No Delimiter");
                    cmp.AddtotblError("LEX-Error", "No Delimiter on Input: " + strCompare, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                cmp.AddtotblLexeme(strCompare, strCompare, intLineNo.ToString(), ""); // put to tblLexeme the lexeme & token
                token.setTokens(strCompare);
                token.setLexemes(strCompare);
                token.setLines(intLineNo);
                tokens.Add(token);
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                /*if (txtCode1.ElementAt(0).Equals(' ')){ //if delim is equal to whitespace
                    cmp.AddtotblLexeme("\" \"", "\" \""); //put to tblLexeme
                    token.setTokens("\" \"");
                    token.setLexemes("\" \"");
                    tokens.Add(token);
                }*/
                return true; //return true to loop the whole process
            }
            /*else if ((Declarations.list1.Contains(strCompare.ToUpper())) && (!Declarations.list1.Contains(strCompare)))
            {
                cmp.AddtotblError("LEX-Error", "Reserved word: " + strCompare.ToUpper() + " should be capitalized", intLineNo.ToString());
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                return true;
            }*/
            return false; //return false to check for other functions
        }

        public bool Analyze2(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intCtr = 0, intTemp = 0;
            foreach (char val1 in txtCode1)
            {
                if (Declarations.huma2.Contains(val1.ToString()) || val1.Equals('n')) // if the character is a delimiter
                {
                    if (intTemp > intDelete)
                        intDelete = intTemp; //length of wrong reserved word (if the word is incorrect)
                    goto label2; // goto label2 to check for reserved word
                }
                string strCompare1 = txtCode1.Substring(0, intCtr); //to compare for wrong delimiter
                if (Declarations.list2.Contains(strCompare1)) //if the words are equal without encountering a delimiter
                {
                    // MessageBox.Show("Wrong expected delimiter on input");
                    cmp.AddtotblError("LEX-Error", "Wrong expected delimiter on " + strCompare1, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                intCtr++;
                intTemp++;
            }
            label2:;
            string strCompare = txtCode1.Substring(0, intCtr); // to check for correct reserved word
            if (Declarations.list2.Contains(strCompare))
            {
                if (intCtr == txtCode1.Length) //if there is no delimiter execute this block
                {
                    // MessageBox.Show("No Delimiter");
                    cmp.AddtotblError("LEX-Error", "No Delimiter on Input: " + strCompare, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                string strToken = strCompare;
                if (strCompare.Equals("YES") || (strCompare.Equals("NO")))
                    strToken = "CHOICElit";
                cmp.AddtotblLexeme(strCompare, strToken, intLineNo.ToString(), ""); // put to tblLexeme the lexeme & token
                token.setTokens(strToken);
                token.setLexemes(strCompare);
                token.setLines(intLineNo);
                tokens.Add(token);
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                /*if (txtCode1.ElementAt(0).Equals(' '))
                { //if delim is equal to whitespace
                    cmp.AddtotblLexeme("\" \"", "\" \""); //put to tblLexeme
                    token.setTokens("\" \"");
                    token.setLexemes("\" \"");
                    tokens.Add(token);
                }*/
                return true; //return true to loop the whole process
            }
            /*else if ((Declarations.list2.Contains(strCompare.ToUpper())) && (!Declarations.list2.Contains(strCompare)))
            {
                cmp.AddtotblError("LEX-Error", "Reserved word: " + strCompare.ToUpper() + " should be capitalized", intLineNo.ToString());
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                return true;
            }*/
            return false; //return false to check for other functions
        }

        public bool Analyze3(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intCtr = 0, intTemp = 0;
            foreach (char val1 in txtCode1)
            {
                if (Declarations.huma3.Contains(val1.ToString()) || val1.Equals('n'))
                {
                    if (intTemp > intDelete)
                        intDelete = intTemp; //length of wrong reserved word (if the word is incorrect)
                    goto label3; // goto label2 to check for reserved word
                }

                string strCompare1 = txtCode1.Substring(0, intCtr); //to compare for wrong delimiter
                if (Declarations.list3.Contains(strCompare1)) //if the words are equal without encountering a delimiter
                {
                    // MessageBox.Show("Wrong expected delimiter on input");
                    cmp.AddtotblError("LEX-Error", "Wrong expected delimiter on " + strCompare1, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                intCtr++;
                intTemp++;
            }
            label3:;
            string strCompare = txtCode1.Substring(0, intCtr); // to check for correct reserved word
            if (Declarations.list3.Contains(strCompare))
            {
                if (intCtr == txtCode1.Length) //if there is no delimiter execute this block
                {
                    // MessageBox.Show("No Delimiter");
                    cmp.AddtotblError("LEX-Error", "No Delimiter on Input: " + strCompare, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                cmp.AddtotblLexeme(strCompare, strCompare, intLineNo.ToString(), ""); // put to tblLexeme the lexeme & token
                token.setTokens(strCompare);
                token.setLexemes(strCompare);
                token.setLines(intLineNo);
                tokens.Add(token);
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                /*if (txtCode1.ElementAt(0).Equals(' '))
                {//if delim is equal to whitespace
                    cmp.AddtotblLexeme("\" \"", "\" \""); //put to tblLexeme
                    token.setTokens("\" \"");
                    token.setLexemes("\" \"");
                    tokens.Add(token);
                }*/
                    return true; //return true to loop the whole process
            }
            /*else if ((Declarations.list3.Contains(strCompare.ToUpper())) && (!Declarations.list3.Contains(strCompare)))
            {
                cmp.AddtotblError("LEX-Error", "Reserved word: " + strCompare.ToUpper() + " should be capitalized", intLineNo.ToString());
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                return true;
            }*/
            return false; //return false to check for other functions
        }

        public bool Analyze4(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intCtr = 0, intTemp = 0;
            foreach (char val1 in txtCode1)
            {
                if (Declarations.huma4.Contains(val1.ToString()) || val1.Equals('n'))
                {
                    if (intTemp > intDelete)
                        intDelete = intTemp; //length of wrong reserved word (if the word is incorrect)
                    goto label4; // goto label2 to check for reserved word
                }

                string strCompare1 = txtCode1.Substring(0, intCtr); //to compare for wrong delimiter
                if (Declarations.list4.Contains(strCompare1)) //if the words are equal without encountering a delimiter
                {
                    // MessageBox.Show("Wrong expected delimiter on input");
                    cmp.AddtotblError("LEX-Error", "Wrong expected delimiter on " + strCompare1, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                intCtr++;
                intTemp++;
            }
            label4:;
            string strCompare = txtCode1.Substring(0, intCtr); // to check for correct reserved word
            if (Declarations.list4.Contains(strCompare))
            {
                if (intCtr == txtCode1.Length) //if there is no delimiter execute this block
                {
                    // MessageBox.Show("No Delimiter");
                    cmp.AddtotblError("LEX-Error", "No Delimiter on Input: " + strCompare, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                cmp.AddtotblLexeme(strCompare, strCompare, intLineNo.ToString(), ""); // put to tblLexeme the lexeme & token
                token.setTokens(strCompare);
                token.setLexemes(strCompare);
                token.setLines(intLineNo);
                tokens.Add(token);
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                /*if (txtCode1.ElementAt(0).Equals(' '))
                {//if delim is equal to whitespace
                    cmp.AddtotblLexeme("\" \"", "\" \""); //put to tblLexeme
                    token.setTokens("\" \"");
                    token.setLexemes("\" \"");
                    tokens.Add(token);
                }*/
                    return true; //return true to loop the whole process
            }
            /*else if ((Declarations.list4.Contains(strCompare.ToUpper())) && (!Declarations.list4.Contains(strCompare)))
            {
                cmp.AddtotblError("LEX-Error", "Reserved word: " + strCompare.ToUpper() + " should be capitalized", intLineNo.ToString());
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                return true;
            }*/
            return false; //return false to check for other functions
        }

        public bool Analyze5(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intCtr = 0, intTemp = 0;
            foreach (char val1 in txtCode1)
            {
                if (Declarations.huma5.Contains(val1.ToString()) || val1.Equals('n'))
                {
                    if (intTemp > intDelete)
                        intDelete = intTemp; //length of wrong reserved word (if the word is incorrect)
                    goto label4; // goto label2 to check for reserved word
                }

                string strCompare1 = txtCode1.Substring(0, intCtr); //to compare for wrong delimiter
                if (Declarations.list5.Contains(strCompare1)) //if the words are equal without encountering a delimiter
                {
                    // MessageBox.Show("Wrong expected delimiter on input");
                    cmp.AddtotblError("LEX-Error", "Wrong expected delimiter on " + strCompare1, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                intCtr++;
                intTemp++;
            }
            label4:;
            string strCompare = txtCode1.Substring(0, intCtr); // to check for correct reserved word
            if (Declarations.list5.Contains(strCompare))
            {
                if (intCtr == txtCode1.Length) //if there is no delimiter execute this block
                {
                    // MessageBox.Show("No Delimiter");
                    cmp.AddtotblError("LEX-Error", "No Delimiter on Input: " + strCompare, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                cmp.AddtotblLexeme(strCompare, strCompare, intLineNo.ToString(), ""); // put to tblLexeme the lexeme & token
                token.setTokens(strCompare);
                token.setLexemes(strCompare);
                token.setLines(intLineNo);
                tokens.Add(token);
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                /*if (txtCode1.ElementAt(0).Equals(' '))
                {//if delim is equal to whitespace
                    cmp.AddtotblLexeme("\" \"", "\" \"");
                    token.setTokens("\" \"");
                    token.setLexemes("\" \"");
                    tokens.Add(token);
                }//put to tblLexeme*/
                return true; //return true to loop the whole process
            }
            /*else if ((Declarations.list5.Contains(strCompare.ToUpper())) && (!Declarations.list5.Contains(strCompare)))
            {
                cmp.AddtotblError("LEX-Error", "Reserved word: " + strCompare.ToUpper() + " should be capitalized", intLineNo.ToString());
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                return true;
            }*/
            return false; //return false to check for other functions
        }

        public bool Analyze6(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intCtr = 0, intTemp = 0;
            foreach (char val1 in txtCode1)
            {
                if (Declarations.huma26.Contains(val1.ToString()) || val1.Equals('n'))
                {
                    if (intTemp > intDelete)
                        intDelete = intTemp; //length of wrong reserved word (if the word is incorrect)
                    goto label4; // goto label2 to check for reserved word
                }

                string strCompare1 = txtCode1.Substring(0, intCtr); //to compare for wrong delimiter
                if (Declarations.list6.Contains(strCompare1)) //if the words are equal without encountering a delimiter
                {
                    // MessageBox.Show("Wrong expected delimiter on input");
                    cmp.AddtotblError("LEX-Error", "Wrong expected delimiter on " + strCompare1, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                intCtr++;
                intTemp++;
            }
            label4:;
            string strCompare = txtCode1.Substring(0, intCtr); // to check for correct reserved word
            if (Declarations.list6.Contains(strCompare))
            {
                if (intCtr == txtCode1.Length) //if there is no delimiter execute this block
                {
                    // MessageBox.Show("No Delimiter");
                    cmp.AddtotblError("LEX-Error", "No Delimiter on Input: " + strCompare, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr); //remove error word
                    return true; //return to checkMain to loop the whole process
                }
                string strToken = strCompare;
                if (strCompare.Equals("YES") || (strCompare.Equals("NO")))
                    strToken = "CHOICElit";
                cmp.AddtotblLexeme(strCompare, strToken, intLineNo.ToString(), ""); // put to tblLexeme the lexeme & token
                token.setTokens(strToken);
                token.setLexemes(strCompare);
                token.setLines(intLineNo);
                tokens.Add(token);
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                /*if (txtCode1.ElementAt(0).Equals(' '))
                {//if delim is equal to whitespace
                    cmp.AddtotblLexeme("\" \"", "\" \"");
                    token.setTokens("\" \"");
                    token.setLexemes("\" \"");
                    tokens.Add(token);
                }//put to tblLexeme*/
                return true; //return true to loop the whole process
            }
            /*else if ((Declarations.list5.Contains(strCompare.ToUpper())) && (!Declarations.list5.Contains(strCompare)))
            {
                cmp.AddtotblError("LEX-Error", "Reserved word: " + strCompare.ToUpper() + " should be capitalized", intLineNo.ToString());
                txtCode1 = txtCode1.Remove(0, intCtr); //remove the finished word
                return true;
            }*/
            return false; //return false to check for other functions
        }

        public bool DeclareId(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intCtr = 0, intChk = 0;
            string strID = null;
            foreach (char val1 in txtCode1)
            {
                if (Declarations.huma6.Contains(val1.ToString()) || val1.Equals('\n'))
                {
                    goto label3;
                }
                intCtr++;
            }
            label3:;
            if (intCtr == txtCode1.Length)
            {
                strID = txtCode1.Substring(0, intCtr);
                cmp.AddtotblError("LEX-Error", "No Delimiter on Input: " + strID, intLineNo.ToString());
                txtCode1 = txtCode1.Remove(0, intCtr);
                return true;
            }
            strID = txtCode1.Substring(0, intCtr);
            foreach (char val2 in strID)
            {
                string strCmp = val2.ToString();
                if(intChk == 0) // checking the first letter of the identifier
                {
                    if (Declarations.sletter.Contains(strCmp)) // if identifier starts with a small letter
                    {
                        intChk++;
                    }
                    else // show an error if it does not
                    {
                        string strSub = txtCode1.Substring(0, intCtr);
                        //MessageBox.Show("Identifier name should start with lowercase letter");
                        cmp.AddtotblError("Error", "Identifier \""+strSub+"\" should start with lowercase letter", intLineNo.ToString());
                        txtCode1 = txtCode1.Remove(0, intCtr);
                        goto exit1;
                    }
                }
                else if (intChk > 0)
                {
                    if (Declarations.ident.Contains(strCmp))
                    {
                        intChk++;
                    }
                    else
                    {
                        string strSub = txtCode1.Substring(0, intCtr);
                        // MessageBox.Show("Identifier name declaration error");
                        cmp.AddtotblError("Error", "There should be no special characters in id name: "+strSub, intLineNo.ToString());
                        txtCode1 = txtCode1.Remove(0, intCtr);
                        goto exit1;
                    }
                }
            }
            if(txtCode1.Length == intCtr)
            {
                cmp.AddtotblError("LEX-Error", "No Delimiter: "+strID, intLineNo.ToString());
                txtCode1 = txtCode1.Remove(0, intCtr);
                return true;
            }
            if (intCtr > 30)
            {
                // MessageBox.Show("Identifier should not exceed 8 characters");
                cmp.AddtotblError("Error", "Identifier should not exceed 30 characters", intLineNo.ToString());
                txtCode1 = txtCode1.Remove(0, intCtr);
                return true;
            }
            //marker
            if (txtCode1.ElementAt(intCtr).Equals('@'))
            {
                txtCode1 = txtCode1.Remove(0, intCtr+1);
                intCtr = 0;
                intChk = 0;
                string strID1 = null;
                foreach (char val1 in txtCode1)
                {
                    if (Declarations.huma6.Contains(val1.ToString()) || val1.Equals('\n'))
                    {
                        goto label4;
                    }
                    intCtr++;
                }
                label4:;
                if (intCtr == txtCode1.Length)
                {
                    strID1 = txtCode1.Substring(0, intCtr);
                    cmp.AddtotblError("Error", "Struct error" + strID1, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr);
                    return true;
                }
                strID1 = txtCode1.Substring(0, intCtr);
                if (intCtr == 0)
                {
                    cmp.AddtotblError("LEX-Error", "Struct error", intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr);
                    return true;
                }
                foreach (char val2 in strID1)
                {
                    string strCmp = val2.ToString();
                    if (intChk == 0) // checking the first letter of the identifier
                    {
                        if (Declarations.sletter.Contains(strCmp)) // if identifier starts with a small letter
                        {
                            intChk++;
                        }
                        else // show an error if it does not
                        {
                            string strSub = txtCode1.Substring(0, intCtr);
                            //MessageBox.Show("Identifier name should start with lowercase letter");
                            cmp.AddtotblError("Error", "Identifier \"" + strSub + "\" should start with lowercase letter", intLineNo.ToString());
                            txtCode1 = txtCode1.Remove(0, intCtr);
                            goto exit1;
                        }
                    }
                    else if (intChk > 0)
                    {
                        if (Declarations.ident.Contains(strCmp))
                        {
                            intChk++;
                        }
                        else
                        {
                            string strSub = txtCode1.Substring(0, intCtr);
                            // MessageBox.Show("Identifier name declaration error");
                            cmp.AddtotblError("Error", "There should be no special characters in id name: " + strSub, intLineNo.ToString());
                            txtCode1 = txtCode1.Remove(0, intCtr);
                            goto exit2;
                        }
                    }
                }
                //MessageBox.Show(strID);
                //strID = temp + strID1;
                if (txtCode1.Length == intCtr)
                {
                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + strID, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr);
                    return true;
                }
                if (intCtr > 30)
                {
                    // MessageBox.Show("Identifier should not exceed 8 characters");
                    cmp.AddtotblError("Error", "Identifier "+strID1+" should not exceed 30 characters", intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr);
                    return true;
                }
                if (txtCode1.ElementAt(intCtr).Equals('@'))
                {
                    cmp.AddtotblError("Error", "Struct error", intLineNo.ToString());
                }
                else if (!Declarations.huma6.Contains(txtCode1.ElementAt(intCtr).ToString()))
                {
                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + strID, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr);
                    return true;
                }
                else
                {
                    cmp.AddtotblLexeme(strID, "id", intLineNo.ToString(), "");
                    token.setTokens("id");
                    token.setLexemes(strID);
                    token.setLines(intLineNo);
                    tokens.Add(token);
                    Tokens token1 = new Tokens();
                    cmp.AddtotblLexeme("@", "@", intLineNo.ToString(), "");
                    token1.setTokens("@");
                    token1.setLexemes(strID);
                    token1.setLines(intLineNo);
                    tokens.Add(token1);
                    Tokens token2 = new Tokens();
                    cmp.AddtotblLexeme(strID1, "id", intLineNo.ToString(), "");
                    token2.setTokens("id");
                    token2.setLexemes(strID);
                    token2.setLines(intLineNo);
                    tokens.Add(token);
                }
                txtCode1 = txtCode1.Remove(0, intCtr);
                exit2:;
                return true;
            }
            else if (!Declarations.huma6.Contains(txtCode1.ElementAt(intCtr).ToString()))
            {
                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + strID, intLineNo.ToString());
                txtCode1 = txtCode1.Remove(0, intCtr);
                return true;
            }
            else
            {
                cmp.AddtotblLexeme(strID, "id", intLineNo.ToString(), "");
                token.setTokens("id");
                token.setLexemes(strID);
                token.setLines(intLineNo);
                tokens.Add(token);

            }
            txtCode1 = txtCode1.Remove(0, intCtr);
            exit1:;
            return true;
        }

        public bool AnalyzeStringlit(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intQuote = 0, intL = intLineNo, intSub = 0;
            string strStringlit = "";
            if (txtCode1.ElementAt(0).Equals('\"'))
            {
                if (txtCode1.Length == 1)
                {
                    cmp.AddtotblError("Error", "\" expected", intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, 1);
                    return true;
                }

                int intCtr = 1;

                while ((!txtCode1.ElementAt(intCtr).Equals('\"'))/* && Declarations.ASCII.Contains(txtCode1.ElementAt(intCtr).ToString())*/)
                {
                    if(intCtr == 1)
                    {
                        strStringlit = strStringlit + "\"";
                    }

                    if (txtCode1.ElementAt(intCtr).Equals('\t'))
                    {
                        strStringlit = strStringlit + "\\t";
                        intSub++;
                    }

                    else if (txtCode1.ElementAt(intCtr).Equals('\n'))
                    {
                        strStringlit = strStringlit + "\\n";
                        intSub++;
                    }

                    else if (txtCode1.ElementAt(intCtr).Equals('\\'))
                    {
                        if(intCtr == txtCode1.Length)
                        {
                            cmp.AddtotblError("Error", "\" expected", intLineNo.ToString());
                            txtCode1 = txtCode1.Remove(0, intCtr);
                            return true;
                        }
                        intCtr++;
                        if(txtCode1.ElementAt(intCtr) == '\"')
                        {
                            strStringlit = strStringlit + "\\\"";
                            intSub = intSub + 4;
                            intQuote--;
                        }
                        if (txtCode1.ElementAt(intCtr) == '\'')
                        {
                            strStringlit = strStringlit + "\\\'";
                            intSub = intSub + 4;
                        }
                        else
                            strStringlit = strStringlit + "\\" + txtCode1.ElementAt(intCtr);
                    }

                    else
                        strStringlit = strStringlit + txtCode1.ElementAt(intCtr);

                    intCtr++;
                    if (txtCode1.Length == intCtr)
                    {
                        cmp.AddtotblError("Error", "\" expected", intLineNo.ToString());
                        txtCode1 = txtCode1.Remove(0, intCtr);
                        return true;
                    }
                    if (txtCode1.ElementAt(intCtr).Equals('\n'))
                        intLineNo++;
                }

                strStringlit = strStringlit + "\"";

                for(int intC = 0; intC <= intCtr; intC++)
                {
                    if (txtCode1.ElementAt(intC).Equals('\"'))
                        intQuote++;
                }

                int length = intCtr + intQuote - 1;
                //string strStringlit = txtCode1.Substring(0, length);

                if((strStringlit.Length - intSub) == txtCode1.Length)
                {
                    cmp.AddtotblError("LEX-Error", "No Delimiter PHRASElit", intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }

                if ((Declarations.huma9.Contains(txtCode1.ElementAt(length).ToString())) && intQuote == 2)
                {
                    cmp.AddtotblLexeme(strStringlit, "PHRASElit", intLineNo.ToString(), "");
                    token.setTokens("PHRASElit");
                    token.setLexemes(strStringlit);
                    token.setLines(intLineNo);
                    tokens.Add(token);
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }

                else if (intQuote == 1)
                {
                    //MessageBox.Show("Incorrect Delimiter stringlit");
                    cmp.AddtotblError("Error", "\" expected", intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }

                else
                {
                    //MessageBox.Show("Incorrect Delimiter stringlit");
                    //MessageBox.Show(strStringlit);
                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: "+strStringlit, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }
            }
            return false;
        }

        public bool AnalyzeCharlit(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intQuote = 0, intSub = 0;
            string strCharlit = "";
            if (txtCode1.ElementAt(0).Equals('\''))
            {
                if (txtCode1.Length == 1)
                {
                    cmp.AddtotblError("Error", "\' expected", intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, 1);
                    return true;
                }

                int intCtr = 1;

                while ((!txtCode1.ElementAt(intCtr).Equals('\''))/* && Declarations.ASCII.Contains(txtCode1.ElementAt(intCtr).ToString())*/)
                {
                    if (intCtr == 1)
                    {
                        strCharlit = strCharlit + "\'";
                    }

                    if (txtCode1.ElementAt(intCtr).Equals('\\'))
                    {
                        if (intCtr == txtCode1.Length)
                        {
                            cmp.AddtotblError("Error", "\' expected", intLineNo.ToString());
                            txtCode1 = txtCode1.Remove(0, intCtr);
                            return true;
                        }
                        intCtr++;
                        if (txtCode1.ElementAt(intCtr) == '\"')
                        {
                            strCharlit = strCharlit + "\\\"";
                            intSub = intSub + 1;
                        }
                        if (txtCode1.ElementAt(intCtr) == '\'')
                        {
                            strCharlit = strCharlit + "\\\'";
                            intSub = intSub + 1;
                            intQuote--;
                        }
                        if (txtCode1.ElementAt(intCtr) == 'n')
                        {
                            strCharlit = strCharlit + "\\n";
                            intSub = intSub + 1;
                        }
                        if (txtCode1.ElementAt(intCtr) == 't')
                        {
                            strCharlit = strCharlit + "\\t";
                            intSub = intSub + 1;
                        }
                        if (txtCode1.ElementAt(intCtr) == '0')
                        {
                            strCharlit = strCharlit + "\\0";
                            intSub = intSub + 1;
                        }
                        if (txtCode1.ElementAt(intCtr) == '\\')
                        {
                            strCharlit = strCharlit + "\\\\";
                            intSub = intSub + 1;
                        }
                    }

                    else
                        strCharlit = strCharlit + txtCode1.ElementAt(intCtr);

                    intCtr++;
                    if (txtCode1.Length == intCtr)
                    {
                        cmp.AddtotblError("Error", "\' expected", intLineNo.ToString());
                        txtCode1 = txtCode1.Remove(0, intCtr);
                        return true;
                    }
                    if (txtCode1.ElementAt(intCtr).Equals('\n'))
                        intLineNo++;
                }

                strCharlit = strCharlit + "\'";
                for (int intC = 0; intC <= intCtr; intC++)
                {
                    if (txtCode1.ElementAt(intC).Equals('\''))
                        intQuote++;
                }

                int length = intCtr + (intQuote - 1);
                int length1 = intCtr + (intQuote - 1) - intSub;
                //strCharlit = txtCode1.Substring(0, length);
                if (length1 > 3)
                {
                    cmp.AddtotblError("Error", "Character literals should only comprise of 1 character", intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }
                if (strCharlit.Length == txtCode1.Length)
                {
                    cmp.AddtotblError("LEX-Error", "No Delimiter SYMBOLlit", intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }

                if ((Declarations.huma9.Contains(txtCode1.ElementAt(length).ToString())) && intQuote == 2)
                {
                    cmp.AddtotblLexeme(strCharlit, "SYMBOLlit", intLineNo.ToString(), "");
                    token.setTokens("SYMBOLlit");
                    token.setLexemes(strCharlit);
                    token.setLines(intLineNo);
                    tokens.Add(token);
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }

                else if (intQuote == 1)
                {
                    //MessageBox.Show("Incorrect Delimiter stringlit");
                    cmp.AddtotblError("Error", "\' expected", intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }

                else
                {
                    //MessageBox.Show("Incorrect Delimiter stringlit");
                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter", intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }
            }
            return false;
        }

        public bool AnalyzeWholelit(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            if ((Declarations.digit.Contains(txtCode1.ElementAt(0).ToString())) || (txtCode1.ElementAt(0).Equals('~')))
            {
                int intCtr = 1, intTemp = 1, intNZ = 0, intZ = 0;
                if (txtCode1.Length == 1)
                {
                    string strerror = txtCode1.Substring(0, intCtr);
                    cmp.AddtotblError("LEX-Error", "No Delimiter "+strerror, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr);
                    return true;
                }
                while (!Declarations.huma7.Contains(txtCode1.ElementAt(intCtr).ToString()) && Declarations.digit.Contains(txtCode1.ElementAt(intCtr).ToString()))
                {
                    intCtr++;
                    intTemp++;
                    if(txtCode1.Length == intCtr)
                    {
                        string strerror = txtCode1.Substring(0, intCtr);
                        cmp.AddtotblError("LEX-Error", "No Delimiter "+strerror, intLineNo.ToString());
                        txtCode1 = txtCode1.Remove(0, intCtr);
                        return true;
                    }
                }
                if (txtCode1.ElementAt(0).Equals('~'))
                {
                    intTemp--;
                    intZ = 1;
                }
                string strWholelit = txtCode1.Substring(0, intCtr);
                foreach (char x in strWholelit)
                {
                    if (x.Equals('~'))
                        continue;
                    if (x.Equals('0') && (intNZ == 0))
                    {
                        intTemp--;
                        strWholelit = strWholelit.Remove(intZ, 1);
                    }
                    else
                        intNZ++;
                    if (intNZ > 0)
                        break;
                }
                if (intNZ == 0 && strWholelit.Length == 0)
                    strWholelit = "0";
                if (strWholelit.Equals("~"))
                    strWholelit = "0";
                if(intTemp > 8)
                {
                    if (txtCode1.ElementAt(0).Equals('~'))
                        txtCode1 = txtCode1.Remove(0, 1);
                    //MessageBox.Show("Integer literals should not exceed 8 characters");
                    cmp.AddtotblError("Error", "Integer literals should not exceed 8 characters: " + strWholelit, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, 8);
                    return true;
                }
                if (Declarations.huma7.Contains(txtCode1.ElementAt(intCtr).ToString()))
                {
                    cmp.AddtotblLexeme(strWholelit, "WHOLElit", intLineNo.ToString(), "");
                    token.setTokens("WHOLElit");
                    token.setLexemes(strWholelit);
                    token.setLines(intLineNo);
                    tokens.Add(token);
                    txtCode1 = txtCode1.Remove(0, intCtr);
                    return true;
                }
                else
                {
                    // MessageBox.Show("Incorrect Delimiter wholelit");
                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + strWholelit, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr);
                    return true;
                }
            }
            return false;
        }

        public bool AnalyzeFloatlit(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            if ((Declarations.digit.Contains(txtCode1.ElementAt(0).ToString())) || (txtCode1.ElementAt(0).Equals('~')))
            {
                int intCtr = 1, intTemp = 1, intPoint = 0, intWhole = 0, intDecimal = 0, intNZ = 0, intZ = 0;

                if(txtCode1.Length == 1)
                {
                    string strerror = txtCode1.Substring(0, intCtr);
                    cmp.AddtotblError("LEX-Error", "No Delimiter "+strerror, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, intCtr);
                    return true;
                }

                while (!Declarations.huma7.Contains(txtCode1.ElementAt(intCtr).ToString()) || Declarations.digit.Contains(txtCode1.ElementAt(intCtr).ToString()))
                {
                    intCtr++;
                    intTemp++;
                    if (txtCode1.Length == intCtr)
                    {
                        string strerror = txtCode1.Substring(0, intCtr);
                        cmp.AddtotblError("LEX-Error", "No Delimiter "+strerror, intLineNo.ToString());
                        txtCode1 = txtCode1.Remove(0, intCtr);
                        return true;
                    }
                }

                string strFractionlit = txtCode1.Substring(0, intCtr);

                foreach(char val1 in strFractionlit)
                {
                    if ((!val1.Equals('.')) && (intPoint == 0))
                        intWhole++;

                    else if ((!val1.Equals('.')) && (intPoint == 1))
                    {
                        intDecimal++;
                        if (intDecimal == 7)
                            break;
                    }

                    else if (intPoint > 1)
                    {
                        intPoint--;
                        break;
                    }

                    else
                        intPoint++;
                }
                int length = intWhole + intDecimal + intPoint;
                if (txtCode1.ElementAt(0).Equals('~'))
                {
                    intZ = 1;
                    intWhole--;
                }
                strFractionlit = strFractionlit.Substring(0, length);
                if (intPoint == 0 || intDecimal == 0)
                    return false;
                foreach (char x in strFractionlit)
                {
                    if (x.Equals('~'))
                        continue;
                    if (x.Equals('0') && intNZ < 1)
                    {
                        intWhole--;
                        strFractionlit = strFractionlit.Remove(intZ, 1);
                    }
                    else
                        intNZ++;
                    if (intNZ > 0)
                        break;
                }
                if(intWhole == 0)
                {
                    if(intZ > 0)
                    {
                        string negative = strFractionlit.Substring(0, 1);
                        string next = strFractionlit.Substring(1);
                        strFractionlit = negative + "0" + next;
                    }
                    else
                    {
                        string body = strFractionlit.Substring(0);
                        strFractionlit = "0" + body;
                    }
                }
                if (intWhole > 8)
                {
                    if (txtCode1.ElementAt(0).Equals('~'))
                        txtCode1 = txtCode1.Remove(0, 1);
                    //MessageBox.Show("Integer literals should not exceed 8 characters");
                    cmp.AddtotblError("Error", "Integer portion should not exceed 8 digits: "+strFractionlit, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, 8);
                    return true;
                }
                if (Declarations.huma8.Contains(txtCode1.ElementAt(length).ToString()))
                {
                    cmp.AddtotblLexeme(strFractionlit, "FRACTIONlit", intLineNo.ToString(), "");
                    token.setTokens("FRACTIONlit");
                    token.setLexemes(strFractionlit);
                    token.setLines(intLineNo);
                    tokens.Add(token);
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }
                else
                {
                    // MessageBox.Show("Incorrect Delimiter fractionlit");
                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + strFractionlit, intLineNo.ToString());
                    txtCode1 = txtCode1.Remove(0, length);
                    return true;
                }
            }
            return false;
        }

        public bool ChkLiterals(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            bool blFlag;
            blFlag = AnalyzeStringlit(cmp); //string literals
            if (blFlag == true)
                return true;
            blFlag = AnalyzeCharlit(cmp); //character literals
            if (blFlag == true)
                return true;
            blFlag = AnalyzeFloatlit(cmp); //floating point literals
            if (blFlag == true)
                return true;
            blFlag = AnalyzeWholelit(cmp); //integer literals
            if (blFlag == true)
                return true;
            return false;
        }

        public bool AnalyzeSymbols(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intCtr = 1;
            string val1 = txtCode1.ElementAt(intCtr-1).ToString();
            string attribu = "";

            if (intDelete > 0)
                return false;

            if (Declarations.symbols.Contains(val1))
            {
                switch (val1)
                {
                    case ".":
                        {
                            cmp.AddtotblError("Error", "Invalid Input: " + val1, intLineNo.ToString());
                            goto del1;
                        }
                    case ",":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (Declarations.huma15.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "{":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (Declarations.huma19.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "}":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                goto post1;
                            }
                            else if (Declarations.huma20.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "(":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (Declarations.huma17.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case ")":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (Declarations.huma18.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        } 
                    case "[":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (Declarations.huma21.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "]":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (Declarations.huma22.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        } 
                    case ":":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("Error", "Invalid Input: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (Declarations.huma23.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }

                    case ";":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                goto post1;
                            }
                            else if (Declarations.huma25.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }

                    case "~":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "Invalid Input: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (Declarations.huma16.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                bool blFlag;
                                blFlag = ChkLiterals(cmp);
                                if (blFlag == true)
                                    return true;
                                blFlag = AnalyzeWholelit(cmp);
                                if (blFlag == true)
                                    return true;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        } break;
                    case "^":
                        {
                            if (txtCode1.ElementAt(intCtr).Equals('&'))
                            {
                                AnalyzeComment(cmp);
                                return true;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "&":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('&'))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma14.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (Declarations.huma24.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "=":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('='))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma13.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (Declarations.huma12.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "@":
                        {
                            cmp.AddtotblError("Error", "Invalid Input: " + val1, intLineNo.ToString());
                            goto del1;
                        }
                    case "+":
                        {
                            if(txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: "+val1, intLineNo.ToString());
                                goto del1;
                            }
                            if (txtCode1.ElementAt(intCtr).Equals('+'))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: "+val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma11.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: "+val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('='))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "-":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            if (txtCode1.ElementAt(intCtr).Equals('-'))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma11.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('='))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "*":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('='))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "/":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('='))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "%":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('='))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "<":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('='))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case ">":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('='))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "!":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("Error", "Invalid Input: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            if (txtCode1.ElementAt(intCtr).Equals('!'))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("Error", "Invalid Input: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma14.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('='))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma10.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            /*else if (Declarations.huma5.Contains(txtCode1.ElementAt(intCtr).ToString()))
                            {
                                goto post1;
                            }*/
                            else
                            {
                                cmp.AddtotblError("Error", "Invalid Input: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                    case "\\":
                        {
                            if (txtCode1.Length == intCtr)
                            {
                                cmp.AddtotblError("LEX-Error", "Invalid Input: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                            else if (txtCode1.ElementAt(intCtr).Equals('\\'))
                            {
                                intCtr++;
                                val1 = txtCode1.Substring(0, intCtr);
                                if (txtCode1.Length == intCtr)
                                {
                                    cmp.AddtotblError("LEX-Error", "No Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                                if (Declarations.huma14.Contains(txtCode1.ElementAt(intCtr).ToString()))
                                    goto post1;
                                else
                                {
                                    cmp.AddtotblError("LEX-Error", "Incorrect Delimiter: " + val1, intLineNo.ToString());
                                    goto del1;
                                }
                            }
                            else
                            {
                                cmp.AddtotblError("LEX-Error", "Invalid Input: " + val1, intLineNo.ToString());
                                goto del1;
                            }
                        }
                }
                post1:;
                cmp.AddtotblLexeme(val1, val1, intLineNo.ToString(), attribu);
                token.setTokens(val1);
                token.setLexemes(val1);
                token.setLines(intLineNo);
                tokens.Add(token);
            del1:;
                txtCode1 = txtCode1.Remove(0, intCtr);
                return true;
            }
            return false;
        }

        public bool AnalyzeComment(Compilourdes_GUI cmp)
        {
            Tokens token = new Tokens();
            int intCtr = 2;
            if (intCtr == txtCode1.Length)
                goto lbl1;
            for(intCtr = 2; intCtr <= txtCode1.Length; intCtr++)
            {
                if (txtCode1.ElementAt(intCtr).Equals('\n'))
                    intLineNo++;
                if ((intCtr == txtCode1.Length))
                    goto lbl1;
                if ((intCtr + 1 == txtCode1.Length))
                {
                    intCtr++;
                    goto lbl1;
                }
                if ((txtCode1.ElementAt(intCtr).Equals('&')) && (txtCode1.ElementAt(intCtr+1).Equals('^')))
                    break;
                else if ((txtCode1.ElementAt(intCtr).Equals('&')) && !(txtCode1.ElementAt(intCtr+1).Equals('^')))
                    continue;
                else
                    continue;
            }
            intCtr += 2;
            if(intCtr == txtCode1.Length - 1)
            {
                intCtr = intCtr + 1;
                goto lbl1;
            }
            lbl1:;
            string strComm = txtCode1.Substring(0, intCtr);
            //cmp.AddtotblLexeme(strComm, "comment");
            //token.setTokens("comment");
            //token.setLexemes(strComm);
            //token.setLines(intLineNo);
            //tokens.Add(token);
            txtCode1 = txtCode1.Remove(0, intCtr);
            return true;
        }
    }
}
