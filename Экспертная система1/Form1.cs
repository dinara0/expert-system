using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экспертная_система1
{
    public partial class Knowledge : Form
    {
        // Question currentQst;
        //Question qst1;
        List<Button> BtnList;
        QuestionsTree tree1 = new QuestionsTree();
        TreeView tree = new TreeView();
        Root root = null;

        public Knowledge()
        {
            InitializeComponent();

            BtnList = new List<Button>();
            //  BtnList.Add(Ans1); BtnList.Add(Ans2);
            //BtnList.Add(Ans3); BtnList.Add(Ans4);

            // qst1 = new Question("Многосезоннное или односезонное аниме?");
            //  Question qst2 = new Question("Там много жестокости?");
            //   qst1.getAnswer(1).Question = qst2;
            //  currentQst = null;
        }

        private void Knowledge_Load(object sender, EventArgs e)
        {

            List<Object> l = new List<Object>();
            using (StreamReader r = new StreamReader("C:/Users/User/Downloads/Books.json"))
            {
                string json = r.ReadToEnd();
                root = JsonConvert.DeserializeObject<Root>(json);

            }
            Object obj = new Object();
            int cur = 0;
            NextQuest(0);

            UpdateWindow();
        }

        /*private void F()
        {
            //   Console.WriteLine("{0}", s.name);
            tboxQuest.Text = s.name;
            Button[] btnlst = new Button[s.choices.Count];
            for (int i = 0; i < s.choices.Count; i++)
            {
                Button button = new Button();
                button.Left = left;
                button.Top = top;
                button.Name = "btn" + i;
                button.Click += ButtonOnClick;

                this.Controls.Add(button);
                top += button.Height + 2;
            }
        }*/

        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            var button = (Button)sender;


            if (button != null)
            {
                NextQuest((int)button.Tag);
            }
        }
        private void NextQuest(int id)
        {
            panel1.Controls.Clear();
            /*foreach (var control in panel1.Controls)
            {
                Button btn = control as Button;
                if (btn != null)
                {

                    btn.Dispose();
                }
            }*/
            Object obj = new Object();
            foreach (Object s in root.objects)
            {
                if (s.id == id)
                    obj = s;

            }
            Point p = new Point(20, 20);
            Point p2 = new Point(1000, 40);
            Size si = new Size(p2);

            //int x = 0, y = 0;
            foreach (Object s in root.objects)
            {
                if (s.id == obj.content)
                {
                    if (s.ty == 1)
                    {
                        tboxQuest.Text = "Предлагаем почитать " + s.name;
                        return;
                    }

                    tboxQuest.Text = s.name;
                    Button[] btnlst = new Button[s.choices.Count];
                    for (int i = 0; i < s.choices.Count; i++)
                    {
                        Button button = new Button();
                        BtnList.Add(button);
                        button.Text = s.choices[i];
                        button.Name = button.Text;
                        button.Location = p;
                        button.Size = si;

                        int ind = obj.children[i];
                        button.Tag = ind;
                        button.Click += ButtonOnClick;
                        panel1.Controls.Add(button);
                        //Controls.Add(button);
                        p.Y += 50;
                    }


                }
            }

        }


        private void UpdateWindow()
        {
            // tboxQuest.Text = 
        }

        private void btnReStart_Click(object sender, EventArgs e)
        {
            // currentQst = qst1;
            UpdateWindow();
        }
        public void BuildQTree(QuestionsTreeNode node, List<QuestionsTreeNode> connectionList)//
        {
            node.children = connectionList;

            // node.сhildren = connectionList.Where(c => c.Parent == node);
            foreach (QuestionsTreeNode c in node.children) BuildQTree(c, connectionList);//вместо connectionList должен передаваться
                                                                                         //оставшийся список, но я пока не поняла, как будет
                                                                                         //устроен список 
        }
        /*  private List<QuestionsTreeNode> GenerateList(string falename)
          {
              List<QuestionsTreeNode> collection;
              return
          }*/
    }
}
