using System;


namespace SearchTrees
{
    public enum NodeAction
    {
        GO,
        BACK,
        GONE,
        BACKED,
        UNDEFINED
    }



    public class Node
    {
        public Node(string state, Node parentNode, NodeAction action, decimal costOfTheWay)
        {
            State = state;
            ParentNode = parentNode;
            Action = action;
            CostOfTheWay = costOfTheWay;
        }

        public string State { get; protected set; }

        public Node ParentNode { get; protected set; }

        public NodeAction Action { get; protected set; }

        public decimal CostOfTheWay { get; protected set; }

        public NodeAction SetNodeAction (NodeAction nodeAction)
        {
            if (nodeAction == NodeAction.UNDEFINED){
                throw new ArgumentException("The action don't be setted to 'undefined'.");
            }

            Action = nodeAction;
            return Action;
        }
    }
}
