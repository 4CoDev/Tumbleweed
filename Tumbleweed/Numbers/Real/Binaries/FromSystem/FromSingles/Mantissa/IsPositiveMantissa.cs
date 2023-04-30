using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromSingles.Mantissa;

public sealed class IsPositiveMantissa : BooleanEnvelope
{
	public IsPositiveMantissa(IScalar<Single> @float) : base
	(
		new LastBoolean(new BitsOfSingle(@float))
	)
	{
	}
}