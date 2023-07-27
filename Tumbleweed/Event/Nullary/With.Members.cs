using NullaryEvent = Tumbleweed.Event.Nullary;
using NullaryProcedure = Tumbleweed.Subroutine.Procedure.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Nullary.With;

public sealed class Members : NullaryEvent.Any
{
	public Members
	(
		Subscription.Any<NullaryProcedure.Any> subscription,
		Action invoke
	) : this
	(
		subscription,
		new NullaryProcedure.From.System(invoke)
	)
	{
	}
	
	public Members
	(
		Subscription.Any<NullaryProcedure.Any> subscription,
		NullaryProcedure.Any invoke
	)
	{
		Subscription = subscription;
		this.invoke = invoke;
	}
	
	public Subscription.Any<NullaryProcedure.Any> Subscription { get; }

	public void Invoke() =>
		invoke.Invoke();
	
	private readonly NullaryProcedure.Any invoke;
}