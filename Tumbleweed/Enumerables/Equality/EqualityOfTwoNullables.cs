using System.Collections;
using Tumbleweed.Booleans;
using Tumbleweed.Nullables;
using Tumbleweed.Nullables.FromSystem;

namespace Tumbleweed.Enumerables.Equality;

public sealed class EqualityOfTwoNullables : BooleanEnvelope
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
		new BooleanOfFunction(
			() => Function(first, second))
	)
	{
	}

	private static IBoolean Function
	(
		INullable<IEnumerable> first,
		INullable<IEnumerable> second
	)
	{
		if (first.Existing.State && second.Existing.State)
			return new EqualityOfTwoEnumerables(first.Value, second.Value);
		return new EqualityOfTwoNullables(first, second);
	}
}