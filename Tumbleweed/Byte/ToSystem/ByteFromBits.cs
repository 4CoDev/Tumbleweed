using Tumbleweed.Boolean;
using Tumbleweed.Boolean.System.From.Tumbleweed;
using Tumbleweed.Byte.OfSystem;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace Tumbleweed.Byte.ToSystem;

public sealed class ByteFromBits : Envelope<System.Byte>
{
	public ByteFromBits(IEnumerable<Any> bits) : base
	(
		new ByteFromBooleans(
			new Multiple(
				new Byte.ByteFromBits(bits)))
	)
	{
	}
}