using Tumbleweed.Bits;

namespace Tumbleweed.Nullability;

public abstract class NullableEnvelope<T> : INullable<T> where T : notnull
{
	protected NullableEnvelope(INullable<T> nullable) =>
		this.nullable = nullable;

	public override Boolean Equals(Object? @object) =>
		nullable.Equals(@object);

	public override Int32 GetHashCode() =>
		nullable.GetHashCode();

	public override String? ToString() =>
		nullable.ToString();

	public T Value => nullable.Value;

	public IBit Existing => nullable.Existing;
	
	private readonly INullable<T> nullable;
}