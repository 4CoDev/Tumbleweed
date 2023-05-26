namespace Tumbleweed.Scalar;

public sealed class ObjectAsScalar<T> : ScalarEnvelope<T>
{
	public ObjectAsScalar(Object @object) : base
	(
		new ScalarOfNested<T>(
			new ResultOfFunction<IScalar<T>>(
				() => (IScalar<T>) @object))
	)
	{
	}
}