
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.From.System;
using Tumbleweed.Mathematics.Boolean.Function.Result;

namespace Tumbleweed.Object.Equality.ByValues;

public sealed class EqualityOfTwoNullables : Envelope
{
	public EqualityOfTwoNullables
	(
		System.Object? first,
		System.Object? second
	) : base
	(
		new Actual(
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