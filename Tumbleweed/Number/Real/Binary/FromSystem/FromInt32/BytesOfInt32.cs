using Tumbleweed._Boolean;
using Tumbleweed._Byte.FromSystem;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed.Number.Real.Binary.FromSystem.FromInt32;

public sealed class BytesOfInt32 : EnumerableEnvelope<IEnumerable<IBoolean>>
{
	public BytesOfInt32(IScalar<Int32> integer) : base
	(
		new BytesFromSystem(
			new EnumerableOfFunction<Byte>(
				() => BitConverter.GetBytes(integer.Value)))
	)
	{
	}
}