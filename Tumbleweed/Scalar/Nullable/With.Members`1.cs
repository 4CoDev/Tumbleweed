using Tumbleweed.Object.Equality.ByValues;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using Nullable = Tumbleweed.Scalar.Nullable;
using Boolean = Tumbleweed.Boolean;
using Immutable = Tumbleweed.Scalar.Immutable;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Scalar.Nullable.With;

public sealed class Members<T> : Nullable::Any<T>
{
	public Members(T value, System::Boolean hasValue) : this
	(
		value,
		new Boolean::From.System.One(hasValue)
	)
	{
	}
	
	public Members(T value, Boolean::Any hasValue) : this
	(
		new Immutable::With.Value<T>(value),
		hasValue
	)
	{
	}
	
	public Members
	(
		Immutable::Any<T> value,
		Boolean::Any hasValue
	)
	{
		this.value = value;
		HasValue = hasValue;
	}

	public override System::Boolean Equals(System::Object? @object) =>
		new EqualityOfTwoNullables(Value, @object).State;

	public override System::Int32 GetHashCode() =>
		new HashOfObject(Value!).Value;

	public override System::String ToString() =>
		new StringFromObject(Value!).Value.Value;

	public T Value => value.Value;

	private readonly Immutable::Any<T> value;

	public Boolean::Any HasValue { get; }
}