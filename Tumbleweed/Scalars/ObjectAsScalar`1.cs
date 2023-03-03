namespace Tumbleweed.Scalars;

public sealed class ObjectAsScalar<T> : ScalarEnvelope<T>
{
	public ObjectAsScalar(object @object) : base
	(
		new ScalarOfDelegate<T>(
			() => (IScalar<T>) @object)
	)
	{
	}
}