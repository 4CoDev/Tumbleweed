using Event = Tumbleweed.Event.Nullary;
using List = Tumbleweed.Event.Listening.List;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Nullary.With;

public sealed class Members : Event::Any
{
	public Members
	(
		List::Any<Procedure::Any> subscription,
		System::Action invoke
	) : this
	(
		subscription,
		new Procedure::From.System(invoke)
	)
	{
	}
	
	public Members
	(
		List::Any<Procedure::Any> subscription,
		Procedure::Any invoke
	)
	{
		Listeners = subscription;
		this.invoke = invoke;
	}
	
	public List::Any<Procedure::Any> Listeners { get; }

	public void Invoke() =>
		invoke.Invoke();
	
	private readonly Procedure::Any invoke;
}