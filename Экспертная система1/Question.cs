using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экспертная_система1
{
    class Question
    {
        QuestionsTree tree = new QuestionsTree();


        private string text;

        private List<Answer> answers;

        public Question(string text_)
        {
            text = text_;
            answers = new List<Answer>();

            answers.Add(new Answer("Да"));
            answers.Add(new Answer("Нет"));
        }

        public Question(string text_, List<Answer> answers_)
        {
            text = text_;
            answers = answers_;
        }

        public Answer getAnswer(int ans)
        {
            return answers[ans - 1];
        }

        public void UpdateWindow(List<Button> btns, RichTextBox qst)
        {
            qst.Text = text;

            int i = 0;
            foreach (Button btn in btns)
            {
                if (i < answers.Count)
                {
                    btn.Enabled = true;
                    btn.Text = answers[i].Txt;
                }
                else btn.Enabled = false;
                ++i;
            };
        }
    }

    class Answer
    {
        private string text;
        private Question LinkQuest;
        private Goal goal;

        public Answer(string text_)
        {
            text = text_;
            LinkQuest = null;
            goal = null;
        }

        public Answer(string text_, Goal goal_)
        {
            text = text_;
            goal = goal_;
            LinkQuest = null;
        }

        public Answer(string text_, Question quest)
        {
            text = text_;
            LinkQuest = quest;
            goal = null;
        }

        public string Txt { get => text; }
        public Question Question
        {
            get => LinkQuest;
            set => LinkQuest = value;
        }
    }

    class Goal
    {
        private string text;

        public Goal(string text_)
        {
            text = text_;
        }

        public void UpdateWindow()
        {
            ;
        }
    }
}
