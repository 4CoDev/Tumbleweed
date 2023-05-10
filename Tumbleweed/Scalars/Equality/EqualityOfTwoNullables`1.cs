using Tumbleweed.Booleans;
using Tumbleweed.Nullables;
using Tumbleweed.Nullables.FromSystem;
using Tumbleweed.Objects.Equality.ByReference;

namespace Tumbleweed.Scalars.Equality;

public sealed class EqualityOfTwoNullables<T> : BooleanEnvelope
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
		new NullableAsType<IScalar<T>>(first),
		new NullableAsType<IScalar<T>>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IScalar<T>? first,
		IScalar<T>? second
	) : this
	(
		new NullableFromSystem<IScalar<T>>(first),
		new NullableFromSystem<IScalar<T>>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		INullable<IScalar<T>> first,
		INullable<IScalar<T>> second
	) : base
	(
		new BooleanOfFunction(
			() => Function(first, second))
	)
	{
	}

	private static IBoolean Function
	(
		INullable<IScalar<T>> first,
		INullable<IScalar<T>> second
	)
	{
		if (first.Existing.State && second.Existing.State)
			return new EqualityOfTwoScalars<T>(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}