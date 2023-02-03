using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces.Indices.FromArrayMesh.FromSurface;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons.
	FromSurface;

public sealed class TrianglesOfSurface
	: EnumerableEnvelope<IEnumerable<IVertex>>
{
	public TrianglesOfSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface
	) : base
	(
		new TrianglesWithVertexIndices(
			mesh,
			surface,
			new VertexIndicesOfTriangles(mesh, surface))
	)
	{
	}
}