namespace Tumbleweed.Mathematics.Vector.Spatial.Generic.Property.Value;

public sealed class Actual<T> : Any<T>
{
	public Actual(Tumbleweed.Property.Output.Any<Any<T>> property) =>
		this.property = property;
	
	public T X => property.Value.X;

	public T Y => property.Value.Y;

	public T Z => property.Value.Z;

	private readonly Tumbleweed.Property.Output.Any<Any<T>> property;
}