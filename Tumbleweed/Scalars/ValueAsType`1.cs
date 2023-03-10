namespace Tumbleweed.Scalars;

public sealed class ValueAsType<T> : ScalarEnvelope<T>
{
	public ValueAsType(Object value) : this
	(
		new ScalarOfValue<Object>(value)
	)
	{
	}
	
	public ValueAsType(IScalar<Object> value) : base
	(
		new ValueOfDelegate<T>(
			() => (T) value.Value)
	)
	{
	}
}