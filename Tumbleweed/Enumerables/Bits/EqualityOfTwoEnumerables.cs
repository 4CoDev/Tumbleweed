using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromSystem;

namespace Tumbleweed.Enumerables.Bits;

public sealed class EqualityOfTwoEnumerables<T> : BooleanEnvelope
{
	public EqualityOfTwoEnumerables
	(
		IEnumerable<T> first,
		IEnumerable<T> second
	) : base
	(
		new BooleanOfFunction(
			() => new BooleanFromSystem(
				first.SequenceEqual(second)))
	)
	{
	}
}