namespace P42WorkflowEngine.Interfaces;
public interface IP42DelayWorkflowStep: IP42WorkflowStep
{
    IP42Workflow SubWorkflow { get; set; }
}