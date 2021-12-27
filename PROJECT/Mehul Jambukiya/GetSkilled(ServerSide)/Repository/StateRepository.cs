using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GetSkilled.Entities;

namespace GetSkilled.Repository
{
    public class StateRepository : GenericRepository<State>, IState
    {
        private readonly GetSkilledDbContext context;
        public StateRepository(GetSkilledDbContext context) : base(context)
        {
            this.context = context;
        }
        public override bool DeleteData(int stateId)
        {
            var state = context.States.Find(stateId);
            if (state != null && state.IsDeleted==false)
            {
                state.IsDeleted = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
