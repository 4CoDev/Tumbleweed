using Procedure = Tumbleweed.Subroutine.Procedure.Nullary;
using Listening = Tumbleweed.Event.Listening;
using System = System;

namespace Tumbleweed.Event.Listening;

public sealed class Subscribe<T> : Procedure::Envelope
{
	public Subscribe
	(
		Listening::List.Any<T> list,
		System::Object key,
		T reaction
	) : base
	(
		new Procedure::From.System(
			() => list.Subscribe(key, reaction))
	)
	{
	}
}