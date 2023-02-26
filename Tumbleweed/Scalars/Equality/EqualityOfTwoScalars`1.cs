using Tumbleweed.Bits;
using Tumbleweed.Delegates.Functions.Nullary.Equality.ByValues;

namespace Tumbleweed.Scalars.Equality;

public sealed class EqualityOfTwoScalars<T> : BitEnvelope
{
	public EqualityOfTwoScalars
	(
		object first,
		object second
	) : this
	(
		new ScalarFromObject<T>(first),
		new ScalarFromObject<T>(second)
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