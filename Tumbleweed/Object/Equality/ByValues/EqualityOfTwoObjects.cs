using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Mathematics.Boolean.System.Function.Result;

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
			new Actual(
				() => first.Equals(second)))
	)
	{
	}
}