using System.Collections.Generic;


namespace SearchTrees
{
    internal interface IMiniProblem
    {
        IList<NodeWithState> Nodes { get; }

        StatesSpace statesSpace { get; }

        State InitialState { get; }
    }
}
