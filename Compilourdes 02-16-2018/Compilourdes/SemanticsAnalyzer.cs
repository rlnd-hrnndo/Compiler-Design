using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Windows.Forms;
using System.Diagnostics;

namespace Compilourdes
{
    public class SemanticsAnalyzer
    {
        public void start(Compilourdes_GUI cmp, DataGridView lexTable, string txtCode1)
        {
            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();

            string output = "HuMac-Output.exe";
            CompilerParameters parameters = new CompilerParameters();
            CompilerResults results;

            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = output;
            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Data.dll");
            parameters.ReferencedAssemblies.Add("System.Xml.dll");

            StringBuilder builder = new StringBuilder();
            builder.Append("using System.Data;using System;using System.Collections.Generic;using System.Text;using System.Threading.Tasks;namespace HumacNamespace{class Program{");
            //builder.Append("private static int convert_(string fetcher_,int x_){int result=0;while(!int.TryParse(fetcher_,out result)){Console.WriteLine(\"Invalid input. Try again\");fetcher_=Console.ReadLine();}return result;}private static float convert_(string fetcher_,float x_){float result=0f;while(!float.TryParse(fetcher_,out result)){Console.WriteLine(\"Invalid input. Try again\");fetcher_=Console.ReadLine();}return result;}private static char convert_(string fetcher_,char x_){char result=' ';while(!char.TryParse(fetcher_,out result)){Console.WriteLine(\"Invalid input. Try again\");fetcher_=Console.ReadLine();}return result;}private static bool convert_(string fetcher_,bool x_){bool result=true;while(!bool.TryParse(fetcher_,out result)){Console.WriteLine(\"Invalid input. Try again\");fetcher_=Console.ReadLine();}return result;}public static int getlen_(string str){return str.Length;}public static int getlen_(string[] str){return str.Length;} public static string tostring_(char ch){return ch.ToString();}public static int intpar_(string str){return int.Parse(str);}public static object eval_(string gen){return dt.Compute(gen, \"\"); }public static string trim_(string str){return str.Trim();}private static string replace_(string str, string p1, string p2){return str.Replace(p1, p2);}public static double pow_(double base1, double exp){return Math.Pow(base1, exp);} public static DataTable dt = new DataTable(); public static int rand_(int min, int max){Random rand = new Random();return rand.Next(min, max);}public static double sqrt_(double num){return Math.Sqrt(num);} public static double cos_(double rad){return Math.Cos(rad);}public static double sin_(double rad){return Math.Sin(rad);} public static double tan_(double rad){return Math.Tan(rad);}public static int convert_(int input, int cbase){string chars = \"0123456789ABCDEF\"; int results = 0; string inputstr = input.ToString(); foreach (char digit in inputstr) { results = (cbase * results) + chars.ToUpper().IndexOf(digit);}return results; }");

            builder.Append("private static int stringLength_(string strL_){ int strLen_ = strL_.Length; return strLen_; } ");

            builder.Append("private static string stringReversal_(string strR_){ char[] charArray = strR_.ToCharArray(); Array.Reverse( charArray ); return new string( charArray );} ");

            builder.Append("private static string binaryAdd_(string bin1_, string bin2_){ int number_one = Convert.ToInt32(bin1_, 2); int number_two = Convert.ToInt32(bin2_, 2); return Convert.ToString(number_one + number_two, 2).PadLeft(8, '0'); }");

            builder.Append("private static string binarySub_(string bin1_, string bin2_){ int number_one = Convert.ToInt32(bin1_, 2); int number_two = Convert.ToInt32(bin2_, 2); return Convert.ToString(number_one - number_two, 2).PadLeft(8, '0'); }");

            builder.Append("private static int countSec_(int count){ System.Threading.Thread.Sleep(count); return 1; }");

            builder.Append("public static float sqrt_(float num){ double b1 = System.Convert.ToDouble(num); double ans = Math.Sqrt(num); float ans1 = Convert.ToSingle(ans); return ans1; }");

            builder.Append("public static float raise_(float base1, float exp){ double b1 = System.Convert.ToDouble(base1); double ep = System.Convert.ToDouble(exp); double ans = Math.Pow(b1, ep); float ans1 = Convert.ToSingle(ans); return ans1; }");

            builder.Append("private static string stringConcat_(string basestring, string let){ string ans = basestring + let; return ans; }");

            builder.Append("private static string stringcharConcat_(string basestring, char let){ string ans = basestring + let; return ans; }");

            builder.Append("private static void clrscr_(){ Console.Clear(); }");

            bool inputFound = false;
            bool twoDArrayFound = false;
            bool declarationFound = false;
            bool arrayFound = false;
            bool functionFound = false;
            bool structDeclarationFound = false;
            bool mainFunctionFound = false;
            bool disregardEqual = false;
            bool arrfound = false;
            bool endfound = false;
            bool paramfound = false;



            List<string> intList = new List<string>();
            List<string> floatList = new List<string>();
            List<string> charList = new List<string>();
            List<string> stringList = new List<string>();
            List<string> boolList = new List<string>();
            List<string> doubleList = new List<string>();

            string currentDatatype = "";
            string comment = "";
            string structName = "";
            string constant = "";
            string inputBody = "";

            for (int i = 0; i < lexTable.Rows.Count; i++)
            {
                if ((string)lexTable.Rows[i].Cells[1].Value == "WAKE")
                {
                    builder.Append(" static void Main ");
                    functionFound = true;
                    mainFunctionFound = true;
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "WHOLE")
                {
                    currentDatatype = "int";
                    declarationFound = true;
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "FRACTION")
                {
                    currentDatatype = "float";
                    declarationFound = true;
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "SYMBOL")
                {
                    currentDatatype = "char";
                    declarationFound = true;
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "PHRASE")
                {
                    currentDatatype = "string";
                    declarationFound = true;
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "CHOICE")
                {
                    currentDatatype = "bool";
                    declarationFound = true;
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "EMPTY")
                {
                    currentDatatype = "void";
                    declarationFound = true;
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "CONSTRUCT")
                {
                    constant = " readonly ";
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "GROUP")
                {
                    builder.Append(" public struct ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "SPEAK")
                {
                    builder.Append(" Console.Write ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "LOOK")
                {
                    inputFound = true;
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "TEST")
                {
                    builder.Append(" if ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "THEN")
                {
                    builder.Append(" else ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "TESTIF")
                {
                    builder.Append(" else if ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "EXAMINE")
                {
                    builder.Append(" switch ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "PICK")
                {
                    builder.Append(" case ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "BREAK")
                {
                    builder.Append(" break ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "DECIDE")
                {
                    builder.Append(" default ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "EXECUTE")
                {
                    builder.Append(" for ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "UNTIL")
                {
                    builder.Append(" while ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "WORK")
                {
                    builder.Append(" do ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "WIPE")
                {
                    builder.Append(" Console.Clear() ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "SLEEP")
                {
                    builder.Append(" } ");
                }
                else if ((string)lexTable.Rows[i].Cells[0].Value == "YES")
                {
                    builder.Append(" true ");
                }
                else if ((string)lexTable.Rows[i].Cells[0].Value == "NO")
                {
                    builder.Append(" false ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "RETURN")
                {
                    builder.Append(" return ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "END")
                {
                    endfound = true;
                }




                else if ((string)lexTable.Rows[i].Cells[1].Value == "=")
                {
                    //MessageBox.Show("Line: " + lexTable.Rows[i].Cells[2].Value + "\ndisregardEqual: " + disregardEqual + "\ndeclarationFound:" + declarationFound);
                    if (disregardEqual && declarationFound)
                    {
                        disregardEqual = false;
                    }
                    else
                    {
                        builder.Append(" = ");
                    }
                    //declarationFound = false;
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "&")
                {
                    builder.Append(" + ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == ";")
                {
                    if (endfound == false)
                    {
                        builder.Append(" ; ");
                        if (declarationFound)
                        {
                            declarationFound = false;
                        }

                        if (disregardEqual)
                        {
                            disregardEqual = false;
                        }

                        if (arrayFound)
                        {
                            arrayFound = false;
                        }

                        if (constant.Length > 0)
                        {
                            constant = "";
                        }
                    }
                    else
                    {
                        endfound = false;
                    }
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == ",")
                {
                    /*if ((declarationFound == true)&&(arrayFound == false)/*(string)lexTable.Rows[i].Cells[3].Value == ",")
                    {
                        builder.Append(" ; ");
                    }
                    else if (arrayFound == true/*(string)lexTable.Rows[i].Cells[3].Value == ",")
                    {
                        builder.Append(" , ");
                    }
                    else
                    {
                        builder.Append(" , ");
                    }*/
                    if ((string)lexTable.Rows[i].Cells[3].Value != "," && arrfound == false && paramfound == false)
                    {
                        builder.Append(" ; ");
                    }
                    else if (arrfound == true || paramfound == true)
                    {
                        builder.Append(" , ");
                    }
                    else
                    {
                        builder.Append(" , ");
                    }
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "~")
                {
                    builder.Append(" - ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "!=")
                {
                    builder.Append(" != ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "@")
                {
                    builder.Append(" . ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "!!")
                {
                    builder.Append(" ! ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "&&")
                {
                    builder.Append(" && ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "\\\\")
                {
                    builder.Append(" || ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "(")
                {
                    if (inputFound)
                    {
                        //do nothing
                    }
                    else
                    {
                        builder.Append(" ( ");
                    }
                    if ((string)lexTable.Rows[i].Cells[3].Value == "Begin Param")
                    {
                        paramfound = true;
                    }
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == ")")
                {
                    if (inputFound)
                    {
                        //if (intList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                        //{
                        //    builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "_ = Convert.ToInt32(Console.ReadLine() ");
                        //}
                        //else if (floatList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                        //{
                        //    builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "_ = Convert.ToInt32(Console.ReadLine() ");
                        //}
                        //else if (charList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                        //{
                        //    builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "_ = Convert.ToChar(Console.ReadLine() ");
                        //}
                        //else if (stringList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                        //{
                        //    builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "_ = Console.ReadLine( ");
                        //}
                        //else if (boolList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                        //{
                        //    builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "_ = Convert.ToBoolean(Console.ReadLine() ");
                        //}
                        //else if (doubleList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                        //{
                        //    builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "_ = Convert.ToDouble(Console.ReadLine() ");
                        //}
                        //else
                        //{
                        //    builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "_ = Console.ReadLine( ");
                        //}
                        builder.Append(" " + inputBody + " ) ");
                        inputFound = false;
                    }
                    else
                    {
                        builder.Append(" ) ");
                    }
                    if (functionFound)
                    {
                        declarationFound = false;
                    }
                    if ((string)lexTable.Rows[i].Cells[3].Value == "End Param")
                    {
                        paramfound = false;
                    }
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "]")
                {
                    if ((string)lexTable.Rows[i + 1].Cells[1].Value == "[")
                    {
                        twoDArrayFound = true;
                        builder.Append(" , ");
                    }
                    else
                    {
                        builder.Append(" ] ");
                        arrayFound = true;
                    }

                    if ((string)lexTable.Rows[i + 1].Cells[1].Value == "=")
                    {
                        disregardEqual = true;
                    }
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "[")
                {
                    if (twoDArrayFound)
                    {
                        twoDArrayFound = false;
                    }
                    else
                    {
                        builder.Append(" [ ");
                    }
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "{")
                {
                    if ((string)lexTable.Rows[i].Cells[3].Value == "Begin Main")
                    {
                        builder.Append(" {try{ Console.Title = \"HuMac Output Window\";Console.BackgroundColor = ConsoleColor.White;Console.ForegroundColor = ConsoleColor.Blue;Console.Clear(); ");
                    }
                    else if ((string)lexTable.Rows[i].Cells[3].Value == "Begin Struct")
                    {
                        structDeclarationFound = true;
                        builder.Append(" { ");
                    }
                    else if ((string)lexTable.Rows[i].Cells[3].Value == "Begin Array")
                    {
                        arrfound = true;
                        builder.Append(" { ");
                    }
                    else
                    {
                        builder.Append(" { ");
                    }
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "}")
                {
                    if ((string)lexTable.Rows[i].Cells[3].Value == "End Main")
                    {
                        functionFound = false;
                        //builder.Append(" Console.ReadLine(); }catch(Exception e){Console.WriteLine(\"Error 404: \" + e.ToString()); Console.ReadLine();}} ");
                        builder.Append(" Console.ReadLine(); }catch(Exception e){Console.WriteLine(\"Error \"); Console.ReadLine();}} ");
                    }
                    else if ((string)lexTable.Rows[i].Cells[3].Value == "End Function")
                    {
                        functionFound = false;
                        builder.Append(" } ");
                    }
                    else if ((string)lexTable.Rows[i].Cells[3].Value == "End Struct")
                    {
                        structDeclarationFound = false;
                        builder.Append(" } ");
                    }
                    else if ((string)lexTable.Rows[i].Cells[3].Value == "End Array")
                    {
                        arrfound = false;
                        builder.Append(" } ");
                    }
                    else
                    {
                        builder.Append(" } ");
                    }
                }





                else if ((string)lexTable.Rows[i].Cells[1].Value == "comment")
                {
                    comment = (string)lexTable.Rows[i].Cells[0].Value;
                    comment = comment.Substring(1, comment.Length - 2);
                    builder.Append(" /" + comment + "/ ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "WHOLElit" ||
                    (string)lexTable.Rows[i].Cells[1].Value == "SYMBOLlit" ||
                    (string)lexTable.Rows[i].Cells[1].Value == "PHRASElit")
                {
                    builder.Append(" " + lexTable.Rows[i].Cells[0].Value + " ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "FRACTIONlit")
                {
                    //builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "F ");
                    builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "f ");
                }
                else if ((string)lexTable.Rows[i].Cells[1].Value == "id")
                {
                    if (declarationFound)
                    {
                        switch (currentDatatype)
                        {
                            case "int": intList.Add((string)lexTable.Rows[i].Cells[0].Value); break;
                            case "float": floatList.Add((string)lexTable.Rows[i].Cells[0].Value); break;
                            case "char": charList.Add((string)lexTable.Rows[i].Cells[0].Value); break;
                            case "string": stringList.Add((string)lexTable.Rows[i].Cells[0].Value); break;
                            case "bool": boolList.Add((string)lexTable.Rows[i].Cells[0].Value); break;
                            case "double": doubleList.Add((string)lexTable.Rows[i].Cells[0].Value); break;
                        }
                    }

                    if ((string)lexTable.Rows[i].Cells[3].Value == "Function Name")
                    {
                        builder.Append(" public static ");
                        functionFound = true;
                    }

                    if ((string)lexTable.Rows[i].Cells[3].Value == "Struct Name")
                    {
                        structName = (string)lexTable.Rows[i].Cells[0].Value;
                    }

                    if (inputFound)
                    {
                        if (arrayFound || twoDArrayFound)
                        {
                            //do nothing
                        }
                        else
                        {
                            if (intList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                            {
                                inputBody = " = Convert.ToInt32(Console.ReadLine() ";
                            }
                            else if (floatList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                            {
                                inputBody = " = Convert.ToInt32(Console.ReadLine() ";
                            }
                            else if (charList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                            {
                                inputBody = " = Convert.ToChar(Console.ReadLine() ";
                            }
                            else if (stringList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                            {
                                inputBody = "  = Console.ReadLine( ";
                            }
                            else if (boolList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                            {
                                inputBody = "  = Convert.ToBoolean(Console.ReadLine() ";
                            }
                            else if (doubleList.Contains((string)lexTable.Rows[i].Cells[0].Value))
                            {
                                inputBody = " = Convert.ToDouble(Console.ReadLine() ";
                            }
                            else
                            {
                                inputBody = "  = Console.ReadLine( ";
                            }
                        }


                        //if ((string)lexTable.Rows[i + 1].Cells[1].Value == ")")
                        //{

                        //}
                        //else
                        //{
                        builder.Append(lexTable.Rows[i].Cells[0].Value + "_");
                        //}

                        if ((string)lexTable.Rows[i + 1].Cells[1].Value == "[")
                        {
                            arrayFound = true;
                        }


                    }
                    else if ((string)lexTable.Rows[i].Cells[3].Value == "Object Name")
                    {
                        declarationFound = true;
                        if ((string)lexTable.Rows[i + 1].Cells[1].Value == "[")
                        {
                            arrayFound = true;
                            if (declarationFound)
                            {
                                if ((string)lexTable.Rows[i + 4].Cells[1].Value == "[")
                                {
                                    builder.Append(" public static " + structName + "_ [,]" + lexTable.Rows[i].Cells[0].Value + "_ = new " + structName + "_ ");
                                }
                                else
                                {
                                    builder.Append(" public static " + structName + "_ []" + lexTable.Rows[i].Cells[0].Value + "_ = new " + structName + "_ ");

                                }
                            }
                        }
                        else
                        {
                            builder.Append(" public static " + structName + "_ " + lexTable.Rows[i].Cells[0].Value + "_");
                        }
                    }
                    else if ((string)lexTable.Rows[i + 1].Cells[1].Value == "[")
                    {
                        arrayFound = true;
                        if (declarationFound)
                        {
                            if ((string)lexTable.Rows[i + 4].Cells[1].Value == "[")
                            {
                                if (functionFound)
                                {
                                    builder.Append(" " + currentDatatype + " [,]" + lexTable.Rows[i].Cells[0].Value + "_ = new " + currentDatatype);
                                }
                                else
                                {
                                    builder.Append(" public static " + constant + currentDatatype + " [,]" + lexTable.Rows[i].Cells[0].Value + "_ = new " + currentDatatype);
                                }


                            }
                            else
                            {
                                if (functionFound)
                                {
                                    builder.Append(" " + currentDatatype + " []" + lexTable.Rows[i].Cells[0].Value + "_ = new " + currentDatatype);
                                    if((string)lexTable.Rows[i+2].Cells[1].Value == "id")
                                    {
                                        //string x = "";
                                        //x = (string)lexTable.Rows[i+2].Cells[0].Value;
                                        builder.Append(" [ " + lexTable.Rows[i+2].Cells[0].Value + "_ ");
                                        //MessageBox.Show(x);
                                        i += 2;
                                    }
                                }
                                else
                                {
                                    builder.Append(" public static " + constant + currentDatatype + " []" + lexTable.Rows[i].Cells[0].Value + "_ = new " + currentDatatype);
                                }
                            }

                        }
                        else
                        {
                            builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "_ ");
                        }
                    }
                    else
                    {
                        if (declarationFound && !functionFound)
                        {
                            if (structDeclarationFound)
                            {
                                builder.Append(" public " + currentDatatype + " " + lexTable.Rows[i].Cells[0].Value + "_ ");
                            }
                            else
                            {
                                builder.Append(" public static " + constant + currentDatatype + " " + lexTable.Rows[i].Cells[0].Value + "_ ");
                            }

                        }
                        else
                        {
                            if (declarationFound && (string)lexTable.Rows[i - 1].Cells[1].Value != "=")
                            {
                                builder.Append(constant + currentDatatype + " " + lexTable.Rows[i].Cells[0].Value + "_ ");
                            }
                            else
                            {
                                builder.Append(" " + lexTable.Rows[i].Cells[0].Value + "_ ");
                            }
                        }
                    }
                }





                else if ((string)lexTable.Rows[i].Cells[1].Value == "__")
                {
                }
                else
                {
                    builder.Append(" " + lexTable.Rows[i].Cells[1].Value + " ");
                }
                if ((i < lexTable.RowCount && i + 1 < lexTable.RowCount))
                {
                    if (((string)lexTable.Rows[i].Cells[2].Value != (string)lexTable.Rows[i + 1].Cells[2].Value))
                    {
                        string x = (string)lexTable.Rows[i].Cells[2].Value;
                        string y = (string)lexTable.Rows[i + 1].Cells[2].Value;
                        int currLine = Convert.ToInt32(x);
                        int nextLine = Convert.ToInt32(y);

                        while (currLine != nextLine)
                        {
                            builder.Append(Environment.NewLine);
                            currLine++;
                        }


                    }
                }
            }



            builder.Append("     }");
            string stringCode = builder.ToString();
            MessageBox.Show(stringCode);
            txtCode1 = stringCode;
            results = icc.CompileAssemblyFromSource(parameters, stringCode);
            string synErrorCode = "";
            string semErrorCode = "";
            string errorMessage;
            string errorMessage2;
            int errorLine;
            bool syntaxErrorFound = false;
            MessageBox.Show("Semantic Analysis Finished");

            for (int errNum = 0; errNum < results.Errors.Count; errNum++)
            {
                string t = results.Errors[errNum].ErrorNumber;
                //MessageBox.Show(t);
            }

            if (results.Errors.Count > 0)
            {
                for (int errNum = 0; errNum < results.Errors.Count; errNum++)
                {
                    string en = results.Errors[errNum].ErrorNumber;
                    errorMessage = results.Errors[errNum].ErrorText;
                    errorMessage2 = "";
                    if (en.Equals("CS0128"))
                    {
                        errorMessage2 = "Variable is already initialized";
                    }
                    else if (en.Equals("CS0165"))
                    {
                        errorMessage2 = "Variable was not initialized";
                    }
                    else if (en.Equals("CS1501"))
                    {
                        errorMessage2 = "The number of arguments does not match the parameters";
                    }
                    else if (en.Equals("CS0103"))
                    {
                        errorMessage2 = "Variable was not declared";
                    }
                    else if (en.Equals("CS0847"))
                    {
                        errorMessage2 = "Array length does not match with the values initialized";
                    }
                    else if (en.Equals("CS1502"))
                    {
                        errorMessage2 = "Invalid argument";
                    }
                    else if (en.Equals("CS1503"))
                    {
                        errorMessage2 = "Invalid data type passed";
                    }
                    else if (en.Equals("CS1525"))
                    {
                        errorMessage2 = "Invalid expression";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'int' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'int' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'int' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'int' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'float' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'float' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'float' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'float' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'char' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'char' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'char' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'char' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'string' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'string' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'string' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'string' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'bool' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'bool' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'bool' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'bool' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '+' cannot be applied to operands of type 'string' and 'method group'"))
                    {
                        errorMessage2 = "Operator '+' cannot be applied to types: 'PHRASE' and function";
                    }
                    else if (errorMessage.Equals("Operator '==' cannot be applied to operands of type 'int' and 'string'"))
                    {
                        errorMessage2 = "Operator '==' cannot be applied to data types: 'WHOLE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '==' cannot be applied to operands of type 'string' and 'int'"))
                    {
                        errorMessage2 = "Operator '==' cannot be applied to data types: 'PHRASE' and 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Operator '==' cannot be applied to operands of type 'float' and 'string'"))
                    {
                        errorMessage2 = "Operator '==' cannot be applied to data types: 'FRACTION' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '==' cannot be applied to operands of type 'string' and 'float'"))
                    {
                        errorMessage2 = "Operator '==' cannot be applied to data types: 'PHRASE' and 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Operator '==' cannot be applied to operands of type 'char' and 'string'"))
                    {
                        errorMessage2 = "Operator '==' cannot be applied to data types: 'SYMBOL' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '==' cannot be applied to operands of type 'string' and 'char'"))
                    {
                        errorMessage2 = "Operator '==' cannot be applied to data types: 'PHRASE' and 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Operator '==' cannot be applied to operands of type 'bool' and 'string'"))
                    {
                        errorMessage2 = "Operator '==' cannot be applied to data types: 'CHOICE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '==' cannot be applied to operands of type 'string' and 'bool'"))
                    {
                        errorMessage2 = "Operator '==' cannot be applied to data types: 'PHRASE' and 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Operator '<=' cannot be applied to operands of type 'int' and 'string'"))
                    {
                        errorMessage2 = "Operator '<=' cannot be applied to data types: 'WHOLE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '<=' cannot be applied to operands of type 'string' and 'int'"))
                    {
                        errorMessage2 = "Operator '<=' cannot be applied to data types: 'PHRASE' and 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Operator '<=' cannot be applied to operands of type 'float' and 'string'"))
                    {
                        errorMessage2 = "Operator '<=' cannot be applied to data types: 'FRACTION' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '<=' cannot be applied to operands of type 'string' and 'float'"))
                    {
                        errorMessage2 = "Operator '<=' cannot be applied to data types: 'PHRASE' and 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Operator '<=' cannot be applied to operands of type 'char' and 'string'"))
                    {
                        errorMessage2 = "Operator '<=' cannot be applied to data types: 'SYMBOL' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '<=' cannot be applied to operands of type 'string' and 'char'"))
                    {
                        errorMessage2 = "Operator '<=' cannot be applied to data types: 'PHRASE' and 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Operator '<=' cannot be applied to operands of type 'bool' and 'string'"))
                    {
                        errorMessage2 = "Operator '<=' cannot be applied to data types: 'CHOICE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '<=' cannot be applied to operands of type 'string' and 'bool'"))
                    {
                        errorMessage2 = "Operator '<=' cannot be applied to data types: 'PHRASE' and 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Operator '>=' cannot be applied to operands of type 'int' and 'string'"))
                    {
                        errorMessage2 = "Operator '>=' cannot be applied to data types: 'WHOLE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '>=' cannot be applied to operands of type 'string' and 'int'"))
                    {
                        errorMessage2 = "Operator '>=' cannot be applied to data types: 'PHRASE' and 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Operator '>=' cannot be applied to operands of type 'float' and 'string'"))
                    {
                        errorMessage2 = "Operator '>=' cannot be applied to data types: 'FRACTION' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '>=' cannot be applied to operands of type 'string' and 'float'"))
                    {
                        errorMessage2 = "Operator '>=' cannot be applied to data types: 'PHRASE' and 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Operator '>=' cannot be applied to operands of type 'char' and 'string'"))
                    {
                        errorMessage2 = "Operator '>=' cannot be applied to data types: 'SYMBOL' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '>=' cannot be applied to operands of type 'string' and 'char'"))
                    {
                        errorMessage2 = "Operator '>=' cannot be applied to data types: 'PHRASE' and 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Operator '>=' cannot be applied to operands of type 'bool' and 'string'"))
                    {
                        errorMessage2 = "Operator '>=' cannot be applied to data types: 'CHOICE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '>=' cannot be applied to operands of type 'string' and 'bool'"))
                    {
                        errorMessage2 = "Operator '>=' cannot be applied to data types: 'PHRASE' and 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Operator '<' cannot be applied to operands of type 'int' and 'string'"))
                    {
                        errorMessage2 = "Operator '<' cannot be applied to data types: 'WHOLE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '<' cannot be applied to operands of type 'string' and 'int'"))
                    {
                        errorMessage2 = "Operator '<' cannot be applied to data types: 'PHRASE' and 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Operator '<' cannot be applied to operands of type 'float' and 'string'"))
                    {
                        errorMessage2 = "Operator '<' cannot be applied to data types: 'FRACTION' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '<' cannot be applied to operands of type 'string' and 'float'"))
                    {
                        errorMessage2 = "Operator '<' cannot be applied to data types: 'PHRASE' and 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Operator '<' cannot be applied to operands of type 'char' and 'string'"))
                    {
                        errorMessage2 = "Operator '<' cannot be applied to data types: 'SYMBOL' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '<' cannot be applied to operands of type 'string' and 'char'"))
                    {
                        errorMessage2 = "Operator '<' cannot be applied to data types: 'PHRASE' and 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Operator '<' cannot be applied to operands of type 'bool' and 'string'"))
                    {
                        errorMessage2 = "Operator '<' cannot be applied to data types: 'CHOICE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '<' cannot be applied to operands of type 'string' and 'bool'"))
                    {
                        errorMessage2 = "Operator '<' cannot be applied to data types: 'PHRASE' and 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Operator '>' cannot be applied to operands of type 'int' and 'string'"))
                    {
                        errorMessage2 = "Operator '>' cannot be applied to data types: 'WHOLE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '>' cannot be applied to operands of type 'string' and 'int'"))
                    {
                        errorMessage2 = "Operator '>' cannot be applied to data types: 'PHRASE' and 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Operator '>' cannot be applied to operands of type 'float' and 'string'"))
                    {
                        errorMessage2 = "Operator '>' cannot be applied to data types: 'FRACTION' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '>' cannot be applied to operands of type 'string' and 'float'"))
                    {
                        errorMessage2 = "Operator '>' cannot be applied to data types: 'PHRASE' and 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Operator '>' cannot be applied to operands of type 'char' and 'string'"))
                    {
                        errorMessage2 = "Operator '>' cannot be applied to data types: 'SYMBOL' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '>' cannot be applied to operands of type 'string' and 'char'"))
                    {
                        errorMessage2 = "Operator '>' cannot be applied to data types: 'PHRASE' and 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Operator '>' cannot be applied to operands of type 'bool' and 'string'"))
                    {
                        errorMessage2 = "Operator '>' cannot be applied to data types: 'CHOICE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '>' cannot be applied to operands of type 'string' and 'bool'"))
                    {
                        errorMessage2 = "Operator '>' cannot be applied to data types: 'PHRASE' and 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Operator '!=' cannot be applied to operands of type 'int' and 'string'"))
                    {
                        errorMessage2 = "Operator '!=' cannot be applied to data types: 'WHOLE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '!=' cannot be applied to operands of type 'string' and 'int'"))
                    {
                        errorMessage2 = "Operator '!=' cannot be applied to data types: 'PHRASE' and 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Operator '!=' cannot be applied to operands of type 'float' and 'string'"))
                    {
                        errorMessage2 = "Operator '!=' cannot be applied to data types: 'FRACTION' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '!=' cannot be applied to operands of type 'string' and 'float'"))
                    {
                        errorMessage2 = "Operator '!=' cannot be applied to data types: 'PHRASE' and 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Operator '!=' cannot be applied to operands of type 'char' and 'string'"))
                    {
                        errorMessage2 = "Operator '!=' cannot be applied to data types: 'SYMBOL' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '!=' cannot be applied to operands of type 'string' and 'char'"))
                    {
                        errorMessage2 = "Operator '!=' cannot be applied to data types: 'PHRASE' and 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Operator '!=' cannot be applied to operands of type 'bool' and 'string'"))
                    {
                        errorMessage2 = "Operator '!=' cannot be applied to data types: 'CHOICE' and 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Operator '!=' cannot be applied to operands of type 'string' and 'bool'"))
                    {
                        errorMessage2 = "Operator '!=' cannot be applied to data types: 'PHRASE' and 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'int' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'int' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'int' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'int' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'float' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'float' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'float' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'float' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'char' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'char' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'char' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'char' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'string' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'string' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'string' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'string' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'bool' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'bool' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'bool' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot implicitly convert type 'bool' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'int' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'int' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'int' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'int' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'WHOLE' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'float' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'float' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'float' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'float' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'FRACTION' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'char' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'char' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'char' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'PHRASE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'char' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'SYMBOL' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'string' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'string' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'string' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'string' to 'bool'"))
                    {
                        errorMessage2 = "Cannot convert type 'PHRASE' to 'CHOICE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'bool' to 'int'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'WHOLE'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'bool' to 'float'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'FRACTION'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'bool' to 'char'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'SYMBOL'";
                    }
                    else if (errorMessage.Equals("Cannot convert type 'bool' to 'string'"))
                    {
                        errorMessage2 = "Cannot convert type 'CHOICE' to 'PHRASE'";
                    }
                    if (errorMessage2.Length == 0)
                        errorMessage2 = errorMessage;
                    /*errorMessage = errorMessage.Replace("if ", " TEST ");
                    errorMessage = errorMessage.Replace(" bool ", " CHOICE ");
                    errorMessage = errorMessage.Replace(" break ", " BREAK ");
                    //errorMessage = errorMessage.Replace(" double ", " FRACTION ");
                    errorMessage = errorMessage.Replace(" int ", " WHOLE ");
                    errorMessage = errorMessage.Replace(" float ", " FRACTION ");
                    errorMessage = errorMessage.Replace(" char ", " SYMBOL ");
                    errorMessage = errorMessage.Replace(" string ", " PHRASE ");
                    errorMessage = errorMessage.Replace(" void ", " EMPTY ");
                    errorMessage = errorMessage.Replace(" const ", " CONSTRUCT ");
                    errorMessage = errorMessage.Replace(" struct ", " GROUP ");
                    //errorMessage = errorMessage.Replace(" double ", " MIRROR ");
                    errorMessage = errorMessage.Replace(" else ", " THEN ");
                    errorMessage = errorMessage.Replace(" switch ", " EXAMINE ");
                    errorMessage = errorMessage.Replace(" case ", " PICK ");
                    errorMessage = errorMessage.Replace(" break ", " BREAK ");
                    errorMessage = errorMessage.Replace(" default ", " DECIDE ");
                    errorMessage = errorMessage.Replace(" for ", " EXECUTE ");
                    errorMessage = errorMessage.Replace(" while ", " UNTIL ");
                    errorMessage = errorMessage.Replace(" do ", " WORK ");
                    errorMessage = errorMessage.Replace(" true ", " YES ");
                    errorMessage = errorMessage.Replace(" false ", " NO ");
                    errorMessage = errorMessage.Replace(" return ", " RETURN ");
                    errorMessage = errorMessage.Replace("An explicit conversion exists (are you missing a cast?)", "");
                    errorMessage = errorMessage.Replace("implicitly ", "");
                    errorMessage = errorMessage.Replace(";", ".");*/
                    if (errorMessage.Contains("expected"))
                    {
                        semErrorCode = "SEM-Error"; //+ results.Errors[errNum].ErrorNumber.Substring(3);
                        syntaxErrorFound = true;
                    }
                    else
                    {
                        if (!syntaxErrorFound)
                        {
                            semErrorCode = "SEM-Error"; //+ results.Errors[errNum].ErrorNumber.Substring(3);
                        }

                    }
                    errorLine = results.Errors[errNum].Line;

                    if (syntaxErrorFound)
                    {
                        cmp.AddtoSemError("SEM-Error", errorMessage2, errorLine.ToString());
                    }
                    else
                    {
                        cmp.AddtoSemError("SEM-Error", errorMessage2, errorLine.ToString());
                    }

                }
            }
            else
            {
                if (Declarations.isrun == 1)
                {
                    Process.Start(output);
                }

            }

        }

    }
}