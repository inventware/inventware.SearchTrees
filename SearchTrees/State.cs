

namespace SearchTrees
{
    public class State
    {
        public State(int id, string name, string value)
        {
            Id = id;
            Name = name;
            Value = value;
        }


        /// <summary>
        /// Used to orderer Nodes in Mini Problems
        /// </summary>
        public int Id { get; set; }

        public string Name { get; set; }

        public string Value { get; set; }
    }
}