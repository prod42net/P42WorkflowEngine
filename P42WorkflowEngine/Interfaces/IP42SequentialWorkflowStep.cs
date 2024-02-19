using System.Collections.Generic;

namespace P42WorkflowEngine.Interfaces;
public interface IP42SequentialWorkflowStep : IP42WorkflowStep
{
    List<IP42WorkflowStep> SequentialSteps { get; set; }
}