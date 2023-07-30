using Godot;
using Tumbleweed.Scalar;
using Tumbleweed.Scalar.Immutable;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Mesh._MeshDataTool.FromArrayMesh;

public sealed class MeshDataToolFromSurface : Any<MeshDataTool>
{
	public MeshDataToolFromSurface
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface
	)
	{
		this.mesh = mesh;
		this.surface = surface;
	}

	public MeshDataTool Value
	{
		get
		{
			MeshDataTool meshDataTool = new MeshDataTool();
			meshDataTool.CreateFromSurface(mesh.Value, surface.Value);
			return meshDataTool;
		}
	}

	private readonly Any<ArrayMesh> mesh;
	
	private readonly Any<Int32> surface;
}