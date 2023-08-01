using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Listening = Tumbleweed.Event.Listening;
using System = System;

namespace Tumbleweed.Event.Listening;

public sealed class Unsubscribe<T> : Procedure::Envelope
{
	public Unsubscribe
	(
		Listening::List.Any<T> list,
		System::Object key
	) : base
	(
		new Procedure::From.System(
			() => list.Unsubscribe(key))
	)
	{
	}
}