using DotGod.Spatial.Graphical.Concave.Geometry._Mesh._MeshDataTool.FromArrayMesh;
using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry.Vertex.FromArrayMesh.
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