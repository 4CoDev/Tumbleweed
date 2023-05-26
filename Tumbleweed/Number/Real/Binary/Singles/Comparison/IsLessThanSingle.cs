using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromSystem;
using Tumbleweed.Scalar;
using BooleanOfFunction = Tumbleweed._Boolean.OfSystem.BooleanOfFunction;

namespace Tumbleweed.Number.Real.Binary.Singles.Comparison;

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