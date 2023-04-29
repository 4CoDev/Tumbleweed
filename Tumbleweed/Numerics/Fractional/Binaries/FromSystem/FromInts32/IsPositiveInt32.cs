using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromEnumerable;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Fractional.Binaries.FromSystem.FromInts32;

public sealed class IsPositiveInt32 : BooleanEnvelope
{
	public IsPositiveInt32(IScalar<Int32> integer) : base
	(
		new LastBoolean(new BitsOfInt32(integer))
	)
	{
	}
}