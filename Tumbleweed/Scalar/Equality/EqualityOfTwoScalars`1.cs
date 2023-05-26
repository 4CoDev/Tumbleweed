using Tumbleweed._Boolean;
using Tumbleweed.Subroutine.Function.Nullary.Equality.ByValues;

namespace Tumbleweed.Scalar.Equality;

public sealed class EqualityOfTwoScalars<T> : BooleanEnvelope
{
	public EqualityOfTwoScalars
	(
		Object first,
		Object second
	) : this
	(
		new ObjectAsScalar<T>(first),
		new ObjectAsScalar<T>(second)
	)
	{
	}
	
	public EqualityOfTwoScalars
	(
		IScalar<T> first,
		IScalar<T> second
	) : base
	(
		new EqualityOfTwoFunctions<T>(
			() => first.Value,
			() => second.Value)
	)
	{
	}
}