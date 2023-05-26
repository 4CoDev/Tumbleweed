using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.ToSystem.Singles;

public sealed class SingleFromReal : ScalarEnvelope<Single>
{
	public SingleFromReal(IReal real) : base
	(
		new SingleFromBits(
			new EnumerableWithElements<IBoolean>(
				real.Mantissa.Natural.Bits,
				real.Exponent.Natural.Bits,
				new EnumerableWithElements<IBoolean>(
					real.Exponent.IsPositive,
					real.Mantissa.IsPositive)))
	)
	{
	}

}