using System;
using System.Collections.Generic;
using System.Linq;


namespace SearchTrees
{
    public class RomeniaMapProblem: IMiniProblem
    {
        private decimal _costOfTheWay;
        private int _depth;
        private string _initialState;
        private string _objectiveState;
        private Node _solutionNode;
        private IList<string> _statesSpace;
        private IList<Node> _nodes;


        public RomeniaMapProblem(string initialStateName, string objectiveStateName,
            IList<string> statesSpace)
        {
            _costOfTheWay = 0;
            _depth = 0;
            _nodes = new List<Node>();
            _statesSpace = statesSpace;
            _initialState = InstanceStateByTheName(initialStateName);
            _objectiveState = InstanceStateByTheName(objectiveStateName);
        }

        private string InstanceStateByTheName(string stateName)
        {
            if (string.IsNullOrEmpty(stateName)) {
                throw new ArgumentNullException("O nome do estado não pode ser nulo ou vazio.");
            }

            var state = _statesSpace.Where(field => field.Equals(stateName));
            if (!state.Any())
            {
                throw new ArgumentException($"O nome do estado '{stateName}', não pertence ao espaço " +
                    "de estados do problema.");
            }

            _nodes.Add(new Node(stateName, null, "", 0));
            return state.FirstOrDefault();
        }


        public IList<string> statesSpace
        {
            get => _statesSpace;
        }

        public string InitialState
        {
            get => _initialState;
        }

        public IList<Node> Nodes
        {
            get => _nodes;
        }

        public Node SolutionNode
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


        public void AddChildToParent(string childNodeName, string parentNodeName, decimal
            costOfTheWay, string action)
        {
            if (string.IsNullOrEmpty(childNodeName)) {
                throw new ArgumentNullException("O nome da nó filho não pode ser um valor nulo ou vazio.");
            }

            if (string.IsNullOrEmpty(parentNodeName)) {
                throw new ArgumentNullException("O nome da nó pai não pode ser um valor nulo ou vazio.");
            }

            GetParentNode(childNodeName, parentNodeName, costOfTheWay, action);
        }

        private void GetParentNode(string childNodeName, string parentNodeName,
            decimal costOfTheWay, string action)
        {
            var parentNode = _nodes.FirstOrDefault(field => field.State == parentNodeName);
            if (parentNode == null) {
                throw new ArgumentException($"O nome do estado pai '{parentNodeName}', não pertence ao espaço " +
                    "de estados do problema.");
            }
            AddChildNodeTo(parentNode, childNodeName, costOfTheWay, action);
        }

        private void AddChildNodeTo(Node parentNode, string childNodeName,
            decimal costOfTheWay, string action)
        {
            var childState = _statesSpace.Where(field => field.Equals(childNodeName)).FirstOrDefault();
            if (childState == null)
            {
                throw new ArgumentException($"O nome do estado filho '{childNodeName}', não pertence ao espaço " +
                    "de estados do problema.");
            }
            _nodes.Add(new Node(childState, parentNode, action, costOfTheWay));
        }


        public void SearchTree()
        {
            var edge = _nodes
                .Where(field => field.ParentNode == null && field.State == _initialState)
                .ToList();

            if (!IsSolutionContainedIn(edge)){
                ExpandLevel(edge);
            }
        }

        private bool IsSolutionContainedIn(IList<Node> edge)
        {
            _solutionNode = (from Node selectedNode in edge
                             where selectedNode.State == _objectiveState
                             select selectedNode).FirstOrDefault();

            if (_solutionNode == null){
                return false;
            }
            return true;
        }

        private void ExpandLevel(List<Node> edge)
        {
            while (_solutionNode == null)   // Should been tried to eliminate infinite loop possibility!
            {
                var expandedNodes = new List<Node>();
                edge.ForEach(node =>
                {
                    if (_solutionNode == null)
                    {
                        expandedNodes.AddRange(GetExpandedNode(node));
                        if (IsSolutionContainedIn(expandedNodes)){
                            return;
                        }
                    }
                });
                ExpandLevel(expandedNodes);
                _depth += 1;
            }
        }

        private List<Node> GetExpandedNode(Node node)
        {
            var childrenNodes = Sucessor(node);
            foreach (var childNode in childrenNodes)
            {
                _costOfTheWay += childNode.CostOfTheWay;
            }
            return childrenNodes;
        }

        private List<Node> Sucessor(Node selectedNode)
        {
            if (selectedNode.ParentNode == null)
            {
                return _nodes.Where(node =>
                    node.ParentNode != null &&
                    node.ParentNode.State == selectedNode.State)
                    .OrderBy(field => field.CostOfTheWay)   //<-- Ordered by cost cheaper
                    .ToList();
            }
            // This clause is because nodes contains ways from City1 to City2 and City2 to 1 (GO and BACK)
            return _nodes.Where(node =>
                node.ParentNode != null &&
                node.ParentNode.State == selectedNode.State &&
                node.State != selectedNode.ParentNode.State)
                .OrderBy(field => field.CostOfTheWay)   //<-- Ordered by cost cheaper
                .ToList();
        }
    }
}
