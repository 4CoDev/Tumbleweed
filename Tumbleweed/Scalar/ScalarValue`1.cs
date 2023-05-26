namespace Tumbleweed.Scalar;

public sealed class ScalarValue<T> : ScalarEnvelope<T>
{
	public ScalarValue(T value) : base
	(
		new ResultOfFunction<T>(() => value)
	)
	{
	}
}