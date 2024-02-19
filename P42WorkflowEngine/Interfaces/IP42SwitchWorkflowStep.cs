using System;
using System.Collections.Generic;

namespace P42WorkflowEngine.Interfaces;
public interface IP42SwitchWorkflowStep: IP42WorkflowStep
{
    Dictionary<Func<List<IP42WorkflowStepInput>, bool>, IP42WorkflowStep> Cases { get; set; }   
}