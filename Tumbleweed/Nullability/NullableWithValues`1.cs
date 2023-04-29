using Tumbleweed.Booleans;
using Tumbleweed.Booleans.FromSystem;
using Tumbleweed.Equality.ByValues;
using Tumbleweed.Hashes;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Nullability;

public sealed class NullableWithValues<T> : INullable<T> where T : notnull
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
		new HashOfObject(Value).Value;

	public override String? ToString() =>
		new NullableFromObject(Value).Value;

	public T Value => value.Value;

	private readonly IScalar<T> value;

	public IBoolean Existing { get; }
}