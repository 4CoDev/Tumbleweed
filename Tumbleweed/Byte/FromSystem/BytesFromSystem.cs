using Tumbleweed.Boolean;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;
using Enumerable = Tumbleweed.Enumerable;

namespace Tumbleweed.Byte.FromSystem;

public sealed class BytesFromSystem : Enumerable.Envelope<IEnumerable<Any>>
{
	public BytesFromSystem(IEnumerable<System.Byte> bytes) : this
	(
		new Enumerable::Item.Every.Scalar.Of.Value<System.Byte>(bytes)
	)
	{
	}
	
	public BytesFromSystem(IEnumerable<Any<System.Byte>> bytes) : base
	(
		new Selected<Any<System.Byte>, IEnumerable<Any>>(
			bytes,
			@byte => new ByteFromSystem(@byte))
	)
	{
	}
}