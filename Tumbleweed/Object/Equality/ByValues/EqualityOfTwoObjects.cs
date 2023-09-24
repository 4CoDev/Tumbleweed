using Tumbleweed.Boolean;
using Tumbleweed.Boolean.System.Function;
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;

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