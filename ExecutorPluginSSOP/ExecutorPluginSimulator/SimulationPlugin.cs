using DistributedExperimentation.DataModel;
using DistributedExperimentation.Experimenter.ExecutorPlugin;
using System;

namespace ExecutorPluginSimulator
{
    public class SimulationPlugin : IExecutorPlugin
    {
        public void execute(IExperimentSeries experimentSeries)
        {
            var experiment = (IParameterList)experimentSeries.getExperiments();
            for (uint i = 0; i < experiment.count(); i++)
            {
                var parameter = experiment.get(i);
                if(parameter.getValue().isPrimitive())
                {
                    
                    
                } else
                {
                    for (int j = 0; j < length; j++)
                    {

                    }
                }
                
            }



        }
    }
}
