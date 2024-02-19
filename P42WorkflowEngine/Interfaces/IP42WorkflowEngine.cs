namespace P42WorkflowEngine.Interfaces;
public interface IP42WorkflowEngine
{
    /// <summary>
    /// The Workflows that the engine can execute.
    /// </summary>
    List<IP42Workflow> Workflows { get; set; }

    /// <summary>
    /// Adds a workflow to the engine.
    /// </summary>
    void AddWorkflow(IP42Workflow workflow);

    /// <summary>
    /// Removes a workflow from the engine.
    /// </summary>
    void RemoveWorkflow(IP42Workflow workflow);

    /// <summary>
    /// Executes all the workflows added to the engine.
    /// </summary>
    void ExecuteAll();  
}