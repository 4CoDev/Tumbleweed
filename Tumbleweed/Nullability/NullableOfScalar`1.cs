using Tumbleweed.Bits;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nullability;

public sealed class NullableOfScalar<T> : INullable<T>
{
	public NullableOfScalar(IScalar<INullable<T>> scalar) =>
		this.scalar = scalar;

	public T Value => scalar.Value.Value;

	public IBit Exists => scalar.Value.Exists;

	private readonly IScalar<INullable<T>> scalar;
}