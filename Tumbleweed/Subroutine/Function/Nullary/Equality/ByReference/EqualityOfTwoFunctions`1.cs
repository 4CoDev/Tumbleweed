using Tumbleweed._Boolean;
using Tumbleweed._Object.Equality.ByReference;

namespace Tumbleweed.Subroutine.Function.Nullary.Equality.ByReference;

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
		new EqualityOfTwoObjects(first, second)
	)
	{
	}
}