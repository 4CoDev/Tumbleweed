using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Mathematics.Vector.Planar.Generic.With.Coordinate.Definition;

public sealed class Unique<T> : Any<T>
{
	public Unique(T x, T y) : this
	(
		new Property::With.Value<T>(x),
		new Property::With.Value<T>(y)
	)
	{
	}
	
	public Unique
	(
		Property::Any<T> x,
		Property::Any<T> y
	)
	{
		this.x = x;
		this.y = y;
	}

	public T X => x.Value;

	private readonly Property::Any<T> x;

	public T Y => y.Value;
	
	private readonly Property::Any<T> y;
}