using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleSystem.Bytes.FromSystem;

public sealed class BytesFromSystem : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesFromSystem(IEnumerable<byte> bytes) : this
	(
		new ScalarsOfValues<byte>(bytes)
	)
	{
	}
	
	public BytesFromSystem(IEnumerable<IScalar<byte>> bytes) : base
	(
		new SelectedByExpression<IScalar<byte>, IEnumerable<IBit>>(
			bytes,
			@byte => new ByteFromSystem(@byte))
	)
	{
	}
}