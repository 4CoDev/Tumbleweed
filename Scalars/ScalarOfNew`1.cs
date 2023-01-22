namespace Tumbleweed.Scalars;

public sealed class ScalarOfNew<T> : ScalarEnvelope<T>
	where T : new()
{
	public ScalarOfNew() : base(new ScalarOfValue<T>(new T()))
	{
	}
}