using Gefest.Contracts.Pipeline;

namespace Gefest.Domain.Pipeline;

public abstract class PipelineBase : IPipeline
{
    private List<Task> _tasks = new List<Task>();
    
    public int Count { get; }
    
    public void AddTask(Task task) => _tasks.Add(task);

    public Task ExecuteAsync() => Task.WhenAll(_tasks);
}