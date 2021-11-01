using System;

    public class Node<T>
    {
        public T Value;
        public Node<T> Next;
        public Node(T val) { Value = val; Next = null; }
    }

    class LinkedList<T>
    {
        private Node<T> Head;
        private Node<T> Tail;

        public void AddNode(T value)
        {
            if (Head == null)
            {
                Head = Tail = new Node<T>(value);
            }
            else
            {
                Tail.Next = new Node<T>(value);
                Tail = Tail.Next;
            }
        }

        public void RemoveNode(T value)
        {
            if (Head != null)
            {
                if (Head.Value.Equals(value))
                {
                    Head = Head.Next;
                }
                else
                {
                    Node<T> previousNode = Head;
                    while (previousNode.Next != null)
                    {
                        if (previousNode.Next.Value.Equals(value))
                        {
                            if (previousNode.Next == Tail)
                            {
                                Tail = previousNode;
                                previousNode.Next = null;
                                break;
                            }
                            else
                            {
                                previousNode.Next = previousNode.Next.Next;
                                break;
                            }  
                        }
                    }
                }
            }
        }

        public void Clear()
        {
            Head = null;
            Tail = null;
        }

    public T[] GetNodes()
    {
        int length = Count();
        T[] result = new T[length];

        int i = 0;
        Node<T> currentNode = Head;
        while (currentNode.Next != null)
        {
            result[i] = currentNode.Value;
            i++;
            currentNode = currentNode.Next;
        }
        return result;
    }

        // запросы

        public bool Contains(T value)
        {
            if (Head == null) return false;

            Node<T> currentNode = Head;
            while (currentNode.Next != null)
            {
                if (currentNode.Value.Equals(value)) return true;
                currentNode = currentNode.Next;
            }
            return false;
        }

        public bool IsEmpty()
        {
            if (Head == null) return true;
            return false;
        }

        public int Count()
        {
            if (Head == null) return 0;
            int counter = 1;
            Node<T> currentNode = Head;
            while (currentNode.Next != null)
            {
                counter++;
                currentNode = currentNode.Next;
            }
            return counter;
        }

        public void ConsoleOutput()
        {
            Node<T> currentNode = Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value + " ");
                currentNode = currentNode.Next;
            }
        }
    }



