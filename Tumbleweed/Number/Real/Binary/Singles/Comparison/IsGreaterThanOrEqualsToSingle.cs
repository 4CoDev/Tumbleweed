using Tumbleweed._Boolean;
using Tumbleweed._Boolean.Algebra;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.Singles.Comparison;

public sealed class IsGreaterThanOrEqualsToSingle : BooleanEnvelope
{
	public IsGreaterThanOrEqualsToSingle
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
	
	public IsGreaterThanOrEqualsToSingle
	(
		IScalar<Single> first,
		IScalar<Single> second
	) : base
	(
		new OrOfTwoBooleans(
			new IsEqualsToSingle(first, second),
			new IsGreaterThanSingle(first, second))
	)
	{
	}
}