using Tumbleweed.Bits;

namespace Tumbleweed.Scalars;

public abstract class ScalarEnvelope<T> : IScalar<T>
{
	protected ScalarEnvelope(IScalar<T> scalar) =>
		this.scalar = scalar;
	
	public T Value() =>
		scalar.Value();

	public override bool Equals(object? other) =>
		scalar.Equals(other);

	public override int GetHashCode() =>
		scalar.GetHashCode();

	public override string? ToString() =>
		scalar.ToString();

	private readonly IScalar<T> scalar;
}