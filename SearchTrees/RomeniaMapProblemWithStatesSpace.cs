using System;
using System.Collections.Generic;
using System.Linq;


namespace SearchTrees
{
    public class RomeniaMapProblemWithStatesSpace : IMiniProblem
    {
        private decimal _costOfTheWay;
        private int _depth;
        private State _initialState;
        private State _objectiveState;
        private NodeWithState _solutionNode;
        private StatesSpace _statesSpace;
        private IList<NodeWithState> _nodes;


        public RomeniaMapProblemWithStatesSpace(string initialStateName, string objectiveStateName, 
            StatesSpace statesSpace)
        {
            _costOfTheWay = 0;
            _depth = 0;
            _nodes = new List<NodeWithState>();
            _statesSpace = statesSpace;
            _initialState = InstanceStateByTheName(initialStateName);
            _objectiveState = InstanceStateByTheName(objectiveStateName);
        }

        private State InstanceStateByTheName(string stateName)
        {
            if (string.IsNullOrEmpty(stateName)){
                throw new ArgumentNullException("O nome do estado não pode ser nulo ou vazio.");
            }

            var state = _statesSpace.GetAllStatesOfSpace().Where(field =>
                field.Name.Equals(stateName));
            if (!state.Any())
            {
                throw new ArgumentException($"O nome do estado '{stateName}', não pertence ao espaço " +
                    "de estados do problema.");
            }

            _nodes.Add(new NodeWithState(state.FirstOrDefault(), null, "", 0));
            return state.FirstOrDefault();
        }

        public StatesSpace statesSpace 
        {    
            get => _statesSpace; 
        }

        public State InitialState 
        { 
            get => _initialState; 
        }

        public IList<NodeWithState> Nodes 
        {
            get => _nodes;
        }

        public NodeWithState SolutionNode 
        { 
            get => _solutionNode; 
        }

        public int Depth
        {
            get => _depth;
        }

        public decimal costOfTheWay
        {
            get => _costOfTheWay;
        }


        public void AddChildToParent(string childNodeName, string parentNodeName, decimal costOfTheWay)
        {
            if (string.IsNullOrEmpty(childNodeName)){
                throw new ArgumentNullException("O nome da nó filho não pode ser um valor nulo ou vazio.");
            }

            if (string.IsNullOrEmpty(parentNodeName)){
                throw new ArgumentNullException("O nome da nó pai não pode ser um valor nulo ou vazio.");
            }

            GetParentNode(childNodeName, parentNodeName, costOfTheWay);
        }

        private void GetParentNode(string childNodeName, string parentNodeName, decimal costOfTheWay)
        {
            var parentNode = _nodes.FirstOrDefault(field => field.State.Name == parentNodeName);
            if (parentNode == null){
                throw new ArgumentException($"O nome do estado pai '{parentNodeName}', não pertence ao espaço " +
                    "de estados do problema.");
            }
            AddChildNodeTo(parentNode, childNodeName, costOfTheWay);
        }

        private void AddChildNodeTo(NodeWithState parentNode, string childNodeName, decimal costOfTheWay)
        {
            var childState = _statesSpace.GetAllStatesOfSpace().Where(field =>
                field.Name.Equals(childNodeName)).FirstOrDefault();
            if (childState == null)
            {
                throw new ArgumentException($"O nome do estado filho '{childNodeName}', não pertence ao espaço " +
                    "de estados do problema.");
            }
            _nodes.Add(new NodeWithState(childState, parentNode, "GoTo", costOfTheWay));
        }

        public void SearchTree()
        {
            var edge = _nodes
                .Where(field => field.ParentNode == null && field.State.Name == _initialState.Name)
                .OrderBy(order => order.State.Id).ToList();

            while (_solutionNode == null) // alguma outra condição que impeça loop infinito
            {
                if (edge == null){ 
                    throw new ApplicationException("Incomplete states space, node not found.");
                }

                _solutionNode = (from NodeWithState selectedNode in edge
                                where selectedNode.State.Name == _objectiveState.Name
                                select selectedNode).FirstOrDefault();

                if (_solutionNode == null)
                {
                    ExpandLevel(ref edge);
                }
            }
        }

        private void ExpandLevel(ref List<NodeWithState> edge)
        {
            foreach (var selectedNode in edge)
            {
                edge = GetExpandedNode(selectedNode);
            }
            _depth += 1;
        }

        private List<NodeWithState> GetExpandedNode(NodeWithState node)
        {
            var childrenNodes = Sucessor(node);
            foreach (var childNode in childrenNodes)
            {
                _costOfTheWay += childNode.CostOfTheWay;
            }
            return childrenNodes;
        }

        private List<NodeWithState> Sucessor(NodeWithState selectedNode)
        {
            return _nodes.Where(node =>
                node.ParentNode != null &&
                node.ParentNode.State.Name == selectedNode.State.Name) 
            .OrderBy(order => order.State.Id)
            .ToList();

            //<-- This clause is because nodes contains City1 -> City2 and City2 -> 1 (go and back)
        }
    }
}
