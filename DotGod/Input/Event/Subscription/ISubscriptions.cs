using Tumbleweed.Event.Subscription;
using Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Input.Event.Subscription;

public interface ISubscriptions
{
	Any<Any> Handled { get; }
	
	Any<Any> Unhandled { get; }
}