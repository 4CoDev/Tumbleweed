using Godot;
using Tumbleweed.Scalars;

namespace Tumbleweed.Measurement.Planars.Scalars;

public sealed class Vector2FromPlanar : IScalar<Vector2>
{
	public Vector2FromPlanar(IPlanar<float> planar)
	{
		this.planar = planar;
	}
	
	public Vector2 Value()
	{
		return new Vector2(planar.X, planar.Y);
	}
	
	private readonly IPlanar<float> planar;
}