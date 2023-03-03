using Tumbleweed.Bits;
using Tumbleweed.Equality.ByReference;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nodes.NAry.Equality;

public sealed class EqualityOfTwoNullables<T> : BitEnvelope
{
	public EqualityOfTwoNullables
	(
		object? first,
		object? second
	) : this
	(
		new ScalarOfValue<object?>(first),
		new ScalarOfValue<object?>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IScalar<object?> first,
		IScalar<object?> second
	) : this
	(
		new NullableAsType<INAryNode<T>>(first),
		new NullableAsType<INAryNode<T>>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		INAryNode<T>? first,
		INAryNode<T>? second
	) : this
	(
		new ScalarOfValue<INAryNode<T>?>(first),
		new ScalarOfValue<INAryNode<T>?>(second)
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IScalar<INAryNode<T>?> first,
		IScalar<INAryNode<T>?> second
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
		INAryNode<T>? first,
		INAryNode<T>? second
	)
	{
		if (first != null && second != null)
			return new EqualityOfTwoNodes<T>(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}