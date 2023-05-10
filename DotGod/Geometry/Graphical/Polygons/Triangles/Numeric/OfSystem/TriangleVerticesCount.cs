using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Polygons.Triangles.Numeric.OfSystem;

public sealed class TriangleVerticesCount : ScalarEnvelope<Int32>
{
	public TriangleVerticesCount() : base
	(
		new ScalarValue<Int32>(3)
	)
	{
	}
}