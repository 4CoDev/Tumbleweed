using DotGod.Geometry.Spatial.Graphical.Surface._SurfaceTool.OfGodot;
using DotGod.Geometry.Spatial.Graphical.Vertex.Index.FromSurfaceTool.FromGodot;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace
	DotGod.Geometry.Spatial.Graphical.Vertex.Index.FromArrayMesh.
	FromSurface;

public sealed class IndicesOfSurface : EnumerableEnvelope<Int32>
{
	public IndicesOfSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface
	) : base
	(
		new IndicesFromSurfaceTool(
			new ToolFromSurface(mesh, surface))
	)
	{
	}
}