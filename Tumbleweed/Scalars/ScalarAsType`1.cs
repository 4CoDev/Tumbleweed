namespace Tumbleweed.Scalars;

public sealed class ScalarAsType<T> : ScalarEnvelope<T>
{
	public ScalarAsType(Object scalar) : this
	(
		new ObjectAsScalar<Object>(scalar)
	)
	{
	}
	
	public ScalarAsType(IScalar<Object> scalar) : base
	(
		new ScalarOfNested<T>(
			new ObjectAsType<IScalar<T>>(scalar))
	)
	{
	}
}