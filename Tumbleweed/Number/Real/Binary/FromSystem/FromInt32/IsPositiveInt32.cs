using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromEnumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromInt32;

public sealed class IsPositiveInt32 : BooleanEnvelope
{
	public IsPositiveInt32(IScalar<Int32> integer) : base
	(
		new LastBoolean(new BitsOfInt32(integer))
	)
	{
	}
}