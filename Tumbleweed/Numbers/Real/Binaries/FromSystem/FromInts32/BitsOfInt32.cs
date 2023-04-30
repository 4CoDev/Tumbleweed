using Tumbleweed.Booleans;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numbers.Real.Binaries.FromSystem.FromInts32;

public sealed class BitsOfInt32 : EnumerableEnvelope<IBoolean>
{
	public BitsOfInt32(IScalar<Int32> integer) : base
	(
		new BitsOfBytes(
			new BytesOfInt32(integer))
	)
	{
	}
}