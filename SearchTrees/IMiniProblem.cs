using System.Collections.Generic;


namespace SearchTrees
{
    internal interface IMiniProblem
    {
        IList<Node> Nodes { get; }

        IList<string> statesSpace { get; }

        Node SolutionNode { get; }

        int Depth { get; }

        decimal CostOfTheWay { get; }

        void AddChildToParent(string childNodeName, string parentNodeName, decimal
            costOfTheWay, NodeAction action);

        void SearchTree();
    }
}
