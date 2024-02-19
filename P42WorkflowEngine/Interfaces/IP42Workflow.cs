using System.Collections.Generic;

namespace P42WorkflowEngine.Interfaces;
public interface IP42Workflow
{
    /// <summary>
    /// The steps that the workflow is composed of.
    /// </summary>
    List<IP42WorkflowStep> Steps { get; }

    /// <summary>
    /// Executes the entire workflow.
    /// </summary>
    void Execute();
}