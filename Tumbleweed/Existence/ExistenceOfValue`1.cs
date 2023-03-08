using Tumbleweed.Bits;
using Tumbleweed.Existence.Equality;
using Tumbleweed.Hashes;
using Tumbleweed.Strings.FromObjects;

namespace Tumbleweed.Existence;

public sealed class ExistenceOfValue<T> : IExistence<T>
{
	public ExistenceOfValue(T value, IBit exists)
	{
		Value = value;
		Exists = exists;
	}

	public override Boolean Equals(Object? @object) =>
		new EqualityOfTwoNullables<T>(this, @object).State;

	public override Int32 GetHashCode() =>
		new CodeFromNullables(Value, Exists).Value;

	public override String ToString() =>
		new StringFromNullables(Value, Exists).Value;

	public T Value { get; }

	public IBit Exists { get; }
}