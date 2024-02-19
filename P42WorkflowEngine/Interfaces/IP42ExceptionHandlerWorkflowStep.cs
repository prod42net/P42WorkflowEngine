using System;

namespace P42WorkflowEngine.Interfaces;
public interface IP42ExceptionHandlerWorkflowStep : IP42WorkflowStep
{
    Action<Exception> ExceptionHandler { get; set; } 
}