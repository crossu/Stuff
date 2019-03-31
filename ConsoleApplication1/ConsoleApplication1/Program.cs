using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree("root");
            Tree branch = tree.AddBranch("branch");
            Tree branch2 = tree.AddBranch("branch");
            Tree branchofbranch = branch.AddBranch("anotherone");
            Tree branchofbranch2 = branch.AddBranch("anotherone");
            Console.WriteLine(tree.GetChilds());
            Console.WriteLine(tree.GetAllChilds());
            Console.ReadLine();
        }
    }
    class Tree
    {
        private string _name;
        private List<Tree> _branches = new List<Tree>();
        public string GetName { get; }
        public List<Tree> GetTrees { get;}

        public Tree(string name)
        {
            this._name = name;
        }

        public Tree AddBranch(string name)
        {
            Tree branch = new Tree(name);
            this._branches.Add(branch);
            return branch;
        }
        public int GetChilds()
        {
            int count = 0;
            foreach (Tree i in _branches)
            {
                count++;
            }
            return count;
        }
        public int GetAllChilds()
        {
            int count = 0;
            foreach(Tree t in _branches)
            {
                count++;
                foreach (Tree i in t._branches)
                {
                    count++;
                }
            }
            return count;
        }
        public void Delete(Tree tree)
        {
            foreach (Tree t in _branches)
            {
                foreach (Tree i in t._branches)
                {
                    i._branches.Remove(i);
                }
                t._branches.Remove(t);
            }
        }
    }
    static class Console
    {
        static public void ReadLine()
        {
            System.Console.ReadLine();
        }
        static public void WriteLine(object any)
        {
            System.Console.WriteLine(any);
        }
        static public void WriteLine(bool show = false)
        {
            if (show)
            {
                System.Console.WriteLine();
            }
            else
            {
                System.Console.WriteLine();
            }
        }
    }
}
