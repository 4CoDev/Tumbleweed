namespace Tumbleweed.Scalars;

public sealed class ObjectAsType<T> : ScalarEnvelope<T>
{
	public ObjectAsType(Object value) : this
	(
		new ScalarValue<Object>(value)
	)
	{
	}
	
	public ObjectAsType(IScalar<Object> value) : base
	(
		new ResultOfFunction<T>(
			() => (T) value.Value)
	)
	{
	}
}