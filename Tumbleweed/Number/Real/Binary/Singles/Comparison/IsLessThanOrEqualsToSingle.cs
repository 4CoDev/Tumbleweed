using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.Singles.Comparison;

public sealed class IsLessThanOrEqualsToSingle : BooleanEnvelope
{
	public IsLessThanOrEqualsToSingle
	(
		Single first,
		Single second
	) : this
	(
		new ScalarValue<Single>(first),
		new ScalarValue<Single>(second)
	)
	{
	}
	
	public IsLessThanOrEqualsToSingle
	(
		IScalar<Single> first,
		IScalar<Single> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsEqualsToSingle(first, second),
			new IsLessThanSingle(first, second))
	)
	{
	}
}