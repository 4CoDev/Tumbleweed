namespace Tumbleweed.Scalars;

public sealed class NullableAsType<T> : ScalarEnvelope<T?>
{
	public NullableAsType(object? value) : this
	(
		new ScalarOfValue<object?>(value)
	)
	{
	}
	
	public NullableAsType(IScalar<object?> scalar) : base
	(
		new ValueOfDelegate<T?>(
			() => (T?) scalar.Value)
	)
	{
	}
}