namespace Tumbleweed.Scalars;

public sealed class ScalarFromObject<T> : ScalarEnvelope<T>
{
	public ScalarFromObject(object @object) : base
	(
		new ScalarOfDelegate<T>(
			() => (IScalar<T>) @object)
	)
	{
	}
}