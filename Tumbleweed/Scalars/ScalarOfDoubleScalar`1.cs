namespace Tumbleweed.Scalars;

public sealed class ScalarOfDoubleScalar<T> : ScalarEnvelope<T>
{
	public ScalarOfDoubleScalar(IScalar<IScalar<T>> scalar) : base
	(
		new ValueOfDelegate<T>(
			() => scalar.Value.Value)
	)
	{
	}
	
}