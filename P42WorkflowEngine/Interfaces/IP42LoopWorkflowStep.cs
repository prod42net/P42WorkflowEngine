using System;
using System.Collections.Generic;

namespace P42WorkflowEngine.Interfaces;
public interface IP42LoopWorkflowStep: IP42WorkflowStep
{
    IP42WorkflowStep LoopStep { get; set; }

    Func<List<IP42WorkflowStepInput>, bool> LoopCondition { get; set; }
}