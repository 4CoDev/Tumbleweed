using Tumbleweed.Scalar.Immutable;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.ArrayMesh.Surface.At.Index.Material;

public sealed class One : Any<Godot.Material>
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

	public Godot.Material Value => mesh.Value.SurfaceGetMaterial(surface.Value);

	private readonly Any<Godot.ArrayMesh> mesh;

	private readonly Any<Int32> surface;
}