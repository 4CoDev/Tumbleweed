namespace Tumbleweed.Scalars;

public sealed class ScalarOfValue : ScalarEnvelope<Object>
{
	public ScalarOfValue(Object value) : base
	(
		new ScalarOfValue<Object>(value)
	)
	{
	}
}