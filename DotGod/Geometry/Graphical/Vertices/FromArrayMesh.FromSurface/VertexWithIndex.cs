using DotGod.Geometry.Graphical.Meshes.MeshDataTools.FromArrayMesh;
using Godot;
using Tumbleweed.Scalars;

namespace DotGod.Geometry.Graphical.Vertices.FromArrayMesh.
	FromSurface;

public sealed class VertexWithIndex : VertexEnvelope
{
	public VertexWithIndex
	(
		IScalar<ArrayMesh> mesh,
		Int32 surface,
		Int32 vertex
	) : this
	(
		mesh,
		new ScalarValue<Int32>(surface),
		new ScalarValue<Int32>(vertex)
	)
	{
	}
	
	public VertexWithIndex
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		Int32 vertex
	) : this
	(
		mesh,
		surface,
		new ScalarValue<Int32>(vertex)
	)
	{
	}
	
	public VertexWithIndex
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface,
		IScalar<Int32> vertex
	) : base
	(
		new FromMeshDataTool.VertexWithIndex(
			new MeshDataToolFromSurface(mesh, surface),
			vertex)
	)
	{
	}
}