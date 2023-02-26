using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;

namespace Tumbleweed.Equality.ByReference;

public sealed class EqualityOfTwoNullables : BitEnvelope
{
	public EqualityOfTwoNullables
	(
		object? first,
		object? second
	) : base
	(
		new BitOfDelegate(
			() => new BitFromBoolean(
				ReferenceEquals(first, second)))
	)
	{
	}
		
}