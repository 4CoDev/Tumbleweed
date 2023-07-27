using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Material.FromArrayMesh;

public sealed class MaterialOfSurface : Any<Material>
{
	public MaterialOfSurface
	(
		Any<ArrayMesh> mesh,
		Any<Int32> surface
	)
	{
		this.mesh = mesh;
		this.surface = surface;
	}

	public Material Value => mesh.Value.SurfaceGetMaterial(surface.Value);

	private readonly Any<ArrayMesh> mesh;

	private readonly Any<Int32> surface;
}