using Tumbleweed.Mathematics.Boolean;
using Property = Tumbleweed.Property.Output;
using Nullable = Tumbleweed.Property.Nullable;
using System = System;


namespace Tumbleweed.Property.Nullable.Property.Value;

public sealed class One<T> : Nullable::Any<T>
{
	public One
	(
		Property::Any<Nullable::Any<T>> property
	)
	{
		this.property = property;
	}

	public override System::Boolean Equals
	(
		System::Object? @object
	) =>
	(
		property.Value.Equals(@object)
	);

	public override System::Int32 GetHashCode() =>
		property.Value.GetHashCode();

	public override System::String? ToString() =>
		property.Value.ToString();

	public T Value =>
		property.Value.Value;

	public Any HasValue =>
		property.Value.HasValue;

	private readonly Property::Any<Nullable::Any<T>> property;
}