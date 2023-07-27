using Tumbleweed.Boolean;
using Tumbleweed.Boolean.From.System;
using Tumbleweed.Boolean.System.Function;

namespace Tumbleweed.Object.Equality.ByValues;

public sealed class EqualityOfTwoObjects : Envelope
{
	public EqualityOfTwoObjects
	(
		System.Object first,
		System.Object second
	) : base
	(
		new One(
			new Result(
				() => first.Equals(second)))
	)
	{
	}
}