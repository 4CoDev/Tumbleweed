using DotGod.Delegates.Events.Input;
using DotGod.Delegates.Events.Iteration;

namespace DotGod.Delegates.Events.Common;

public interface ICommonEvents
{
	IIterationEvents Iteration { get; }
	
	IInputEvents Input { get; }
}