using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Controller.Interface
{
    public interface IAgentController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="firtsName"></param>
        /// <returns></returns>
        AgentModel getAgentById(string agent, string firtsName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        void createAgent(AgentModel model);

        IEnumerable<AgentModel> getAllAgent();



    }
}
