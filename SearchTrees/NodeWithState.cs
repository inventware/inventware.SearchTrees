

namespace SearchTrees
{
    public class NodeWithState
    {
        public NodeWithState(State state, NodeWithState parentNode, string action, decimal costOfTheWay)
        {
            State = state;
            ParentNode = parentNode;
            Action = action;
            CostOfTheWay = costOfTheWay;
        }

        public State State { get; protected set; }

        public NodeWithState ParentNode { get; protected set; }

        public string Action { get; protected set; }

        public decimal CostOfTheWay { get; protected set; }
    }
}
