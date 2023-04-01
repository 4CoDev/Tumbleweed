using Tumbleweed.Bits;
using Tumbleweed.Equality.ByValues;
using Tumbleweed.Hashes;
using Tumbleweed.Scalars;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Nullability;

public sealed class NullableWithValues<T> : INullable<T> where T : notnull
{
	public NullableWithValues(T value, IBit exists) : this
	(
		new ScalarValue<T>(value),
		exists
	)
	{
	}
	
	public NullableWithValues(IScalar<T> value, IBit exists)
	{
		this.value = value;
		Exists = exists;
	}

	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables(Value, @object).State;

	public override Int32 GetHashCode() =>
		new HashOfObject(Value).Value;

	public override String? ToString() =>
		new NullableFromObject(Value).Value;

	public T Value => value.Value;

	private readonly IScalar<T> value;

	public IBit Exists { get; }
}