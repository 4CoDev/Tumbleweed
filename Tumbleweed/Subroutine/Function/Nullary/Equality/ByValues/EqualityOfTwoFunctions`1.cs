using Tumbleweed._Boolean;
using Tumbleweed._Object.Equality.ByValues;

namespace Tumbleweed.Subroutine.Function.Nullary.Equality.ByValues;

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