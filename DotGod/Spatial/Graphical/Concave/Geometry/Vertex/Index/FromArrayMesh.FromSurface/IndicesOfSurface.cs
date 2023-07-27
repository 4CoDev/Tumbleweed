using DotGod.Spatial.Graphical.Concave.Geometry.Surface._SurfaceTool.OfGodot;
using DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromSurfaceTool.FromGodot;
using Godot;
using Tumbleweed.Enumerable;
using Tumbleweed.Scalar;

namespace
	DotGod.Spatial.Graphical.Concave.Geometry.Vertex.Index.FromArrayMesh.
	FromSurface;

public sealed class IndicesOfSurface : Tumbleweed.Enumerable.Envelope<Int32>
{
	public IndicesOfSurface
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface
	) : base
	(
		new IndicesFromSurfaceTool(
			new ToolFromSurface(mesh, surface))
	)
	{
	}
}