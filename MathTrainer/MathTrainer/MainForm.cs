using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MathTrainer
{
    public partial class MainForm : Form
    {
        private enum FunctionType
        {
            Addition = 1,
            Subtraction = 2,
            Multiplication = 3,
            Division = 4
        }
        
        private Func<int,int,int> _currentFunction;
        private Func<int,int,int> addition = (a,b) => a + b;
        private Func<int, int, int> subtraction = (a, b) => a - b;
        private Func<int,int,int> multiplication = (a,b) => a* b;
        private Func<int, int, int> division = (a, b) => a/b;
        List<char> _validKeys = new List<char>();
        List<char> _currentAnswer = new List<char>();

        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupDefaultProblem();
            
            // In the future we'll come up with a mechanism to determine what the current function is
            _currentFunction = addition;
        
            _validKeys.Add("0".ToCharArray()[0]);
            _validKeys.Add("1".ToCharArray()[0]);
            _validKeys.Add("2".ToCharArray()[0]);
            _validKeys.Add("3".ToCharArray()[0]);
            _validKeys.Add("4".ToCharArray()[0]);
            _validKeys.Add("5".ToCharArray()[0]);
            _validKeys.Add("6".ToCharArray()[0]);
            _validKeys.Add("7".ToCharArray()[0]);
            _validKeys.Add("8".ToCharArray()[0]);
            _validKeys.Add("9".ToCharArray()[0]);

            this.lblCorrectIncorrect.Visible = false;

            cboLevel.SelectedIndex = 0;

            cboFunction.DataSource = Enum.GetValues(typeof(FunctionType));
            cboFunction.SelectedIndex = 0;

            this.KeyDown += new KeyEventHandler(MainForm_KeyDown);
        }

        void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            cboCrap.Focus();
            cboCrap.Select();
        }

        //Sets up a problem on the screen when the app launches
        private void SetupDefaultProblem()
        {
            lblTopNumber.Text = random.Next(1,10).ToString();
            lblBottomNumber.Text = random.Next(1,10).ToString();
            lblOperand.Text = "+";

        }

        private void HandleFormKeyPress(object sender, KeyPressEventArgs e)
        {
            // Enter is (char)13
            // Delete is (char)8
            cboCrap.Focus();
            cboCrap.Select();
            char theChar = e.KeyChar;

            if (e.KeyChar == (char)13)
            {
                CheckSolution();
            }

            if (e.KeyChar == (char)8)
            {
                if (_currentAnswer.Count > 0)
                {
                    _currentAnswer.Remove(_currentAnswer.Last());
                    UpdateCurrentAnswerLabel();
                }
            }

            if (_validKeys.Contains(e.KeyChar))
            {
                // YEah, they've pressed a number key!
                _currentAnswer.Add(e.KeyChar);
                UpdateCurrentAnswerLabel();
            }
        }

        private void CheckSolution()
        {
            
            int curAnswer;
            if (int.TryParse(new string(
                _currentAnswer.ToArray()), out curAnswer))
            {
                // Write out the current question and answer
                System.IO.File.AppendAllText("MoneyEarned.txt", DateTime.Now.ToString() +" "+ lblTopNumber.Text + lblOperand.Text + lblBottomNumber.Text + "=" + curAnswer.ToString() + "\r\n");
 
                if (_currentFunction(Convert.ToInt32(lblTopNumber.Text), Convert.ToInt32(lblBottomNumber.Text)) ==
                    curAnswer)
                {
                    ProcessCorrectAnswer();
                }
                else
                {
                    ProcessIncorrectAnswer();
                }
           }

        }

        private void UpdateCurrentAnswerLabel()
        {
            lblAnswer.Text = new string(_currentAnswer.ToArray());
       
        }

        private void SaveCurrentMoneyEarned()
        {
            System.IO.File.AppendAllText("MoneyEarned.txt",DateTime.Now.ToString() + " Lily has earned " + lblMoneyEarned.Text + " so far\r\n");

        }
        private void ProcessCorrectAnswer()
        {
            lblCorrectIncorrect.ForeColor = Color.Green;
            lblCorrectIncorrect.Text = "Good Job!";
            lblCorrectIncorrect.Visible = true;

            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            lblCorrectIncorrect.Visible = false;
            lblAnswer.Text = "";
            _currentAnswer = new List<char>();

            lblMoneyEarned.Text = (Convert.ToDecimal(lblMoneyEarned.Text) + GetPayoutByFunctionTypeAndLevel((FunctionType) cboFunction.SelectedItem,Convert.ToInt32(cboLevel.SelectedItem))).ToString();
            SaveCurrentMoneyEarned();

            ProcessNextQuestion();
        }

        private void ProcessIncorrectAnswer()
        {
            lblCorrectIncorrect.ForeColor = Color.Red;
            lblCorrectIncorrect.Text = "Try Again";
            lblCorrectIncorrect.Visible = true;
            this.Refresh();
            System.Threading.Thread.Sleep(1000);
            lblCorrectIncorrect.Visible = false;
            lblAnswer.Text = "";
            _currentAnswer = new List<char>();
           
            ProcessNextQuestion();
        
        }

        System.Random random = new Random(DateTime.Now.Millisecond);
        private void ProcessNextQuestion()
        {
            int bottom, top;
            if (cboFunction.SelectedItem == null || cboLevel.SelectedItem == null) return;
            GetTopAndBottomForFunctionAndLevel(out top, out bottom, (FunctionType)cboFunction.SelectedItem, Convert.ToInt32(cboLevel.SelectedItem));
            lblTopNumber.Text = top.ToString();
            lblBottomNumber.Text = bottom.ToString();
  
        }

        private void GetTopAndBottomForFunctionAndLevel(out int top, out int bottom, FunctionType funcType, int level)
        {
            bottom = 0;
            top = 0;
            if (funcType == FunctionType.Addition)
            {
                if (level == 1)
                {
                    bottom = random.Next(1, 10);
                    top = random.Next(1, 10);
                }

                else if (level == 2)
                {
                    bottom = 10 * random.Next(1, 10);
                    top = 10 * random.Next(1, 10);
                }

                else
                {
                    bottom = random.Next(10, 99);
                    top = random.Next(10, 99);
                }

            }

            if (funcType == FunctionType.Subtraction)
            {
                bottom = random.Next(1, 10);
                top = random.Next(bottom, 20);
            }

            if (funcType == FunctionType.Multiplication)
            {
                bottom = random.Next(1, 10);
                top = random.Next(1, 10);
            }

            if (funcType == FunctionType.Division)
            {
                bottom = random.Next(1, 10);
                top = random.Next(1, 10)*bottom;
            }

        }

        private decimal GetPayoutByFunctionTypeAndLevel(FunctionType functionType, int level)
        {
            if (functionType == FunctionType.Addition)
            {
                if (level == 1)
                {
                    return .01m;
                }

                if (level == 2)
                {
                    return .015m;
                }

                if (level == 3)
                {
                    return .02m;
                }

                return .02m;

            }

            if (functionType == FunctionType.Subtraction)
            {
                return .01m;
            }

            if (functionType == FunctionType.Multiplication)
            {
                return .02m;
            }

            if (functionType == FunctionType.Division)
            {
                return .02m;
            }

            return .01m;

        }

        private void HandleFunctionChanged(object sender, EventArgs e)
        {
            FunctionType curFunc = (FunctionType) cboFunction.SelectedItem;
            if (curFunc == FunctionType.Addition)
            {
                _currentFunction = addition;
                lblOperand.Text = "+";
            }

            if (curFunc == FunctionType.Subtraction)
            {
                _currentFunction = subtraction;
                lblOperand.Text = "-";
            }

            if (curFunc == FunctionType.Multiplication)
            {
                _currentFunction = multiplication;
                lblOperand.Text = "x";
            }

            if (curFunc == FunctionType.Division)
            {
                _currentFunction = division;
                lblOperand.Text = "%";
            }
            
            ProcessNextQuestion();
            cboCrap.Select();
        }

        private void OnCBOLevelSelectedIndexChanged(object sender, EventArgs e)
        {
            cboCrap.Select();
            ProcessNextQuestion();
        }
 
    }
}
