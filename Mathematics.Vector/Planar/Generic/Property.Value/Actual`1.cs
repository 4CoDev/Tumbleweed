namespace Tumbleweed.Mathematics.Vector.Planar.Generic.Property.Value;

public sealed class Actual<T> : Any<T>
{
	public Actual(Tumbleweed.Property.Output.Any<Any<T>> point) =>
		this.point = point;
	
	public T X => point.Value.X;

	public T Y => point.Value.Y;

	private readonly Tumbleweed.Property.Output.Any<Any<T>> point;
}