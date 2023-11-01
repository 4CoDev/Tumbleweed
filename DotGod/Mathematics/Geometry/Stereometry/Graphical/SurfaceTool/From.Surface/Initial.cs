using DotGod.Mathematics.Geometry.Stereometry.Graphical.Mesh.PrimitiveType;
using Godot;
using Tumbleweed.Property.Output;

namespace DotGod.Mathematics.Geometry.Stereometry.Graphical.SurfaceTool.From.Surface;

public sealed class Initial
	: Envelope<Godot.SurfaceTool>
{
	public Initial(Any<Material> material) : base
	(
		new With.Material.Set.One(
			new SurfaceTool.With.PrimitiveType.Set.One(new Triangles()),
			material)
	)
	{
	}
}