using Godot;
using Tumbleweed.Scalar;

namespace DotGod.Spatial.Graphical.Concave.Geometry._Material.FromArrayMesh;

public sealed class MaterialOfSurface : IScalar<Material>
{
	public MaterialOfSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<Int32> surface
	)
	{
		this.mesh = mesh;
		this.surface = surface;
	}

	public Material Value => mesh.Value.SurfaceGetMaterial(surface.Value);

	private readonly IScalar<ArrayMesh> mesh;

	private readonly IScalar<Int32> surface;
}