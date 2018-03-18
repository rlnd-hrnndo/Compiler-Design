using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compilourdes
{
    public class TableAttrib
    {
        public void StartView(Compilourdes_GUI cmp, DataGridView tblLexeme)
        {
            int intRowCount = tblLexeme.RowCount;
            bool inMain = false;
            for(int i = 0; i < intRowCount; i++)
            {
                //string abc = (string)tblLexeme.Rows[6].Cells[0].Value;
                if ((string)tblLexeme.Rows[i].Cells[0].Value == "WAKE")
                {
                    tblLexeme.Rows[i + 3].Cells[3].Value = "Begin Main";
                    inMain = true;
                }

                if ((string)tblLexeme.Rows[i].Cells[0].Value == "SLEEP")
                {
                    tblLexeme.Rows[i - 1].Cells[3].Value = "End Main";
                }

                if ((string)tblLexeme.Rows[i].Cells[0].Value == "GROUP")
                {
                    int temp1 = i + 2, temp2, temp3;
                    tblLexeme.Rows[i + 1].Cells[3].Value = "Struct Name";
                    tblLexeme.Rows[i + 2].Cells[3].Value = "Begin Struct";
                    while (!((string)tblLexeme.Rows[i].Cells[0].Value == "}"))
                        i++;
                    temp2 = i;
                    tblLexeme.Rows[i].Cells[3].Value = "End Struct";
                    temp3 = i;
                    while (!((string)tblLexeme.Rows[temp3].Cells[0].Value == ";"))
                        temp3++;
                    for (int ctr = temp2; ctr < temp3; ctr++)
                    {
                        if ((string)tblLexeme.Rows[ctr].Cells[1].Value == "id")
                            tblLexeme.Rows[ctr].Cells[3].Value = "Object Name";
                    }
                    continue;
                }

                if ((string)tblLexeme.Rows[i].Cells[0].Value == "EMPTY" && inMain == false)
                {
                    bool isFunc = false;
                    int temp1 = i, t1 = 0, t2 = 0;
                    tblLexeme.Rows[i + 1].Cells[3].Value = "Function Name";
                    while (!((string)tblLexeme.Rows[i].Cells[0].Value == "{"))
                        i++;
                    tblLexeme.Rows[i].Cells[3].Value = "Begin Function";
                    for (int ctr = temp1; ctr < i; ctr++)
                    {
                        if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "(")
                        {
                            t1 = ctr;
                            isFunc = true;
                            tblLexeme.Rows[ctr].Cells[3].Value = "Param Start";
                        }
                    }
                    if (isFunc == true)
                    {
                        for (int ctr = t1; ctr < i; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ")")
                            {
                                t2 = ctr;
                                break;
                            }
                        }
                        for (int ctr = t1; ctr < t2; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "[")
                            {
                                tblLexeme.Rows[ctr - 1].Cells[3].Value = "Param";
                            }
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ",")
                            {
                                tblLexeme.Rows[ctr].Cells[3].Value = ",";
                            }
                        }
                    }
                    while (!((string)tblLexeme.Rows[i].Cells[0].Value == "END"))
                        i++;
                    while (!((string)tblLexeme.Rows[i].Cells[0].Value == "}"))
                        i++;
                    tblLexeme.Rows[i].Cells[3].Value = "End Function";
                }

                if ((string)tblLexeme.Rows[i].Cells[0].Value == "WHOLE" && inMain == false)
                {
                    bool isFunc = false;
                    int temp1 = i, t1 = 0, t2 = 0, temp2 = i, temp3 = i;
                    while (!((string)tblLexeme.Rows[temp1].Cells[0].Value == ")" && (string)tblLexeme.Rows[temp1 + 1].Cells[0].Value == "{"))
                        temp1++;
                    temp1++;
                    while (!((string)tblLexeme.Rows[temp3].Cells[0].Value == ";"))
                        temp3++;
                    if (temp3 > temp1)
                    {
                        for (int ctr = i; ctr < temp1; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "(")
                            {
                                t1 = ctr;
                                isFunc = true;
                            }
                        }
                        if (isFunc == true)
                        {
                            for (int ctr = t1; ctr < temp1; ctr++)
                            {
                                if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ")")
                                {
                                    t2 = ctr;
                                    break;
                                }
                            }
                            for (int ctr = t1; ctr < t2; ctr++)
                            {
                                if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "[")
                                {
                                    tblLexeme.Rows[ctr - 1].Cells[3].Value = "Param";
                                }
                                if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ",")
                                {
                                    tblLexeme.Rows[ctr].Cells[3].Value = ",";
                                }
                            }
                            tblLexeme.Rows[i + 1].Cells[3].Value = "Function Name";
                            while (!((string)tblLexeme.Rows[i].Cells[0].Value == "{"))
                                i++;
                            tblLexeme.Rows[i].Cells[3].Value = "Begin Function";
                            while (!((string)tblLexeme.Rows[i].Cells[0].Value == "RETURN"))
                                i++;
                            while (!((string)tblLexeme.Rows[i].Cells[0].Value == "}"))
                                i++;
                            tblLexeme.Rows[i].Cells[3].Value = "End Function";
                            continue;
                        }
                    }
                }

                if ((string)tblLexeme.Rows[i].Cells[0].Value == "FRACTION" && inMain == false)
                {
                    bool isFunc = false;
                    int temp1 = i, t1 = 0, t2 = 0;
                    while (!((string)tblLexeme.Rows[temp1].Cells[0].Value == ")" && (string)tblLexeme.Rows[temp1 + 1].Cells[0].Value == "{"))
                        temp1++;
                    temp1++;
                    for (int ctr = i; ctr < temp1; ctr++)
                    {
                        if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "(")
                        {
                            t1 = ctr;
                            isFunc = true;
                        }
                    }
                    if (isFunc == true)
                    {
                        for (int ctr = t1; ctr < temp1; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ")")
                            {
                                t2 = ctr;
                                break;
                            }
                        }
                        for (int ctr = t1; ctr < t2; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "[")
                            {
                                tblLexeme.Rows[ctr - 1].Cells[3].Value = "Param";
                            }
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ",")
                            {
                                tblLexeme.Rows[ctr].Cells[3].Value = ",";
                            }
                        }
                        tblLexeme.Rows[i + 1].Cells[3].Value = "Function Name";
                        tblLexeme.Rows[temp1].Cells[3].Value = "Begin Function";
                        while (!((string)tblLexeme.Rows[i].Cells[0].Value == "RETURN"))
                            i++;
                        while (!((string)tblLexeme.Rows[i].Cells[0].Value == "}"))
                            i++;
                        tblLexeme.Rows[i].Cells[3].Value = "End Function";
                        continue;
                    }
                }

                if ((string)tblLexeme.Rows[i].Cells[0].Value == "PHRASE" && inMain == false)
                {
                    bool isFunc = false;
                    int temp1 = i, t1 = 0, t2 = 0;
                    while (!((string)tblLexeme.Rows[temp1].Cells[0].Value == ")" && (string)tblLexeme.Rows[temp1 + 1].Cells[0].Value == "{"))
                        temp1++;
                    temp1++;
                    for (int ctr = i; ctr < temp1; ctr++)
                    {
                        if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "(")
                        {
                            t1 = ctr;
                            isFunc = true;
                        }
                    }
                    if (isFunc == true)
                    {
                        for (int ctr = t1; ctr < temp1; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ")")
                            {
                                t2 = ctr;
                                break;
                            }
                        }
                        for (int ctr = t1; ctr < t2; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "[")
                            {
                                tblLexeme.Rows[ctr - 1].Cells[3].Value = "Param";
                            }
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ",")
                            {
                                tblLexeme.Rows[ctr].Cells[3].Value = ",";
                            }
                        }
                        tblLexeme.Rows[i + 1].Cells[3].Value = "Function Name";
                        tblLexeme.Rows[temp1].Cells[3].Value = "Begin Function";
                        while (!((string)tblLexeme.Rows[i].Cells[0].Value == "RETURN"))
                            i++;
                        while (!((string)tblLexeme.Rows[i].Cells[0].Value == "}"))
                            i++;
                        tblLexeme.Rows[i].Cells[3].Value = "End Function";
                        continue;
                    }
                }

                if ((string)tblLexeme.Rows[i].Cells[0].Value == "SYMBOL" && inMain == false)
                {
                    bool isFunc = false;
                    int temp1 = i, t1 = 0, t2 = 0;
                    while (!((string)tblLexeme.Rows[temp1].Cells[0].Value == ")" && (string)tblLexeme.Rows[temp1 + 1].Cells[0].Value == "{"))
                        temp1++;
                    temp1++;
                    for (int ctr = i; ctr < temp1; ctr++)
                    {
                        if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "(")
                        {
                            t1 = ctr;
                            isFunc = true;
                        }
                    }
                    if (isFunc == true)
                    {
                        for (int ctr = t1; ctr < temp1; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ")")
                            {
                                t2 = ctr;
                                break;
                            }
                        }
                        for (int ctr = t1; ctr < t2; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "[")
                            {
                                tblLexeme.Rows[ctr - 1].Cells[3].Value = "Param";
                            }
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ",")
                            {
                                tblLexeme.Rows[ctr].Cells[3].Value = ",";
                            }
                        }
                        tblLexeme.Rows[i + 1].Cells[3].Value = "Function Name";
                        tblLexeme.Rows[temp1].Cells[3].Value = "Begin Function";
                        while (!((string)tblLexeme.Rows[i].Cells[0].Value == "RETURN"))
                            i++;
                        while (!((string)tblLexeme.Rows[i].Cells[0].Value == "}"))
                            i++;
                        tblLexeme.Rows[i].Cells[3].Value = "End Function";
                        continue;
                    }
                }

                if ((string)tblLexeme.Rows[i].Cells[0].Value == "CHOICE" && inMain == false)
                {
                    bool isFunc = false;
                    int temp1 = i, t1 = 0, t2 = 0;
                    while (!((string)tblLexeme.Rows[temp1].Cells[0].Value == ")" && (string)tblLexeme.Rows[temp1 + 1].Cells[0].Value == "{"))
                        temp1++;
                    temp1++;
                    for (int ctr = i; ctr < temp1; ctr++)
                    {
                        if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "(")
                        {
                            t1 = ctr;
                            isFunc = true;
                        }
                    }
                    if (isFunc == true)
                    {
                        for (int ctr = t1; ctr < temp1; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ")")
                            {
                                t2 = ctr;
                                break;
                            }
                        }
                        for (int ctr = t1; ctr < t2; ctr++)
                        {
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == "[")
                            {
                                tblLexeme.Rows[ctr - 1].Cells[3].Value = "Param";
                            }
                            if ((string)tblLexeme.Rows[ctr].Cells[0].Value == ",")
                            {
                                tblLexeme.Rows[ctr].Cells[3].Value = ",";
                            }
                        }
                        tblLexeme.Rows[i + 1].Cells[3].Value = "Function Name";
                        tblLexeme.Rows[temp1].Cells[3].Value = "Begin Function";
                        while (!((string)tblLexeme.Rows[i].Cells[0].Value == "RETURN"))
                            i++;
                        while (!((string)tblLexeme.Rows[i].Cells[0].Value == "}"))
                            i++;
                        tblLexeme.Rows[i].Cells[3].Value = "End Function";
                        continue;
                    }
                }

                if (((string)tblLexeme.Rows[i].Cells[1].Value == "id" && (string)tblLexeme.Rows[i + 1].Cells[1].Value == "[") && i + 1 < tblLexeme.RowCount)
                {
                    bool init = false, init2 = false;
                    int temp1 = i;
                    while (!((string)tblLexeme.Rows[temp1].Cells[0].Value == "]"))
                        temp1++;
                    if((string)tblLexeme.Rows[temp1 + 1].Cells[1].Value == "=" && temp1 + 1 < tblLexeme.RowCount)
                    {
                        init = true;
                        if ((string)tblLexeme.Rows[temp1 + 2].Cells[1].Value != "{" && temp1 + 1 < tblLexeme.RowCount)
                            init = false;
                    }
                    if((string)tblLexeme.Rows[temp1 + 1].Cells[1].Value == "[" && temp1 + 1 < tblLexeme.RowCount)
                    {
                        temp1++;
                        while (!((string)tblLexeme.Rows[temp1].Cells[0].Value == "]"))
                            temp1++;
                        if ((string)tblLexeme.Rows[temp1 + 1].Cells[1].Value == "=" && temp1 + 1 < tblLexeme.RowCount)
                        {
                            init2 = true;
                        }
                    }
                    int temp2 = temp1, temp3 = temp1;
                    if (init == true)
                    {
                        while (!((string)tblLexeme.Rows[temp2].Cells[0].Value == "{") && temp2 < tblLexeme.RowCount)
                            temp2++;
                        while (!((string)tblLexeme.Rows[temp3].Cells[0].Value == "}") && temp3 < tblLexeme.RowCount)
                            temp3++;
                        tblLexeme.Rows[temp2].Cells[3].Value = "Begin Array";
                        tblLexeme.Rows[temp3].Cells[3].Value = "End Array";
                        i = temp3;
                    }
                    if (init2 == true)
                    {
                        temp2 += 2;
                        if((string)tblLexeme.Rows[temp2 + 1].Cells[0].Value == "{")
                        {
                            while (!((((string)tblLexeme.Rows[temp2].Cells[0].Value == "{") && temp2 < tblLexeme.RowCount) && (((string)tblLexeme.Rows[temp2 + 1].Cells[0].Value == "{") && temp2 + 1 < tblLexeme.RowCount)))
                                temp2++;
                            while (!((((string)tblLexeme.Rows[temp3].Cells[0].Value == "}") && temp3 < tblLexeme.RowCount) && (((string)tblLexeme.Rows[temp3 - 1].Cells[0].Value == "}") && temp3 - 1 < tblLexeme.RowCount)))
                                temp3++;
                            tblLexeme.Rows[temp2].Cells[3].Value = "Begin Array";
                            tblLexeme.Rows[temp3].Cells[3].Value = "End Array";
                            i = temp3;
                        }
                        else
                        {
                            cmp.Syntax2("SYN-Error", "Expected \"{\"", tblLexeme.Rows[temp2].Cells[2].Value.ToString());
                            goto end;
                        }
                    }
                    else
                        i = temp1;
                }
                if (((string)tblLexeme.Rows[i].Cells[1].Value == "id" && (string)tblLexeme.Rows[i + 1].Cells[1].Value == "(") && i + 1 < tblLexeme.RowCount)
                {
                    i++;
                    int temp1 = i;
                    while (!((string)tblLexeme.Rows[temp1].Cells[0].Value == ")"))
                        temp1++;
                    tblLexeme.Rows[i].Cells[3].Value = "Begin Param";
                    tblLexeme.Rows[temp1].Cells[3].Value = "End Param";
                }
            }
            end:;
        }
    }
}
