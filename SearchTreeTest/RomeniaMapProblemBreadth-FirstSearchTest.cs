using SearchTrees;


namespace SearchTreeTest
{
    [TestClass]
    public class RomeniaMapProblemBreadthFirstSearchTest
    {
        private IList<string> _stateSpaces;

        [TestInitialize]
        public void Initialize()
        {
            AddSatesSpace();
        }

        private void AddSatesSpace()
        {
            _stateSpaces = new List<string>();
            _stateSpaces.Add("Arad");
            _stateSpaces.Add("Zerind");
            _stateSpaces.Add("Oradea");
            _stateSpaces.Add("Timisoara");
            _stateSpaces.Add("Sibiu");
            _stateSpaces.Add("Lugoj");
            _stateSpaces.Add("Mehadia");
            _stateSpaces.Add("Dobreta");
            _stateSpaces.Add("Craiova");
            _stateSpaces.Add("Rimnieu Vilcea");
            _stateSpaces.Add("Pitesti");
            _stateSpaces.Add("Fagaras");
            _stateSpaces.Add("Bucareste");
            _stateSpaces.Add("Giurgiu");
            _stateSpaces.Add("Urziceni");
            _stateSpaces.Add("Neamt");
            _stateSpaces.Add("Nome Apagado");
            _stateSpaces.Add("Vaslui");
            _stateSpaces.Add("Hirsova");
            _stateSpaces.Add("Eforie");
        }

        private void AddNodesToProblem(ref RomeniaMapProblemBreadthFirstSearch romeniaMapProblem)
        {
            var alala = (NodeAction)Enum.Parse(typeof(NodeAction), "GO");

            romeniaMapProblem.AddChildToParent("Zerind", "Arad", 75, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Arad", "Zerind", 75, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Sibiu", "Arad", 140, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Arad", "Sibiu", 140, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Timisoara", "Arad", 118, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Arad", "Timisoara", 118, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Oradea", "Zerind", 71, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Zerind", "Oradea", 71, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Sibiu", "Oradea", 151, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Oradea", "Sibiu", 151, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Lugoj", "Timisoara", 111, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Timisoara", "Lugoj", 111, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Mehadia", "Lugoj", 70, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Lugoj", "Mehadia", 70, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Dobreta", "Mehadia", 75, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Mehadia", "Dobreta", 75, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Craiova", "Dobreta", 120, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Dobreta", "Craiova", 120, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Pitesti", "Craiova", 138, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Craiova", "Pitesti", 138, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Rimnieu Vilcea", "Craiova", 146, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Craiova", "Rimnieu Vilcea", 146, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Rimnieu Vilcea", "Sibiu", 80, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Sibiu", "Rimnieu Vilcea", 80, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Fagaras", "Sibiu", 99, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Sibiu", "Fagaras", 99, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Bucareste", "Fagaras", 211, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Fagaras", "Bucareste", 211, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Pitesti", "Rimnieu Vilcea", 97, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Rimnieu Vilcea", "Pitesti", 97, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Bucareste", "Pitesti", 101, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Pitesti", "Bucareste", 101, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Giurgiu", "Bucareste", 90, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Bucareste", "Giurgiu", 90, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Urziceni", "Bucareste", 85, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Bucareste", "Urziceni", 85, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Hirsova", "Urziceni", 98, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Urziceni", "Hirsova", 98, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Eforie", "Hirsova", 86, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Hirsova", "Eforie", 86, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Vaslui", "Urziceni", 142, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Urziceni", "Vaslui", 142, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Nome Apagado", "Vaslui", 92, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Vaslui", "Nome Apagado", 92, NodeAction.BACK);
            romeniaMapProblem.AddChildToParent("Neamt", "Nome Apagado", 87, NodeAction.GO);
            romeniaMapProblem.AddChildToParent("Nome Apagado", "Neamt", 87, NodeAction.BACK);
        }


        [TestMethod]
        public void WhenTheInitialStateNameNotBelongsTo()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("UnknownCity", string.Empty, _stateSpaces);
            }
            catch (ArgumentException err)
            {
                Assert.AreEqual(err.Message, "O nome do estado 'UnknownCity', não pertence ao espaço de estados do problema.");
            }
        }


