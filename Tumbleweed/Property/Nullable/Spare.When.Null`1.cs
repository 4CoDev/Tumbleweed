using Property = Tumbleweed.Property.Output;
using Nullable = Tumbleweed.Property.Nullable;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Property.Nullable.Spare.When;

public sealed class Null<T> : Property::Envelope<T>
{
	public Null
	(
		Nullable::Any<T> nullable,
		T spare
	) : this
	(
		nullable,
		new Property::With.Value<T>(spare)
	)
	{
	}
	
	public Null
	(
		Nullable::Any<T> nullable,
		Property::Any<T> spare
	) : base
	(
		new Property::Function.Result.Actual<T>(
			() => Function(nullable, spare))
	)
	{
	}

	private static T Function
	(
		Nullable::Any<T> nullable,
		Property::Any<T> spare
	)
	{
		if (nullable.HasValue.State) return nullable.Value;
		return spare.Value;
	}
}