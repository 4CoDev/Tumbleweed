using Godot;
using TumbleGD.Geometrics.Graphical.Vertices;
using TumbleGD.Geometrics.Graphical.Vertices.Indices.FromArrayMesh.FromSurface;
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
		IScalar<Int32> surface
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