namespace Tumbleweed.Scalars.Numerics.OfSystem;

public sealed class HashCodeOfScalar<T> : ScalarEnvelope<int>
	where T : notnull
{
	public HashCodeOfScalar(IScalar<T> scalar) : base
	(
		new ValueOfDelegate<int>(
			() => scalar.Value.GetHashCode())
	)
	{
	}
}