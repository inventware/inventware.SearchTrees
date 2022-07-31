using SearchTrees;


namespace SearchTreeTest
{
    [TestClass]
    public class RomeniaMapProblemWithStatesSpaceTest
    {
        private StatesSpace _stateSpaces;

        [TestInitialize]
        public void Initialize()
        {
            AddSatesSpace();
        }

        private void AddSatesSpace()
        {
            _stateSpaces = new StatesSpace();
            var isAdded = _stateSpaces.AddState(new State(0, "Arad", "1"));
            isAdded = _stateSpaces.AddState(new State(1, "Zerind", "1"));
            isAdded = _stateSpaces.AddState(new State(2, "Oradea", "1"));
            isAdded = _stateSpaces.AddState(new State(3, "Timisoara", "1"));
            isAdded = _stateSpaces.AddState(new State(4, "Sibiu", "1"));
            isAdded = _stateSpaces.AddState(new State(5, "Lugoj", "1"));
            isAdded = _stateSpaces.AddState(new State(6, "Mehadia", "1"));
            isAdded = _stateSpaces.AddState(new State(7, "Dobreta", "1"));
            isAdded = _stateSpaces.AddState(new State(8, "Craiova", "1"));
            isAdded = _stateSpaces.AddState(new State(9, "Rimnieu Vilcea", "1"));
            isAdded = _stateSpaces.AddState(new State(10, "Pitesti", "1"));
            isAdded = _stateSpaces.AddState(new State(11, "Fagaras", "1"));
            isAdded = _stateSpaces.AddState(new State(12, "Bucareste", "1"));
            isAdded = _stateSpaces.AddState(new State(13, "Giurgiu", "1"));
            isAdded = _stateSpaces.AddState(new State(14, "Urziceni", "1"));
            isAdded = _stateSpaces.AddState(new State(15, "Neamt", "1"));
            isAdded = _stateSpaces.AddState(new State(16, "Nome Apagado", "1"));
            isAdded = _stateSpaces.AddState(new State(17, "Vaslui", "1"));
            isAdded = _stateSpaces.AddState(new State(18, "Hirsova", "1"));
            isAdded = _stateSpaces.AddState(new State(19, "Eforie", "1"));
        }

        private void AddNodesToProblem(ref RomeniaMapProblemWithStatesSpace romeniaMapProblem)
        {
            romeniaMapProblem.AddChildToParent("Zerind", "Arad", 75);
            romeniaMapProblem.AddChildToParent("Arad", "Zerind", 75);
            romeniaMapProblem.AddChildToParent("Sibiu", "Arad", 140);
            romeniaMapProblem.AddChildToParent("Arad", "Sibiu", 140);
            romeniaMapProblem.AddChildToParent("Timisoara", "Arad", 118);
            romeniaMapProblem.AddChildToParent("Arad", "Timisoara", 118);
            romeniaMapProblem.AddChildToParent("Oradea", "Zerind", 71);
            romeniaMapProblem.AddChildToParent("Zerind", "Oradea", 71);
            romeniaMapProblem.AddChildToParent("Sibiu", "Oradea", 151);
            romeniaMapProblem.AddChildToParent("Oradea", "Sibiu", 151);
            romeniaMapProblem.AddChildToParent("Lugoj", "Timisoara", 111);
            romeniaMapProblem.AddChildToParent("Timisoara", "Lugoj", 111);
            romeniaMapProblem.AddChildToParent("Mehadia", "Lugoj", 70);
            romeniaMapProblem.AddChildToParent("Lugoj", "Mehadia", 70);
            romeniaMapProblem.AddChildToParent("Dobreta", "Mehadia", 75);
            romeniaMapProblem.AddChildToParent("Mehadia", "Dobreta", 75);
            romeniaMapProblem.AddChildToParent("Craiova", "Dobreta", 120);
            romeniaMapProblem.AddChildToParent("Dobreta", "Craiova", 120);
            romeniaMapProblem.AddChildToParent("Pitesti", "Craiova", 138);
            romeniaMapProblem.AddChildToParent("Craiova", "Pitesti", 138);
            romeniaMapProblem.AddChildToParent("Rimnieu Vilcea", "Craiova", 146);
            romeniaMapProblem.AddChildToParent("Craiova", "Rimnieu Vilcea", 146);
            romeniaMapProblem.AddChildToParent("Rimnieu Vilcea", "Sibiu", 80);
            romeniaMapProblem.AddChildToParent("Sibiu", "Rimnieu Vilcea", 80);
            romeniaMapProblem.AddChildToParent("Fagaras", "Sibiu", 99);
            romeniaMapProblem.AddChildToParent("Sibiu", "Fagaras", 99);
            romeniaMapProblem.AddChildToParent("Bucareste", "Fagaras", 211);
            romeniaMapProblem.AddChildToParent("Fagaras", "Bucareste", 211);
            romeniaMapProblem.AddChildToParent("Pitesti", "Rimnieu Vilcea", 97);
            romeniaMapProblem.AddChildToParent("Rimnieu Vilcea", "Pitesti", 97);
            romeniaMapProblem.AddChildToParent("Bucareste", "Pitesti", 101);
            romeniaMapProblem.AddChildToParent("Pitesti", "Bucareste", 101);
            romeniaMapProblem.AddChildToParent("Giurgiu", "Bucareste", 90);
            romeniaMapProblem.AddChildToParent("Bucareste", "Giurgiu", 90);
            romeniaMapProblem.AddChildToParent("Urziceni", "Bucareste", 85);
            romeniaMapProblem.AddChildToParent("Bucareste", "Urziceni", 85);
            romeniaMapProblem.AddChildToParent("Hirsova", "Urziceni", 98);
            romeniaMapProblem.AddChildToParent("Urziceni", "Hirsova", 98);
            romeniaMapProblem.AddChildToParent("Eforie", "Hirsova", 86);
            romeniaMapProblem.AddChildToParent("Hirsova", "Eforie", 86);
            romeniaMapProblem.AddChildToParent("Vaslui", "Urziceni", 142);
            romeniaMapProblem.AddChildToParent("Urziceni", "Vaslui", 142);
            romeniaMapProblem.AddChildToParent("Nome Apagado", "Vaslui", 92);
            romeniaMapProblem.AddChildToParent("Vaslui", "Nome Apagado", 92);
            romeniaMapProblem.AddChildToParent("Neamt", "Nome Apagado", 87);
            romeniaMapProblem.AddChildToParent("Nome Apagado", "Neamt", 87);
        }


