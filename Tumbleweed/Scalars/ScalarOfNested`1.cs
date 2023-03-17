namespace Tumbleweed.Scalars;

public sealed class ScalarOfNested<T> : ScalarEnvelope<T>
{
	public ScalarOfNested(IScalar<IScalar<T>> scalar) : base
	(
		new ValueOfFunction<T>(
			() => scalar.Value.Value)
	)
	{
	}
	
}