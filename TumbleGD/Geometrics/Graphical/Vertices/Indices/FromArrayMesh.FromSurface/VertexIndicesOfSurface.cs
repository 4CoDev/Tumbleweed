using Godot;
using TumbleGD.Geometrics.Graphical.SurfaceTools;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace
	TumbleGD.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.
	FromSurface;

public sealed class VertexIndicesOfSurface : EnumerableEnvelope<IScalar<Int32>>
{
	public VertexIndicesOfSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface
	) : base
	(
		new VertexIndicesFromSurfaceTool(
			new SurfaceToolFromSurface(mesh, surface))
	)
	{
	}
}