using Tumbleweed.Bits;
using Tumbleweed.Equality.ByReference;

namespace Tumbleweed.Scalars.Equality;

public sealed class EqualityOfTwoNullables<T> : BitEnvelope
{
	public EqualityOfTwoNullables
	(
		Object? first,
		Object? second
	) : this
	(
		new ScalarOfValue<Object?>(first),
		new ScalarOfValue<Object?>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IScalar<Object?> first,
		IScalar<Object?> second
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
		new ScalarOfValue<IScalar<T>?>(first),
		new ScalarOfValue<IScalar<T>?>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IScalar<IScalar<T>?> first,
		IScalar<IScalar<T>?> second
	) : base
	(
		new BitOfDelegate(
			() => Function(
				first.Value,
				second.Value))
	)
	{
	}

	private static IBit Function
	(
		IScalar<T>? first,
		IScalar<T>? second
	)
	{
		if (first != null && second != null)
			return new EqualityOfTwoScalars<T>(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}