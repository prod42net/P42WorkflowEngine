using System;
using System.Collections.Generic;

namespace P42WorkflowEngine.Interfaces;
public interface IP42ConditionalWorkflowStep : IP42WorkflowStep
{
    IP42WorkflowStep ThenStep { get; set; }

    IP42WorkflowStep ElseStep { get; set; }

    Func<List<IP42WorkflowStepInput>, bool> Condition { get; set; }  
}