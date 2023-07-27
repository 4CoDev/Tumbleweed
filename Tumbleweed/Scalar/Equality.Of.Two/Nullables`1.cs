using Tumbleweed.Boolean.Function;
using Tumbleweed.Boolean;
using Tumbleweed.Nullable.As;
using Tumbleweed.Nullable.From.System;
using Tumbleweed.Object.Equality.ByReference;
using System = System;

namespace Tumbleweed.Scalar.Equality.Of.Two;

public sealed class Nullables<T> : Envelope
{
	public Nullables
	(
		System::Object? first,
		System::Object? second
	) : this
	(
		new One<System::Object>(first),
		new One<System::Object>(second)
	)
	{
	}
	
	public Nullables
	(
		Nullable.Any<System::Object> first,
		Nullable.Any<System::Object> second
	) : this
	(
		new Type<Scalar.Any<T>>(first),
		new Type<Scalar.Any<T>>(second)
	)
	{
	}
	
	public Nullables
	(
		Scalar.Any<T>? first,
		Scalar.Any<T>? second
	) : this
	(
		new One<Any<T>>(first),
		new One<Any<T>>(second)
	)
	{
	}
	
	public Nullables
	(Nullable.Any<Scalar.Any<T>> first, Nullable.Any<Scalar.Any<T>> second
	) : base
	(
		new Result(
			() => Function(first, second))
	)
	{
	}

	private static Any Function
	(Nullable.Any<Scalar.Any<T>> first, Nullable.Any<Scalar.Any<T>> second
	)
	{
		if (first.HasValue.State && second.HasValue.State)
			return new Of.Two.Values<T>(first, second);
		return new EqualityOfTwoNullables(first, second);
	}
}