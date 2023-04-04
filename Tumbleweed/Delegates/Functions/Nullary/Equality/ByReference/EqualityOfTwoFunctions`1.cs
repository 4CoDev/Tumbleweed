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
		new EqualityOfTwoObjects(first, second)
	)
	{
	}
}