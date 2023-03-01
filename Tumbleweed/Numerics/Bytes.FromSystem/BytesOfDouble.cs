using Tumbleweed.Bits;
using Tumbleweed.Bytes.FromSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Numerics.Bytes.FromSystem;

public sealed class BytesOfDouble : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesOfDouble(IScalar<double> @double) : base
	(
		new BytesFromSystem(
			new EnumerableOfDelegate<byte>(
				() => BitConverter.GetBytes(@double.Value)))
	)
	{
	}
}