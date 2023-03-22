using System.Collections;
using Tumbleweed.Bits;
using Tumbleweed.Nullability;

namespace Tumbleweed.Enumerables.Equality;

public sealed class EqualityOfTwoNullables : BitEnvelope
{
	public EqualityOfTwoNullables
	(
		Object? first,
		Object? second
	) : this
	(
		new NullableFromSystem<Object>(first),
		new NullableFromSystem<Object>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		INullable<Object> first,
		INullable<Object> second
	) : this
	(
		new NullableAsType<IEnumerable>(first),
		new NullableAsType<IEnumerable>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IEnumerable? first,
		IEnumerable? second
	) : this
	(
		new NullableFromSystem<IEnumerable>(first),
		new NullableFromSystem<IEnumerable>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		INullable<IEnumerable> first,
		INullable<IEnumerable> second
	) : base
	(
		new BitOfFunction(
			() => Function(first, second))
	)
	{
	}

	private static IBit Function
	(
		INullable<IEnumerable> first,
		INullable<IEnumerable> second
	)
	{
		if (first.Exists.State && second.Exists.State)
			return new EqualityOfTwoEnumerables(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}