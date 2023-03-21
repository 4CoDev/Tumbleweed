using Tumbleweed.Bits;

namespace Tumbleweed.Nullability;

public sealed class NullableAsType<T> : INullable<T>
{
	public NullableAsType(INullable<Object> origin) =>
		this.origin = origin;

	public T Value => (T) origin.Value;

	public IBit Exists => origin.Exists;

	private readonly INullable<Object> origin;
}