

// ReSharper disable once CheckNamespace

using Tumbleweed.Scalar.Function;

namespace Tumbleweed.Scalar.Spare.When;

public sealed class Null<T> : Scalar.Envelope<T>
{
	public Null
	(Nullable.Any<T> any,
		T spare
	) : this
	(
		any,
		new Scalar.Of.Value<T>(spare)
	)
	{
	}
	
	public Null
	(Nullable.Any<T> any,
		Scalar.Any<T> spare
	) : base
	(
		new Function.Result<T>(
			() => Function(any, spare))
	)
	{
	}

	private static T Function
	(Nullable.Any<T> any,
		Scalar.Any<T> spare
	)
	{
		if (any.HasValue.State) return any.Value;
		return spare.Value;
	}
}