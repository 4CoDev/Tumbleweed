using DotGod.Geometry.Spatial.Graphical.Surfaces.SurfaceTools.OfGodot;
using DotGod.Geometry.Spatial.Graphical.Vertices.Indices.FromSurfaceTools.FromGodot;
using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace
	DotGod.Geometry.Spatial.Graphical.Vertices.Indices.FromArrayMesh.
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