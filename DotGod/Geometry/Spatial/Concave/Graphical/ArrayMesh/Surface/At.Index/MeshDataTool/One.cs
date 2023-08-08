using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Spatial.Concave.Graphical.ArrayMesh.Surface.At.Index.MeshDataTool;

public sealed class One : Any<Godot.MeshDataTool>
{
	public One
	(
		Any<Godot.ArrayMesh> mesh,
		Any<Int32> surface
	)
	{
		this.mesh = mesh;
		this.surface = surface;
	}

	public Godot.MeshDataTool Value
	{
		get
		{
			Godot.MeshDataTool meshDataTool = new Godot.MeshDataTool();
			meshDataTool.CreateFromSurface(mesh.Value, surface.Value);
			return meshDataTool;
		}
	}

	private readonly Any<Godot.ArrayMesh> mesh;
	
	private readonly Any<Int32> surface;
}