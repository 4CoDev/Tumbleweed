using Property = Tumbleweed.Property.Output;

namespace Tumbleweed.Mathematics.Vector.Spatial.Generic.With.Coordinate.Definition;

public sealed class Unique<T> : Any<T>
{
	public Unique(T x, T y, T z) : this
	(
		new Property::With.Value.One<T>(x),
		new Property::With.Value.One<T>(y),
		new Property::With.Value.One<T>(z)
	)
	{
	}
	
	public Unique
	(
		Property::Any<T> x,
		Property::Any<T> y,
		Property::Any<T> z
	)
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}

	public T X => x.Value;

	private readonly Property::Any<T> x;

	public T Y => y.Value;
	
	private readonly Property::Any<T> y;

	public T Z => z.Value;
	
	private readonly Property::Any<T> z;
}