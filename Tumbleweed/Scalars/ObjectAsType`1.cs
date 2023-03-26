namespace Tumbleweed.Scalars;

public sealed class ObjectAsType<T> : ScalarEnvelope<T>
{
	public ObjectAsType(Object value) : this
	(
		new ScalarOfValue<Object>(value)
	)
	{
	}
	
	public ObjectAsType(IScalar<Object> value) : base
	(
		new ValueOfFunction<T>(
			() => (T) value.Value)
	)
	{
	}
}