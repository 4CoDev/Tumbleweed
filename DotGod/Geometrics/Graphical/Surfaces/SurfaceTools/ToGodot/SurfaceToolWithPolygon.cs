using DotGod.Geometrics.Graphical.Polygons;
using DotGod.Geometrics.Graphical.Vertices;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometrics.Graphical.Surfaces.SurfaceTools.
	ToGodot;

public sealed class SurfaceToolWithPolygon : ScalarEnvelope<SurfaceTool>
{
	public SurfaceToolWithPolygon
	(
		IPolygon polygon,
		IScalar<SurfaceTool> tool
	) : base
	(
		new SurfaceToolWithVertices(
			new VerticesOfPolygon(polygon),
			tool)
	)
	{
	}
}