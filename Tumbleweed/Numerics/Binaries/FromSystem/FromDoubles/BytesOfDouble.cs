using Tumbleweed.Bits;
using Tumbleweed.Bytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Binaries.FromSystem.FromDoubles;

public sealed class BytesOfDouble : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesOfDouble(IScalar<Double> @double) : base
	(
		new BytesFromSystem(
			new EnumerableOfDelegate<Byte>(
				() => BitConverter.GetBytes(@double.Value)))
	)
	{
	}
}