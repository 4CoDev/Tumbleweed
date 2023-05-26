using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromInt32;

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