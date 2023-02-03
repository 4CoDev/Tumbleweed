using Godot;
using TumbleGD.Geometrics.Graphical.Surfaces.FromArrayMesh.FromSurface;
using TumbleGD.Geometrics.Graphical.Surfaces.Indices.FromArrayMesh.FromSurface;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Enumerables;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Polygons.FromSurface;

public sealed class TriangleWithIndex : EnumerableEnvelope<IVertex>
{
	public TriangleWithIndex
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface,
		IScalar<int> triangle
	) : base
	(
		new VerticesWithIndices(
			mesh,
			surface,
			new VertexIndicesOfTriangle(mesh, surface, triangle))
	)
	{
	}
}