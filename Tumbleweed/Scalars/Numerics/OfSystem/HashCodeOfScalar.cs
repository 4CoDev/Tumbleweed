namespace Tumbleweed.Scalars.Numerics.OfSystem;

public sealed class HashCodeOfScalar<T> : ScalarEnvelope<Int32>
	where T : notnull
{
	public HashCodeOfScalar(IScalar<T> scalar) : base
	(
		new ValueOfDelegate<Int32>(
			() => scalar.Value.GetHashCode())
	)
	{
	}
}