using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTrees
{
    internal interface IStatesSpace
    {
        IList<State> GetAllStatesOfSpace();

        IList<State> GetStatesByTheParent(int idParentNode);

        bool AddState(State state);
    }
}