        [TestMethod]
        public void WhenTheInitialStateNameIsEmpty()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch(string.Empty, "Bucareste", _stateSpaces);
            }
            catch (ArgumentException err)
            {
                Assert.IsTrue(err.Message.Contains("O nome do estado não pode ser nulo ou vazio."));
            }
        }


        [TestMethod]
        public void WhenTheObjectiveStateNameIsEmpty()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", string.Empty, _stateSpaces);
            }
            catch (ArgumentException err)
            {
                Assert.IsTrue(err.Message.Contains("O nome do estado não pode ser nulo ou vazio."));
            }
        }


        [TestMethod]
        public void WhenTheObjectiveStateNameNotBelongsTo()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "UnknownCity", _stateSpaces);
            }
            catch (ArgumentException err)
            {
                Assert.AreEqual(err.Message, "O nome do estado 'UnknownCity', não pertence ao espaço de estados do problema.");
            }
        }


        [TestMethod]
        public void WhenTheInitialStateNameGetMatchWithStatesSpace()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Bucareste", _stateSpaces);
            Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);
        }


        [TestMethod]
        public void AddChildToParentWhenChildNodeNameIsEmpty()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Bucareste", _stateSpaces);
                Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

                romeniaMapProblem.AddChildToParent(string.Empty, "Zerind", 0, NodeAction.BACK);
            }
            catch (ArgumentException err)
            {
                Assert.IsTrue(err.Message.Contains("O nome da nó filho não pode ser um valor nulo ou vazio."));
            }
        }


        [TestMethod]
        public void AddChildToParentWhenParentNodeNameIsEmpty()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Bucareste", _stateSpaces);
                Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

                romeniaMapProblem.AddChildToParent("Arad", string.Empty, 0, NodeAction.BACK);
            }
            catch (ArgumentException err)
            {
                Assert.IsTrue(err.Message.Contains("O nome da nó pai não pode ser um valor nulo ou vazio."));
            }
        }

        [TestMethod]
        public void AddChildToParentWhenParentNodeNameDoesntExists()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Bucareste", _stateSpaces);
                Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

                romeniaMapProblem.AddChildToParent("Zerind", "Unknown", 0, NodeAction.BACK);
            }
            catch (ArgumentException err)
            {
                Assert.IsTrue(err.Message.Contains("O nome do estado pai 'Unknown', não pertence ao espaço " +
                    "de estados do problema."));
            }
        }


        [TestMethod]
        public void AddChildToParentWhenChildNodeNameDoenstExists()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Bucareste", _stateSpaces);
                Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

                romeniaMapProblem.AddChildToParent("Unknown", "Arad", 0, NodeAction.BACK);
            }
            catch (ArgumentException err)
            {
                Assert.IsTrue(err.Message.Contains("O nome do estado filho 'Unknown', não pertence ao espaço " +
                    "de estados do problema."));
            }
        }


        [TestMethod]
        public void AddChildToParent()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Bucareste", _stateSpaces);
            Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

            romeniaMapProblem.AddChildToParent("Zerind", "Arad", 75, NodeAction.BACK);
            Assert.AreEqual(romeniaMapProblem.Nodes.Count, 3);
        }


        [TestMethod]
        public void AddFortyEighteenChildrenToParent()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Bucareste", _stateSpaces);
            Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

            AddNodesToProblem(ref romeniaMapProblem);
            Assert.AreEqual(romeniaMapProblem.Nodes.Count, 48);
        }



        [TestMethod]
        public void SearchTreeFromAradToArad()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Arad", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);
            
            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State, "Arad");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode, null);
            Assert.AreEqual(romeniaMapProblem.SolutionNode.CostOfTheWay, 0); 
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, NodeAction.UNDEFINED);
        }


        [TestMethod]
        public void SearchTreeFromAradToZerind()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Zerind", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State, "Zerind");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State, "Arad");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, NodeAction.GO);
            Assert.AreEqual(romeniaMapProblem.CostOfTheWay, 333); //<-- Zerind(75) + Sibiu(140) + Timisoara(118)
            Assert.AreEqual(romeniaMapProblem.Depth, 1);
        }


        [TestMethod]
        public void SearchTreeFromAradToSibiu()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Sibiu", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State, "Sibiu");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State, "Arad");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, NodeAction.GO);
            Assert.AreEqual(romeniaMapProblem.CostOfTheWay, 333); //<-- Zerind(75) + Sibiu(140) + Timisoara(118)
            Assert.AreEqual(romeniaMapProblem.Depth, 1);
        }


        [TestMethod]
        public void SearchTreeFromAradToOradea()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Oradea", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State, "Oradea");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State, "Zerind");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, NodeAction.GO);
            Assert.AreEqual(romeniaMapProblem.CostOfTheWay, 404); //<-- Zerind(75) + Sibiu(140) + Timisoara(118) + Oradea(71)
            Assert.AreEqual(romeniaMapProblem.Depth, 2);
        }


        [TestMethod]
        public void SearchTreeFromAradToFagaras()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Fagaras", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State, "Fagaras");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State, "Sibiu");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, NodeAction.GO);
            Assert.AreEqual(romeniaMapProblem.CostOfTheWay, 845); //<-- Zerind(75) + Sibiu(140) + Timisoara(118) + Oradea(71) + Lugoj(111) + Fagaras(99) + Rimnieur Vilcea(80) + Oradea(151)
            Assert.AreEqual(romeniaMapProblem.Depth, 2);
        }


        [TestMethod]
        public void SearchTreeFromAradToBucareste()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Bucareste", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State, "Bucareste");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State, "Fagaras");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, NodeAction.GO);
            Assert.AreEqual(romeniaMapProblem.Depth, 3);
            Assert.IsNotNull(romeniaMapProblem.ActionsAlongTheWay);
        }


        [TestMethod]
        public void SearchTreeFromBucaresteToArad()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Bucareste", "Arad", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State, "Arad");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State, "Sibiu");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, NodeAction.BACK);
            Assert.AreEqual(romeniaMapProblem.Depth, 3);
            Assert.IsNotNull(romeniaMapProblem.ActionsAlongTheWay);
        }


        [TestMethod]
        public void SearchTreeFromAradToNeamt()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Arad", "Neamt", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State, "Neamt");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State, "Nome Apagado");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, NodeAction.GO);
            Assert.AreEqual(romeniaMapProblem.Depth, 7);
        }


        [TestMethod]
        public void SearchTreeFromNeamtToArad()
        {
            var romeniaMapProblem = new RomeniaMapProblemBreadthFirstSearch("Neamt", "Arad", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State, "Arad");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State, "Sibiu");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, NodeAction.BACK);
            Assert.AreEqual(romeniaMapProblem.Depth, 7);
        }
    }
}
