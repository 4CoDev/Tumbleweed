using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;

namespace Tumbleweed.Enumerables.Bits;

public sealed class EqualityOfTwoEnumerables<T> : BitEnvelope
{
	public EqualityOfTwoEnumerables
	(
		IEnumerable<T> first,
		IEnumerable<T> second
	) : base
	(
		new BitOfFunction(
			() => new BitFromBoolean(
				first.SequenceEqual(second)))
	)
	{
	}
}