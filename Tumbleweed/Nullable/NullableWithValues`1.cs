using Tumbleweed._Boolean;
using Tumbleweed._Boolean.FromSystem;
using Tumbleweed._Object.Equality.ByValues;
using Tumbleweed._Object.Hash;
using Tumbleweed._Object.String;
using Tumbleweed.Scalar;

namespace Tumbleweed.Nullable;

public sealed class NullableWithValues<T> : INullable<T>
{
	public NullableWithValues(T value, Boolean existing) : this
	(
		value,
		new BooleanFromSystem(existing)
	)
	{
	}
	
	public NullableWithValues(T value, IScalar<Boolean> existing) : this
	(
		value,
		new BooleanFromSystem(existing)
	)
	{
	}
	
	public NullableWithValues(T value, IBoolean existing) : this
	(
		new ScalarValue<T>(value),
		existing
	)
	{
	}
	
	public NullableWithValues(IScalar<T> value, IBoolean existing)
	{
		this.value = value;
		Existing = existing;
	}

	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables(Value, @object).State;

	public override Int32 GetHashCode() =>
		new HashOfObject(Value!).Value;

	public override String? ToString() =>
		new StringFromObject(Value!).Value.Value;

	public T Value => value.Value;

	private readonly IScalar<T> value;

	public IBoolean Existing { get; }
}