using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromSystem;
using Tumbleweed.Scalar;
using BooleanOfFunction = Tumbleweed._Boolean.OfSystem.BooleanOfFunction;

namespace Tumbleweed.Number.Real.Binary.Singles.Comparison;

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