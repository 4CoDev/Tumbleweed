using Tumbleweed.Bits;

namespace Tumbleweed.Nullability;

public sealed class NullableWithValues<T> : INullable<T>
{
	public NullableWithValues(T value, IBit exists)
	{
		Value = value;
		Exists = exists;
	}

	public T Value { get; }

	public IBit Exists { get; }
}