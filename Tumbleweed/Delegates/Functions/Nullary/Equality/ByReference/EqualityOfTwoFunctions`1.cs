using Tumbleweed.Bits;
using Tumbleweed.Equality.ByReference;

namespace Tumbleweed.Delegates.Functions.Nullary.Equality.ByReference;

public sealed class EqualityOfTwoFunctions<TResult> : BitEnvelope
{
	public EqualityOfTwoFunctions
	(
		Func<TResult> first,
		Func<TResult> second
	) : this
	(
		new NullaryFromSystem<TResult>(first),
		new NullaryFromSystem<TResult>(second)
	)
	{
	}
	
	public EqualityOfTwoFunctions
	(
		INullaryFunction<TResult> first,
		INullaryFunction<TResult> second
	) : base
	(
		new EqualityOfTwoObjects(first, second)
	)
	{
	}
}