using Tumbleweed._Boolean;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace Tumbleweed._Byte.FromSystem;

public sealed class BytesFromSystem : EnumerableEnvelope<IEnumerable<IBoolean>>
{
	public BytesFromSystem(IEnumerable<Byte> bytes) : this
	(
		new ScalarsOfValues<Byte>(bytes)
	)
	{
	}
	
	public BytesFromSystem(IEnumerable<IScalar<Byte>> bytes) : base
	(
		new SelectedByExpression<IScalar<Byte>, IEnumerable<IBoolean>>(
			bytes,
			@byte => new ByteFromSystem(@byte))
	)
	{
	}
}