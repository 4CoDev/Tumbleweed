namespace Tumbleweed.Mathematics.Vector.Spatial.Generic.Scalar.Value;

public sealed class Actual<T> : Any<T>
{
	public Actual(Tumbleweed.Scalar.Immutable.Any<Any<T>> scalar) =>
		this.scalar = scalar;
	
	public T X => scalar.Value.X;

	public T Y => scalar.Value.Y;

	public T Z => scalar.Value.Z;

	private readonly Tumbleweed.Scalar.Immutable.Any<Any<T>> scalar;
}