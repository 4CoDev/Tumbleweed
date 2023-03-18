using TumbleGD.Delegates.Events.Input;
using TumbleGD.Delegates.Events.Iteration;

namespace TumbleGD.Delegates.Events.Common;

public interface ICommonEvents
{
	IIterationEvents Iteration { get; }
	
	IInputEvents Input { get; }
}