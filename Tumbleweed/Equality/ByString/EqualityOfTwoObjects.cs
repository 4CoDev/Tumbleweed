using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;

namespace Tumbleweed.Equality.ByString;

public sealed class EqualityOfTwoObjects : BitEnvelope
{
	public EqualityOfTwoObjects(object first, object second) : base
	(
		new BitOfDelegate(
			() => new BitFromBoolean(
				new ByReference.EqualityOfTwoObjects(first, second).State ||
					first.ToString() == second.ToString()))
		)
	{
	}
}