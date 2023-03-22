using System.Collections;
using Tumbleweed.Bits;
using Tumbleweed.Bits.FromSystem;
using Tumbleweed.Scalars;

namespace Tumbleweed.Enumerables.Equality;

public sealed class EqualityOfTwoEnumerables : BitEnvelope
{
	public EqualityOfTwoEnumerables
	(
		Object first,
		Object second
	) : this
	(
		new ObjectAsScalar<IEnumerable>(first),
		new ObjectAsScalar<IEnumerable>(second)
	)
	{
	}
	
	public EqualityOfTwoEnumerables
	(
		IScalar<IEnumerable> first,
		IScalar<IEnumerable> second
	) : base
	(
		new BitOfFunction(
			() => Function(first.Value, second.Value))
	)
	{
	}

	private static IBit Function
	(
		IEnumerable first,
		IEnumerable second
	) =>
	(
		Function(
			first.Cast<Object>(),
			second.Cast<Object>())
	);
	
	private static IBit Function
	(
		IEnumerable<Object> first,
		IEnumerable<Object> second
	) =>
	(
		new BitFromBoolean(
			first.SequenceEqual(second))
	);
}