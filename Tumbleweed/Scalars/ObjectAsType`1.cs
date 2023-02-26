namespace Tumbleweed.Scalars;

public sealed class ObjectAsType<T> : ScalarEnvelope<T>
{
	public ObjectAsType(object @object) : base
	(
		new ValueOfDelegate<T>(
			() => (T) @object)
	)
	{
	}
}