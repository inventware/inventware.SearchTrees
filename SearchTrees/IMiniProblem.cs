using System.Collections.Generic;


namespace SearchTrees
{
    internal interface IMiniProblem
    {
        IList<Node> Nodes { get; }

        IList<string> statesSpace { get; }

        Node SolutionNode { get; }

        int Depth { get; }

        decimal costOfTheWay { get; }

        void AddChildToParent(string childNodeName, string parentNodeName, decimal
            costOfTheWay, string action);

        void SearchTree();
    }
}
