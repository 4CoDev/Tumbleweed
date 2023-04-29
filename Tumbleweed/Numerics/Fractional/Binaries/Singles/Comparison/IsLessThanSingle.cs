using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Scalars;
using BooleanOfFunction = Tumbleweed.Booleans.OfSystem.BooleanOfFunction;

namespace Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;

public sealed class IsLessThanSingle : BooleanEnvelope
{
	public IsLessThanSingle
	(
		Single smaller,
		Single larger
	) : this
	(
		new ScalarValue<Single>(smaller),
		new ScalarValue<Single>(larger)
	)
	{
	}
	
	public IsLessThanSingle
	(
		IScalar<Single> smaller,
		IScalar<Single> larger
	) : base
	(
		new BooleanFromSystem(
			new BooleanOfFunction(
				() => larger.Value < smaller.Value))
	)
	{
	}
}