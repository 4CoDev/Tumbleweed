using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromSystem;
using Tumbleweed.Scalar;
using BooleanOfFunction = Tumbleweed._Boolean.OfSystem.BooleanOfFunction;

namespace Tumbleweed.Number.Real.Binary.Singles.Comparison;

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