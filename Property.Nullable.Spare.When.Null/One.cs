using Output = Tumbleweed.Property.Output;
using Nullable = Tumbleweed.Property.Nullable;

namespace Tumbleweed.Property.Nullable.Spare.When.Null;

public sealed class One<T> : Output::Envelope<T>
{
	public One
	(
		Nullable::Any<T> nullable,
		T spare
	) : this
	(
		nullable,
		new Output::With.Value.One<T>(spare)
	)
	{
	}
	
	public One
	(
		Nullable::Any<T> nullable,
		Output::Any<T> spare
	) : base
	(
		new Output::Function.Result.Actual<T>(
			() => Function(nullable, spare))
	)
	{
	}

	private static T Function
	(
		Nullable::Any<T> nullable,
		Output::Any<T> spare
	)
	{
		if (nullable.HasValue.State) return nullable.Value;
		return spare.Value;
	}
}