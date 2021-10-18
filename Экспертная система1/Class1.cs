using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экспертная_система1
{
    public class QuestionsTreeNode
    {
        public string question = null;
        public string answer = null;//ответ на предыдущий узел
        Object obj;
        public QuestionsTreeNode Parent = null;
        public QuestionsTreeNode()
        {
            // question = null;
        }
        public QuestionsTreeNode(string name)
        {
            question = name;
        }

        public void AddName(string name)
        {
            question = name;
        }
        public List<QuestionsTreeNode> children = null;//либо создать объект, который
                                                       //представляет из себя список ответов
                                                       //public List <QuestionsTreeNode> сhildren { get; set; }
    }
    /*  public class AnswerTreeNode// один из ответов на вопрос
      {
          readonly string answer;//доступно только для чтения
          QuestionsTreeNode node;
      }*/
    public class QuestionsTree // Класс «Бинарное дерево произвольного вида»
    {
        public QuestionsTreeNode root; // ссылка на корень дерева

        public QuestionsTree() // создание пустого дерева
        {
            root = null;
        }
        public void AddNode(QuestionsTreeNode n)
        {
            root.children.Add(n);
        }


    }
    public class Object
    {
        public bool is_binary { get; set; }
        public List<string> choices { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int ty { get; set; }
        public string descr { get; set; }
        public int? content { get; set; }
        public List<int> children { get; set; }
    }

    public class Root
    {
        public List<Object> objects { get; set; }
        public int cur_node { get; set; }
        public string es_descr { get; set; }
        public string es_name { get; set; }
        public int version { get; set; }
    }
    public class MyTreeNode : TreeNode
    {
        private Object obj;
        public Object Obj
        {
            get => obj;
            set
            {
                obj = value;
            }
        }
    }

}
