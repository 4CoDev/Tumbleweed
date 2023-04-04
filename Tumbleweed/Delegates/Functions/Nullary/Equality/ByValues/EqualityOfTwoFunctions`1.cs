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
		new FunctionFromSystem<TResult>(first),
		new FunctionFromSystem<TResult>(second)
	)
	{
	}
	
	public EqualityOfTwoFunctions
	(
		INullaryFunction<TResult> first,
		INullaryFunction<TResult> second
	) : base
	(
		new BitOfFunction(
			() => new EqualityOfTwoNullables(
				first.Invoke(),
				second.Invoke()))
	)
	{
	}
}