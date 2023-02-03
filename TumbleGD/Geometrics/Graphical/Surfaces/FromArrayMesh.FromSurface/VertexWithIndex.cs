using Godot;
using TumbleGD.Geometrics.Graphical.MeshDataTools.FromArrayMesh;
using TumbleGD.Geometrics.Graphical.Vertices;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Surfaces.FromArrayMesh.
	FromSurface;

public sealed class VertexWithIndex : VertexEnvelope
{
	public VertexWithIndex
	(
		IScalar<ArrayMesh> arrayMesh,
		IScalar<int> surface,
		IScalar<int> vertex
	) : base
	(
		new FromMeshDataTool.VertexWithIndex(
			new MeshDataToolFromSurface(arrayMesh, surface),
			vertex)
	)
	{
	}
}