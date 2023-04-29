using DotGod.Geometrics.Graphical.Surfaces.SurfaceTools.OfGodot;
using DotGod.Geometrics.Graphical.Vertices.Indices.FromSurfaceTools.FromGodot;
using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace
	DotGod.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.
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