using Tumbleweed.Bits;
using Tumbleweed.Equality.ByReference;
using Tumbleweed.Scalars;

namespace Tumbleweed.Existence.Equality;

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
		new NullableAsExistence<T>(first),
		new NullableAsExistence<T>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IExistence<T>? first,
		IExistence<T>? second
	) : this
	(
		new ScalarOfValue<IExistence<T>?>(first),
		new ScalarOfValue<IExistence<T>?>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IScalar<IExistence<T>?> first,
		IScalar<IExistence<T>?> second
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
		IExistence<T>? first,
		IExistence<T>? second
	)
	{
		if (first != null && second != null)
			return new EqualityOfTwoScalars<T>(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}