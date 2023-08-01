using Tumbleweed.Event.Listening.List;
using NullaryProcedure = Tumbleweed.Subroutine.Procedure.Nullary;

namespace DotGod.Iteration.Event.Subscription;

public sealed class SubscriptionsWithSpecific : Any
{
	public SubscriptionsWithSpecific
	(
		Any<NullaryProcedure.Any> graphical,
		Any<NullaryProcedure.Any> physical
	)
	{
		Graphical = graphical;
		Physical = physical;
	}
	
	public Any<NullaryProcedure.Any> Graphical { get; }

	public Any<NullaryProcedure.Any> Physical { get; }
}