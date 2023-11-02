using Tumbleweed.Mathematics.Boolean.Literal;
using Nullable = Tumbleweed.Property.Nullable;
using Property = Tumbleweed.Property.Output;


namespace Tumbleweed.Property.Nullable.With.Value;

public sealed class One<T> : Nullable::Envelope<T>
{
	public One(T value) : this
	(
		new Property::With.Value.One<T>(value)
	)
	{
	}
	
	public One(Property::Any<T> value) : base
	(
		new Nullable::With.Members<T>(
			value,
			new True()))
	{
	}
}