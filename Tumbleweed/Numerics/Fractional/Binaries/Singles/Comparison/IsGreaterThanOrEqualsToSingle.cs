using Tumbleweed.Booleans;
using Tumbleweed.Booleans.Algebra;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;

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