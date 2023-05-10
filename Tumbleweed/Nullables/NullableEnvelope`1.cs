using Tumbleweed.Booleans;

namespace Tumbleweed.Nullables;

public abstract class NullableEnvelope<T> : INullable<T>
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

	public IBoolean Existing => nullable.Existing;
	
	private readonly INullable<T> nullable;
}