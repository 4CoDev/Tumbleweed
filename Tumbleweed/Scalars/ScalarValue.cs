namespace Tumbleweed.Scalars;

public sealed class ScalarValue : ScalarEnvelope<Object>
{
	public ScalarValue(Object value) : base
	(
		new ScalarValue<Object>(value)
	)
	{
	}
}