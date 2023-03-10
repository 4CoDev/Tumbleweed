using Tumbleweed.Bits;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace Tumbleweed.Bytes.FromSystem;

public sealed class BytesFromSystem : EnumerableEnvelope<IEnumerable<IBit>>
{
	public BytesFromSystem(IEnumerable<Byte> bytes) : this
	(
		new ScalarsOfValues<Byte>(bytes)
	)
	{
	}
	
	public BytesFromSystem(IEnumerable<IScalar<Byte>> bytes) : base
	(
		new SelectedByExpression<IScalar<Byte>, IEnumerable<IBit>>(
			bytes,
			@byte => new ByteFromSystem(@byte))
	)
	{
	}
}