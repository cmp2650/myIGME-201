using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pendergast_UnitTest2_10
{
    public abstract class Writing
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public abstract void Write();
        public virtual void Publish()
        {
            Console.WriteLine("Publishing...");
        }
    }
    public interface Printable
    {
        void Print();
    }
    public interface AudioBook
    {
        void Narrate();
    }
    public class Novel : Writing, Printable
    {
        public int GetWordCount()
        {
            return 0;
        }
        public override void Write()
        {
            Console.WriteLine("Writing novel...");
        }
        public override void Publish()
        {
            base.Publish();
            Console.WriteLine("Publishing novel...");
        }
        public void Print()
        {
            Console.WriteLine("Printing novel...");
        }
    }
    public class Poem : Writing, AudioBook
    {
        public int GetLineCount()
        {
            return 0;
        }
        public override void Write()
        {
            Console.WriteLine("Writing poem...");
        }
        public void Narrate()
        {
            Console.WriteLine("Narrating poem...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Novel novel = new Novel();
            Poem poem = new Poem();

            MyMethod(novel);
            MyMethod(poem);
        }
        static bool MyMethod(object obj)
        {
            if (obj is Novel)
            {
                Novel novel = obj as Novel;
                novel.Write();
                novel.Publish();
                novel.Print();
                return true;
            }
            else if (obj is Poem)
            {
                Poem poem = obj as Poem;
                poem.Write();
                poem.Narrate();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}