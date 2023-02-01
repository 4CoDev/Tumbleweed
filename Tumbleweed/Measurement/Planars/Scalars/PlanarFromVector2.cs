using Godot;
using Tumbleweed.Scalars;

namespace Tumbleweed.Measurement.Planars.Scalars;

public sealed class PlanarFromVector2 : IScalar<IPlanar<float>>
{
	public PlanarFromVector2(Vector2 vector2)
	{
		this.vector2 = vector2;
	}
	
	public IPlanar<float> Value()
	{
		return new Planar<float>(vector2.x, vector2.y);
	}
	
	private readonly Vector2 vector2;
}