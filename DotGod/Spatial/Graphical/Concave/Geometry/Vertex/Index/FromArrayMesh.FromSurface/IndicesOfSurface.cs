using DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot;
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromSurfaceTool.FromGodot;
using Godot;
using Tumbleweed._Enumerable;
using Tumbleweed.Scalar;

namespace
	DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromArrayMesh.
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