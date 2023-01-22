using Tumbleweed.Bits.WithSystem.FromBytes;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bits.WithSystem;

public sealed class BitsOfInt32 : EnumerableEnvelope<IBit>
{
	public BitsOfInt32(IScalar<int> integer) : base
	(
		new BitsFromBytes(
			new ScalarsOfValues<byte>(
				new EnumerableOfScalar<byte>(
					new ScalarOfDelegate<IEnumerable<byte>>(
						() => BitConverter.GetBytes(integer.Value())))))
	)
	{
	}
}