using Tumbleweed.Bits;
using Tumbleweed.Bytes.WithSystem;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.WithSystem.Numerics.Ints32.FromTumbleweed;

public sealed class NumberFromBytes : ScalarEnvelope<int>
{
	public NumberFromBytes(IEnumerable<IEnumerable<IBit>> bytes) : base
	(
		new ScalarOfDelegate<int>(
			() => BitConverter.ToInt32(
				new ReadOnlySpan<byte>(
					new ValuesOfScalars<byte>(
						new BytesFromTumbleweed(bytes)).ToArray())))
	)
	{
	}
}