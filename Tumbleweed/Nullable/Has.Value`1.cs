using System = System;
using Tumbleweed.Boolean;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Nullable.Has;

public sealed class Value : Envelope
{
	public Value(Any<System::Object> any) : base
	(
		new Boolean.Function.Result(
			() => any.HasValue)
	)
	{
	}
}