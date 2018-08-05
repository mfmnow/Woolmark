namespace Wool.Test.LinkedList.Domain
{
    public class LinkedList
    {
        private Node _tail { get; set; }

        public void AddNode(int nodeData)
        {
            Node newTail = new Node()
            {
                Data = nodeData,
                Previous = _tail
            };
            _tail = newTail;
        }

        public int GetFromEnd(int rankFromEnd)
        {
            var current = this._tail;
            if (current == null)
            {
                throw new System.Exception("LinkedList is not initialized");
            }
            for (int i = 1; i < rankFromEnd; i++)
            {
                current = current.Previous;
                if (current == null)
                {
                    throw new System.Exception("rankFromEnd must not be bigger than list length");
                }
            }
            return current.Data;
        }
    }
}
