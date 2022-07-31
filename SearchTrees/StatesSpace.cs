using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchTrees
{
    public class StatesSpace : IStatesSpace
    {
        private IList<State> _states;

        public StatesSpace()
        {
            _states = new List<State>();
        }

        public bool AddState(State state)
        {
            if (!IsStateIsNull(state))
            {
                _states.Add(state);
                return true;
            };
            return false;
        }

        private bool IsStateIsNull(State state)
        {
            if (state == null){
                return true;
            }
            return IsStateFieldsIsNullOrEmpty(state);
        }

        private bool IsStateFieldsIsNullOrEmpty(State state)
        {
            if (state.Id < 0 || string.IsNullOrEmpty(state.Name) || string.IsNullOrEmpty(state.Value)){
                return true;
            }
            return ThereIsAnotherStateWithTheSameId(state);
        }

        private bool ThereIsAnotherStateWithTheSameId(State state)
        {
            if (_states.Any(field => field.Id.Equals(state.Id))){
                return true;
            }
            return false;
        }



        public IList<State> GetStatesByTheParent(int idParentNode)
        {
            throw new NotImplementedException();
        }

        public IList<State> GetAllStatesOfSpace()
        {
            return _states.ToList();
        }
    }
}
