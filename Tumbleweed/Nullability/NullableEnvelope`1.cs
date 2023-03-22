using Tumbleweed.Bits;

namespace Tumbleweed.Nullability;

public abstract class NullableEnvelope<T> : INullable<T> where T : notnull
{
	protected NullableEnvelope(INullable<T> nullable) =>
		this.nullable = nullable;
	
	public T Value => nullable.Value;

	public IBit Exists => nullable.Exists;
	
	private readonly INullable<T> nullable;
}