namespace Tumbleweed.Scalars;

public sealed class ValueAsType<T> : ScalarEnvelope<T>
{
	public ValueAsType(object value) : this
	(
		new ScalarOfValue<object>(value)
	)
	{
	}
	
	public ValueAsType(IScalar<object> value) : base
	(
		new ValueOfDelegate<T>(
			() => (T) value.Value)
	)
	{
	}
}