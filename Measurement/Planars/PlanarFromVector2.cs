using Godot;

namespace Tumbleweed.Measurement.Planars;

public sealed class PlanarFromVector2 : PlanarEnvelope<float>
{
	public PlanarFromVector2(Vector2 vector2) : base
	(
		new PlanarFromScalar<float>(
			new Scalars.PlanarFromVector2(vector2))
	)
	{
	}
}