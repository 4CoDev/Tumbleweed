using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;

namespace Tumbleweed.Equality.ByReference;

public sealed class EqualityOfTwoNullables : BitEnvelope
{
	public EqualityOfTwoNullables
	(
		Object? first,
		Object? second
	) : base
	(
		new BitOfDelegate(
			() => new BitFromBoolean(
				ReferenceEquals(first, second)))
	)
	{
	}
		
}