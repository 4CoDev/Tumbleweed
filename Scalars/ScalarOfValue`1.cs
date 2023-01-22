namespace Tumbleweed.Scalars;

public sealed class ScalarOfValue<T> : ScalarEnvelope<T>
{
	public ScalarOfValue(T value) : base
	(
		new ScalarOfDelegate<T>(() => value)
	)
	{
	}
}