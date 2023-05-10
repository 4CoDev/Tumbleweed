using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Objects.Equality.ByValues;
using Tumbleweed.Objects.Hashes;
using Tumbleweed.Objects.Strings;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nullables;

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
		new StringFromObject(Value!).Value;

	public T Value => value.Value;

	private readonly IScalar<T> value;

	public IBoolean Existing { get; }
}