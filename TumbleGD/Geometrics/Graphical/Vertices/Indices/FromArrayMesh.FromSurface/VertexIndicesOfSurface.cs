using Godot;
using TumbleGD.SurfaceTools;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace
	TumbleGD.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.
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