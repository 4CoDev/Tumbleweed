using Tumbleweed.Boolean;
using Tumbleweed.Boolean.FromByte.FromSystem;
using Tumbleweed.Enumerable;
using Tumbleweed.Enumerable.Function;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Byte.FromSystem;

public sealed class ByteFromSystem : Enumerable.Envelope<Any>
{
	public ByteFromSystem(Any<System.Byte> @byte) : base
	(
		new Result<Any>(
			() => Function(@byte))
	)
	{
	}

	private static IEnumerable<Any> Function(Any<System.Byte> @byte)
	{
		for (Int32 index = 0; index < 8; index++)
			yield return new BooleanWithIndex(@byte, index);
	}
}