using SearchTrees;


namespace SearchTreeTest
{
    [TestClass]
    public class StatesSpaceTest
    {
        [TestMethod]
        public void AddStateWhenStateIsNull()
        {
            var statesSpace = new StatesSpace();
            var isAdded = statesSpace.AddState(null);
            Assert.IsFalse(isAdded);
        }

        [TestMethod]
        public void AddStateWhenIdStateIsNegative()
        {
            var statesSpace = new StatesSpace();
            var state = new State(int.MinValue, "NAME", "VALUE");

            var isAdded = statesSpace.AddState(state);
            Assert.IsFalse(isAdded);
        }

        [TestMethod]
        public void AddStateWhenIdStateIsZero()
        {
            var statesSpace = new StatesSpace();
            var state = new State(0, "NAME", "VALUE");

            var isAdded = statesSpace.AddState(state);
            Assert.IsTrue(isAdded);
        }

        [TestMethod]
        public void AddStateWhenNameIsNull()
        {
            var statesSpace = new StatesSpace();
            var state = new State(1, null, "VALUE");

            var isAdded = statesSpace.AddState(state);
            Assert.IsFalse(isAdded);
        }

        [TestMethod]
        public void AddStateWhenNameIsEmpty()
        {
            var statesSpace = new StatesSpace();
            var state = new State(1, String.Empty, "VALUE");

            var isAdded = statesSpace.AddState(state);
            Assert.IsFalse(isAdded);
        }

        [TestMethod]
        public void AddStateWhenValueIsNull()
        {
            var statesSpace = new StatesSpace();
            var state = new State(1, "NAME", null);

            var isAdded = statesSpace.AddState(state);
            Assert.IsFalse(isAdded);
        }

        [TestMethod]
        public void AddStateWhenValueIsEmpty()
        {
            var statesSpace = new StatesSpace();
            var state = new State(1, "NAME", String.Empty);

            var isAdded = statesSpace.AddState(state);
            Assert.IsFalse(isAdded);
        }

        [TestMethod]
        public void AddStateWhenInsertOneValidState()
        {
            var statesSpace = new StatesSpace();
            var state = new State(1, "NAME", "VALUE");

            var isAdded = statesSpace.AddState(state);
            Assert.IsTrue(isAdded);
            Assert.AreEqual(statesSpace.GetAllStatesOfSpace().Count, 1);
        }

        [TestMethod]
        public void AddStateWhenThereIsAnotherStateWithTheSameId()
        {
            var statesSpace = new StatesSpace();
            var isAdded = statesSpace.AddState(new State(1, "NAME", "VALUE"));
            Assert.IsTrue(isAdded);
            Assert.AreEqual(statesSpace.GetAllStatesOfSpace().Count, 1);

            isAdded = statesSpace.AddState(new State(1, "OTHER_NAME", "OTHER_VALUE"));
            Assert.IsFalse(isAdded);
            Assert.AreEqual(statesSpace.GetAllStatesOfSpace().Count, 1);
        }
    }
}