using Tumbleweed.Boolean;
using Tumbleweed.Boolean.Function;
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;

namespace Tumbleweed.Object.Equality.ByValues;

public sealed class EqualityOfTwoNullables : Envelope
{
	public EqualityOfTwoNullables
	(
		System.Object? first,
		System.Object? second
	) : base
	(
		new Result(
			() => Function(first, second))
	)
	{
	}

	private static Any Function(System.Object? first, System.Object? second) =>
	(
		new One(
			first == second ||
			first != null && second != null &&
			first.Equals(second))
	);
}