using Godot;
using TumbleGD.Geometrics.Graphical.SurfaceTools.OfGodot;
using TumbleGD.Geometrics.Graphical.Vertices.Indices.FromSurfaceTools.FromGodot;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace
	TumbleGD.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.
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