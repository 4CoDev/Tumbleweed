using Tumbleweed.Booleans;
using Tumbleweed.Scalars;

namespace Tumbleweed.Nullability;

public sealed class NullableOfScalar<T> : INullable<T> where T : notnull
{
	public NullableOfScalar(IScalar<INullable<T>> scalar) =>
		this.scalar = scalar;

	public override Boolean Equals(Object? @object) =>
		scalar.Value.Equals(@object);

	public override Int32 GetHashCode() =>
		scalar.Value.GetHashCode();

	public override String? ToString() =>
		scalar.Value.ToString();

	public T Value => scalar.Value.Value;

	public IBoolean Existing => scalar.Value.Existing;

	private readonly IScalar<INullable<T>> scalar;
}