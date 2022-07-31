

namespace SearchTrees
{
    public class Node
    {
        public Node(string state, Node parentNode, string action, decimal costOfTheWay)
        {
            State = state;
            ParentNode = parentNode;
            Action = action;
            CostOfTheWay = costOfTheWay;
        }

        public string State { get; protected set; }

        public Node ParentNode { get; protected set; }

        public string Action { get; protected set; }

        public decimal CostOfTheWay { get; protected set; }
    }
}
