using Output = Tumbleweed.Property.Output;
using Nullable = Tumbleweed.Property.Nullable;
using Boolean = Tumbleweed.Mathematics.Boolean;

namespace Tumbleweed.Property.Nullable.Output.Value;

public sealed class One<T> : Nullable::Any<T>
{
	public One
	(
		Output::Any<Nullable::Any<T>> property
	)
	{
		this.property = property;
	}

	public T Value =>
		property.Value.Value;

	public Boolean::Any HasValue =>
		property.Value.HasValue;

	private readonly Output::Any<Nullable::Any<T>> property;
}