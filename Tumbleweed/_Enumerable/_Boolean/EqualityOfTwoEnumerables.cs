using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromSystem;

namespace Tumbleweed._Enumerable._Boolean;

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