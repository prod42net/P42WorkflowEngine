namespace P42WorkflowEngine;
public enum WorkflowStepType
{
    Normal,
    Conditional,
    Switch,
    Loop,
    Parallel,
    Sequential,
    Delay,
    SubWorkflow,
    ExceptionHandler
}