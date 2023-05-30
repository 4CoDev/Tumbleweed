using Tumbleweed.Number.Integer.Natural;
using Tumbleweed.Number.Integer.Natural.FromSystem;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Polygon.Triangle.Number;

public sealed class TriangleVerticesCount : NaturalEnvelope
{
	public TriangleVerticesCount() : base
	(
		new NaturalFromInt32(
			new OfSystem.TriangleVerticesCount())
	)
	{
	}
}