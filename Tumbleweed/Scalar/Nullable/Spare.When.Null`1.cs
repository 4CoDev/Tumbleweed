using Immutable = Tumbleweed.Scalar.Immutable;
using Nullable = Tumbleweed.Scalar.Nullable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Nullable.Spare.When;

public sealed class Null<T> : Immutable::Envelope<T>
{
	public Null
	(
		Nullable::Any<T> nullable,
		T spare
	) : this
	(
		nullable,
		new Immutable::With.Value<T>(spare)
	)
	{
	}
	
	public Null
	(
		Nullable::Any<T> nullable,
		Immutable::Any<T> spare
	) : base
	(
		new Immutable::Function.Result.Actual<T>(
			() => Function(nullable, spare))
	)
	{
	}

	private static T Function
	(
		Nullable::Any<T> nullable,
		Immutable::Any<T> spare
	)
	{
		if (nullable.HasValue.State) return nullable.Value;
		return spare.Value;
	}
}