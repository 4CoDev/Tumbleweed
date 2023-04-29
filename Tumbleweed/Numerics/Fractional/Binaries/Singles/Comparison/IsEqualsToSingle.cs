using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Scalars;
using BooleanOfFunction = Tumbleweed.Booleans.OfSystem.BooleanOfFunction;

namespace Tumbleweed.Numerics.Fractional.Binaries.Singles.Comparison;

public sealed class IsEqualsToSingle : BooleanEnvelope
{
	public IsEqualsToSingle
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
	
	public IsEqualsToSingle
	(
		IScalar<Single> first,
		IScalar<Single> second
	) : base
	(
		new BooleanFromSystem(
			new BooleanOfFunction(
				() => second.Value < first.Value))
	)
	{
	}
}