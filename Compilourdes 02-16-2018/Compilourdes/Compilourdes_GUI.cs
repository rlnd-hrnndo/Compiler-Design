using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ionic.WinForms;
using Syntax_Analyzer;
using System.Runtime.InteropServices;

namespace Compilourdes
{
    public partial class Compilourdes_GUI : Form 
    {
        public Compilourdes_GUI()
        {
            InitializeComponent();
        }

        private void Start()
        {
            tblLexeme.Rows.Clear();
            tblErrors.Rows.Clear();
            gvSyntax.Rows.Clear();
            gvSyntaxError.Rows.Clear();
            gvSemanticError.Rows.Clear();
            string txtCode1 = txtCode.Text;
            LexicalAnalyzer lex = new LexicalAnalyzer(txtCode1);
            lex.StartLex(this);
            if (CheckTable2() == 1 && CheckTable() == 1)
            {
                TableAttrib tab = new TableAttrib();
                tab.StartView(this, tblLexeme);
                //start ng semantics
                SemanticsAnalyzer seman = new SemanticsAnalyzer();
                seman.start(this, tblLexeme, txtCode1);
            }
            /*if (CheckTable2() == 1)
            {
                //start ng semantics
                SemanticsAnalyzer seman = new SemanticsAnalyzer();
                seman.start(this, tblLexeme, txtCode1);
            }*/
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string txtCode1 = txtCode.Text;
            Declarations.isrun = 1;
            Start();
        }

        public void AddtotblLexeme(string lexeme, string token, string lineno, string attrib)
        {
            tblLexeme.Rows.Add(lexeme, token, lineno, attrib); //populating table with lexeme and token
        }

        public void Syntax1(string aa,string ab, string ad, string ae)
        {
            gvSyntax.Rows.Add(aa, ab, ad, ae);
        }

        public void Syntax2(string aa, string b, string c)
        {
            
            gvSyntaxError.Rows.Add(aa, b, c);



        }

        public int CheckTable()
        {
            return tblErrors.RowCount;
        }

        public int CheckTable2()
        {
            return gvSyntaxError.RowCount;
        }

        public void AddtotblError(string code, string desc, string line)
        {
            tblErrors.Rows.Add(code, desc, line);
        }
        public void AddtoSemError(string code, string desc, string line)
        {
            gvSemanticError.Rows.Add(code, desc, line);
        }

        public List<TokenLibrary.TokenClass> tokenDump(List<Tokens> tokens)
        {
            List<TokenLibrary.TokenClass> token = new List<TokenLibrary.TokenClass>();
            Tokens t = new Tokens();
            foreach (var item in tokens)
            {
                t = new Tokens();
                t.setLexemes(item.getLexemes());
                t.setLines(item.getLines());
                t.setTokens(item.getTokens());
                token.Add(t);
            }
            return token;
        }

        private void tblErrors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvSyntaxError_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tblLexeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Compilourdes_GUI_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txtCode1 = txtCode.Text;
            Declarations.isrun = 0;
            Start();
        }

        //OPEN
        private void button3_Click(object sender, EventArgs e)
        {
            using (var openDialog = new System.Windows.Forms.OpenFileDialog())
            {
                openDialog.DefaultExt = "*.humac";
                openDialog.Filter = "Humac files (*.humac)|*.humac";
                DialogResult result = openDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filename = openDialog.FileName;

         //           newTabToolStrip_Click(sender, e);

                    txtCode.Text = System.IO.File.ReadAllText(filename);
                    //codeTabControl.SelectedTab.Text = openDialog.SafeFileName;
                    tblLexeme.DataSource = null;
                    tblLexeme.Rows.Clear();
                    gvSyntax.DataSource = null;
                    gvSyntax.Rows.Clear();
                    tblErrors.Rows.Clear();
                    gvSyntaxError.Rows.Clear();
                    gvSemanticError.Rows.Clear();
                    //currentCodeEditor.ProcessAllLines();
                }
            }
        }

        //SAVE
        private void button4_Click(object sender, EventArgs e)
        {
            using (var saveDialog = new System.Windows.Forms.SaveFileDialog())
            {
                saveDialog.DefaultExt = "*.humac";
                saveDialog.Filter = "Humac files (*.humac)|*.humac";
                DialogResult result = saveDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string filename = saveDialog.FileName;
                    System.IO.File.WriteAllText(filename, txtCode.Text);
                }
            }
        }

        //NEW
        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCode.Text.Length > 0)
            {
                DialogResult result;
                result = MessageBox.Show("Do you wish to save your project?", "Attention",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        button4_Click(sender, e);
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        txtCode.Text = "";
                        tblLexeme.DataSource = null;
                        tblLexeme.Rows.Clear();
                        gvSyntax.DataSource = null;
                        gvSyntax.Rows.Clear();
                        tblErrors.Rows.Clear();
                        gvSyntaxError.Rows.Clear();
                        gvSemanticError.Rows.Clear();
                        break;
                }
            }
        }
        

    }
}
