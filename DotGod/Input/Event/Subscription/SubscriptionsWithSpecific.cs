using Tumbleweed.Event.Listening.List;
using Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Input.Event.Subscription;

public sealed class SubscriptionsWithSpecific : ISubscriptions
{
	public SubscriptionsWithSpecific
	(
		Any<Any> handled,
		Any<Any> unhandled
	)
	{
		Handled = handled;
		Unhandled = unhandled;
	}


	public Any<Any> Handled { get; }

	public Any<Any> Unhandled { get; }
}