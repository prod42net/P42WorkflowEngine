namespace P42WorkflowEngine.Interfaces;
public interface IP42WorkflowStep
{
    WorkflowStepType StepType { get; }
    /// <summary>
    /// The inputs to the step.
    /// </summary>
    List<IP42WorkflowStepInput> Inputs { get; set; }

    /// <summary>
    /// The outputs from the step.
    /// </summary>
    List<IP42WorkflowStepOutput> Outputs { get; set; }

    /// <summary>
    /// Performs the step using the provided inputs and produces outputs.
    /// </summary>
    void Perform(List<IP42WorkflowStepInput> inputs);
}