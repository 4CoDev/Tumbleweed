
using Tumbleweed.Mathematics.Boolean;
using Tumbleweed.Mathematics.Boolean.Function.Result;
using Tumbleweed.Object.Equality.ByValues;
using Tumbleweed.Subroutine.Function.Nullary.From;

namespace Tumbleweed.Subroutine.Function.Nullary.Equality.Structural.Of;

public sealed class Two<TResult> : Envelope
{
	public Two
	(
		Func<TResult> first,
		Func<TResult> second
	) : this
	(
		new System<TResult>(first),
		new System<TResult>(second)
	)
	{
	}
	
	public Two
	(
		Any<TResult> first,
		Any<TResult> second
	) : base
	(
		new Actual(
			() => new EqualityOfTwoNullables(
				first.Result,
				second.Result))
	)
	{
	}
}