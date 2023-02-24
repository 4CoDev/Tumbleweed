using Godot;
using Tumbleweed.Scalars;

namespace TumbleGD.Geometrics.Graphical.Materials.FromArrayMesh;

public sealed class MaterialOfSurface : IScalar<Material>
{
	public MaterialOfSurface
	(
		IScalar<ArrayMesh> mesh,
		IScalar<int> surface
	)
	{
		this.mesh = mesh;
		this.surface = surface;
	}

	public Material Value => mesh.Value.SurfaceGetMaterial(surface.Value);

	private readonly IScalar<ArrayMesh> mesh;

	private readonly IScalar<int> surface;
}