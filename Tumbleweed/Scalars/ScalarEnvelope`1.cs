namespace Tumbleweed.Scalars;

public abstract class ScalarEnvelope<T> : IScalar<T>
{
	protected ScalarEnvelope(IScalar<T> scalar) =>
		this.scalar = scalar;

	public T Value => scalar.Value;

	public override Boolean Equals(Object? other) =>
		scalar.Equals(other);

	public override Int32 GetHashCode() =>
		scalar.GetHashCode();

	public override String? ToString() =>
		scalar.ToString();

	private readonly IScalar<T> scalar;
}