using Tumbleweed.Boolean;
using Tumbleweed.Object.Equality.ByReference;

namespace Tumbleweed.Subroutine.Function.Nullary.Equality.Referential.Of;

public sealed class Two<TResult> : Envelope
{
	public Two
	(
		Func<TResult> first,
		Func<TResult> second
	) : this
	(
		new Nullary.From.System<TResult>(first),
		new Nullary.From.System<TResult>(second)
	)
	{
	}
	
	public Two
	(
		Nullary.Any<TResult> first,
		Nullary.Any<TResult> second
	) : base
	(
		new EqualityOfTwoObjects(first, second)
	)
	{
	}
}