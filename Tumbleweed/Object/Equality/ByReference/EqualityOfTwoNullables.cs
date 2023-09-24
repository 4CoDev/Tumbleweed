using Tumbleweed.Boolean;
using Tumbleweed.Boolean.Function;
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;

namespace Tumbleweed.Object.Equality.ByReference;

public sealed class EqualityOfTwoNullables : Envelope
{
	public EqualityOfTwoNullables
	(
		System.Object? first,
		System.Object? second
	) : base
	(
		new Result(
			() => new One(
				ReferenceEquals(first, second)))
	)
	{
	}
		
}