        [TestMethod]
        public void WhenTheInitialStateNameNotBelongsTo()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Uberlândia", string.Empty, _stateSpaces);
            }
            catch (ArgumentException err)
            {
                Assert.AreEqual(err.Message, "O nome do estado 'Uberlândia', não pertence ao espaço de estados do problema.");
            }
        }


        [TestMethod]
        public void WhenTheInitialStateNameIsEmpty()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace(string.Empty, "Bucareste", _stateSpaces);
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
                var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", string.Empty, _stateSpaces);
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
                var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Uberlândia", _stateSpaces);
            }
            catch (ArgumentException err)
            {
                Assert.AreEqual(err.Message, "O nome do estado 'Uberlândia', não pertence ao espaço de estados do problema.");
            }
        }


        [TestMethod]
        public void WhenTheInitialStateNameGetMatchWithStatesSpace()
        {
            var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Bucareste", _stateSpaces);
            Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);
        }


        [TestMethod]
        public void AddChildToParentWhenChildNodeNameIsEmpty()
        {
            try
            {
                var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Bucareste", _stateSpaces);
                Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

                romeniaMapProblem.AddChildToParent(string.Empty, "Zerind", 0);
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
                var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Bucareste", _stateSpaces);
                Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

                romeniaMapProblem.AddChildToParent("Arad", string.Empty, 0);
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
                var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Bucareste", _stateSpaces);
                Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

                romeniaMapProblem.AddChildToParent("Zerind", "Unknown", 0);
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
                var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Bucareste", _stateSpaces);
                Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

                romeniaMapProblem.AddChildToParent("Unknown", "Arad", 0);
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
            var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Bucareste", _stateSpaces);
            Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

            romeniaMapProblem.AddChildToParent("Zerind", "Arad", 75);
            Assert.AreEqual(romeniaMapProblem.Nodes.Count, 3);
        }


        [TestMethod]
        public void AddFortyEighteenChildrenToParent()
        {
            var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Bucareste", _stateSpaces);
            Assert.AreEqual(romeniaMapProblem.Nodes.Count, 2);

            AddNodesToProblem(ref romeniaMapProblem);
            Assert.AreEqual(romeniaMapProblem.Nodes.Count, 48);
        }



        [TestMethod]
        public void SearchTreeFromAradToArad()
        {
            var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Arad", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);
            
            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State.Name, "Arad");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode, null);
            Assert.AreEqual(romeniaMapProblem.SolutionNode.CostOfTheWay, 0); 
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, "");
        }


        [TestMethod]
        public void SearchTreeFromAradToZerind()
        {
            var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Zerind", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State.Name, "Zerind");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State.Name, "Arad");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, "GoTo");
            Assert.AreEqual(romeniaMapProblem.costOfTheWay, 333); //<-- Zerind(75) + Sibiu(140) + Timisoara(118)
            Assert.AreEqual(romeniaMapProblem.Depth, 1);
        }


        [TestMethod]
        public void SearchTreeFromAradToSibiu()
        {
            var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Sibiu", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State.Name, "Sibiu");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State.Name, "Arad");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, "GoTo");
            Assert.AreEqual(romeniaMapProblem.costOfTheWay, 333); //<-- Zerind(75) + Sibiu(140) + Timisoara(118)
            Assert.AreEqual(romeniaMapProblem.Depth, 1);
        }


        [TestMethod]
        public void SearchTreeFromAradToOradea()
        {
            var romeniaMapProblem = new RomeniaMapProblemWithStatesSpace("Arad", "Oradea", _stateSpaces);
            AddNodesToProblem(ref romeniaMapProblem);

            romeniaMapProblem.SearchTree();

            Assert.AreEqual(romeniaMapProblem.SolutionNode.State.Name, "Oradea");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.ParentNode.State.Name, "Zerind");
            Assert.AreEqual(romeniaMapProblem.SolutionNode.Action, "GoTo");
            Assert.AreEqual(romeniaMapProblem.costOfTheWay, 404); //<-- Zerind(75) + Sibiu(140) + Timisoara(118) + Oradea(71)
            Assert.AreEqual(romeniaMapProblem.Depth, 1);
        }
    }
}
