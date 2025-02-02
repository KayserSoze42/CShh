using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShh
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }

        public Node(T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

    }

    public class Binz<T>
    {
        private Node<T> root;

        public Binz()
        {
            root = null;
        }


        public void Insert(T value) 
        {
            root = InsertRecz(root, value);
        }

        private Node<T> InsertRecz(Node<T> current, T value) 
        {
            if (current == null)
            {
                return new Node<T>(value);
            }

            // babe, Hash(), Hash()
            if (value.GetHashCode() % 2 == 0)
            {
                current.Left = InsertRecz(current.Left, value);
            }
            else
            { 
                current.Right = InsertRecz(current.Right, value);  
            }

            return current;
        }

        // and the second verse: traverse..

        // disorder.. this order.. in dis ooooooordeeeeer

        public IEnumerable<T> InDisOrderTraversal()
        {
            return InDisReczOrderTraversal(root);
        }

        private IEnumerable<T> InDisReczOrderTraversal(Node<T> nodepm)
        {
            if (nodepm != null)
            {
                // kanan
                foreach (var value in InDisReczOrderTraversal(nodepm.Left))
                    yield return value;

                // toor
                yield return nodepm.Value;

                // kaliwa
                foreach (var value in InDisReczOrderTraversal(nodepm.Right))
                    yield return value;
            }

        }

        // pre ordered
        public IEnumerable<T> PreDisOrderTraversal()
        {
            var result = new List<T>();
            PreDisReczOrderTraversal(root, result);
            return result;
        }

        private void PreDisReczOrderTraversal(Node<T> nodepm, List<T> result)
        {
            if (nodepm == null) return;

            // toor, kanan, kaliwa
            result.Add(nodepm.Value);
            PreDisReczOrderTraversal(nodepm.Left, result);
            PreDisReczOrderTraversal(nodepm.Right, result);
        }

        // put/patch/post ordered
        public IEnumerable<T> PostDisOrderTraversal()
        {
            var result = new List<T>();
            PostDisReczOrderTraversal(root, result);
            return result;
        }

        private void PostDisReczOrderTraversal(Node<T> nodepm, List<T> result)
        {
            if (nodepm == null) return;

            // kanan, kaliwa, toor
            PostDisReczOrderTraversal(nodepm.Left, result);
            PostDisReczOrderTraversal(nodepm.Right, result);
            result.Add(nodepm.Value);
        }

        // bfs and bffs here


    }
}
