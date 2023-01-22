using Godot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;
using SurfaceToolFromSurface = Tumbleweed.WithGodot.SurfaceTools.SurfaceToolFromSurface;

namespace
	Tumbleweed.Geometrics.WithGodot.Graphical.Vertices.Indices.FromArrayMesh.
	FromSurface;

public sealed class VertexIndicesOfSurface : EnumerableEnvelope<IScalar<int>>
{
	public VertexIndicesOfSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface
	) : base
	(
		new VertexIndicesFromSurfaceTool(
			new SurfaceToolFromSurface(mesh, surface))
	)
	{
	}
}