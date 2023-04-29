using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Scalars;
using BooleanOfFunction = Tumbleweed.Booleans.OfSystem.BooleanOfFunction;

namespace Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;

public sealed class IsGreaterThanSingle : BooleanEnvelope
{
	public IsGreaterThanSingle
	(
		Single larger,
		Single smaller
	) : this
	(
		new ScalarValue<Single>(larger),
		new ScalarValue<Single>(smaller)
	)
	{
	}
	
	public IsGreaterThanSingle
	(
		IScalar<Single> larger,
		IScalar<Single> smaller
	) : base
	(
		new BooleanFromSystem(
			new BooleanOfFunction(
				() => larger.Value > smaller.Value))
	)
	{
	}
}