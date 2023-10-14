
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Mathematics.Boolean.Function.Result;

namespace Tumbleweed.Object.Equality.ByReference;

public sealed class EqualityOfTwoNullables : Envelope
{
	public EqualityOfTwoNullables
	(
		System.Object? first,
		System.Object? second
	) : base
	(
		new Actual(
			() => new One(
				ReferenceEquals(first, second)))
	)
	{
	}
		
}