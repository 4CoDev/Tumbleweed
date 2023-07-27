using Tumbleweed.Boolean;
using Tumbleweed.Boolean.From.System;
using Tumbleweed.Object.Equality.ByValues;
using Tumbleweed.Object.Hash;
using Tumbleweed.Object.String;
using System = System;

// ReSharper disable once CheckNamespace
namespace Tumbleweed.Nullable.With;

public sealed class Members<T> : Nullable.Any<T>
{
	public Members(T value, System::Boolean existing) : this
	(
		value,
		new One(existing)
	)
	{
	}
	
	public Members(T value, Scalar.Any<System::Boolean> existing) : this
	(
		value,
		new One(existing)
	)
	{
	}
	
	public Members(T value, Any existing) : this
	(
		new Tumbleweed.Scalar.Of.Value<T>(value),
		existing
	)
	{
	}
	
	public Members(Scalar.Any<T> value, Any existing)
	{
		this.value = value;
		HasValue = existing;
	}

	public override System::Boolean Equals(System::Object? @object) =>
		new EqualityOfTwoNullables(Value, @object).State;

	public override Int32 GetHashCode() =>
		new HashOfObject(Value!).Value;

	public override System::String? ToString() =>
		new StringFromObject(Value!).Value.Value;

	public T Value =>
		value.Value;

	private readonly Scalar.Any<T> value;

	public Any HasValue { get; }
}