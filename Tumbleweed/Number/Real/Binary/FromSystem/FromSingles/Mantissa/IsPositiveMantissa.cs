using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromEnumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromSingles.Mantissa;

public sealed class IsPositiveMantissa : BooleanEnvelope
{
	public IsPositiveMantissa(IScalar<Single> @float) : base
	(
		new LastBoolean(new BitsOfSingle(@float))
	)
	{
	}
}