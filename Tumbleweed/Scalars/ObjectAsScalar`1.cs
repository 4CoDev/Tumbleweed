namespace Tumbleweed.Scalars;

public sealed class ObjectAsScalar<T> : ScalarEnvelope<T>
{
	public ObjectAsScalar(Object @object) : base
	(
		new ScalarOfDelegate<T>(
			() => (IScalar<T>) @object)
	)
	{
	}
}