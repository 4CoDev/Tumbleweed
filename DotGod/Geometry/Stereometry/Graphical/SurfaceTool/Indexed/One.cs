using Tumbleweed.Scalar.Immutable;

namespace DotGod.Geometry.Stereometry.Graphical.SurfaceTool.Indexed;

public sealed class One : Any<Godot.SurfaceTool>
{
	public One(Any<Godot.SurfaceTool> origin)
	{
		this.origin = origin;
	}

	public Godot.SurfaceTool Value
	{
		get
		{
			Godot.SurfaceTool indexed = origin.Value;
			indexed.Index();
			return indexed;
		}
	}

	private readonly Any<Godot.SurfaceTool> origin;
}