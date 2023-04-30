using Tumbleweed.Numbers.Integers.Natural;
using Tumbleweed.Numbers.Integers.Natural.FromSystem;

namespace DotGod.Geometrics.Graphical.Polygons.Triangles.Numeric;

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