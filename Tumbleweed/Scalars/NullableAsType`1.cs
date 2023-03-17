namespace Tumbleweed.Scalars;

public sealed class NullableAsType<T> : ScalarEnvelope<T?>
{
	public NullableAsType(Object? value) : this
	(
		new ScalarOfValue<Object?>(value)
	)
	{
	}
	
	public NullableAsType(IScalar<Object?> scalar) : base
	(
		new ValueOfFunction<T?>(
			() => (T?) scalar.Value)
	)
	{
	}
}