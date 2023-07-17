using System.Collections;
using System.Windows.Forms.VisualStyles;

namespace InferenceBasedDecisionMaking
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
        string input = "";
        bool ifFlg = true;
        List<string> list = new List<string>();
        List<string> events = new List<string>();
        Dictionary<char, string> events1 = new Dictionary<char, string>();
        string target;
        List<string> myList = new List<string>();


        void printList(List<string> list, TextBox box)
        {
            box.Text = String.Empty;
            foreach (string s in list)
            {
                box.Text += s;
            }
        }

        private void ifThen_Click(object sender, EventArgs e)
        {
            if (ifFlg)
            {
                EventAdd.Enabled = true; Negate.Enabled = true;
                orBtn.Enabled = false;
                andBtn.Enabled = false;
                EndBtn.Enabled = false;
                list.Add("If ");
                ifFlg = false;
                ifThen.Text = "Then";
                printList(list, InputText);
                events.Add("if");
                ifThen.Enabled = false;
            }
            else
            {
                EventAdd.Enabled = true; Negate.Enabled = true;
                orBtn.Enabled = false;
                andBtn.Enabled = false;
                EndBtn.Enabled = false;
                list.Add("then ");
                ifFlg = true;
                ifThen.Text = "If";
                printList(list, InputText);
                events.Add("then");
                ifThen.Enabled = false;
            }
            Conclusion.Enabled = false;


        }

        private void orBtn_Click(object sender, EventArgs e)
        {
            events.Add("or");
            list.Add(" or ");
            printList(list, InputText);
            orBtn.Enabled = false;
            andBtn.Enabled = false;
            EndBtn.Enabled = false;
            EventAdd.Enabled = true;
            Conclusion.Enabled = false;
        }

        private void andBtn_Click(object sender, EventArgs e)
        {
            events.Add("and");
            list.Add(" and ");
            printList(list, InputText);
            orBtn.Enabled = false;
            andBtn.Enabled = false;
            EndBtn.Enabled = false;
            EventAdd.Enabled = true; Negate.Enabled = true;
            Conclusion.Enabled = false;
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (events.Count > 0) events.RemoveAt(events.Count - 1);
            if (list.Count > 0)
            {
                if (list[list.Count - 1] == "then ")
                {
                    ifFlg = false;
                    ifThen.Text = "Then";
                    if (list.Count > 1) if ((list[list.Count - 2] != "then " || list[list.Count - 2] != "If "))
                        {
                            EventAdd.Enabled = true; Negate.Enabled = true;
                            orBtn.Enabled = true;
                            andBtn.Enabled = true;
                            EndBtn.Enabled = true;
                            ifThen.Enabled = true;
                        }
                }
                if (list[list.Count - 1] == "If ")
                {
                    ifFlg = true;
                    ifThen.Text = "If";
                    if (list.Count > 1) if ((list[list.Count - 2] != "then " || list[list.Count - 2] != "If "))
                        {
                            EventAdd.Enabled = true; Negate.Enabled = true;
                            orBtn.Enabled = true;
                            andBtn.Enabled = true;
                            EndBtn.Enabled = true;
                            ifThen.Enabled = true;
                        }

                }
                EventAdd.Enabled = true; Negate.Enabled = true;
                if (Conclusion.Enabled == false)
                {
                    if (!list.Contains("Therefore "))
                    {
                        Conclusion.Enabled = true;
                    }
                }
                list.RemoveAt(list.Count - 1);
                if (list.Count == 0)
                {
                    ClearText();
                }

            }
            printList(list, InputText);

        }

        void ClearText()
        {
            InputText.Text = string.Empty;
            list.Clear();
            events.Clear();
            EventAdd.Enabled = true; Negate.Enabled = true;
            orBtn.Enabled = false;
            andBtn.Enabled = false;
            EndBtn.Enabled = false;
            ifThen.Enabled = true;
            Conclusion.Enabled = false;
            ifFlg = true;
            ifThen.Text = "If";
            translationBox.Text = string.Empty;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void EventAdd_Click(object sender, EventArgs e)
        {
            if (EventDropdown.SelectedItem != null)
            {
                char ToID = Char.Parse(EventDropdown.SelectedItem.ToString());
                list.Add(events1[ToID] + " ");
                events.Add(ToID.ToString());
                orBtn.Enabled = true;
                andBtn.Enabled = true;
                if (ifFlg)
                {
                    EndBtn.Enabled = true;
                    ifThen.Enabled = false;
                }
                else ifThen.Enabled = true;
                EventAdd.Enabled = false; Negate.Enabled = false;
                printList(list, InputText);
                Conclusion.Enabled = false;
            }

        }

        private void EventCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EventCreateInp.Text))
            {
                char count = Char.Parse(events1.Count.ToString());
                events1.Add(count, EventCreateInp.Text);
                string nl = "\r\n";
                EventListbox.Text += nl + count + ": " + EventCreateInp.Text;
                EventDropdown.Items.Add(count);
            }

        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            EventAdd.Enabled = true; Negate.Enabled = true;
            orBtn.Enabled = true;
            andBtn.Enabled = true;
            EndBtn.Enabled = false;
            ifThen.Enabled = true;
            Conclusion.Enabled = true;
            ifFlg = true;
            ifThen.Text = "If";
            list[list.Count - 1] = list[list.Count - 1].Remove(list[list.Count - 1].Length - 1, 1) + ". ";
            printList(list, InputText);
            events.Add(".");
            Begin.Enabled = true;

            if (list.Contains("Therefore "))
            {
                orBtn.Enabled = false;
                andBtn.Enabled = false;
                ifThen.Enabled = false;
                EndBtn.Enabled = false;
                EventAdd.Enabled = false;
                Negate.Enabled = false;
            }

        }

        private void Negate_Click(object sender, EventArgs e)
        {
            if (EventDropdown.SelectedItem != null)
            {
                char ToID = Char.Parse(EventDropdown.SelectedItem.ToString());
                string Event = events1[ToID];
                if (Event.Contains(" do "))

                    Event = ReplaceFirst(Event, " do ", " do not ");

                else if (Event.Contains(" will "))

                    Event = ReplaceFirst(Event, " will ", " will not ");

                else if (Event.Contains(" can "))

                    Event = ReplaceFirst(Event, " can ", " can not ");

                else if (Event.Contains(" is "))

                    Event = ReplaceFirst(Event, " is ", " is not ");

                else if (Event.Contains(" are "))

                    Event = ReplaceFirst(Event, " are ", " are not ");

                else if (Event.Contains(" am "))

                    Event = ReplaceFirst(Event, " am ", " am not ");

                else if (Event.Contains(" "))

                    Event = ReplaceFirst(Event, " ", " do not ");

                else
                {
                    Event = "Not " + Event;
                }
                list.Add(Event + " ");
                events.Add("!" + ToID.ToString());

                orBtn.Enabled = true;
                andBtn.Enabled = true;
                if (ifFlg)
                {
                    EndBtn.Enabled = true;
                    ifThen.Enabled = false;
                }
                else ifThen.Enabled = true;
                EventAdd.Enabled = false; Negate.Enabled = false;
                printList(list, InputText);
                Conclusion.Enabled = false;
            }

        }

        private void Begin_Click(object sender, EventArgs e)
        {
            translationBox.Text = string.Empty;
            TranslateInput();
            int lastLine = myList.Count - 1;
            target = myList[lastLine].ToString();
        }

        void TranslateInput()
        {
            bool thenFlag = false;
            string temp;
            for (int i = 0; i < events.Count; i++)
            {
                switch (events[i])
                {
                    case ".":
                        if (thenFlag) input += ")";
                        input += "\r\n";
                        myList.Add(input);
                        input = "";
                        break;
                    case "if":
                        input += "(";
                        thenFlag = true;
                        break;
                    case "then":
                        input += ")→";
                        thenFlag = false;
                        break;
                    case "or":
                        input += "∨";
                        break;
                    case "and":
                        input += "∧";
                        break;
                    case "conc":
                        input += "=====================" + "\r\n";
                        break;
                    default:
                        temp = events[i];
                        if (events[i].Contains("!"))
                        {
                            temp = events[i].Remove(0, 1);
                            input += "¬";
                        }

                        input += temp;
                        break;
                }


            }
            printList(myList, translationBox);
        }


        private void Conclusion_Click(object sender, EventArgs e)
        {
            list.Add("Therefore ");
            Conclusion.Enabled = false;
            printList(list, InputText);
            EventAdd.Enabled = true;
            Negate.Enabled = true;
            orBtn.Enabled = true;
            andBtn.Enabled = true;
            EndBtn.Enabled = false;
            Begin.Enabled = false;
            ifThen.Enabled = true;
            events.Add("conc");
        }



        string implies(string arg1, string arg2)
        {
            return "(" + (arg1) + ")→(" + arg2 + ")";
        }

        string or(string arg1, string arg2)
        {
            return "(" + (arg1) + "∨" + arg2 + ")";
        }

        string and(string arg1, string arg2)
        {
            return "(" + (arg1) + "∧" + arg2 + ")";
        }

        string not(string arg)
        {
            if (!arg.Contains("¬"))
                return "¬(" + arg + ")";
            else return arg.Substring(1);
        }


    }
}
