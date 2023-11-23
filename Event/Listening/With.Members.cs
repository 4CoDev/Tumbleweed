using Listening = Tumbleweed.Event.Listening;
using System = System;
using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Event.Listening.With;

public sealed class Members<T> : Listening::Any<T>
{
	public Members
	(
		System::Action unsubscribe,
		System::Action subscribe
	) : this
	(
		new Procedure::From.System(unsubscribe),
		new Procedure::From.System(subscribe)
	)
	{
	}

	public Members
	(
		Procedure::Any unsubscribe,
		Procedure::Any subscribe
	)
	{
		this.unsubscribe = unsubscribe;
		this.subscribe = subscribe;
	}

	public void Unsubscribe() =>
		unsubscribe.Invoke();
	
	private readonly Procedure::Any unsubscribe;

	public void Subscribe() =>
		subscribe.Invoke();

	private readonly Procedure::Any subscribe;
}