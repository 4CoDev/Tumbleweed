using Tumbleweed.Bits;
using Tumbleweed.Equality.ByValues;

namespace Tumbleweed.Delegates.Functions.Nullary.Equality.ByValues;

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
		new BitOfDelegate(
			() => new EqualityOfTwoNullables(
				first.Invoke(),
				second.Invoke()))
	)
	{
	}
}