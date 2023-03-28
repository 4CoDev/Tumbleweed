using Godot;
using TumbleGD.Geometrics.Graphical.Polygons;
using TumbleGD.Geometrics.Graphical.SurfaceTools.OfGodot.FromEnumerable;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.SurfaceTools.
	ToGodot;

public sealed class SurfaceToolWithPolygon : ScalarEnvelope<SurfaceTool>
{
	public SurfaceToolWithPolygon
	(
		IPolygon polygon,
		IScalar<SurfaceTool> origin
	) : base
	(
		new SurfaceToolWithVertices(
			new VerticesOfPolygon(polygon),
			origin)
	)
	{
	}
}