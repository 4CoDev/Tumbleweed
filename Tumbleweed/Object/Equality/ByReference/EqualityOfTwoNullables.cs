using Tumbleweed.Boolean;
using Tumbleweed.Boolean.From.System;
using Tumbleweed.Boolean.Function;

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