using Tumbleweed.Numerics.Integers.Natural;
using Tumbleweed.Numerics.Integers.Natural.FromSystem;

namespace TumbleGD.Geometrics.Graphical.Polygons.Triangles.Numeric;

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