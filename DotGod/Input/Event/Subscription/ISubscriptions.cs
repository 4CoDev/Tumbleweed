using Tumbleweed.Event.Listening.List;
using Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Input.Event.Subscription;

public interface ISubscriptions
{
	Any<Any> Handled { get; }
	
	Any<Any> Unhandled { get; }
}