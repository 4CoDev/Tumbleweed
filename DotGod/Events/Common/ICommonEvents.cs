using DotGod.Events.Input;
using DotGod.Events.Iteration;

namespace DotGod.Events.Common;

public interface ICommonEvents
{
	IIterationEvents Iteration { get; }
	
	IInputEvents Input { get; }
}