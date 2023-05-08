using Tumbleweed.Booleans;
using Tumbleweed.Equality.ByValues;

namespace Tumbleweed.Delegates.Functions.Nullary.Equality.ByValues;

public sealed class EqualityOfTwoFunctions<TResult> : BooleanEnvelope
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
		IFunction<TResult> first,
		IFunction<TResult> second
	) : base
	(
		new BooleanOfFunction(
			() => new EqualityOfTwoNullables(
				first.Result,
				second.Result))
	)
	{
	}
}