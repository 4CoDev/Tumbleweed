namespace Tumbleweed.Scalars;

public sealed class ScalarOfValue<T> : ScalarEnvelope<T>
{
	public ScalarOfValue(T value) : base
	(
		new ValueOfDelegate<T>(() => value)
	)
	{
	}
}