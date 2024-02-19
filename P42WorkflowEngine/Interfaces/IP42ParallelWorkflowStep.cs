using System.Collections.Generic;

namespace P42WorkflowEngine.Interfaces;
public interface IP42ParallelWorkflowStep : IP42WorkflowStep
{
    List<IP42WorkflowStep> ParallelSteps { get; set; }
}