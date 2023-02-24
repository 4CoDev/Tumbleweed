namespace Tumbleweed.Scalars.Numerics.OfSystem;

public sealed class HashCodeOfScalar<T> : ScalarEnvelope<int>
	where T : notnull
{
	public HashCodeOfScalar(IScalar<T> scalar) : base
	(
		new ScalarOfDelegate<int>(
			() => scalar.Value().GetHashCode())
	)
	{
	}
}