using Tumbleweed.Bits;
using Tumbleweed.Equality.ByReference;

namespace Tumbleweed.Scalars.Equality;

public sealed class EqualityOfTwoNullables<T> : BitEnvelope
{
	public EqualityOfTwoNullables
	(
		object? first,
		object? second
	) : this
	(
		new BitOfDelegate(
			() => Function(
				first as IScalar<T>,
				second as IScalar<T>))
	)
	{
	}
	
	public EqualityOfTwoNullables
	(
		IScalar<T>? first,
		IScalar<T>? second
	) : this
	(
		new BitOfDelegate(
			() => Function(first, second))
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

	private EqualityOfTwoNullables(IBit bit) : base(bit)
	{
	}
}